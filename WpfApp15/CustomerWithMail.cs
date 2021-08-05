using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp15
{
    class CustomerWithMail : Customer
    {
        public string ProductName { get; set; }
        public string Mail { get; set; }
        public void Notification()
        {
            MailSender s = new MailSender();
            s.SendMail(Mail, ProductName);
        }
    }
}
