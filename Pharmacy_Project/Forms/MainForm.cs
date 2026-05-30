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
        int EditingId = -1;

        /// <summary>
        /// MainForm
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadMedicines();
            //LoadHomeData();
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
                                                  MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Pharmacy.SaveData();
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }
        /// <summary>
        /// Home Tab
        /// </summary>
        //private void LoadHomeData()
        //{
        //    // Welcome
        //    LabelWelcome.Text = $"Welcome back, {Pharmacy.User.Username} 👋";
        //    //lblDate.Text = DateTime.Now.ToString("dddd, MMM dd yyyy");

        //    // إحصائيات
        //    int totalMeds = Pharmacy.Medicines.Count;
        //    int expired = Pharmacy.Medicines.Count(m => m.IsExpired());
        //    int lowStock = Pharmacy.Medicines.Count(m => m.IsLowStock());
        //    int totalSold = Pharmacy.Invoices
        //                      .SelectMany(i => i.Items)
        //                      .Sum(i => i.Quantity);
        //    double totalSales = Pharmacy.Invoices
        //                       .Sum(i => i.TotalPrice);

        //    LabelMedicinesSold.Text = totalSold.ToString();
        //    LabelTotalSales.Text = totalSales.ToString("N0") + " SYP";

        //    // Cartesian Chart — أكتر 5 أدوية بالمخزون
        //    var top5 = Pharmacy.Medicines
        //               .OrderByDescending(m => m.Quantity)
        //               .Take(5)
        //               .ToList();

        //    cartesianChart1.Series = new ISeries[]
        //    {
        //new ColumnSeries<int>
        //{
        //    Name   = "Stock",
        //    Values = top5.Select(m => m.Quantity).ToArray(),
        //    Fill   = new SolidColorPaint(SKColor.Parse("#1565C0")),
        //    Stroke = null,
        //    MaxBarWidth = 40
        //}
        //    };

        //    cartesianChart1.XAxes = new Axis[]
        //    {
        //new Axis
        //{
        //    Labels      = top5.Select(m => m.TradeName).ToArray(),
        //    LabelsPaint = new SolidColorPaint(SKColor.Parse("#333333")),
        //    TicksPaint  = null
        //}
        //    };

        //    cartesianChart1.YAxes = new Axis[]
        //    {
        //new Axis
        //{
        //    LabelsPaint = new SolidColorPaint(SKColor.Parse("#333333"))
        //}
        //    };

        //    // Pie Chart — Total / LowStock / Expired
        //    int normal = totalMeds - expired - lowStock;

        //    pieChart1.Series = new ISeries[]
        //    {
        //new PieSeries<int>
        //{
        //    Name   = "Normal",
        //    Values = new[] { normal },
        //    Fill   = new SolidColorPaint(SKColor.Parse("#4CAF50"))
        //},
        //new PieSeries<int>
        //{
        //    Name   = "Low Stock",
        //    Values = new[] { lowStock },
        //    Fill   = new SolidColorPaint(SKColor.Parse("#FF9800"))
        //},
        //new PieSeries<int>
        //{
        //    Name   = "Expired",
        //    Values = new[] { expired },
        //    Fill   = new SolidColorPaint(SKColor.Parse("#F44336"))
        //}
        //    };
        //}

        /// <summary>
        /// Medicine Tab
        /// </summary>

        private void ClearFields()
        {
            TradeNameTextBox.Text = "";
            ScientificNameTextBox.Text = "";
            ManufacturerTextBox.Text = "";
            PriceTextBox.Text = "";
            QuantityTextBox.Text = "";
            ExpiryDateTextBox.Text = "";
        }
        private void LoadMedicines()
        {
            string type = "";
            if (FilterComboBox.SelectedIndex == 1) type = "Price";
            else if (FilterComboBox.SelectedIndex == 2) type = "Manufacturer";
            else if (FilterComboBox.SelectedIndex == 3) type = "Expiry";

            var list = Pharmacy.FilterBy(type, true);

            MedicinesDataGridView.Rows.Clear();
            foreach (Medicine m in list)
            {
                int i = MedicinesDataGridView.Rows.Add();
                MedicinesDataGridView.Rows[i].Cells["Id"].Value = m.Id;
                MedicinesDataGridView.Rows[i].Cells["TradeName"].Value = m.TradeName;
                MedicinesDataGridView.Rows[i].Cells["ScientificName"].Value = m.ScientificName;
                MedicinesDataGridView.Rows[i].Cells["Manufacturer"].Value = m.Manufacturer;
                MedicinesDataGridView.Rows[i].Cells["Price"].Value = m.Price;
                MedicinesDataGridView.Rows[i].Cells["Quantity"].Value = m.Quantity;
                MedicinesDataGridView.Rows[i].Cells["ExpiryDate"].Value = m.ExpiryDate.ToShortDateString();

                if (m.IsExpired())
                {
                    MedicinesDataGridView.Rows[i].Cells["status"].Value = "Expired";
                    MedicinesDataGridView.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(255, 200, 200);
                }
                else if (m.IsExpiringSoon())
                {
                    MedicinesDataGridView.Rows[i].Cells["status"].Value = "ExpiringSoon";
                    MedicinesDataGridView.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(255, 240, 180);
                }
                else if (m.IsLowStock())
                {
                    MedicinesDataGridView.Rows[i].Cells["status"].Value = "LowStock";
                    MedicinesDataGridView.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(255, 220, 150);
                }
                else
                {
                    MedicinesDataGridView.Rows[i].Cells["status"].Value = "Good";
                }
            }
        }
        private void AddMedicinebtn_Click(object sender, EventArgs e)
        {
            ClearFields();
            AddMedicinePanel.Visible = true;
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            ClearFields();
            AddMedicinePanel.Visible = false;
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            Medicine m = new Medicine
            {
                TradeName = TradeNameTextBox.Text,
                ScientificName = ScientificNameTextBox.Text,
                Manufacturer = ManufacturerTextBox.Text,
                Price = Double.Parse(PriceTextBox.Text),
                Quantity = int.Parse(QuantityTextBox.Text),
                ExpiryDate = DateTime.Parse(ExpiryDateTextBox.Text)
            };

            if (EditingId == -1)
            {
                Pharmacy.AddMedicine(m);
            }
            else
            {
                m.Id = EditingId;
                Pharmacy.UpdateMedicine(m);
            }

            EditingId = -1;
            AddMedicinePanel.Visible = false;
            LoadMedicines();
        }

        private void Editbtn_Click(object sender, EventArgs e)
        {
            if (MedicinesDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select Medicine First");
                return;
            }
            int id = (int)MedicinesDataGridView.SelectedRows[0].Cells["Id"].Value;
            Medicine m = Pharmacy.Medicines.Find(x => x.Id == id);

            TradeNameTextBox.Text = m.TradeName;
            ScientificNameTextBox.Text = m.ScientificName;
            ManufacturerTextBox.Text = m.Manufacturer;
            PriceTextBox.Text = m.Price.ToString();
            QuantityTextBox.Text = m.Quantity.ToString();
            ExpiryDateTextBox.Text = m.ExpiryDate.ToShortDateString();

            EditingId = id;
            AddMedicinePanel.Visible = true;

        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            if (MedicinesDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select Medicine First");
                return;
            }
            int id = (int)MedicinesDataGridView.SelectedRows[0].Cells["Id"].Value;
            DialogResult result = MessageBox.Show("Do You Want To Delete This Medicine", "Are you Sure",
                                                   MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Pharmacy.RemoveMedicine(id);
                LoadMedicines();
            }
        }

        private void FilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMedicines();
        }
    }
}
