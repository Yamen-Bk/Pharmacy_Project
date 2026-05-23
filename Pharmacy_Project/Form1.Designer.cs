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
            guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            SignButton = new Guna.UI2.WinForms.Guna2ImageButton();
            PasswordTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            UsernameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            LoginPic = new Guna.UI2.WinForms.Guna2PictureBox();
            labelErrorUser = new Label();
            labelErrorPass = new Label();
            guna2ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LoginPic).BeginInit();
            SuspendLayout();
            // 
            // guna2ShadowPanel1
            // 
            guna2ShadowPanel1.BackColor = Color.Transparent;
            guna2ShadowPanel1.Controls.Add(labelErrorPass);
            guna2ShadowPanel1.Controls.Add(labelErrorUser);
            guna2ShadowPanel1.Controls.Add(SignButton);
            guna2ShadowPanel1.Controls.Add(PasswordTextBox);
            guna2ShadowPanel1.Controls.Add(UsernameTextBox);
            guna2ShadowPanel1.Controls.Add(LoginPic);
            guna2ShadowPanel1.FillColor = Color.White;
            guna2ShadowPanel1.Location = new Point(441, 119);
            guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            guna2ShadowPanel1.ShadowColor = Color.Black;
            guna2ShadowPanel1.Size = new Size(553, 697);
            guna2ShadowPanel1.TabIndex = 0;
            // 
            // SignButton
            // 
            SignButton.CheckedState.ImageSize = new Size(64, 64);
            SignButton.HoverState.ImageSize = new Size(64, 64);
            SignButton.Image = (Image)resources.GetObject("SignButton.Image");
            SignButton.ImageOffset = new Point(0, 0);
            SignButton.ImageRotate = 0F;
            SignButton.Location = new Point(153, 564);
            SignButton.Name = "SignButton";
            SignButton.PressedState.ImageSize = new Size(64, 64);
            SignButton.ShadowDecoration.CustomizableEdges = customizableEdges1;
            SignButton.Size = new Size(228, 66);
            SignButton.TabIndex = 3;
            SignButton.Click += SignButton_Click;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.CustomizableEdges = customizableEdges2;
            PasswordTextBox.DefaultText = "";
            PasswordTextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            PasswordTextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            PasswordTextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            PasswordTextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            PasswordTextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            PasswordTextBox.Font = new Font("Segoe UI", 9F);
            PasswordTextBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            PasswordTextBox.Location = new Point(122, 454);
            PasswordTextBox.Margin = new Padding(4, 5, 4, 5);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PlaceholderText = "";
            PasswordTextBox.SelectedText = "";
            PasswordTextBox.ShadowDecoration.CustomizableEdges = customizableEdges3;
            PasswordTextBox.Size = new Size(303, 54);
            PasswordTextBox.TabIndex = 2;
            PasswordTextBox.TextChanged += PasswordTextBox_TextChanged;
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.CustomizableEdges = customizableEdges4;
            UsernameTextBox.DefaultText = "";
            UsernameTextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            UsernameTextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            UsernameTextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            UsernameTextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            UsernameTextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            UsernameTextBox.Font = new Font("Segoe UI", 9F);
            UsernameTextBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            UsernameTextBox.Location = new Point(122, 346);
            UsernameTextBox.Margin = new Padding(4, 5, 4, 5);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.PlaceholderText = "";
            UsernameTextBox.SelectedText = "";
            UsernameTextBox.ShadowDecoration.CustomizableEdges = customizableEdges5;
            UsernameTextBox.Size = new Size(303, 54);
            UsernameTextBox.TabIndex = 1;
            UsernameTextBox.TextChanged += UsernameTextBox_TextChanged;
            // 
            // LoginPic
            // 
            LoginPic.CustomizableEdges = customizableEdges6;
            LoginPic.Image = (Image)resources.GetObject("LoginPic.Image");
            LoginPic.ImageRotate = 0F;
            LoginPic.Location = new Point(181, 72);
            LoginPic.Name = "LoginPic";
            LoginPic.ShadowDecoration.CustomizableEdges = customizableEdges7;
            LoginPic.Size = new Size(186, 185);
            LoginPic.TabIndex = 0;
            LoginPic.TabStop = false;
            // 
            // labelErrorUser
            // 
            labelErrorUser.AutoSize = true;
            labelErrorUser.ForeColor = Color.Red;
            labelErrorUser.Location = new Point(290, 316);
            labelErrorUser.Name = "labelErrorUser";
            labelErrorUser.Size = new Size(0, 25);
            labelErrorUser.TabIndex = 4;
            labelErrorUser.Visible = false;
            // 
            // labelErrorPass
            // 
            labelErrorPass.AutoSize = true;
            labelErrorPass.ForeColor = Color.Red;
            labelErrorPass.Location = new Point(290, 424);
            labelErrorPass.Name = "labelErrorPass";
            labelErrorPass.Size = new Size(0, 25);
            labelErrorPass.TabIndex = 5;
            labelErrorPass.Visible = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1478, 944);
            Controls.Add(guna2ShadowPanel1);
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            guna2ShadowPanel1.ResumeLayout(false);
            guna2ShadowPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LoginPic).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2PictureBox LoginPic;
        private Guna.UI2.WinForms.Guna2ImageButton SignButton;
        private Guna.UI2.WinForms.Guna2TextBox PasswordTextBox;
        private Guna.UI2.WinForms.Guna2TextBox UsernameTextBox;
        private Label labelErrorPass;
        private Label labelErrorUser;
    }
}
