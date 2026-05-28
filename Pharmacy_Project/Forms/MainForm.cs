using Guna.UI2.WinForms.Suite;
using Pharmacy_Project.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Project.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnNavHome_Click(object sender, EventArgs e)
        {
            MainTabControl.SelectedTab = TabHome;
        }

        private void btnNavMedicines_Click(object sender, EventArgs e)
        {
            MainTabControl.SelectedTab = TabMedicines;
        }

        private void btnNavExpired_Click(object sender, EventArgs e)
        {
            MainTabControl.SelectedTab = TabExpired;
        }

        private void btnNavPOS_Click(object sender, EventArgs e)
        {
            MainTabControl.SelectedTab = TabPOS;
        }

        private void btnNavInvoice_Click(object sender, EventArgs e)
        {
            MainTabControl.SelectedTab = TabInvoice;
        }

        private void btnNavSettings_Click(object sender, EventArgs e)
        {
            MainTabControl.SelectedTab = TabSettings;
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!this.Visible) return;
            if (e.CloseReason != CloseReason.UserClosing) return;
            DialogResult result = MessageBox.Show("Do you want to Exit the Application", "Exit",
                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Pharmacy.SaveData();
                Application.Exit();
            }
        }
    }
}
