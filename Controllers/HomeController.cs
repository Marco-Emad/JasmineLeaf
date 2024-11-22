using JasmineLeaf.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace JasmineLeaf.Controllers
{
    public class HomeController : Controller
    {
        private readonly LeafContext _context;
        public HomeController(LeafContext _context)
        {
            this._context = _context;
        }

        public IActionResult Index()
        {
            var userId = Request.Cookies["UserId"];
            ViewData["UserStatus"] = null;
            if (!string.IsNullOrEmpty(userId))
            {
                ViewData["UserStatus"] = _context.Requests.FirstOrDefault(r => r.UserId == userId).Status;
            }

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
