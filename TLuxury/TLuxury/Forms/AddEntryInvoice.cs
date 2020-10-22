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
        decimal tongtien = 0;
        List<string> stockEntry = new List<string>();
        Model_Employee Employee;
        Model_Supplier Supplier;
        Model_EntryInvoice model;
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
        private void ClearText()
        {
            comboBoxProduct.Text = "";
            comboBoxSupplier.Text = "";
            DateEntryPicker.Value = DateTime.Today;
            textBoxDiscount.Text = "0";
            textBoxUnitPrice.Text = "";
            numericUpDownQuantity.Value = 0;
            comboBoxProduct.SelectedIndex = -1;
        }
        private string GetProductName(string text)
        {
            return text.Substring(9);
        }
        private bool CheckStock(string id)
        {
            if (stockEntry.Contains(id))
                return false;
            return true;
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (CheckForms())
            {              
                
                Employee = (Model_Employee)comboBoxEmployee.SelectedItem;
                Model_Product Product = (Model_Product)comboBoxProduct.SelectedItem;
                Supplier = (Model_Supplier)comboBoxSupplier.SelectedItem;
                string NameOfProduct = GetProductName(Product.Name);
                
                DateTime day = DateEntryPicker.Value;
                // Them data vao datagridview
                if (CheckStock(Product.ID) == false)
                    MessageBox.Show("Đã có sản phẩm trong danh sách", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Error);
                else
                {
                    stockEntry.Add(Product.ID);
                    tongtien += numericUpDownQuantity.Value * int.Parse(textBoxUnitPrice.Text);
                    labelTotal.Text ="Tổng tiền : " + tongtien.ToString("N0",System.Globalization.CultureInfo.GetCultureInfo("de")) + " VND";
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = Product.ID;
                    dataGridView1.Rows[n].Cells[1].Value = NameOfProduct;
                    dataGridView1.Rows[n].Cells[2].Value = numericUpDownQuantity.Value.ToString();
                    dataGridView1.Rows[n].Cells[3].Value = textBoxUnitPrice.Text;
                    dataGridView1.Rows[n].Cells[4].Value = textBoxDiscount.Text;
                    dataGridView1.Rows[n].Cells[5].Value = Supplier.ID;
                }
                
                //Clear data
                ClearText();
            }           
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            AddProduct a = new AddProduct();
            a.ShowDialog();
            GetProducts();
        }

        private void AddEntryInvoice_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            // Tạo cột
            dataGridView1.Columns.Add("ProductID", "Mã Sản Phẩm");    //columnname , header
            dataGridView1.Columns.Add("ProductName", "Tên Sản Phẩm"); //columnname , header
            dataGridView1.Columns.Add("Quantity", "Số Lượng");        //columnname , header
            dataGridView1.Columns.Add("UnitPrice", "Đơn Giá");        //columnname , header
            dataGridView1.Columns.Add("Discount", "Giảm Giá");        //columnname , header
            dataGridView1.Columns.Add("SupplierID", "Nhà Cung Cấp");  //columnname , header

            //set size cho tung cot
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private bool CheckForms()
        {
            if(comboBoxEmployee.Text == "")
            {
                MessageBox.Show("Cần chọn nhân viên !", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            if(comboBoxProduct.Text == "")
            {
                MessageBox.Show("Cần chọn sản Phẩm !", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            if (comboBoxSupplier.Text == "")
            {
                MessageBox.Show("Cần chọn Nhà Cung Cấp !", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            if(numericUpDownQuantity.Text == "0")
            {
                MessageBox.Show("Cần Thêm số lượng !", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            if(textBoxUnitPrice.Text == "")
            {
                MessageBox.Show("Cần Thêm giá của sản phẩm !", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            if(textBoxDiscount.Text =="")
            {
                MessageBox.Show("Cần thêm giảm giá  !", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn chắc chắn muốn xóa sản phẩm này ","Thông báo",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (DataGridViewRow item in dataGridView1.SelectedRows)
                {
                    decimal money = decimal.Parse(item.Cells[2].Value.ToString()) * decimal.Parse(item.Cells[3].Value.ToString());
                    tongtien = tongtien - money;
                    labelTotal.Text = "Tổng tiền : " + tongtien.ToString("N0", System.Globalization.CultureInfo.GetCultureInfo("de")) + " VND";
                    dataGridView1.Rows.RemoveAt(item.Index);
                }
            }
        }

        private void buttonComplete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác Nhận Nhập Hàng  ^_^ ", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                try
                {
                    model = GlobalConfig.Connection.InsertNewEntryInvoice(Employee.ID, Supplier.ID, DateEntryPicker.Value, tongtien);
                }
                catch
                {
                    MessageBox.Show(" Lỗi câu lệnh sql ~ 1 ~ line 186", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row != null)
                    {
                        try
                        {
                            GlobalConfig.Connection.InsertNewEntryDetails(
                                model.ID,
                                row.Cells["ProductID"].Value.ToString(),
                                float.Parse(row.Cells["Discount"].Value.ToString()) / 100,
                                decimal.Parse(row.Cells["UnitPrice"].Value.ToString()),
                                int.Parse(row.Cells["Quantity"].Value.ToString()),
                                tongtien
                             );
                            MessageBox.Show("Thêm hóa đơn thành công!", "Thông Báo", MessageBoxButtons.OK);
                            this.Dispose();
                          //  dataGridView1.Rows.Clear();
                         //   labelTotal.Text = "Tổng Tiền : 0 VND";
                        }
                        catch
                        {
                            MessageBox.Show(" Lỗi câu lệnh sql ~ 2 ~ line 199", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void buttonAddSupplier_Click(object sender, EventArgs e)
        {
            AddSupplier a = new AddSupplier();
            a.ShowDialog();
            GetSupplier();
        }
    }
}
