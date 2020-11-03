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
            try
            {
                List<Model_Product> products = GlobalConfig.Connection.GetAllProduct_List();
                comboBoxProduct.DataSource = null;
                comboBoxProduct.DataSource = products;
                comboBoxProduct.DisplayMember = "Name";
                comboBoxProduct.SelectedIndex = -1;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString(), "Thông Báo",MessageBoxButtons.OK);
            }

        }
        private void GetSupplier()
        {
            try
            {
                List<Model_Supplier> suppliers = GlobalConfig.Connection.GetAllSupplier_List();
                comboBoxSupplier.DataSource = null;
                comboBoxSupplier.DataSource = suppliers;
                comboBoxSupplier.DisplayMember = "Name";
                comboBoxSupplier.SelectedIndex = -1;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Thông Báo", MessageBoxButtons.OK);
            }
        }
        private void GetEmployee()
        {
            try
            {
                List<Model_Employee> employees = GlobalConfig.Connection.GetAllEmployee_List();
                comboBoxEmployee.DataSource = null;
                comboBoxEmployee.DataSource = employees;
                comboBoxEmployee.DisplayMember = "Name";
                comboBoxEmployee.SelectedIndex = -1;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Thông Báo", MessageBoxButtons.OK);
            }
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
                //Lấy Thông tin được chọn từ Forms
                Employee = (Model_Employee)comboBoxEmployee.SelectedItem;
                Model_Product Product = (Model_Product)comboBoxProduct.SelectedItem;
                Supplier = (Model_Supplier)comboBoxSupplier.SelectedItem;
                string NameOfProduct = GetProductName(Product.Name);             
                DateTime day = DateEntryPicker.Value;
                // Kiem tra  san pham da co trong danh sách chưa
                if (CheckStock(Product.ID) == false)
                    MessageBox.Show("Đã có sản phẩm trong danh sách", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Error);
                else
                {
                    stockEntry.Add(Product.ID);
                    //Tổng tiền = (Số Lượng * đơn Giá ) * (1 - Giảm Giá)
                    tongtien += (numericUpDownQuantity.Value * decimal.Parse(textBoxUnitPrice.Text))* (1- decimal.Parse(textBoxDiscount.Text)/100);
                    labelTotal.Text ="Tổng tiền : " + tongtien.ToString("N0",System.Globalization.CultureInfo.GetCultureInfo("de")) + " VND";
                    //Thêm thông tin vào datagridview
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = Product.ID;
                    dataGridView1.Rows[n].Cells[1].Value = NameOfProduct;
                    dataGridView1.Rows[n].Cells[2].Value = numericUpDownQuantity.Value.ToString();
                    dataGridView1.Rows[n].Cells[3].Value = textBoxUnitPrice.Text;
                    dataGridView1.Rows[n].Cells[4].Value = textBoxDiscount.Text;
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
            dataGridView1.Columns.Add("Discount", "Giảm Giá (%)");    //columnname , header

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
            if (dataGridView1.Rows.Count < 1)
                return;
            if(MessageBox.Show("Bạn chắc chắn muốn xóa sản phẩm này ","Thông báo",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //Tiến hành Tính lại tiền sau khi xóa
                foreach (DataGridViewRow item in dataGridView1.SelectedRows)
                {
                    //Lấy tiền từ đối tượng được chọn
                    decimal money = (decimal.Parse(item.Cells[2].Value.ToString()) * decimal.Parse(item.Cells[3].Value.ToString())) * (1-decimal.Parse(item.Cells["Discount"].Value.ToString())/100);
                    //Lấy tổng tiền hiện tại trừ đi 
                    tongtien = tongtien - money;
                    //Cập nhật lại Tổng tiền trên label
                    labelTotal.Text = "Tổng tiền : " + tongtien.ToString("N0", System.Globalization.CultureInfo.GetCultureInfo("de")) + " VND";
                    stockEntry.Remove(item.Cells[0].Value.ToString());
                    dataGridView1.Rows.RemoveAt(item.Index);                  
                }
            }
        }

        private void buttonComplete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác Nhận Nhập Hàng  ^_^ ", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //Thêm dữ liệu vào bảng hóa đơn nhập
                try
                {
                    model = GlobalConfig.Connection.InsertNewEntryInvoice(Employee.ID, Supplier.ID, DateEntryPicker.Value.ToString("yyyy-MM-dd HH:mm:ss"), tongtien);
                }
                catch (Exception r)
                {
                    MessageBox.Show($"{r.ToString()} Lỗi câu lệnh sql ~ 1 ~ line 186", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //Thêm dữ liệu vào bảng chi tiết hóa đơn nhập
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row != null)
                    {
                        try
                        {
                            decimal unitprice = decimal.Parse(row.Cells["UnitPrice"].Value.ToString());
                            decimal quantity = decimal.Parse(row.Cells["Quantity"].Value.ToString());
                            decimal discount = (1 - decimal.Parse(row.Cells["Discount"].Value.ToString()) / 100);
                            //Truy Vấn SQL
                            GlobalConfig.Connection.InsertNewEntryDetails(
                                model.ID,
                                row.Cells["ProductID"].Value.ToString(),
                                float.Parse(row.Cells["Discount"].Value.ToString()),
                                decimal.Parse(row.Cells["UnitPrice"].Value.ToString()),
                                int.Parse(row.Cells["Quantity"].Value.ToString()),
                                (unitprice * quantity) * discount
                             );
                          //  dataGridView1.Rows.Clear();
                         //   labelTotal.Text = "Tổng Tiền : 0 VND";
                        }
                        catch
                        {
                            MessageBox.Show(" Lỗi câu lệnh sql ~ 2 ~ line 199", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                MessageBox.Show("Thêm hóa đơn thành công!", "Thông Báo", MessageBoxButtons.OK);
                this.Dispose();
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
