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
    public partial class BANHANG : Form
    {
        public BANHANG()
        {
            InitializeComponent();
        }

        private void BANHANG_Load(object sender, EventArgs e)
        {
            labeltime.Text = DateTime.Now.ToString("MM/dd/yyyy");
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
