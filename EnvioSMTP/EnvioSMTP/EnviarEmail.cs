
using System.Net;
using System.Net.Mail;

namespace EnvioSMTP
{
    public class EnviarEmail
    {
        public static void EnviarMessagemEmail(string from, string to, string subject, string messagem)
        {
            var Email = new MailMessage();
            Email.To.Add(new MailAddress(to));
            Email.From = new MailAddress(from);
            Email.Subject = subject;
            Email.IsBodyHtml = true;
            Email.Body = messagem;
            var SMTPClient = new SmtpClient("smtp.gmail.com", 587);
            SMTPClient.EnableSsl = true;
            SMTPClient.UseDefaultCredentials = false;
            SMTPClient.Credentials = new NetworkCredential("SEU EMAIL", "SUA SENHA");
            SMTPClient.Send(Email);
        }
    }
}
