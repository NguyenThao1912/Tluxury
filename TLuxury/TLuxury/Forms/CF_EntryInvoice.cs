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
    public partial class CF_EntryInvoice : Form
    {
        public CF_EntryInvoice()
        {
            InitializeComponent();
        }

        private void buttonThêm_Click(object sender, EventArgs e)
        {
            AddEntryInvoice entry = new AddEntryInvoice();
            entry.ShowDialog();
            //wireData();
        }
    }
}
