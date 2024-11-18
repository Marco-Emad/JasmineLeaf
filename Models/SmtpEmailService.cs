using System.Net;
using System.Net.Mail;
using Microsoft.Extensions.Configuration;

namespace JasmineLeaf.Models
{
    public class SmtpEmailService
    {
        private readonly IConfiguration _configuration;

        public SmtpEmailService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task SendEmailAsync(string recipientEmail, string subject, string messageBody)
        {
            var smtpSettings = _configuration.GetSection("SmtpSettings");
            var smtpClient = new SmtpClient(smtpSettings["Server"], int.Parse(smtpSettings["Port"]))
            {
                Credentials = new NetworkCredential(smtpSettings["SenderEmail"], smtpSettings["SenderPassword"]),
                EnableSsl = bool.Parse(smtpSettings["EnableSSL"])
            };

            var mailMessage = new MailMessage(smtpSettings["SenderEmail"], recipientEmail)
            {
                Subject = subject,
                Body = messageBody,
                IsBodyHtml = true
            };

            await smtpClient.SendMailAsync(mailMessage);
        }
    }

}
