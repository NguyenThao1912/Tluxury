using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StoreLibrary;
using StoreLibrary.Models;
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
            DataTable model = GlobalConfig.Connection.GetAllProducts();
            dataGridViewhanghoa.DataSource = null;
            dataGridViewhanghoa.DataSource = model;
            dataGridViewhanghoa.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewhanghoa.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewhanghoa.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewhanghoa.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewhanghoa.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewhanghoa.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewhanghoa.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewhanghoa.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewhanghoa.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewhanghoa.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewhanghoa.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }
    }
}
