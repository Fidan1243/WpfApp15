﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp15
{
    class MailSender
    {
        public void SendMail(string server,string name)
        {
            string to = $"{server}";
            string from = "testm3212@gmail.com";
            string subject = "New notification!!";
            string body = $@"{name} is in your wish list";
            MailMessage message = new MailMessage(from, to, subject, body);
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.Timeout = 100;
            // Credentials are necessary if the server requires the client 
            // to authenticate before it will send e-mail on the client's behalf.
            client.Credentials = CredentialCache.DefaultNetworkCredentials;

            try
            {
                client.Send(message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught in CreateTimeoutTestMessage(): {0}",
                      ex.ToString());
            }
        }
    }
}