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
        public KoliController(IWebHostEnvironment environment, LeafContext context)
        {
            _environment = environment;
            _context = context;
        }
        public IActionResult Index()
        {
            //generate koli dataset
            //try
            //{
            //    // Generate the dataset
            //    var koliData = new List<object>();
            //    for (int i = 1; i <= 253; i++)
            //    {
            //        koliData.Add(new
            //        {
            //            Id = i,
            //            Name = $"Koli ({i})",
            //            Image = $"wwwroot/images/kolidataset/Koli ({i}).jpeg",
            //            Description = $"Description for Koli {i}"
            //        });
            //    }

            //    // Serialize the data to JSON
            //    string json = JsonSerializer.Serialize(koliData, new JsonSerializerOptions { WriteIndented = true });

            //    // Define the file path in wwwroot
            //    string filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Kolis.json");

            //    // Ensure the directory exists
            //    string directoryPath = Path.GetDirectoryName(filePath);
            //    if (!Directory.Exists(directoryPath))
            //    {
            //        Directory.CreateDirectory(directoryPath);
            //    }

            //    // Write the JSON data to the file
            //    System.IO.File.WriteAllText(filePath, json);

            //    ViewBag.Message = "JSON file created successfully!";
            //}
            //catch (Exception ex)
            //{
            //    ViewBag.Message = $"Error: {ex.Message}";
            //}

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

        public IActionResult DownloadStage()
        {
            if (!IsDownloadAuthorized())
            {
                return Json(new
                {
                    title = "Access Denied",
                    message = "you are not authorized to download the dataset, request the admin for permission."
                });
            }

            string stageFolderPath = Path.Combine(_environment.WebRootPath, "images", "kolidataset");

            if (!Directory.Exists(stageFolderPath))
            {
                return NotFound("The specified stage does not exist.");
            }

            string zipPath = Path.Combine(_environment.WebRootPath, "temp", $"Koli_images.zip");

            //if the file already exist delete it
            if (System.IO.File.Exists(zipPath))
            {
                System.IO.File.Delete(zipPath);
            }

            ZipFile.CreateFromDirectory(stageFolderPath, zipPath);

            byte[] fileBytes = System.IO.File.ReadAllBytes(zipPath);

            return File(fileBytes, "application/zip", $"Koli_images.zip");
        }
    }
}
