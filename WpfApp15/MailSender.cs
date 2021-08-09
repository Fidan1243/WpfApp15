using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp15
{
    class MailSender
    {
        public void SendMail(string mails,string name)
        {
            MailMessage mail = new MailMessage();
            SmtpClient smtpClient = new SmtpClient("smtp.google.com");

            mail.From = new MailAddress("testm3212@gmail.com");
            mail.To.Add(mails);
            mail.Subject = "About your order";
            mail.Body = $"The {name} named product was sent to you successfully! Thanks for shopping!";

            smtpClient.Port = 587;
            smtpClient.Credentials = new System.Net.NetworkCredential("testm3212@gmail.com", "test121416");
            smtpClient.EnableSsl = true;
            smtpClient.Send(mail);

            MessageBox.Show("Your Message was sent to you", "Mail Customer",MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
