using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.IO;
using JasmineLeaf.Models;
using System.IO.Compression;

namespace JasmineLeaf.Controllers
{
    public class KoliController : Controller
    {
        private readonly LeafContext _context;
        private readonly IWebHostEnvironment _environment;
        private readonly List<string> stages = new List<string> { "Original", "Blurred" };
        public KoliController(IWebHostEnvironment environment, LeafContext context)
        {
            _environment = environment;
            _context = context;
        }
        public IActionResult Index()
        {
            #region generate bird dataset
            try
            {
                // Generate the dataset
                var birdData = new List<Koli>();
                int imageCountPerStage = 258; // Distribute images equally among stages
                int imageCounter = 1;

                foreach (var stage in stages)
                {
                    for (int i = 1; i <= imageCountPerStage; i++)
                    {
                        birdData.Add(new Koli
                        {
                            Id = imageCounter,
                            Name = $"{stage} ({i})",
                            Stage = stage,
                            Image = $"wwwroot/images/birddataset/{stage}/{stage} ({i}).jpeg",
                            Description = $"Description for Bird {stage} {i}"
                        });
                        imageCounter++;
                    }
                }

                // Serialize the data to JSON
                string json = JsonSerializer.Serialize(birdData, new JsonSerializerOptions { WriteIndented = true });

                // Define the file path in wwwroot
                string filePath = Path.Combine(Directory.GetCurrentDirectory(), "SeedData", "BirdData.json");

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

            string stageFolderPath = Path.Combine(_environment.WebRootPath, "images/birddataset", stage);

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
            string zipPath = Path.Combine(tempFolderPath, "All_Birds_Images.zip");

            // Delete any existing ZIP file with the same name
            if (System.IO.File.Exists(zipPath))
            {
                System.IO.File.Delete(zipPath);
            }

            // Create the ZIP file
            using (var zipArchive = ZipFile.Open(zipPath, ZipArchiveMode.Create))
            {
                // Add each stage folder directly into the zip archive
                foreach (var stage in stages)
                {
                    string stageFolderPath = Path.Combine(_environment.WebRootPath, "images/birddataset", stage);

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

            return File(fileBytes, "application/zip", "All_Birds_Images.zip");
        }
    }
}
