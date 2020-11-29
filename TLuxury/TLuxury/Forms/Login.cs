using StoreLibrary;
using StoreLibrary.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TLuxury.Forms
{
    public partial class Login : Form
    {
        private static Login _instance;
        static public Login Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Login();
                return _instance;
            }
            private set
            {
                _instance = value;
            }
        }
        private Login()
        {
            InitializeComponent();
            buttonDangNhap.FlatAppearance.MouseOverBackColor = Color.FromArgb(237, 125, 49);
            buttonDangNhap.FlatAppearance.MouseDownBackColor = Color.FromArgb(237, 125, 49);
            textBoxUser.Text = "Thao";
            textBoxPassword.Text = "123456";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonDangNhap_Click(object sender, EventArgs e)
        {

            Users a = GlobalConfig.Connection.Checklogin(textBoxUser.Text, textBoxPassword.Text);
            if (a.islogin == 1)
            {
                this.Hide();
                MainForm.Intance.BringToFront();
                MainForm.Intance.Show();
            }
            else
            {
                textBoxUser.Focus();
                MessageBox.Show("Sai Tài Khoản Hoặc Mật Khẩu ", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
