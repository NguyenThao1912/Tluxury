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
    public partial class CF_HOADON : Form
    {
        public CF_HOADON()
        {
            InitializeComponent();
        }

        private void CF_HOADON_Load(object sender, EventArgs e)
        {
            button_luu.Hide();
        }

        private void button_sua_Click(object sender, EventArgs e)
        {
            button_luu.Show();
        }

        private void button_luu_Click(object sender, EventArgs e)
        {
            button_luu.Hide();
        }

        private void button_them_Click(object sender, EventArgs e)
        {
            Add_hoadon f1AddHoadon =new Add_hoadon();
            f1AddHoadon.Show();
        }
    }
}
