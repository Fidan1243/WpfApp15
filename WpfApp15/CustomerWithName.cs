using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp15
{
    class CustomerWithName : Customer
    {
        public string ProductName { get; set; }
        public string Name { get; set; }
        public void Notification()
        {
            MessageBox.Show($"{ProductName} is ordered by {Name}");
        }
    }
}
