using JasmineLeaf.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.IO.Compression;
using System.Text.Json;

namespace JasmineLeaf.Controllers
{
    public class LeafController : Controller
    {
        private readonly LeafContext _context;
        private readonly IWebHostEnvironment _environment;
        //dynamically change the stages here
        private readonly List<string> _stages = new List<string> { "Healthy", "Stage1", "Stage2", "Stage3", "Stage4" };

        public LeafController(IWebHostEnvironment environment, LeafContext context)
        {
            _environment = environment;
            _context = context;
        }

        public IActionResult Index()
        {
            #region generate leafDataset
            try
            {
                // Generate the dataset
                var leafData = new List<Leaf>();
                int idCounter = 1;

                foreach (var stage in _stages)
                {
                    for (int x = 1; x <= 25; x++) // Number of images per stage
                    {
                        for (int y = 1; y <= 8; y++) // Rotations per image
                        {
                            leafData.Add(new Leaf
                            {
                                Id = idCounter++,
                                Name = $"{stage}_{x} ({y}).jpg",
                                Image = $"wwwroot/images/leafdataset/{stage}/{stage}_{x} ({y}).jpg",
                                Stage = stage,
                                Description = $"Description for {stage} image {x}, rotation {y}"
                            });
                        }
                    }
                }

                // Serialize the data to JSON
                string json = JsonSerializer.Serialize(leafData, new JsonSerializerOptions { WriteIndented = true });

                // Define the file path in wwwroot
                string filePath = Path.Combine(Directory.GetCurrentDirectory(), "SeedData", "LeafData.json");

                // Ensure the directory exists
                string directoryPath = Path.GetDirectoryName(filePath);
                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }

                // Write the JSON data to the file
                System.IO.File.WriteAllText(filePath, json);

                ViewBag.Message = "JSON file created successfully!";
            }
            catch (Exception ex)
            {
                ViewBag.Message = $"Error: {ex.Message}";
            }
            #endregion



            var userId = Request.Cookies["UserId"];
            ViewData["UserStatus"] = null;
            if (!string.IsNullOrEmpty(userId))
            {
                ViewData["UserStatus"] = _context.Requests.FirstOrDefault(r => r.UserId == userId).Status;
            }

            return View();
        }
        public bool IsDownloadAuthorized()
        {
            var userId = Request.Cookies["UserId"];
            if (string.IsNullOrEmpty(userId))
                return false;

            var request = _context.Requests.FirstOrDefault(r => r.UserId == userId);
            if (request?.Status != "Approved")
                return false;

            return true;
        }
        public IActionResult DownloadStage(string stage)
        {
            if (!IsDownloadAuthorized())
            {
                return Json(new
                {
                    title = "Access Denied",
                    message = "you are not authorized to download the dataset, request the admin for permission."
                });
            }

            string stageFolderPath = Path.Combine(_environment.WebRootPath, "images/leafdataset", stage);

            if (!Directory.Exists(stageFolderPath))
            {
                return NotFound("The specified stage does not exist.");
            }

            string zipPath = Path.Combine(_environment.WebRootPath, "temp", $"{stage}_images.zip");

            //if the file already exist delete it
            if (System.IO.File.Exists(zipPath))
            {
                System.IO.File.Delete(zipPath);
            }

            ZipFile.CreateFromDirectory(stageFolderPath, zipPath);

            byte[] fileBytes = System.IO.File.ReadAllBytes(zipPath);

            return File(fileBytes, "application/zip", $"{stage}_images.zip");
        }
        public IActionResult DownloadAllStages()
        {
            if (!IsDownloadAuthorized())
            {
                return Json(new
                {
                    title = "Access Denied",
                    message = "you are not authorized to download the dataset, request the admin for permission."
                });
            }

            string tempFolderPath = Path.Combine(_environment.WebRootPath, "temp");

            // Ensure the temp folder exists
            if (!Directory.Exists(tempFolderPath))
            {
                Directory.CreateDirectory(tempFolderPath);
            }

            // Path for the combined zip file
            string zipPath = Path.Combine(tempFolderPath, "All_Stages_Images.zip");

            // Delete any existing ZIP file with the same name
            if (System.IO.File.Exists(zipPath))
            {
                System.IO.File.Delete(zipPath);
            }

            // Create the ZIP file
            using (var zipArchive = ZipFile.Open(zipPath, ZipArchiveMode.Create))
            {
                // Add each stage folder directly into the zip archive
                foreach (var stage in _stages)
                {
                    string stageFolderPath = Path.Combine(_environment.WebRootPath, "images/leafdataset", stage);

                    if (Directory.Exists(stageFolderPath))
                    {
                        // Add each file in the current stage folder to the zip
                        foreach (var filePath in Directory.GetFiles(stageFolderPath))
                        {
                            string fileName = Path.GetFileName(filePath);
                            string entryName = Path.Combine(stage, fileName); // Organize by folder in zip
                            zipArchive.CreateEntryFromFile(filePath, entryName);
                        }
                    }
                }
            }

            // Read the ZIP file into a byte array to send as a downloadable file
            byte[] fileBytes = System.IO.File.ReadAllBytes(zipPath);

            return File(fileBytes, "application/zip", "All_Stages_Images.zip");
        }

    }
}
