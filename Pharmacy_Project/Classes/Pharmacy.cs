using Newtonsoft.Json;
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Project.Classes
{
    public static class Pharmacy
    {
        public static List<Medicine> Medicines = new List<Medicine>();
        public static List<Invoice> Invoices = new List<Invoice>();
        public static User User;

        private static string medicinesPath = "medicines.json";
        private static string invoicesPath = "invoices.json";
        private static string userPath = "user.json";

        public static void LoadData()
        {
            if (File.Exists(medicinesPath))
                Medicines = JsonConvert.DeserializeObject<List<Medicine>>(File.ReadAllText(medicinesPath));

            if (File.Exists(invoicesPath))
                Invoices = JsonConvert.DeserializeObject<List<Invoice>>(File.ReadAllText(invoicesPath));

            if (File.Exists(userPath))
                User = JsonConvert.DeserializeObject<User>(File.ReadAllText(userPath));
        }
        public static void SaveData() 
        {
            File.WriteAllText(medicinesPath, JsonConvert.SerializeObject(Medicines, Formatting.Indented));
            File.WriteAllText(invoicesPath, JsonConvert.SerializeObject(Invoices, Formatting.Indented));
        }
        public static void LoadInitialData()
        {
            Medicines.Add(new Medicine
            {
                Id = 1,
                TradeName = "بنادول",
                ScientificName = "باراسيتامول",
                Manufacturer = "GSK",
                Price = 2500,
                Quantity = 50,
                ExpiryDate = DateTime.Now.AddMonths(6)
                TradeName = "أموكسيل",
                ScientificName = "أموكسيسيلين",
                Manufacturer = "Pfizer",
                Price = 4000,
                Quantity = 3,
                ExpiryDate = DateTime.Now.AddDays(10)
            });
            Medicines.Add(new Medicine
            {
                Id = 3,
                TradeName = "فولتارين",
                ScientificName = "ديكلوفيناك",
                Manufacturer = "Novartis",
                Price = 3000,
                Quantity = 20,
                ExpiryDate = DateTime.Now.AddYears(-1)
            });
        }
    }
}
