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

        public static void AddMedicine(Medicine m)
        {
            //if (Medicines.Count == 0)
            //    m.Id = 1;
            //else
            //    m.Id = Medicines.Count + 1;

            //condition ? value_if_true : value_if_false
            m.Id = Medicines.Count == 0 ? 1 : Medicines.Max(x => x.Id) + 1;
            Medicines.Add(m);
            SaveData();
        }

        public static void RemoveMedicine(int id)
        {
            Medicines.RemoveAll(m => m.Id == id);
            SaveData();
        }

        public static void RemoveAllExpired()
        {
            Medicines.RemoveAll(m => m.IsExpired());
            SaveData();
        }

        public static void UpdateMedicine(Medicine m)
        {
            int index = Medicines.FindIndex(x => x.Id == m.Id);
            if (index >= 0)
                Medicines[index] = m;
            SaveData();
        }
        public static List<Medicine> FilterBy(string type, bool ascending)
        {
            if (type == "Price")
                return ascending ?
                    Medicines.OrderBy(m => m.Price).ToList():
                    Medicines.OrderByDescending(m => m.Price).ToList();

            if (type == "Manufacturer")
                return ascending ?
                    Medicines.OrderBy(m => m.Manufacturer).ToList() :
                    Medicines.OrderByDescending(m => m.Manufacturer).ToList();

            if (type == "Expiry")
                return ascending ?
                    Medicines.OrderBy(m => m.ExpiryDate).ToList() :
                    Medicines.OrderByDescending(m => m.ExpiryDate).ToList();

            return Medicines;
        }
        public static List<Medicine> GetExpiredMedicines()
        {
            return Medicines.Where(m => m.IsExpired()).ToList();
        }
    }
}
