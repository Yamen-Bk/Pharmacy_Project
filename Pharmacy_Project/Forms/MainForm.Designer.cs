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
            panel1 = new Panel();
            btnNavSettings = new Guna.UI2.WinForms.Guna2ImageButton();
            btnNavInvoice = new Guna.UI2.WinForms.Guna2ImageButton();
            btnNavPOS = new Guna.UI2.WinForms.Guna2ImageButton();
            btnNavExpired = new Guna.UI2.WinForms.Guna2ImageButton();
            btnNavMedicines = new Guna.UI2.WinForms.Guna2ImageButton();
            btnNavHome = new Guna.UI2.WinForms.Guna2ImageButton();
            MainTabControl = new TabControl();
            TabHome = new TabPage();
            TabMedicines = new TabPage();
            TabExpired = new TabPage();
            TabPOS = new TabPage();
            TabInvoice = new TabPage();
            TabSettings = new TabPage();
            panel1.SuspendLayout();
            MainTabControl.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(btnNavSettings);
            panel1.Controls.Add(btnNavInvoice);
            panel1.Controls.Add(btnNavPOS);
            panel1.Controls.Add(btnNavExpired);
            panel1.Controls.Add(btnNavMedicines);
            panel1.Controls.Add(btnNavHome);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(295, 944);
            panel1.TabIndex = 0;
            // 
            // btnNavSettings
            // 
            btnNavSettings.BackColor = Color.Transparent;
            btnNavSettings.CheckedState.ImageSize = new Size(310, 185);
            btnNavSettings.Dock = DockStyle.Top;
            btnNavSettings.HoverState.ImageSize = new Size(305, 180);
            btnNavSettings.Image = (Image)resources.GetObject("btnNavSettings.Image");
            btnNavSettings.ImageOffset = new Point(0, 0);
            btnNavSettings.ImageRotate = 0F;
            btnNavSettings.ImageSize = new Size(300, 175);
            btnNavSettings.Location = new Point(0, 565);
            btnNavSettings.Name = "btnNavSettings";
            btnNavSettings.PressedState.ImageSize = new Size(310, 185);
            btnNavSettings.ShadowDecoration.CustomizableEdges = customizableEdges1;
            btnNavSettings.Size = new Size(295, 113);
            btnNavSettings.TabIndex = 5;
            btnNavSettings.Click += btnNavSettings_Click;
            // 
            // btnNavInvoice
            // 
            btnNavInvoice.BackColor = Color.Transparent;
            btnNavInvoice.CheckedState.ImageSize = new Size(310, 185);
            btnNavInvoice.Dock = DockStyle.Top;
            btnNavInvoice.HoverState.ImageSize = new Size(305, 180);
            btnNavInvoice.Image = (Image)resources.GetObject("btnNavInvoice.Image");
            btnNavInvoice.ImageOffset = new Point(0, 0);
            btnNavInvoice.ImageRotate = 0F;
            btnNavInvoice.ImageSize = new Size(300, 175);
            btnNavInvoice.Location = new Point(0, 452);
            btnNavInvoice.Name = "btnNavInvoice";
            btnNavInvoice.PressedState.ImageSize = new Size(310, 185);
            btnNavInvoice.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnNavInvoice.Size = new Size(295, 113);
            btnNavInvoice.TabIndex = 4;
            btnNavInvoice.Click += btnNavInvoice_Click;
            // 
            // btnNavPOS
            // 
            btnNavPOS.BackColor = Color.Transparent;
            btnNavPOS.CheckedState.ImageSize = new Size(310, 185);
            btnNavPOS.Dock = DockStyle.Top;
            btnNavPOS.HoverState.ImageSize = new Size(305, 180);
            btnNavPOS.Image = (Image)resources.GetObject("btnNavPOS.Image");
            btnNavPOS.ImageOffset = new Point(0, 0);
            btnNavPOS.ImageRotate = 0F;
            btnNavPOS.ImageSize = new Size(300, 175);
            btnNavPOS.Location = new Point(0, 339);
            btnNavPOS.Name = "btnNavPOS";
            btnNavPOS.PressedState.ImageSize = new Size(310, 185);
            btnNavPOS.ShadowDecoration.CustomizableEdges = customizableEdges3;
            btnNavPOS.Size = new Size(295, 113);
            btnNavPOS.TabIndex = 3;
            btnNavPOS.Click += btnNavPOS_Click;
            // 
            // btnNavExpired
            // 
            btnNavExpired.BackColor = Color.Transparent;
            btnNavExpired.CheckedState.ImageSize = new Size(310, 185);
            btnNavExpired.Dock = DockStyle.Top;
            btnNavExpired.HoverState.ImageSize = new Size(305, 180);
            btnNavExpired.Image = (Image)resources.GetObject("btnNavExpired.Image");
            btnNavExpired.ImageOffset = new Point(0, 0);
            btnNavExpired.ImageRotate = 0F;
            btnNavExpired.ImageSize = new Size(300, 175);
            btnNavExpired.Location = new Point(0, 226);
            btnNavExpired.Name = "btnNavExpired";
            btnNavExpired.PressedState.ImageSize = new Size(310, 185);
            btnNavExpired.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnNavExpired.Size = new Size(295, 113);
            btnNavExpired.TabIndex = 2;
            btnNavExpired.Click += btnNavExpired_Click;
            // 
            // btnNavMedicines
            // 
            btnNavMedicines.BackColor = Color.Transparent;
            btnNavMedicines.CheckedState.ImageSize = new Size(310, 185);
            btnNavMedicines.Dock = DockStyle.Top;
            btnNavMedicines.HoverState.ImageSize = new Size(305, 180);
            btnNavMedicines.Image = (Image)resources.GetObject("btnNavMedicines.Image");
            btnNavMedicines.ImageOffset = new Point(0, 0);
            btnNavMedicines.ImageRotate = 0F;
            btnNavMedicines.ImageSize = new Size(300, 175);
            btnNavMedicines.Location = new Point(0, 113);
            btnNavMedicines.Name = "btnNavMedicines";
            btnNavMedicines.PressedState.ImageSize = new Size(310, 185);
            btnNavMedicines.ShadowDecoration.CustomizableEdges = customizableEdges5;
            btnNavMedicines.Size = new Size(295, 113);
            btnNavMedicines.TabIndex = 1;
            btnNavMedicines.Click += btnNavMedicines_Click;
            // 
            // btnNavHome
            // 
            btnNavHome.BackColor = Color.Transparent;
            btnNavHome.CheckedState.ImageSize = new Size(310, 185);
            btnNavHome.Dock = DockStyle.Top;
            btnNavHome.HoverState.ImageSize = new Size(305, 180);
            btnNavHome.Image = (Image)resources.GetObject("btnNavHome.Image");
            btnNavHome.ImageOffset = new Point(0, 0);
            btnNavHome.ImageRotate = 0F;
            btnNavHome.ImageSize = new Size(300, 175);
            btnNavHome.Location = new Point(0, 0);
            btnNavHome.Name = "btnNavHome";
            btnNavHome.PressedState.ImageSize = new Size(310, 185);
            btnNavHome.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnNavHome.Size = new Size(295, 113);
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
            TabHome.Location = new Point(4, 5);
            TabHome.Name = "TabHome";
            TabHome.Size = new Size(1470, 935);
            TabHome.TabIndex = 5;
            TabHome.Text = "Home";
            TabHome.UseVisualStyleBackColor = true;
            // 
            // TabMedicines
            // 
            TabMedicines.BackColor = Color.Transparent;
            TabMedicines.Location = new Point(4, 5);
            TabMedicines.Name = "TabMedicines";
            TabMedicines.Padding = new Padding(3);
            TabMedicines.Size = new Size(1470, 935);
            TabMedicines.TabIndex = 0;
            TabMedicines.Text = "Medicines";
            // 
            // TabExpired
            // 
            TabExpired.Location = new Point(4, 5);
            TabExpired.Name = "TabExpired";
            TabExpired.Padding = new Padding(3);
            TabExpired.Size = new Size(1470, 935);
            TabExpired.TabIndex = 1;
            TabExpired.Text = "Expired";
            TabExpired.UseVisualStyleBackColor = true;
            // 
            // TabPOS
            // 
            TabPOS.Location = new Point(4, 5);
            TabPOS.Name = "TabPOS";
            TabPOS.Padding = new Padding(3);
            TabPOS.Size = new Size(1470, 935);
            TabPOS.TabIndex = 2;
            TabPOS.Text = "POS";
            TabPOS.UseVisualStyleBackColor = true;
            // 
            // TabInvoice
            // 
            TabInvoice.Location = new Point(4, 5);
            TabInvoice.Name = "TabInvoice";
            TabInvoice.Padding = new Padding(3);
            TabInvoice.Size = new Size(1470, 935);
            TabInvoice.TabIndex = 3;
            TabInvoice.Text = "Invoice";
            TabInvoice.UseVisualStyleBackColor = true;
            // 
            // TabSettings
            // 
            TabSettings.Location = new Point(4, 5);
            TabSettings.Name = "TabSettings";
            TabSettings.Padding = new Padding(3);
            TabSettings.Size = new Size(1470, 935);
            TabSettings.TabIndex = 4;
            TabSettings.Text = "Settings";
            TabSettings.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1478, 944);
            Controls.Add(panel1);
            Controls.Add(MainTabControl);
            Name = "MainForm";
            Text = "MainForm";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            MainTabControl.ResumeLayout(false);
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
    }
}