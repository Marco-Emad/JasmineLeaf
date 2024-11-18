using System;
using System.Net.Mail;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using JasmineLeaf.Models;

namespace JasmineLeaf.Controllers
{
    public class AuthorizationController : Controller
    {
        private readonly string _adminEmail = "marcoemad42@yahoo.com";
        private readonly string _appUrl = "https://localhost:44362"; // Replace with your app URL
        private readonly SmtpEmailService _emailService;
        public AuthorizationController(SmtpEmailService emailService)
        {
            _emailService = emailService;
        }

        public async Task<IActionResult> RequestAuthorization()
        {
            var approveLink = Url.Action("ApproveAuthorization", "Authorization", null, HttpContext.Request.Scheme);
            var denyLink = Url.Action("DenyAuthorization", "Authorization", null, HttpContext.Request.Scheme);
            var message = $"A user has requested download authorization.<br><a href='{approveLink}'>Approve</a> | <a href='{denyLink}'>Deny</a>";

            await _emailService.SendEmailAsync("your-email@example.com", "Download Authorization Request", message);

            return RedirectToAction("AuthorizationRequested");
        }

        // Action to handle the "Get Authorized" request
        [HttpGet]
        public IActionResult Request()
        {
            string authorizeUrl = $"{_appUrl}/Authorization/Authorize";
            string denyUrl = $"{_appUrl}/Authorization/Deny";

            SendAuthorizationRequestEmail(authorizeUrl, denyUrl);

            return Json(new { message = "Authorization request sent!" });
        }

        private void SendAuthorizationRequestEmail(string authorizeUrl, string denyUrl)
        {
            using (var client = new SmtpClient("smtp.example.com")) // Use your SMTP configuration
            {
                var message = new MailMessage();
                message.To.Add(_adminEmail);
                message.Subject = "Authorization Request";
                message.Body = $"A user is requesting download authorization. \n\n" +
                               $"Authorize: {authorizeUrl}\n" +
                               $"Deny: {denyUrl}";

                client.Send(message);
            }
        }

        // Endpoint to authorize a download
        [HttpGet]
        public IActionResult Authorize()
        {
            SetAuthorizationCookie();
            return Content("Authorization granted! The user can now download files.");
        }

        // Endpoint to deny a download request
        [HttpGet]
        public IActionResult Deny()
        {
            return Content("Authorization denied. The user will not be able to download files.");
        }

        private void SetAuthorizationCookie()
        {
            CookieOptions options = new CookieOptions
            {
                Expires = DateTime.Now.AddDays(7),
                HttpOnly = true
            };
            Response.Cookies.Append("DownloadAuthorization", "Authorized", options);
        }
    }


}
