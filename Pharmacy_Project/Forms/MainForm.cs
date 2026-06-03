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



        /// <summary>
        //!? Medicine Tab
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

            var list = Pharmacy.FilterBy(type);

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

        private void SaveMedbtn_Click(object sender, EventArgs e)
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
            Medicine m = null;
            foreach (Medicine med in Pharmacy.Medicines)
            {
                if (med.Id == id)
                    m = med;
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
            DialogResult result = MessageBox.Show("Do You Want To Delete This Medicine", "Are you Sure",
                                                   MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
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

        List<InvoiveItem> cart = new List<InvoiveItem>();
        private void UpdateCartTotal()
        {
            double total = 0;
            foreach (InvoiveItem item in cart)
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
                if (!m.IsExpired())
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
                    QuantityNumeric.Maximum = m.Quantity;
                    QuantityNumeric.Minimum = 1;
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
                }
            }
            int quantity = (int)QuantityNumeric.Value;
            if (quantity > selectedMedicine.Quantity)
            {
                MessageBox.Show("Quantity exceeds available Stock!");
                return;
            }

            InvoiveItem item = new InvoiveItem();
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
        private void POSBuybtn_Click(object sender, EventArgs e)
        {

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

            LabelWelcome.Text = $"Welcome Back, {Pharmacy.User.Username}";
        }

    }
}
