using StoreLibrary;
using StoreLibrary.Models;
using System;
using System.Data;
using System.Windows.Forms;

namespace TLuxury.Forms
{
    public partial class CF_BANHANG : Form
    {
        public CF_BANHANG()
        {
            InitializeComponent();
        }

        private void BANHANG_Load(object sender, EventArgs e)
        {
            labeltime.Text = DateTime.Now.ToString("MM/dd/yyyy");
            DataTable model = GlobalConfig.Connection.GetAllProducts();
            dataGridViewhanghoa.DataSource = null;
            dataGridViewhanghoa.DataSource = model;
            dataGridViewhanghoa.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewhanghoa.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewhanghoa.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewhanghoa.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewhanghoa.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewhanghoa.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewhanghoa.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewhanghoa.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewhanghoa.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewhanghoa.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewhanghoa.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void dataGridViewhanghoa_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count == 0) return;
            Model_Product product = new Model_Product();
            DataGridViewRow currentRow = new DataGridViewRow();
            currentRow = dataGridViewhanghoa.CurrentRow;
            product.ID = currentRow.Cells[0].Value.ToString();
            product.Name = currentRow.Cells[1].Value.ToString();
            Model_Color cloColor = new Model_Color();
            cloColor.Name = currentRow.Cells[5].Value.ToString();
            product.Color = cloColor;
            Model_Size modelSize = new Model_Size();
            modelSize.Size = currentRow.Cells[3].Value.ToString();
            product.Size = modelSize;
            product.PriceSell = decimal.Parse(currentRow.Cells[10].Value.ToString());

            DataGridViewRow addRow = (DataGridViewRow)dataGridView1.Rows[0].Clone();

            addRow.Cells[0].Value = product.ID;
            addRow.Cells[1].Value = product.Name;
            addRow.Cells[2].Value = product.Size.Size;
            addRow.Cells[3].Value = product.Color.Name;
            addRow.Cells[4].Value = 1;
            addRow.Cells[5].Value = product.PriceSell;
            addRow.Cells[6].Value = 0;
            addRow.Cells[7].Value = product.PriceSell;


            Button b=new Button();
            b.Text = " ";
            b.ImageList = imageList1;
            b.ImageIndex = 3;
            addRow.Cells[8].Value = b;




            dataGridView1.Rows.Add(addRow);
            int dem = 0; float tongtien = 0;
            for (var VARIABLE = 0; VARIABLE <= dataGridView1.Rows.Count - 1; VARIABLE++)
            {
                if (dataGridView1.Rows[VARIABLE].Cells[4].Value != null)
                    dem += int.Parse(dataGridView1.Rows[VARIABLE].Cells[4].Value.ToString());
                if (dataGridView1.Rows[VARIABLE].Cells[7].Value != null)
                    tongtien += float.Parse(dataGridView1.Rows[VARIABLE].Cells[7].Value.ToString());
            }

            labeltongsoluong.Text = " " + (dem);
            labeltongtien.Text = " " + tongtien;
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Cells[7].Value =
                decimal.Parse(dataGridView1.CurrentRow.Cells[5].Value.ToString()) *
                decimal.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString()) *
                ( 1-(decimal.Parse(dataGridView1.CurrentRow.Cells[6].Value.ToString())/100))
                ;

            int dem = 0; float tongtien = 0;
            for (var VARIABLE = 0; VARIABLE <= dataGridView1.Rows.Count - 1; VARIABLE++)
            {
                if (dataGridView1.Rows[VARIABLE].Cells[4].Value != null)
                    dem += int.Parse(dataGridView1.Rows[VARIABLE].Cells[4].Value.ToString());
                if (dataGridView1.Rows[VARIABLE].Cells[7].Value != null)
                    tongtien += float.Parse(dataGridView1.Rows[VARIABLE].Cells[7].Value.ToString());
            }

            labeltongsoluong.Text = " " + (dem);
            labeltongtien.Text = " " + tongtien;
        }
    }
}