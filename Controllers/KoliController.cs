using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.IO;

namespace JasmineLeaf.Controllers
{
    public class KoliController : Controller
    {
        public IActionResult Index()
        {
            //generate koli dataset
            try
            {
                // Generate the dataset
                var koliData = new List<object>();
                for (int i = 1; i <= 253; i++)
                {
                    koliData.Add(new
                    {
                        Id = i,
                        Name = $"Koli ({i})",
                        Image = $"wwwroot/images/kolidataset/Koli ({i}).jpeg",
                        Description = $"Description for Koli {i}"
                    });
                }

                // Serialize the data to JSON
                string json = JsonSerializer.Serialize(koliData, new JsonSerializerOptions { WriteIndented = true });

                // Define the file path in wwwroot
                string filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Kolis.json");

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

            return View();
        }
    }
}
