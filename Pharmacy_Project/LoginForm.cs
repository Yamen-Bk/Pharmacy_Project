using Pharmacy_Project.Classes;
using Pharmacy_Project.Forms;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Pharmacy_Project
{
    public partial class LoginForm : Form
    {
        Image[] images = new Image[27];
        public LoginForm()
        {
            InitializeComponent();

            this.DoubleBuffered = true;
            LoadImages();
        }
        private void LoadImages()
        {
            for (int i = 0; i < 24; i++)
                images[i] = Image.FromFile(Application.StartupPath + $"\\login_pics\\textbox_user_{i + 1}.jpg");

            images[24] = Image.FromFile(Application.StartupPath + @"\login_pics\debut.jpg");
            images[25] = Image.FromFile(Application.StartupPath + @"\login_pics\textbox_password.png");
            images[26] = Image.FromFile(Application.StartupPath + @"\login_pics\textbox_password_show.png");
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {
            labelErrorUser.Visible = false;
            if (UsernameTextBox.Text.Length > 0 && UsernameTextBox.Text.Length <= 15)
                LoginPic.Image = images[UsernameTextBox.Text.Length - 1];
            else if (UsernameTextBox.Text.Length <= 0)
                LoginPic.Image = images[24];
            else
                LoginPic.Image = images[23];
        }
        private void UsernameTextBox_Click(object sender, EventArgs e)
        {
            if (UsernameTextBox.Text.Length > 0)
                LoginPic.Image = images[UsernameTextBox.Text.Length - 1];
            else
                LoginPic.Image = images[24];
        }
        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            labelErrorPass.Visible = false;
            LoginPic.Image = images[25];
        }
        private void ShowPassbtn_MouseDown(object sender, MouseEventArgs e)
        {
            if (PasswordTextBox.UseSystemPasswordChar == true)
            {
                PasswordTextBox.UseSystemPasswordChar = false;
                ShowPassbtn.Checked = true;
                LoginPic.Image = images[26];
            }
            else
            {
                PasswordTextBox.UseSystemPasswordChar = true;
                ShowPassbtn.Checked = false;
                LoginPic.Image = images[25];
            }
        }
        private async void SignButton_Click(object sender, EventArgs e)
        {
            labelErrorUser.Visible = false;
            labelErrorPass.Visible = false;

            bool hasError = false;

            if (UsernameTextBox.Text.Trim() == "")
            {
                labelErrorUser.Text = "Please Enter Your Username";
                labelErrorUser.Visible = true;
                hasError = true;
            }
            else if (UsernameTextBox.Text != Pharmacy.User.Username)
            {
                labelErrorUser.Text = "Username is Incorrect";
                labelErrorUser.Visible = true;
                hasError = true;
            }

            if (PasswordTextBox.Text == "")
            {
                labelErrorPass.Text = "Please Enter Your Password";
                labelErrorPass.Visible = true;
                hasError = true;
            }
            else if (BCrypt.Net.BCrypt.Verify(PasswordTextBox.Text, Pharmacy.User.Password))
            {
                labelErrorPass.Text = "Password is Incorrect";
                labelErrorPass.Visible = true;
                hasError = true;
            }

            if (hasError) return;

            SignButton.Enabled = false;
            UsernameTextBox.Enabled = false;
            PasswordTextBox.Enabled = false;


            Forms.MainForm main = new Forms.MainForm();
            main.StartPosition = FormStartPosition.Manual;
            main.Location = this.Location;
            main.Size = this.Size;
            main.WindowState = this.WindowState;
            main.Opacity = 0;
            main.Show();

            for (double i = 0; i <= 1; i += 0.04)
            {
                this.Opacity = 1 - i;
                main.Opacity = i;
                await Task.Delay(12);
            }
            main.Opacity = 1;
            this.Hide();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
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
