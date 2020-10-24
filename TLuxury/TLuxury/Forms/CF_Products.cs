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
    public partial class CF_Products : Form
    {
        Button curButton ;
        public CF_Products()
        {
            InitializeComponent();
            curButton = button1;
        }
        private void SlideMove(Button a)
        {
            Point b = a.Location;
            panel1.Location = new Point(b.X, b.Y + 54);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            curButton = (Button)sender;
            SlideMove(curButton);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            curButton = (Button)sender;
            SlideMove(curButton);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            curButton = (Button)sender;
            SlideMove(curButton);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            curButton = (Button)sender;
            SlideMove(curButton);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            curButton = (Button)sender;
            SlideMove(curButton);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            curButton = (Button)sender;
            SlideMove(curButton);
        }

        private void CF_Products_SizeChanged(object sender, EventArgs e)
        {
            SlideMove(curButton);
        }
    }
}
