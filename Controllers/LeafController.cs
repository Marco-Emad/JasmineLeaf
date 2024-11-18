using Microsoft.AspNetCore.Mvc;
using System.IO.Compression;

namespace JasmineLeaf.Controllers
{
    public class LeafController : Controller
    {
        private readonly IWebHostEnvironment _environment;
        private readonly List<string> _stages = new List<string> { "Healthy", "Stage1", "Stage2", "Stage3", "Stage4" };

        public LeafController(IWebHostEnvironment environment)
        {
            _environment = environment;
        }
        private bool IsAuthorized()
        {
            return Request.Cookies.ContainsKey("Authorization");
        }
        public IActionResult DownloadStage(string stage)
        {
            // Check if the user authorized to download
            if (!IsAuthorized())
            {
                return Json(new { success = false, message = "You are not authorized to download. Please request access." });
            }

            string stageFolderPath = Path.Combine(_environment.WebRootPath, "images", stage);

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
            // Check if the user authorized to download
            if (!IsAuthorized())
            {
                return Json(new { success = false, message = "You are not authorized to download. Please request access." });
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
                    string stageFolderPath = Path.Combine(_environment.WebRootPath, "images", stage);

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

        public IActionResult Index()
        {
            return View();
        }
    }
}
