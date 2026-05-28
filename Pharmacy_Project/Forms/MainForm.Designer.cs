namespace Pharmacy_Project.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultLegend skDefaultLegend1 = new LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultLegend();
            LiveChartsCore.Drawing.Padding padding1 = new LiveChartsCore.Drawing.Padding();
            LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultTooltip skDefaultTooltip1 = new LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultTooltip();
            LiveChartsCore.Drawing.Padding padding2 = new LiveChartsCore.Drawing.Padding();
            panel1 = new Panel();
            MedicinesTabSelectArrow = new PictureBox();
            ExpiredTabSelectArrow = new PictureBox();
            POSTabSelectArrow = new PictureBox();
            InvoiceTabSelectArrow = new PictureBox();
            SettingsTabSelectArrow = new PictureBox();
            HomeTabSelectArrow = new PictureBox();
            btnNavSettings = new Guna.UI2.WinForms.Guna2ImageButton();
            btnNavInvoice = new Guna.UI2.WinForms.Guna2ImageButton();
            btnNavPOS = new Guna.UI2.WinForms.Guna2ImageButton();
            btnNavExpired = new Guna.UI2.WinForms.Guna2ImageButton();
            btnNavMedicines = new Guna.UI2.WinForms.Guna2ImageButton();
            btnNavHome = new Guna.UI2.WinForms.Guna2ImageButton();
            MainTabControl = new TabControl();
            TabHome = new TabPage();
            pieChart1 = new LiveChartsCore.SkiaSharpView.WinForms.PieChart();
            TabMedicines = new TabPage();
            TabExpired = new TabPage();
            TabPOS = new TabPage();
            TabInvoice = new TabPage();
            TabSettings = new TabPage();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MedicinesTabSelectArrow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ExpiredTabSelectArrow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)POSTabSelectArrow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InvoiceTabSelectArrow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SettingsTabSelectArrow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HomeTabSelectArrow).BeginInit();
            MainTabControl.SuspendLayout();
            TabHome.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(MedicinesTabSelectArrow);
            panel1.Controls.Add(ExpiredTabSelectArrow);
            panel1.Controls.Add(POSTabSelectArrow);
            panel1.Controls.Add(InvoiceTabSelectArrow);
            panel1.Controls.Add(SettingsTabSelectArrow);
            panel1.Controls.Add(HomeTabSelectArrow);
            panel1.Controls.Add(btnNavSettings);
            panel1.Controls.Add(btnNavInvoice);
            panel1.Controls.Add(btnNavPOS);
            panel1.Controls.Add(btnNavExpired);
            panel1.Controls.Add(btnNavMedicines);
            panel1.Controls.Add(btnNavHome);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(303, 944);
            panel1.TabIndex = 0;
            // 
            // MedicinesTabSelectArrow
            // 
            MedicinesTabSelectArrow.BackColor = Color.Transparent;
            MedicinesTabSelectArrow.Image = (Image)resources.GetObject("MedicinesTabSelectArrow.Image");
            MedicinesTabSelectArrow.Location = new Point(0, 145);
            MedicinesTabSelectArrow.Name = "MedicinesTabSelectArrow";
            MedicinesTabSelectArrow.Size = new Size(23, 44);
            MedicinesTabSelectArrow.SizeMode = PictureBoxSizeMode.StretchImage;
            MedicinesTabSelectArrow.TabIndex = 10;
            MedicinesTabSelectArrow.TabStop = false;
            MedicinesTabSelectArrow.Visible = false;
            // 
            // ExpiredTabSelectArrow
            // 
            ExpiredTabSelectArrow.BackColor = Color.Transparent;
            ExpiredTabSelectArrow.Image = (Image)resources.GetObject("ExpiredTabSelectArrow.Image");
            ExpiredTabSelectArrow.Location = new Point(0, 259);
            ExpiredTabSelectArrow.Name = "ExpiredTabSelectArrow";
            ExpiredTabSelectArrow.Size = new Size(23, 44);
            ExpiredTabSelectArrow.SizeMode = PictureBoxSizeMode.StretchImage;
            ExpiredTabSelectArrow.TabIndex = 9;
            ExpiredTabSelectArrow.TabStop = false;
            ExpiredTabSelectArrow.Visible = false;
            // 
            // POSTabSelectArrow
            // 
            POSTabSelectArrow.BackColor = Color.Transparent;
            POSTabSelectArrow.Image = (Image)resources.GetObject("POSTabSelectArrow.Image");
            POSTabSelectArrow.Location = new Point(0, 371);
            POSTabSelectArrow.Name = "POSTabSelectArrow";
            POSTabSelectArrow.Size = new Size(23, 44);
            POSTabSelectArrow.SizeMode = PictureBoxSizeMode.StretchImage;
            POSTabSelectArrow.TabIndex = 8;
            POSTabSelectArrow.TabStop = false;
            POSTabSelectArrow.Visible = false;
            // 
            // InvoiceTabSelectArrow
            // 
            InvoiceTabSelectArrow.BackColor = Color.Transparent;
            InvoiceTabSelectArrow.Image = (Image)resources.GetObject("InvoiceTabSelectArrow.Image");
            InvoiceTabSelectArrow.Location = new Point(0, 484);
            InvoiceTabSelectArrow.Name = "InvoiceTabSelectArrow";
            InvoiceTabSelectArrow.Size = new Size(23, 44);
            InvoiceTabSelectArrow.SizeMode = PictureBoxSizeMode.StretchImage;
            InvoiceTabSelectArrow.TabIndex = 7;
            InvoiceTabSelectArrow.TabStop = false;
            InvoiceTabSelectArrow.Visible = false;
            // 
            // SettingsTabSelectArrow
            // 
            SettingsTabSelectArrow.BackColor = Color.Transparent;
            SettingsTabSelectArrow.Image = (Image)resources.GetObject("SettingsTabSelectArrow.Image");
            SettingsTabSelectArrow.Location = new Point(0, 600);
            SettingsTabSelectArrow.Name = "SettingsTabSelectArrow";
            SettingsTabSelectArrow.Size = new Size(23, 44);
            SettingsTabSelectArrow.SizeMode = PictureBoxSizeMode.StretchImage;
            SettingsTabSelectArrow.TabIndex = 6;
            SettingsTabSelectArrow.TabStop = false;
            SettingsTabSelectArrow.Visible = false;
            // 
            // HomeTabSelectArrow
            // 
            HomeTabSelectArrow.BackColor = Color.Transparent;
            HomeTabSelectArrow.Image = (Image)resources.GetObject("HomeTabSelectArrow.Image");
            HomeTabSelectArrow.Location = new Point(0, 33);
            HomeTabSelectArrow.Name = "HomeTabSelectArrow";
            HomeTabSelectArrow.Size = new Size(23, 44);
            HomeTabSelectArrow.SizeMode = PictureBoxSizeMode.StretchImage;
            HomeTabSelectArrow.TabIndex = 0;
            HomeTabSelectArrow.TabStop = false;
            // 
            // btnNavSettings
            // 
            btnNavSettings.BackColor = Color.Transparent;
            btnNavSettings.CheckedState.ImageSize = new Size(292, 167);
            btnNavSettings.Dock = DockStyle.Top;
            btnNavSettings.HoverState.ImageSize = new Size(295, 170);
            btnNavSettings.Image = (Image)resources.GetObject("btnNavSettings.Image");
            btnNavSettings.ImageOffset = new Point(0, 0);
            btnNavSettings.ImageRotate = 0F;
            btnNavSettings.ImageSize = new Size(290, 165);
            btnNavSettings.Location = new Point(0, 565);
            btnNavSettings.Name = "btnNavSettings";
            btnNavSettings.PressedState.ImageSize = new Size(310, 185);
            btnNavSettings.ShadowDecoration.CustomizableEdges = customizableEdges1;
            btnNavSettings.Size = new Size(303, 113);
            btnNavSettings.TabIndex = 5;
            btnNavSettings.Click += btnNavSettings_Click;
            // 
            // btnNavInvoice
            // 
            btnNavInvoice.BackColor = Color.Transparent;
            btnNavInvoice.CheckedState.ImageSize = new Size(292, 167);
            btnNavInvoice.Dock = DockStyle.Top;
            btnNavInvoice.HoverState.ImageSize = new Size(295, 170);
            btnNavInvoice.Image = (Image)resources.GetObject("btnNavInvoice.Image");
            btnNavInvoice.ImageOffset = new Point(0, 0);
            btnNavInvoice.ImageRotate = 0F;
            btnNavInvoice.ImageSize = new Size(290, 165);
            btnNavInvoice.Location = new Point(0, 452);
            btnNavInvoice.Name = "btnNavInvoice";
            btnNavInvoice.PressedState.ImageSize = new Size(310, 185);
            btnNavInvoice.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnNavInvoice.Size = new Size(303, 113);
            btnNavInvoice.TabIndex = 4;
            btnNavInvoice.Click += btnNavInvoice_Click;
            // 
            // btnNavPOS
            // 
            btnNavPOS.BackColor = Color.Transparent;
            btnNavPOS.CheckedState.ImageSize = new Size(292, 167);
            btnNavPOS.Dock = DockStyle.Top;
            btnNavPOS.HoverState.ImageSize = new Size(295, 170);
            btnNavPOS.Image = (Image)resources.GetObject("btnNavPOS.Image");
            btnNavPOS.ImageOffset = new Point(0, 0);
            btnNavPOS.ImageRotate = 0F;
            btnNavPOS.ImageSize = new Size(290, 165);
            btnNavPOS.Location = new Point(0, 339);
            btnNavPOS.Name = "btnNavPOS";
            btnNavPOS.PressedState.ImageSize = new Size(310, 185);
            btnNavPOS.ShadowDecoration.CustomizableEdges = customizableEdges3;
            btnNavPOS.Size = new Size(303, 113);
            btnNavPOS.TabIndex = 3;
            btnNavPOS.Click += btnNavPOS_Click;
            // 
            // btnNavExpired
            // 
            btnNavExpired.BackColor = Color.Transparent;
            btnNavExpired.CheckedState.ImageSize = new Size(292, 167);
            btnNavExpired.Dock = DockStyle.Top;
            btnNavExpired.HoverState.ImageSize = new Size(295, 170);
            btnNavExpired.Image = (Image)resources.GetObject("btnNavExpired.Image");
            btnNavExpired.ImageOffset = new Point(0, 0);
            btnNavExpired.ImageRotate = 0F;
            btnNavExpired.ImageSize = new Size(290, 165);
            btnNavExpired.Location = new Point(0, 226);
            btnNavExpired.Name = "btnNavExpired";
            btnNavExpired.PressedState.ImageSize = new Size(310, 185);
            btnNavExpired.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnNavExpired.Size = new Size(303, 113);
            btnNavExpired.TabIndex = 2;
            btnNavExpired.Click += btnNavExpired_Click;
            // 
            // btnNavMedicines
            // 
            btnNavMedicines.BackColor = Color.Transparent;
            btnNavMedicines.CheckedState.ImageSize = new Size(292, 167);
            btnNavMedicines.Dock = DockStyle.Top;
            btnNavMedicines.HoverState.ImageSize = new Size(295, 170);
            btnNavMedicines.Image = (Image)resources.GetObject("btnNavMedicines.Image");
            btnNavMedicines.ImageOffset = new Point(0, 0);
            btnNavMedicines.ImageRotate = 0F;
            btnNavMedicines.ImageSize = new Size(290, 165);
            btnNavMedicines.Location = new Point(0, 113);
            btnNavMedicines.Name = "btnNavMedicines";
            btnNavMedicines.PressedState.ImageSize = new Size(310, 185);
            btnNavMedicines.ShadowDecoration.CustomizableEdges = customizableEdges5;
            btnNavMedicines.Size = new Size(303, 113);
            btnNavMedicines.TabIndex = 1;
            btnNavMedicines.Click += btnNavMedicines_Click;
            // 
            // btnNavHome
            // 
            btnNavHome.BackColor = Color.Transparent;
            btnNavHome.CheckedState.ImageSize = new Size(292, 167);
            btnNavHome.Dock = DockStyle.Top;
            btnNavHome.HoverState.ImageSize = new Size(295, 170);
            btnNavHome.Image = (Image)resources.GetObject("btnNavHome.Image");
            btnNavHome.ImageOffset = new Point(0, 0);
            btnNavHome.ImageRotate = 0F;
            btnNavHome.ImageSize = new Size(290, 165);
            btnNavHome.Location = new Point(0, 0);
            btnNavHome.Name = "btnNavHome";
            btnNavHome.PressedState.ImageSize = new Size(310, 185);
            btnNavHome.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnNavHome.Size = new Size(303, 113);
            btnNavHome.TabIndex = 0;
            btnNavHome.Click += btnNavHome_Click;
            // 
            // MainTabControl
            // 
            MainTabControl.Appearance = TabAppearance.Buttons;
            MainTabControl.Controls.Add(TabHome);
            MainTabControl.Controls.Add(TabMedicines);
            MainTabControl.Controls.Add(TabExpired);
            MainTabControl.Controls.Add(TabPOS);
            MainTabControl.Controls.Add(TabInvoice);
            MainTabControl.Controls.Add(TabSettings);
            MainTabControl.Dock = DockStyle.Fill;
            MainTabControl.ItemSize = new Size(0, 1);
            MainTabControl.Location = new Point(0, 0);
            MainTabControl.Name = "MainTabControl";
            MainTabControl.Padding = new Point(0, 0);
            MainTabControl.SelectedIndex = 0;
            MainTabControl.Size = new Size(1478, 944);
            MainTabControl.SizeMode = TabSizeMode.Fixed;
            MainTabControl.TabIndex = 1;
            // 
            // TabHome
            // 
            TabHome.BackColor = Color.FromArgb(205, 220, 248);
            TabHome.BackgroundImageLayout = ImageLayout.None;
            TabHome.Controls.Add(pieChart1);
            TabHome.Location = new Point(4, 5);
            TabHome.Name = "TabHome";
            TabHome.Size = new Size(1470, 935);
            TabHome.TabIndex = 5;
            TabHome.Text = "Home";
            // 
            // pieChart1
            // 
            pieChart1.AutoUpdateEnabled = true;
            pieChart1.ChartTheme = null;
            skDefaultLegend1.AnimationsSpeed = TimeSpan.Parse("00:00:00.1500000");
            skDefaultLegend1.Content = null;
            skDefaultLegend1.IsValid = false;
            skDefaultLegend1.Opacity = 1F;
            padding1.Bottom = 0F;
            padding1.Left = 0F;
            padding1.Right = 0F;
            padding1.Top = 0F;
            skDefaultLegend1.Padding = padding1;
            skDefaultLegend1.RemoveOnCompleted = false;
            skDefaultLegend1.RotateTransform = 0F;
            skDefaultLegend1.X = 0F;
            skDefaultLegend1.Y = 0F;
            pieChart1.Legend = skDefaultLegend1;
            pieChart1.Location = new Point(665, 149);
            pieChart1.Name = "pieChart1";
            pieChart1.Size = new Size(180, 162);
            pieChart1.TabIndex = 0;
            skDefaultTooltip1.AnimationsSpeed = TimeSpan.Parse("00:00:00.1500000");
            skDefaultTooltip1.Content = null;
            skDefaultTooltip1.IsValid = false;
            skDefaultTooltip1.Opacity = 1F;
            padding2.Bottom = 0F;
            padding2.Left = 0F;
            padding2.Right = 0F;
            padding2.Top = 0F;
            skDefaultTooltip1.Padding = padding2;
            skDefaultTooltip1.RemoveOnCompleted = false;
            skDefaultTooltip1.RotateTransform = 0F;
            skDefaultTooltip1.Wedge = 10;
            skDefaultTooltip1.X = 0F;
            skDefaultTooltip1.Y = 0F;
            pieChart1.Tooltip = skDefaultTooltip1;
            pieChart1.UpdaterThrottler = TimeSpan.Parse("00:00:00.0500000");
            // 
            // TabMedicines
            // 
            TabMedicines.BackColor = Color.FromArgb(205, 220, 248);
            TabMedicines.Location = new Point(4, 5);
            TabMedicines.Name = "TabMedicines";
            TabMedicines.Padding = new Padding(3);
            TabMedicines.Size = new Size(1470, 935);
            TabMedicines.TabIndex = 0;
            TabMedicines.Text = "Medicines";
            // 
            // TabExpired
            // 
            TabExpired.BackColor = Color.FromArgb(205, 220, 248);
            TabExpired.Location = new Point(4, 5);
            TabExpired.Name = "TabExpired";
            TabExpired.Padding = new Padding(3);
            TabExpired.Size = new Size(1470, 935);
            TabExpired.TabIndex = 1;
            TabExpired.Text = "Expired";
            // 
            // TabPOS
            // 
            TabPOS.BackColor = Color.FromArgb(205, 220, 248);
            TabPOS.Location = new Point(4, 5);
            TabPOS.Name = "TabPOS";
            TabPOS.Padding = new Padding(3);
            TabPOS.Size = new Size(1470, 935);
            TabPOS.TabIndex = 2;
            TabPOS.Text = "POS";
            // 
            // TabInvoice
            // 
            TabInvoice.BackColor = Color.FromArgb(205, 220, 248);
            TabInvoice.Location = new Point(4, 5);
            TabInvoice.Name = "TabInvoice";
            TabInvoice.Padding = new Padding(3);
            TabInvoice.Size = new Size(1470, 935);
            TabInvoice.TabIndex = 3;
            TabInvoice.Text = "Invoice";
            // 
            // TabSettings
            // 
            TabSettings.BackColor = Color.FromArgb(205, 220, 248);
            TabSettings.Location = new Point(4, 5);
            TabSettings.Name = "TabSettings";
            TabSettings.Padding = new Padding(3);
            TabSettings.Size = new Size(1470, 935);
            TabSettings.TabIndex = 4;
            TabSettings.Text = "Settings";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1478, 944);
            Controls.Add(panel1);
            Controls.Add(MainTabControl);
            Name = "MainForm";
            Text = "MainForm";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MedicinesTabSelectArrow).EndInit();
            ((System.ComponentModel.ISupportInitialize)ExpiredTabSelectArrow).EndInit();
            ((System.ComponentModel.ISupportInitialize)POSTabSelectArrow).EndInit();
            ((System.ComponentModel.ISupportInitialize)InvoiceTabSelectArrow).EndInit();
            ((System.ComponentModel.ISupportInitialize)SettingsTabSelectArrow).EndInit();
            ((System.ComponentModel.ISupportInitialize)HomeTabSelectArrow).EndInit();
            MainTabControl.ResumeLayout(false);
            TabHome.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TabControl MainTabControl;
        private TabPage TabMedicines;
        private TabPage TabExpired;
        private TabPage TabPOS;
        private TabPage TabInvoice;
        private TabPage TabSettings;
        private Guna.UI2.WinForms.Guna2ImageButton btnNavHome;
        private Guna.UI2.WinForms.Guna2ImageButton btnNavInvoice;
        private Guna.UI2.WinForms.Guna2ImageButton btnNavPOS;
        private Guna.UI2.WinForms.Guna2ImageButton btnNavExpired;
        private Guna.UI2.WinForms.Guna2ImageButton btnNavMedicines;
        private TabPage TabHome;
        private Guna.UI2.WinForms.Guna2ImageButton btnNavSettings;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private PictureBox HomeTabSelectArrow;
        private PictureBox MedicinesTabSelectArrow;
        private PictureBox ExpiredTabSelectArrow;
        private PictureBox POSTabSelectArrow;
        private PictureBox InvoiceTabSelectArrow;
        private PictureBox SettingsTabSelectArrow;
        private LiveChartsCore.SkiaSharpView.WinForms.PieChart pieChart1;
    }
}