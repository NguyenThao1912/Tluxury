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
    public partial class AddEntryInvoice : Form
    {
        public AddEntryInvoice()
        {
            InitializeComponent();
            GetProducts();
            GetSupplier();
            GetEmployee();
        }
        private void GetProducts()
        {
            List<Model_Product> products = GlobalConfig.Connection.GetAllProduct_List();
            comboBoxProduct.DataSource = null;
            comboBoxProduct.DataSource = products;
            comboBoxProduct.DisplayMember = "Name";
            comboBoxProduct.SelectedIndex = -1;
        }
        private void GetSupplier()
        {
            List<Model_Supplier> suppliers = GlobalConfig.Connection.GetAllSupplier_List();
            comboBoxSupplier.DataSource = null;
            comboBoxSupplier.DataSource = suppliers;
            comboBoxSupplier.DisplayMember = "Name";
            comboBoxSupplier.SelectedIndex = -1;
        }
        private void GetEmployee()
        {
            List<Model_Employee> employees = GlobalConfig.Connection.GetAllEmployee_List();
            comboBoxEmployee.DataSource = null;
            comboBoxEmployee.DataSource = employees;
            comboBoxEmployee.DisplayMember = "Name";
            comboBoxEmployee.SelectedIndex = -1;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Mã Sản Phẩm", typeof(string));
            table.Columns.Add("Tên Sản Phẩm", typeof(string));
            table.Columns.Add("Số Lượng", typeof(int));
            table.Columns.Add("Đơn Giá", typeof(double));
            table.Columns.Add("Giảm Giá (%)", typeof(float));
            table.Columns.Add("Nhà Cung Cấp", typeof(string));
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = table;
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {

        }
    }
}
