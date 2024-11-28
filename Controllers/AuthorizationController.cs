using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.Mail;
using NETCore.MailKit.Core;
using Microsoft.EntityFrameworkCore;
using JasmineLeaf.Models;

namespace JasmineLeaf.Controllers
{
    public class AuthorizationController : Controller
    {
        private readonly LeafContext _context;
        private readonly IConfiguration _config;

        public AuthorizationController(LeafContext _context, IConfiguration config)
        {
            this._context = _context;
            _config = config;
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
        public IActionResult RequestDownload()
        {
            //remove expired cookies from database
            var expirationDate = DateTime.Now.AddDays(-7); // 7-day cookie expiration
            var expiredRequests = _context.Requests.Where(r => r.RequestedAt < expirationDate);
            try
            {
                _context.Requests.RemoveRange(expiredRequests);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                return Json(new
                {
                    title = "Error",
                    message = "An error occurred while deleting expired cookies. Please try again later."
                });
            }


            // Check if the user has a cookie
            var userId = Request.Cookies["UserId"];
            if (string.IsNullOrEmpty(userId))
            {
                // Generate a new UserId and set the cookie
                userId = Guid.NewGuid().ToString();
                Response.Cookies.Append("UserId", userId, new CookieOptions
                {
                    Expires = DateTimeOffset.Now.AddDays(7)
                });
            }

            // Check for an existing request in the database
            var existingRequest = _context.Requests.FirstOrDefault(r => r.UserId == userId);
            if (existingRequest != null)
            {
                // Return a message based on the status of the existing request
                if (existingRequest.Status == "Pending")
                    return Json(new { title = "Pending Request", message = "Your request is still pending. Please wait for admin approval." });
                else if (existingRequest.Status == "Rejected")
                    return Json(new { title = "Request Rejected", message = "Your request has been Rejected. Contact admin for more details." });
                else if (existingRequest.Status == "Approved")
                    return Json(new { title = "Request Approved", message = "You are already Approved. You can download the files now." });
            }

            // Only add a new request if no existing request is found
            var newRequest = new Request
            {
                UserId = userId,
                Status = "Pending",
                RequestedAt = DateTime.Now
            };
            _context.Requests.Add(newRequest);
            _context.SaveChanges();

            return Json(new { title = "Request Sent", message = "Your request has been sent. Please wait for admin approval." });
        }

        [HttpPost]
        public IActionResult ValidateAdminKey(string key)
        {
            var adminKey = _config["AdminKey"];
            if (key == adminKey)
            {
                HttpContext.Session.SetString("IsAdmin", "true");
                return RedirectToAction("ReviewRequests");
            }

            ModelState.AddModelError("", "Invalid admin key.");
            return View("Index");
        }
        public IActionResult ReviewRequests()
        {
            if (HttpContext.Session.GetString("IsAdmin") != "true")
                return Unauthorized("Access denied.");

            var pendingRequests = _context.Requests.Where(r => r.Status == "Pending").ToList();
            return View(pendingRequests);
        }

        [HttpPost]
        public IActionResult ApproveRequest(int requestId)
        {
            var request = _context.Requests.Find(requestId);
            if (request == null) return NotFound();

            request.Status = "Approved";
            request.ReviewedAt = DateTime.Now;
            _context.SaveChanges();

            return RedirectToAction("ReviewRequests");
        }

        [HttpPost]
        public IActionResult RejectedRequest(int requestId)
        {
            var request = _context.Requests.Find(requestId);
            if (request == null) return NotFound();

            request.Status = "Rejected";
            request.ReviewedAt = DateTime.Now;
            _context.SaveChanges();

            return RedirectToAction("ReviewRequests");
        }

    }
}