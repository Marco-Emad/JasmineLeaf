﻿using Microsoft.AspNetCore.Mvc;
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
            return View();
        }
        public IActionResult RequestDownload()
        {
            //remove expired cookies from database
            var expirationDate = DateTime.Now.AddDays(-7); // Assume 7-day cookie expiration
            var expiredRequests = _context.Requests.Where(r => r.RequestedAt < expirationDate);
            try
            {
                _context.Requests.RemoveRange(expiredRequests);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                // Log the exception here
                return Json(new { message = "An error occurred while deleting expired cookies. Please try again later." });
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
                    return Json(new { message = "Your request is still pending. Please wait for admin approval." });
                else if (existingRequest.Status == "Rejected")
                    return Json(new { message = "Your request has been rejected. Contact admin for more details." });
                else if (existingRequest.Status == "Approved")
                    return Json(new { message = "You are already approved. You can download the files." });
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

            return Json(new { message = "Your request has been sent. Please wait for admin approval." });
        }

        [HttpPost]
        public IActionResult ReviewRequests(string key)
        {
            // Get the admin key from configuration
            var adminKey = _config["AdminKey"];

            // Check if the provided key matches the stored admin key
            if (key != adminKey)
            {
                // If not, return Unauthorized
                return Unauthorized("You are not authorized to access this page.");
            }

            // If the key is valid, retrieve pending requests
            var pendingRequests = _context.Requests.Where(r => r.Status == "Pending").ToList();

            // Return the view with the list of pending requests
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

        //private void SendNotification(string userId, string message)
        //{
        //    var user = _context.Users.Find(userId);
        //    if (user != null && !string.IsNullOrEmpty(user.Email))
        //    {
        //        // كود إرسال الإيميل هنا
        //    }
        //}

    }
}