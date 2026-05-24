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
        List<Image> images = new List<Image>();
        string[] location = new string[25];
        public LoginForm()
        {
            InitializeComponent();

            this.DoubleBuffered = true;

            location[0] = Application.StartupPath + @"\login_pics\textbox_user_1.jpg";
            location[1] = Application.StartupPath + @"\login_pics\textbox_user_2.jpg";
            location[2] = Application.StartupPath + @"\login_pics\textbox_user_3.jpg";
            location[3] = Application.StartupPath + @"\login_pics\textbox_user_4.jpg";
            location[4] = Application.StartupPath + @"\login_pics\textbox_user_5.jpg";
            location[5] = Application.StartupPath + @"\login_pics\textbox_user_6.jpg";
            location[6] = Application.StartupPath + @"\login_pics\textbox_user_7.jpg";
            location[7] = Application.StartupPath + @"\login_pics\textbox_user_8.jpg";
            location[8] = Application.StartupPath + @"\login_pics\textbox_user_9.jpg";
            location[9] = Application.StartupPath + @"\login_pics\textbox_user_10.jpg";
            location[10] = Application.StartupPath + @"\login_pics\textbox_user_11.jpg";
            location[11] = Application.StartupPath + @"\login_pics\textbox_user_12.jpg";
            location[12] = Application.StartupPath + @"\login_pics\textbox_user_13.jpg";
            location[13] = Application.StartupPath + @"\login_pics\textbox_user_14.jpg";
            location[14] = Application.StartupPath + @"\login_pics\textbox_user_15.jpg";
            location[15] = Application.StartupPath + @"\login_pics\textbox_user_16.jpg";
            location[16] = Application.StartupPath + @"\login_pics\textbox_user_17.jpg";
            location[17] = Application.StartupPath + @"\login_pics\textbox_user_18.jpg";
            location[18] = Application.StartupPath + @"\login_pics\textbox_user_19.jpg";
            location[19] = Application.StartupPath + @"\login_pics\textbox_user_20.jpg";
            location[20] = Application.StartupPath + @"\login_pics\textbox_user_21.jpg";
            location[21] = Application.StartupPath + @"\login_pics\textbox_user_22.jpg";
            location[22] = Application.StartupPath + @"\login_pics\textbox_user_23.jpg";
            location[23] = Application.StartupPath + @"\login_pics\textbox_user_24.jpg";
            LoadImages();
        }
        private void LoadImages()
        {
            for (int i = 0; i < 24; i++)
                images.Add(Image.FromFile(location[i]));

            images.Add(Image.FromFile(Application.StartupPath + @"\login_pics\debut.jpg"));
            images.Add(Image.FromFile(Application.StartupPath + @"\login_pics\textbox_password.png"));
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
            else if (PasswordTextBox.Text != Pharmacy.User.Password)
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

        private void LoginPanel_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
