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

        private static string projectPath = Directory.GetParent(Application.StartupPath).Parent.Parent.Parent.FullName;

        private static string jsonFolder = Path.Combine(projectPath, "Jsons");
        private static string medicinesPath = Path.Combine(jsonFolder, "medicines.json");
        private static string invoicesPath = Path.Combine(jsonFolder, "invoices.json");
        private static string userPath = Path.Combine(jsonFolder, "user.json");

        public static void LoadData()
        {
            if (!Directory.Exists(jsonFolder))
                Directory.CreateDirectory(jsonFolder);

            if (!File.Exists(medicinesPath))
                File.WriteAllText(medicinesPath, "[]");

            if (!File.Exists(invoicesPath))
                File.WriteAllText(invoicesPath, "[]");

            if (!File.Exists(userPath))
                File.WriteAllText(userPath, "{}");

            Medicines = JsonConvert.DeserializeObject<List<Medicine>>(File.ReadAllText(medicinesPath));
            Invoices = JsonConvert.DeserializeObject<List<Invoice>>(File.ReadAllText(invoicesPath));
            User = JsonConvert.DeserializeObject<User>(File.ReadAllText(userPath));

            if (Medicines == null)
                Medicines = new List<Medicine>();

            if (Invoices == null)
                Invoices = new List<Invoice>();
        }
        public static void SaveData()
        {
            if (!Directory.Exists(jsonFolder))
                Directory.CreateDirectory(jsonFolder);

            File.WriteAllText(medicinesPath, JsonConvert.SerializeObject(Medicines, Formatting.Indented));
            File.WriteAllText(invoicesPath, JsonConvert.SerializeObject(Invoices, Formatting.Indented));
            File.WriteAllText(userPath, JsonConvert.SerializeObject(User, Formatting.Indented));
        }
        public static void AddMedicine(Medicine m)
        {
            int maxid = 0;
            if (Medicines.Count == 0)
                m.Id = 1;
            else
            {
                foreach (Medicine med in Medicines)
                {
                    if (med.Id > maxid)
                        maxid = med.Id;
                }
            }
            m.Id = maxid + 1;
            Medicines.Add(m);
            SaveData();
        }
        public static void RemoveMedicine(int id)
        {
            Medicine toremove = null;
            foreach (Medicine med in Medicines)
            {
                if (med.Id == id)
                    toremove = med;
            }
            if (toremove != null)
                Medicines.Remove(toremove);
            SaveData();
        }
        public static void RemoveAllExpired()
        {
            List<Medicine> toremove = new List<Medicine>();
            foreach (Medicine med in Medicines)
            {
                if (med.IsExpired())
                    toremove.Add(med);
            }
            foreach (Medicine med in toremove)
            {
                Medicines.Remove(med);
            }
            SaveData();
        }
        public static void UpdateMedicine(Medicine m)
        {
            for (int i = 0; i < Medicines.Count; i++)
            {
                if (Medicines[i].Id == m.Id)
                {
                    Medicines[i] = m;
                    break;
                }
            }
            SaveData();
        }
        public static List<Medicine> GetExpiredMedicines()
        {
            List<Medicine> result = new List<Medicine>();
            foreach (Medicine m in Medicines)
            {
                if (m.IsExpired())
                    result.Add(m);
            }
            return result;
        }
        public static void ProcessSale(List<InvoiceItem> cart)
        {
            foreach(InvoiceItem item in cart)
            {
                foreach (Medicine m in Medicines)
                {
                    if(m.Id == item.Medicine.Id)
                    {
                        m.Quantity -= item.Quantity;
                        break;
                    }
                }
            }
            Invoice inv = new Invoice();
            inv.Id = Invoices.Count + 1;
            inv.Date = DateTime.Now;
            inv.Items = new List<InvoiceItem>(cart);
            inv.CalculateTotal();
            Invoices.Add(inv);
            SaveData();
        }
    }
}
