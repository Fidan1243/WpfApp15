using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp15
{
    public interface Customer
    {
        string ProductName { get; set; }
        void Notification();
    }
}
