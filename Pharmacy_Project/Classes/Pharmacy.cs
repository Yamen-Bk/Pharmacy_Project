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
            int maxid = 0;
            if (Medicines.Count == 0)
                m.Id = 1;
            else
            {
                foreach (Medicine med in Medicines)
                {
                    if (m.Id > maxid)
                        maxid = m.Id;
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
        public static List<Medicine> FilterBy(string type)
        {
            List<Medicine> result = new List<Medicine>();
            foreach (Medicine me in Medicines)
                result.Add(me);
            if (type == "")
                return result;
            for (int i = 0; i < result.Count; i++)
            {
                for (int j = i + 1; j < result.Count; j++)
                {
                    bool shouldswap = false;
                    if (type == "Price")
                    {
                        if (result[i].Price > result[j].Price)
                            shouldswap = true;
                    }
                    else if (type == "Manufacturer")
                    {
                        if (result[i].Manufacturer[0] > result[j].Manufacturer[0])
                            shouldswap = true;
                    }
                    else if (type == "Expiry")
                    {
                        if (result[i].ExpiryDate > result[j].ExpiryDate)
                            shouldswap = true;
                    }
                    if (shouldswap)
                    {
                        Medicine temp = result[i];
                        result[i] = result[j];
                        result[j] = temp;
                    }
                }
            }
            return result;
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
    }
}
