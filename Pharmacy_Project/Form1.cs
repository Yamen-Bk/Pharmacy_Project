using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pharmacy_Project
{
    public partial class LoginForm : Form
    {
        List<Image> images = new List<Image>();
        string[] location = new string[25];
        public LoginForm()
        {
            InitializeComponent();
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
            {

                Image img = Image.FromFile(location[i]);
                images.Add(img);
            }
            images.Add(Image.FromFile(Application.StartupPath + @"\login_pics\debut.jpg"));
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (UsernameTextBox.Text.Length > 0 && UsernameTextBox.Text.Length <= 15)
            {
                LoginPic.Image = images[UsernameTextBox.Text.Length - 1];
                LoginPic.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else if (UsernameTextBox.Text.Length <= 0)
                LoginPic.Image = Image.FromFile(Application.StartupPath + @"\login_pics\debut.jpg");
            else
                LoginPic.Image = images[23];
        }
        private void UsernameTextBox_Click(object sender, EventArgs e)
        {
            if (UsernameTextBox.Text.Length > 0)
                LoginPic.Image = images[UsernameTextBox.Text.Length - 1];
            else
                LoginPic.Image = Image.FromFile(Application.StartupPath + @"\login_pics\debut.jpg");
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            LoginPic.Image = Image.FromFile(Application.StartupPath + @"\login_pics\textbox_password.png");
        }

        private void SignButton_Click(object sender, EventArgs e)
        {

        }
    }
}
