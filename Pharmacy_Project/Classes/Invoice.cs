using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Project.Classes
{
    public class Invoice
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public List<InvoiveItem> Items { get; set; }
        public double TotalPrice { get; set; }

        public void CalculateTotal()
        {
            TotalPrice = 0;
            foreach (InvoiveItem item in Items)
            {
                TotalPrice += item.SubTotal;
            }
        }
    }
}
