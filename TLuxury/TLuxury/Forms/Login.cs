using StoreLibrary;
using StoreLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            
           Users a = GlobalConfig.Connection.Checklogin(textBoxUser.Text,textBoxPassword.Text);
           if(a.islogin == 1)
           {
                MainForm main = new MainForm();
                this.Hide();
                main.BringToFront();
                main.Show();
           }
           else
           {
                textBoxUser.Focus();
                MessageBox.Show("Sai Tài Khoản Hoặc Mật Khẩu ","Attention",MessageBoxButtons.OK,MessageBoxIcon.Error);
           }
        }
    }
}
