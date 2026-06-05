using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Project.Classes
{
    public class InvoiveItem
    {
        public Medicine Medicine { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
        public double SubTotal
        {
            get { return Quantity * UnitPrice; }
        }
    }
}
