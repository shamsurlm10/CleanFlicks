using CleanMovie.Application.Interfaces;
using System.Net;
using System.Net.Mail;

namespace CleanMovie.Application.Services
{
    public class EmailService : IEmailService
    {
        public Task SendEmailAsync(string to, string subject, string body)
        {
            var mail = "test.amberit@gmail.com";
            var pw = "gllh pzec tnyl bfcw";
            var client = new SmtpClient("smtp.gmail.com", 587)
            {
                EnableSsl = false,
                UseDefaultCredentials = true,
                Credentials = new NetworkCredential(mail, pw),
                DeliveryMethod = SmtpDeliveryMethod.Network
            };
            var message = new MailMessage(from: mail, to: to, subject, body);
            return client.SendMailAsync(message);
        }
    }
}
