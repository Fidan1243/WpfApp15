using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp15
{
    class Store
    {
        public Store(List<Customer> customers)
        {
            Customers = customers;
        }
        public List<Customer> Customers { get; set; }
        public void SendAllNotifications()
        {
            foreach (var item in Customers)
            {
                item.Notification();
            }
        }

    }
}
