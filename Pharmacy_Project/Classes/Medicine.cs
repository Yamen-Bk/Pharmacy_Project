using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Project.Classes
{
    public class Medicine
    {
        public int Id { get; set; }
        public string TradeName { get; set; }
        public string ScientificName { get; set; }
        public string Manufacturer { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public DateTime ExpiryDate { get; set; }

        public bool IsExpired()
        {
            if(DateTime.Today > ExpiryDate.Date)
                return true;
            return false;
        }
        public bool IsExpiringSoon()
        {
            TimeSpan remaining = ExpiryDate.Date - DateTime.Today;
            if (remaining.Days < 30 && remaining.Days > 0) 
                return true; 
            return false;
        }
        public bool IsLowStock()
        {
            if(Quantity < 5)
                return true;
            return false;
        }
   }
}
