using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalSoftware.Logic
{
    class OrderItem
    {
        public class Order
        {
           
            public string ItemName { get; set; }
            public string Quantity { get; set; }
            public string UnitPrice { get; set; }
            public string Total { get; set; }
        }
    }
}
