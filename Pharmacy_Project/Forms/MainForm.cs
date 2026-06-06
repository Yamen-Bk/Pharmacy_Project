using Guna.UI2.WinForms.Suite;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using Newtonsoft.Json;
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
        //!? MainForm
        /// </summary>

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadHomeData();
            LoadMedicines();
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
            LoadHomeData();
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
            LoadExpired();
            ExpiredTabSelectArrow.Visible = true;
        }

        private void btnNavPOS_Click(object sender, EventArgs e)
        {
            HideAllArrows();
            MainTabControl.SelectedTab = TabPOS;
            LoadPOSMedicines();
            POSTabSelectArrow.Visible = true;
        }

        private void btnNavInvoice_Click(object sender, EventArgs e)
        {
            HideAllArrows();
            MainTabControl.SelectedTab = TabInvoice;
            LoadInvoices();
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
        //!? Home Tab
        /// </summary>
        private void LoadHomeData()
        {
            HomWelcomeLabel.Text = $"Welcome Back, {Pharmacy.User.Username}";

            int soldCount = 0;
            double totalSales = 0;

            foreach (Invoice inv in Pharmacy.Invoices)
            {
                totalSales += inv.TotalPrice;
                foreach (InvoiceItem item in inv.Items)
                    soldCount += item.Quantity;
            }

            HomSoldCountLabel.Text = soldCount.ToString();
            HomTotalSalesLabel.Text = totalSales.ToString("F2");

            List<Medicine> sorted = new List<Medicine>(Pharmacy.Medicines);
            for (int i = 0; i < sorted.Count - 1; i++)
            {
                for (int j = 0; j < sorted.Count - 1 - i; j++)
                {
                    if (sorted[j].Quantity < sorted[j + 1].Quantity)
                    {
                        Medicine temp = sorted[j];
                        sorted[j] = sorted[j + 1];
                        sorted[j + 1] = temp;
                    }
                }
            }

            int take = sorted.Count >= 5 ? 5 : sorted.Count;
            double[] barValues = new double[take];
            string[] barLabels = new string[take];

            for (int i = 0; i < take; i++)
            {
                barValues[i] = sorted[i].Quantity;
                barLabels[i] = sorted[i].TradeName;
            }

            cartesianChart1.Series = new ISeries[]
            {
        new ColumnSeries<double>
        {
            Values = barValues,
            Name = "Stock",
            Rx = 8,
            Ry = 8,
            Fill = new SolidColorPaint(SKColor.Parse("#4CAF50"))
        }
            };
            cartesianChart1.XAxes = new Axis[]
            {
        new Axis { Labels = barLabels }
            };

            int total = Pharmacy.Medicines.Count;
            int expired = 0;
            int lowStock = 0;

            foreach (Medicine m in Pharmacy.Medicines)
            {
                if (m.IsExpired()) expired++;
                if (m.IsLowStock()) lowStock++;
            }

            pieChart1.Series = new ISeries[]
            {
        new PieSeries<double>
        {
            Values = new double[] { total },
            Name = "Total",
            InnerRadius = 60,
            MaxRadialColumnWidth = 40,
            Fill = new SolidColorPaint(SKColor.Parse("#2196F3"))
        },
        new PieSeries<double>
        {
            Values = new double[] { lowStock },
            Name = "LowStock",
            InnerRadius = 60,
            MaxRadialColumnWidth = 40,
            Fill = new SolidColorPaint(SKColor.Parse("#FF9800"))
        },
        new PieSeries<double>
        {
            Values = new double[] { expired },
            Name = "Expired",
            InnerRadius = 60,
            MaxRadialColumnWidth = 40,
            Fill = new SolidColorPaint(SKColor.Parse("#F44336"))
        }
            };
        }

        /// <summary>
        //!? Medicine Tab
        /// </summary>

        private void ShowFilterControls(string type)
        {
            MinPricelbl.Visible = false;
            MaxPriceNumeric.Visible = false;
            ApplyPriceFilterBtn.Visible = false;
            ManufacturerFilterComboBox.Visible = false;
            StatusFilterComboBox.Visible = false;
            MaxPricelbl.Visible = false;
            MinPricelbl.Visible = false;
            StatusFilterlibl.Visible = false;
            ManufacturerFilterlbl.Visible = false;

            if (type == "Price")
            {
                MaxPricelbl.Visible = true;
                MinPricelbl.Visible = true;
                MinPricelbl.Visible = true;
                MaxPriceNumeric.Visible = true;
                MinPriceNumeric.Visible = true;
                ApplyPriceFilterBtn.Visible = true;
            }
            else if (type == "Manufacturer")
            {
                ManufacturerFilterComboBox.Items.Clear();
                ManufacturerFilterComboBox.Items.Add("All");
                foreach (Medicine m in Pharmacy.Medicines)
                {
                    bool found = false;
                    foreach (string item in ManufacturerFilterComboBox.Items)
                    {
                        if (item == m.Manufacturer) { found = true; break; }
                    }
                    if (!found)
                        ManufacturerFilterComboBox.Items.Add(m.Manufacturer);
                }
                ManufacturerFilterComboBox.SelectedIndex = 0;
                ManufacturerFilterlbl.Visible = true;
                ManufacturerFilterComboBox.Visible = true;
            }
            else if (type == "Status")
            {
                StatusFilterlibl.Visible = true;
                StatusFilterComboBox.Visible = true;
            }
        }
        private void FillMedicineRow(int i, Medicine m)
        {
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
                MedicinesDataGridView.Rows[i].DefaultCellStyle.SelectionBackColor = Color.FromArgb(220, 100, 100);
            }
            else if (m.IsExpiringSoon())
            {
                MedicinesDataGridView.Rows[i].Cells["status"].Value = "ExpiringSoon";
                MedicinesDataGridView.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(255, 240, 180);
                MedicinesDataGridView.Rows[i].DefaultCellStyle.SelectionBackColor = Color.FromArgb(220, 180, 80);
            }
            else if (m.IsLowStock())
            {
                MedicinesDataGridView.Rows[i].Cells["status"].Value = "LowStock";
                MedicinesDataGridView.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(255, 220, 150);
                MedicinesDataGridView.Rows[i].DefaultCellStyle.SelectionBackColor = Color.FromArgb(220, 160, 60);
            }
            else
            {
                MedicinesDataGridView.Rows[i].Cells["status"].Value = "Good";
                MedicinesDataGridView.Rows[i].DefaultCellStyle.SelectionBackColor = Color.FromArgb(180, 220, 255);
            }
        }
        private void LoadMedicines()
        {
            MedicinesDataGridView.Rows.Clear();
            foreach (Medicine m in Pharmacy.Medicines)
            {
                int i = MedicinesDataGridView.Rows.Add();
                FillMedicineRow(i, m);
            }
        }
        private void ClearFields()
        {
            TradeNameTextBox.Text = "";
            ScientificNameTextBox.Text = "";
            ManufacturerTextBox.Text = "";
            PriceTextBox.Text = "";
            QuantityTextBox.Text = "";
            ExpiryDateTextBox.Text = "";
        }
        private void AddMedicinebtn_Click(object sender, EventArgs e)
        {
            ClearFields();
            AddMedicinePanel.Visible = true;
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            ClearFields();
            EditingId = -1;
            AddMedicinePanel.Visible = false;
        }
        private void SaveMedbtn_Click(object sender, EventArgs e)
        {
            if (TradeNameTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Trade Name cannot be empty.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (ScientificNameTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Scientific Name cannot be empty.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (ManufacturerTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Manufacturer cannot be empty.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (PriceTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Price cannot be empty.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (QuantityTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Quantity cannot be empty.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (ExpiryDateTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Expiry Date cannot be empty.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            double price;
            if (!double.TryParse(PriceTextBox.Text, out price) || price < 0)
            {
                MessageBox.Show("Price must be a valid positive number.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int quantity;
            if (!int.TryParse(QuantityTextBox.Text, out quantity) || quantity < 0)
            {
                MessageBox.Show("Quantity must be a valid positive number.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DateTime expiryDate;
            if (!DateTime.TryParse(ExpiryDateTextBox.Text, out expiryDate))
            {
                MessageBox.Show("Expiry Date format is invalid.\nPlease enter date as: DD/MM/YYYY\nExample: 25/12/2027",
                                "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (expiryDate < DateTime.Today)
            {
                MessageBox.Show("Expiry Date cannot be in the past.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Medicine m = new Medicine
            {
                TradeName = TradeNameTextBox.Text.Trim(),
                ScientificName = ScientificNameTextBox.Text.Trim(),
                Manufacturer = ManufacturerTextBox.Text.Trim(),
                Price = price,
                Quantity = quantity,
                ExpiryDate = expiryDate
            };

            if (EditingId == -1)
                Pharmacy.AddMedicine(m);
            else
            {
                m.Id = EditingId;
                Pharmacy.UpdateMedicine(m);
            }

            EditingId = -1;
            AddMedicinePanel.Visible = false;
            ClearFields();
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
            Medicine m = null;
            foreach (Medicine med in Pharmacy.Medicines)
            {
                if (med.Id == id) { m = med; break; }
            }

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
            DialogResult result = MessageBox.Show("Do You Want To Delete This Medicine?", "Are you Sure",
                                                   MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Pharmacy.RemoveMedicine(id);
                LoadMedicines();
            }
        }
        private void ApplyPriceFilterBtn_Click(object sender, EventArgs e)
        {
            double min = (double)MinPriceNumeric.Value;
            double max = (double)MaxPriceNumeric.Value;

            if (min > max)
            {
                MessageBox.Show("Min price cannot be greater than Max price.");
                return;
            }

            MedicinesDataGridView.Rows.Clear();
            foreach (Medicine m in Pharmacy.Medicines)
            {
                if (m.Price >= min && m.Price <= max)
                {
                    int i = MedicinesDataGridView.Rows.Add();
                    FillMedicineRow(i, m);
                }
            }
        }
        private void FilterTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FilterTypeComboBox.SelectedIndex == 0) ShowFilterControls("");
            else if (FilterTypeComboBox.SelectedIndex == 1) ShowFilterControls("Price");
            else if (FilterTypeComboBox.SelectedIndex == 2) ShowFilterControls("Manufacturer");
            else if (FilterTypeComboBox.SelectedIndex == 3) ShowFilterControls("Status");

            if (FilterTypeComboBox.SelectedIndex == 0)
                LoadMedicines();
        }
        private void ManufacturerFilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ManufacturerFilterComboBox.SelectedIndex == -1) return;

            string selected = ManufacturerFilterComboBox.SelectedItem.ToString();

            MedicinesDataGridView.Rows.Clear();
            foreach (Medicine m in Pharmacy.Medicines)
            {
                if (selected == "All" || m.Manufacturer == selected)
                {
                    int i = MedicinesDataGridView.Rows.Add();
                    FillMedicineRow(i, m);
                }
            }
        }
        private void StatusFilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StatusFilterComboBox.SelectedIndex == -1) return;

            string selected = StatusFilterComboBox.SelectedItem.ToString();

            MedicinesDataGridView.Rows.Clear();
            foreach (Medicine m in Pharmacy.Medicines)
            {
                bool show = false;
                if (selected == "All") show = true;
                else if (selected == "Expired" && m.IsExpired()) show = true;
                else if (selected == "ExpiringSoon" && m.IsExpiringSoon()) show = true;
                else if (selected == "LowStock" && m.IsLowStock()) show = true;
                else if (selected == "Good" && !m.IsExpired() && !m.IsExpiringSoon() && !m.IsLowStock()) show = true;
                if (show)
                {
                    int i = MedicinesDataGridView.Rows.Add();
                    FillMedicineRow(i, m);
                }
            }
        }

        /// <summary>
        //!? Expired Tab
        /// </summary>

        private void LoadExpired()
        {
            var list = Pharmacy.GetExpiredMedicines();

            ExpiredDataGridView.Rows.Clear();

            foreach (Medicine m in list)
            {
                int i = ExpiredDataGridView.Rows.Add();
                ExpiredDataGridView.Rows[i].Cells["ExpId"].Value = m.Id;
                ExpiredDataGridView.Rows[i].Cells["ExpTradeName"].Value = m.TradeName;
                ExpiredDataGridView.Rows[i].Cells["ExpScientificName"].Value = m.ScientificName;
                ExpiredDataGridView.Rows[i].Cells["ExpManufacturer"].Value = m.Manufacturer;
                ExpiredDataGridView.Rows[i].Cells["ExpPrice"].Value = m.Price;
                ExpiredDataGridView.Rows[i].Cells["ExpQuantity"].Value = m.Quantity;
                ExpiredDataGridView.Rows[i].Cells["ExpExpiryDate"].Value = m.ExpiryDate.ToShortDateString();

                ExpiredDataGridView.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(255, 200, 200);
                ExpiredDataGridView.Rows[i].DefaultCellStyle.SelectionBackColor = Color.FromArgb(220, 100, 100);
            }
        }

        private void DisposeSelectedbtn_Click(object sender, EventArgs e)
        {
            if (ExpiredDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select Medicine First");
                return;
            }
            int id = (int)ExpiredDataGridView.SelectedRows[0].Cells["ExpId"].Value;
            DialogResult result = MessageBox.Show("Do You Want To Delete This Medicine", "Are you Sure",
                                                   MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Pharmacy.RemoveMedicine(id);
                LoadExpired();
                LoadMedicines();
            }
        }

        private void DisposeAllbtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Want To Delete All Expired Medicines ?", "Are You Sure",
                                                   MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Pharmacy.RemoveAllExpired();
                LoadExpired();
                LoadMedicines();
            }
        }

        /// <summary>
        //!? POS Tab
        /// </summary>

        List<InvoiceItem> cart = new List<InvoiceItem>();
        int editingCartIndex = -1;
        private void UpdateCartTotal()
        {
            double total = 0;
            foreach (InvoiceItem item in cart)
            {
                total += item.SubTotal;
            }
            POSTotalPriceLabel.Text = total.ToString();
        }
        private void LoadPOSMedicines()
        {
            POSNameComboBox.Items.Clear();
            foreach (Medicine m in Pharmacy.Medicines)
            {
                if (!m.IsExpired() && m.Quantity > 0)
                    POSNameComboBox.Items.Add(m.TradeName);
            }
        }
        private void POSNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (POSNameComboBox.SelectedIndex == -1) return;

            string selectedName = POSNameComboBox.SelectedItem.ToString();

            foreach (Medicine m in Pharmacy.Medicines)
            {
                if (m.TradeName == selectedName)
                {
                    POSAvailableLabel.Text = m.Quantity.ToString();
                    POSPriceLabel.Text = m.Price.ToString();
                    QuantityNumeric.Minimum = 1;
                    QuantityNumeric.Maximum = m.Quantity;
                    QuantityNumeric.Value = 1;
                    break;
                }
            }
        }
        private void POSClearAllbtn_Click(object sender, EventArgs e)
        {
            cart.Clear();
            POSDataGridView.Rows.Clear();
            POSTotalPriceLabel.Text = "0";
        }

        private void POSClearbtn_Click(object sender, EventArgs e)
        {
            if (POSDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select Medicine First");
                return;
            }
            int index = POSDataGridView.SelectedRows[0].Index;
            cart.RemoveAt(index);
            POSDataGridView.Rows.RemoveAt(index);
            UpdateCartTotal();
        }


        private void POSAddbtn_Click(object sender, EventArgs e)
        {
            if (POSNameComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Select Medicine First");
                return;
            }

            string selectedName = POSNameComboBox.SelectedItem.ToString();
            Medicine selectedMedicine = null;
            foreach (Medicine m in Pharmacy.Medicines)
            {
                if (m.TradeName == selectedName)
                {
                    selectedMedicine = m;
                    break;
                }
            }

            foreach (InvoiceItem existing in cart)
            {
                if (existing.Medicine.Id == selectedMedicine.Id)
                {
                    MessageBox.Show("This Medicine is Already in the cart \n Use Edit To Change its Quantity");
                    return;
                }
            }

            int quantity = (int)QuantityNumeric.Value;
            if (quantity > selectedMedicine.Quantity)
            {
                MessageBox.Show("Quantity exceeds available Stock!");
                return;
            }

            InvoiceItem item = new InvoiceItem();
            item.Medicine = selectedMedicine;
            item.Quantity = quantity;
            item.UnitPrice = selectedMedicine.Price;
            cart.Add(item);

            int i = POSDataGridView.Rows.Add();
            POSDataGridView.Rows[i].Cells["POSTradeName"].Value = selectedMedicine.TradeName;
            POSDataGridView.Rows[i].Cells["POSPrice"].Value = selectedMedicine.Price;
            POSDataGridView.Rows[i].Cells["POSQuantity"].Value = quantity;
            POSDataGridView.Rows[i].Cells["POSSubtotal"].Value = item.SubTotal;
            UpdateCartTotal();
        }
        private void POSEditbtn_Click(object sender, EventArgs e)
        {
            POSSelectMedicineLabel.Visible = false;
            POSNewSaleLabel.Text = "Edit Sale";
            if (POSDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a medicine from the cart first.");
                return;
            }

            editingCartIndex = POSDataGridView.SelectedRows[0].Index;
            InvoiceItem item = cart[editingCartIndex];

            POSNameComboBox.SelectedItem = item.Medicine.TradeName;
            QuantityNumeric.Value = item.Quantity;

            POSAddbtn.Visible = false;
            POSSavebtn.Visible = true;
        }

        private void POSBuybtn_Click(object sender, EventArgs e)
        {
            if (cart.Count == 0)
            {
                MessageBox.Show("Cart is empty! Add medicines first.", "Empty Cart",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show($"Complete purchase?\nTotal: {POSTotalPriceLabel.Text}",
                                            "Confirm Sale", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            Pharmacy.ProcessSale(cart);

            cart.Clear();
            POSDataGridView.Rows.Clear();
            POSTotalPriceLabel.Text = "0";
            POSNameComboBox.SelectedIndex = -1;
            POSAvailableLabel.Text = "0";
            POSPriceLabel.Text = "0";
            QuantityNumeric.Value = 1;

            LoadPOSMedicines();

            MessageBox.Show("Sale completed successfully!\nInvoice has been saved.",
                            "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void POSSavebtn_Click(object sender, EventArgs e)
        {
            int newQuantity = (int)QuantityNumeric.Value;
            InvoiceItem item = cart[editingCartIndex];

            if (newQuantity > item.Medicine.Quantity)
            {
                MessageBox.Show("Quantity exceeds available stock!");
                return;
            }

            item.Quantity = newQuantity;

            POSDataGridView.Rows[editingCartIndex].Cells["POSQuantity"].Value = newQuantity;
            POSDataGridView.Rows[editingCartIndex].Cells["POSSubtotal"].Value = item.SubTotal;

            UpdateCartTotal();

            editingCartIndex = -1;
            POSSavebtn.Visible = false;
            POSAddbtn.Visible = true;
            POSSelectMedicineLabel.Visible = true;
            POSNewSaleLabel.Text = "New Sale";

            POSNameComboBox.SelectedIndex = -1;
            QuantityNumeric.Value = 1;
        }

        /// <summary>
        //!? Invoice Tab
        /// </summary>
        private void LoadInvoices()
        {
            InvoicesDataGridView.Rows.Clear();

            foreach (Invoice inv in Pharmacy.Invoices)
            {
                int i = InvoicesDataGridView.Rows.Add();
                InvoicesDataGridView.Rows[i].Cells["InvoiceId"].Value = inv.Id;
                InvoicesDataGridView.Rows[i].Cells["InvoiceDate"].Value = inv.Date.ToString("yyyy-MM-dd HH:mm");
                InvoicesDataGridView.Rows[i].Cells["InvoiceTotal"].Value = inv.TotalPrice.ToString("F2");
            }

            InvoiceItemsDataGridView.Rows.Clear();
        }

        private void InvoicesDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (InvoicesDataGridView.SelectedRows.Count == 0) return;

            int invId = (int)InvoicesDataGridView.SelectedRows[0].Cells["InvoiceId"].Value;

            Invoice selected = null;
            foreach (Invoice inv in Pharmacy.Invoices)
            {
                if (inv.Id == invId)
                {
                    selected = inv;
                    break;
                }
            }

            if (selected == null) return;

            InvoiceItemsDataGridView.Rows.Clear();
            foreach (InvoiceItem item in selected.Items)
            {
                int i = InvoiceItemsDataGridView.Rows.Add();
                InvoiceItemsDataGridView.Rows[i].Cells["ItemTradeName"].Value = item.Medicine.TradeName;
                InvoiceItemsDataGridView.Rows[i].Cells["ItemUnitPrice"].Value = item.UnitPrice.ToString("F2");
                InvoiceItemsDataGridView.Rows[i].Cells["ItemQuantity"].Value = item.Quantity;
                InvoiceItemsDataGridView.Rows[i].Cells["ItemSubtotal"].Value = item.SubTotal.ToString("F2");
            }
        }


        /// <summary>
        //!? Settings Tab
        /// </summary>

        private void SaveSettingsbtn_Click(object sender, EventArgs e)
        {
            if (OldPasswordTextBox.Text == "" || NewPasswordTextBox.Text == "" || ConfirmPasswordTextBox.Text == "")
            {
                MessageBox.Show("Please fill all password fields", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!BCrypt.Net.BCrypt.Verify(OldPasswordTextBox.Text, Pharmacy.User.Password))
            {
                MessageBox.Show("Current password is incorrect", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (NewPasswordTextBox.Text != ConfirmPasswordTextBox.Text)
            {
                MessageBox.Show("Passwords do not match", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (NewUsernameTextBox.Text.Trim() != "")
                Pharmacy.User.Username = NewUsernameTextBox.Text.Trim();

            Pharmacy.User.Password = BCrypt.Net.BCrypt.HashPassword(NewPasswordTextBox.Text);

            File.WriteAllText("user.json", JsonConvert.SerializeObject(Pharmacy.User, Formatting.Indented));


            MessageBox.Show("Settings saved successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            NewUsernameTextBox.Text = "";
            OldPasswordTextBox.Text = "";
            NewPasswordTextBox.Text = "";
            ConfirmPasswordTextBox.Text = "";

            HomWelcomeLabel.Text = $"Welcome Back, {Pharmacy.User.Username}";
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout",
                                                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (result != DialogResult.Yes) return;

            Pharmacy.SaveData();
            Application.Restart();
        }

    }
}
