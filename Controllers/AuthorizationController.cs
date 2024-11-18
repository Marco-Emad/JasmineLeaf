using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.Mail;
using NETCore.MailKit.Core;

namespace JasmineLeaf.Controllers
{
    public class AuthorizationController : Controller
    {
        //private readonly string _adminEmail = "marcoemad42@yahoo.com";
        //private readonly string _appUrl = "https://localhost:44362"; // Replace with your app URL
        //private readonly ILogger<AuthorizationController> _logger;
        //private readonly IEmailService _emailService;
        //public AuthorizationController(IEmailService emailService, ILogger<AuthorizationController> logger)
        //{
        //    _emailService = emailService;
        //    _logger = logger;
        //}

        [HttpPost]
        public IActionResult RequestAuthorization()
        {
            // Replace with your SMTP configuration and email logic
            string userEmail = "marcoemad42@yahoo.com"; // Your email
            string subject = "Authorization Request for Download";

            string acceptUrl = Url.Action("GrantAuthorization", "Authorization", new { token = "sample_token" }, Request.Scheme);
            string declineUrl = Url.Action("DenyAuthorization", "Authorization", null, Request.Scheme);

            string body = $@"
            A visitor has requested authorization to download images.
            <br><br>
            Accept: <a href='{acceptUrl}'>Grant Access</a><br>
            Decline: <a href='{declineUrl}'>Deny Access</a>";

            bool emailSent = SendEmail(userEmail, subject, body);

            if (emailSent)
            {
                return Json(new { success = true, message = "Authorization request sent. Please check your email." });
            }
            else
            {
                return Json(new { success = false, message = "Failed to send authorization request. Try again later." });
            }
        }

        private bool SendEmail(string to, string subject, string body)
        {
            try
            {
                var smtpClient = new SmtpClient("smtp.mail.yahoo.com")
                {
                    Port = 465,
                    Credentials = new NetworkCredential("macmax160@yahoo.com", "marcoemad*2295955"),
                    EnableSsl = true,
                };

                var mailMessage = new MailMessage
                {
                    From = new MailAddress("macmax160@yahoo.com"),
                    Subject = subject,
                    Body = body,
                    IsBodyHtml = true,
                };
                mailMessage.To.Add(to);

                smtpClient.Send(mailMessage);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); // Log error
                return false;
            }
        }

        public IActionResult GrantAuthorization(string token)
        {
            // Logic to generate and store a cookie or token
            Response.Cookies.Append("Authorization", token, new CookieOptions { Expires = DateTime.Now.AddDays(7) });
            return Content("Access granted. The visitor can now download images.");
        }

        public IActionResult DenyAuthorization()
        {
            return Content("Access denied. The visitor will not be able to download images.");
        }

    }
}