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
using LiveChartsCore;

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
        private void HideAllArrows()
        {
            HomeTabSelectArrow.Visible = false;
            MedicinesTabSelectArrow.Visible = false;
            ExpiredTabSelectArrow.Visible = false;
            POSTabSelectArrow.Visible = false;
            InvoiceTabSelectArrow.Visible = false;
            SettingsTabSelectArrow.Visible = false;
        }

        private void btnNavHome_Click(object sender, EventArgs e)
        {
            HideAllArrows();
            MainTabControl.SelectedTab = TabHome;
            HomeTabSelectArrow.Visible = true;
        }

        private void btnNavMedicines_Click(object sender, EventArgs e)
        {
            HideAllArrows();
            MainTabControl.SelectedTab = TabMedicines;
            MedicinesTabSelectArrow.Visible = true;
        }

        private void btnNavExpired_Click(object sender, EventArgs e)
        {
            HideAllArrows();
            MainTabControl.SelectedTab = TabExpired;
            ExpiredTabSelectArrow.Visible = true;
        }

        private void btnNavPOS_Click(object sender, EventArgs e)
        {
            HideAllArrows();
            MainTabControl.SelectedTab = TabPOS;
            POSTabSelectArrow.Visible = true;
        }

        private void btnNavInvoice_Click(object sender, EventArgs e)
        {
            HideAllArrows();
            MainTabControl.SelectedTab = TabInvoice;
            InvoiceTabSelectArrow.Visible = true;
        }

        private void btnNavSettings_Click(object sender, EventArgs e)
        {
            HideAllArrows();
            MainTabControl.SelectedTab = TabSettings;
            SettingsTabSelectArrow.Visible = true;
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
