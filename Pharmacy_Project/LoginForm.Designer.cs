namespace Pharmacy_Project
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            LoginPanel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            ShowPassbtn = new Guna.UI2.WinForms.Guna2ImageButton();
            PasswordTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            labelErrorPass = new Label();
            labelErrorUser = new Label();
            SignButton = new Guna.UI2.WinForms.Guna2ImageButton();
            UsernameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            LoginPic = new Guna.UI2.WinForms.Guna2PictureBox();
            guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            LoginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LoginPic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LoginPanel
            // 
            LoginPanel.Anchor = AnchorStyles.None;
            LoginPanel.BackColor = Color.Transparent;
            LoginPanel.BackgroundImageLayout = ImageLayout.Stretch;
            LoginPanel.Controls.Add(ShowPassbtn);
            LoginPanel.Controls.Add(PasswordTextBox);
            LoginPanel.Controls.Add(labelErrorPass);
            LoginPanel.Controls.Add(labelErrorUser);
            LoginPanel.Controls.Add(SignButton);
            LoginPanel.Controls.Add(UsernameTextBox);
            LoginPanel.Controls.Add(LoginPic);
            LoginPanel.FillColor = SystemColors.ControlLightLight;
            LoginPanel.ForeColor = SystemColors.ButtonHighlight;
            LoginPanel.Location = new Point(475, 150);
            LoginPanel.Name = "LoginPanel";
            LoginPanel.Radius = 25;
            LoginPanel.ShadowColor = Color.Black;
            LoginPanel.ShadowDepth = 125;
            LoginPanel.ShadowShift = 15;
            LoginPanel.Size = new Size(550, 700);
            LoginPanel.TabIndex = 0;
            // 
            // ShowPassbtn
            // 
            ShowPassbtn.CheckedState.Image = (Image)resources.GetObject("resource.Image");
            ShowPassbtn.CheckedState.ImageSize = new Size(40, 40);
            ShowPassbtn.HoverState.ImageSize = new Size(40, 40);
            ShowPassbtn.Image = (Image)resources.GetObject("ShowPassbtn.Image");
            ShowPassbtn.ImageOffset = new Point(0, 0);
            ShowPassbtn.ImageRotate = 0F;
            ShowPassbtn.ImageSize = new Size(40, 40);
            ShowPassbtn.Location = new Point(384, 469);
            ShowPassbtn.Name = "ShowPassbtn";
            ShowPassbtn.PressedState.Image = (Image)resources.GetObject("resource.Image1");
            ShowPassbtn.PressedState.ImageSize = new Size(42, 42);
            ShowPassbtn.ShadowDecoration.CustomizableEdges = customizableEdges1;
            ShowPassbtn.Size = new Size(34, 31);
            ShowPassbtn.TabIndex = 2;
            ShowPassbtn.MouseDown += ShowPassbtn_MouseDown;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.AutoRoundedCorners = true;
            PasswordTextBox.BackColor = Color.Transparent;
            PasswordTextBox.BorderColor = Color.DimGray;
            PasswordTextBox.BorderRadius = 29;
            PasswordTextBox.BorderThickness = 2;
            PasswordTextBox.CustomizableEdges = customizableEdges2;
            PasswordTextBox.DefaultText = "";
            PasswordTextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            PasswordTextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            PasswordTextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            PasswordTextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            PasswordTextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            PasswordTextBox.Font = new Font("Segoe UI", 10F);
            PasswordTextBox.ForeColor = SystemColors.ActiveCaptionText;
            PasswordTextBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            PasswordTextBox.IconLeft = (Image)resources.GetObject("PasswordTextBox.IconLeft");
            PasswordTextBox.IconLeftSize = new Size(50, 50);
            PasswordTextBox.IconRightOffset = new Point(7, 0);
            PasswordTextBox.IconRightSize = new Size(35, 35);
            PasswordTextBox.Location = new Point(121, 454);
            PasswordTextBox.Margin = new Padding(4, 6, 4, 6);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PlaceholderForeColor = Color.Gray;
            PasswordTextBox.PlaceholderText = "Password";
            PasswordTextBox.SelectedText = "";
            PasswordTextBox.ShadowDecoration.BorderRadius = 2;
            PasswordTextBox.ShadowDecoration.CustomizableEdges = customizableEdges3;
            PasswordTextBox.ShadowDecoration.Depth = 10;
            PasswordTextBox.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            PasswordTextBox.Size = new Size(310, 60);
            PasswordTextBox.TabIndex = 6;
            PasswordTextBox.TextOffset = new Point(0, -1);
            PasswordTextBox.UseSystemPasswordChar = true;
            PasswordTextBox.TextChanged += PasswordTextBox_TextChanged;
            // 
            // labelErrorPass
            // 
            labelErrorPass.AutoSize = true;
            labelErrorPass.ForeColor = Color.Red;
            labelErrorPass.Location = new Point(144, 412);
            labelErrorPass.Name = "labelErrorPass";
            labelErrorPass.Size = new Size(0, 25);
            labelErrorPass.TabIndex = 5;
            labelErrorPass.Visible = false;
            // 
            // labelErrorUser
            // 
            labelErrorUser.AutoSize = true;
            labelErrorUser.ForeColor = Color.Red;
            labelErrorUser.Location = new Point(144, 299);
            labelErrorUser.Name = "labelErrorUser";
            labelErrorUser.Size = new Size(0, 25);
            labelErrorUser.TabIndex = 4;
            labelErrorUser.Visible = false;
            // 
            // SignButton
            // 
            SignButton.CheckedState.ImageSize = new Size(64, 64);
            SignButton.HoverState.ImageSize = new Size(245, 145);
            SignButton.Image = (Image)resources.GetObject("SignButton.Image");
            SignButton.ImageOffset = new Point(0, 0);
            SignButton.ImageRotate = 0F;
            SignButton.ImageSize = new Size(240, 140);
            SignButton.Location = new Point(165, 547);
            SignButton.Name = "SignButton";
            SignButton.PressedState.ImageSize = new Size(242, 142);
            SignButton.ShadowDecoration.CustomizableEdges = customizableEdges4;
            SignButton.Size = new Size(210, 73);
            SignButton.TabIndex = 3;
            SignButton.Click += SignButton_Click;
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.AutoRoundedCorners = true;
            UsernameTextBox.BackColor = Color.Transparent;
            UsernameTextBox.BorderColor = Color.DimGray;
            UsernameTextBox.BorderRadius = 29;
            UsernameTextBox.BorderThickness = 2;
            UsernameTextBox.CustomizableEdges = customizableEdges5;
            UsernameTextBox.DefaultText = "";
            UsernameTextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            UsernameTextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            UsernameTextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            UsernameTextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            UsernameTextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            UsernameTextBox.Font = new Font("Segoe UI", 10F);
            UsernameTextBox.ForeColor = SystemColors.ActiveCaptionText;
            UsernameTextBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            UsernameTextBox.IconLeft = (Image)resources.GetObject("UsernameTextBox.IconLeft");
            UsernameTextBox.IconLeftSize = new Size(50, 50);
            UsernameTextBox.Location = new Point(121, 330);
            UsernameTextBox.Margin = new Padding(4, 6, 4, 6);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.PlaceholderForeColor = Color.Gray;
            UsernameTextBox.PlaceholderText = "Usernsme";
            UsernameTextBox.SelectedText = "";
            UsernameTextBox.ShadowDecoration.BorderRadius = 2;
            UsernameTextBox.ShadowDecoration.CustomizableEdges = customizableEdges6;
            UsernameTextBox.ShadowDecoration.Depth = 10;
            UsernameTextBox.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            UsernameTextBox.Size = new Size(310, 60);
            UsernameTextBox.TabIndex = 1;
            UsernameTextBox.TextOffset = new Point(0, -1);
            UsernameTextBox.TextChanged += UsernameTextBox_TextChanged;
            // 
            // LoginPic
            // 
            LoginPic.CustomizableEdges = customizableEdges7;
            LoginPic.Image = (Image)resources.GetObject("LoginPic.Image");
            LoginPic.ImageRotate = 0F;
            LoginPic.Location = new Point(183, 72);
            LoginPic.Name = "LoginPic";
            LoginPic.ShadowDecoration.CustomizableEdges = customizableEdges8;
            LoginPic.Size = new Size(186, 185);
            LoginPic.SizeMode = PictureBoxSizeMode.Zoom;
            LoginPic.TabIndex = 0;
            LoginPic.TabStop = false;
            // 
            // guna2PictureBox1
            // 
            guna2PictureBox1.BackColor = Color.Transparent;
            guna2PictureBox1.BackgroundImageLayout = ImageLayout.None;
            guna2PictureBox1.CustomizableEdges = customizableEdges9;
            guna2PictureBox1.Image = (Image)resources.GetObject("guna2PictureBox1.Image");
            guna2PictureBox1.ImageRotate = 0F;
            guna2PictureBox1.Location = new Point(67, 30);
            guna2PictureBox1.Name = "guna2PictureBox1";
            guna2PictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges10;
            guna2PictureBox1.Size = new Size(250, 200);
            guna2PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            guna2PictureBox1.TabIndex = 1;
            guna2PictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1478, 944);
            Controls.Add(guna2PictureBox1);
            Controls.Add(LoginPanel);
            Name = "LoginForm";
            Text = "LoginForm";
            FormClosing += LoginForm_FormClosing;
            Load += LoginForm_Load;
            LoginPanel.ResumeLayout(false);
            LoginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LoginPic).EndInit();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel LoginPanel;
        private Guna.UI2.WinForms.Guna2PictureBox LoginPic;
        private Guna.UI2.WinForms.Guna2ImageButton SignButton;
        private Guna.UI2.WinForms.Guna2TextBox UsernameTextBox;
        private Label labelErrorPass;
        private Label labelErrorUser;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox PasswordTextBox;
        private Guna.UI2.WinForms.Guna2ImageButton ShowPassbtn;
    }
}
