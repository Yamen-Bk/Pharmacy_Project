using Guna.UI2.WinForms.Suite;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using Pharmacy_Project.Classes;
using SkiaSharp;
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
            LoadHomeData();
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
        //LabelTotalMedicines.Text = Pharmacy.Medicines.Count.ToString();
        //LabelExpired.Text = Pharmacy.Medicines.Count(m => m.IsExpired()).ToString();
        //LabelLowStock.Text = Pharmacy.Medicines.Count(m => m.IsLowStock()).ToString();

        private void LoadHomeData()
        {
            // Welcome
            LabelWelcome.Text = $"Welcome back, {Pharmacy.User.Username} 👋";
            //lblDate.Text = DateTime.Now.ToString("dddd, MMM dd yyyy");

            // إحصائيات
            int totalMeds = Pharmacy.Medicines.Count;
            int expired = Pharmacy.Medicines.Count(m => m.IsExpired());
            int lowStock = Pharmacy.Medicines.Count(m => m.IsLowStock());
            int totalSold = Pharmacy.Invoices
                              .SelectMany(i => i.Items)
                              .Sum(i => i.Quantity);
            double totalSales = Pharmacy.Invoices
                               .Sum(i => i.TotalPrice);

            LabelMedicinesSold.Text = totalSold.ToString();
            LabelTotalSales.Text = totalSales.ToString("N0") + " SYP";

            // Cartesian Chart — أكتر 5 أدوية بالمخزون
            var top5 = Pharmacy.Medicines
                       .OrderByDescending(m => m.Quantity)
                       .Take(5)
                       .ToList();

            cartesianChart1.Series = new ISeries[]
            {
        new ColumnSeries<int>
        {
            Name   = "Stock",
            Values = top5.Select(m => m.Quantity).ToArray(),
            Fill   = new SolidColorPaint(SKColor.Parse("#1565C0")),
            Stroke = null,
            MaxBarWidth = 40
        }
            };

            cartesianChart1.XAxes = new Axis[]
            {
        new Axis
        {
            Labels      = top5.Select(m => m.TradeName).ToArray(),
            LabelsPaint = new SolidColorPaint(SKColor.Parse("#333333")),
            TicksPaint  = null
        }
            };

            cartesianChart1.YAxes = new Axis[]
            {
        new Axis
        {
            LabelsPaint = new SolidColorPaint(SKColor.Parse("#333333"))
        }
            };

            // Pie Chart — Total / LowStock / Expired
            int normal = totalMeds - expired - lowStock;

            pieChart1.Series = new ISeries[]
            {
        new PieSeries<int>
        {
            Name   = "Normal",
            Values = new[] { normal },
            Fill   = new SolidColorPaint(SKColor.Parse("#4CAF50"))
        },
        new PieSeries<int>
        {
            Name   = "Low Stock",
            Values = new[] { lowStock },
            Fill   = new SolidColorPaint(SKColor.Parse("#FF9800"))
        },
        new PieSeries<int>
        {
            Name   = "Expired",
            Values = new[] { expired },
            Fill   = new SolidColorPaint(SKColor.Parse("#F44336"))
        }
            };
        }
    }
}
