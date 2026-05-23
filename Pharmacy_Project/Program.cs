using Pharmacy_Project.Classes;

namespace Pharmacy_Project
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Pharmacy.LoadData();
            Application.Run(new LoginForm());
        }
    }
}