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
    public partial class CF_Customer : Form
    {
        Model_Customer temp ; // Đối tượng để xóa
        public CF_Customer()
        {
            InitializeComponent();
            WireData();
            comboBox1.SelectedItem = "--- Tìm Kiếm ---";
        }
        private void WireData()
        {   
            DataTable model = GlobalConfig.Connection.GetAllCustomers();
            DanhsachKH.DataSource = null;
            DanhsachKH.DataSource = model;
            DanhsachKH.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DanhsachKH.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DanhsachKH.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DanhsachKH.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void ResetButton()
        {
            textBoxName.ReadOnly = true;
            textBoxPhoneNumber.ReadOnly = true;
            textBoxAddress.ReadOnly = true;
            buttonSave.Visible = false;
        }
        private void ClearData()
        {
            textBoxID.Text = "";
            textBoxName.Text = "";
            textBoxPhoneNumber.Text = "";
            textBoxAddress.Text = "";
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Lấy thông tin của dòng được người dùng Click
            if (e.RowIndex >= 0)
            {
                if (textBoxName.ReadOnly == false)
                    ResetButton();
                temp = new Model_Customer();
                DataGridViewRow selectRow = this.DanhsachKH.Rows[e.RowIndex];
                temp.ID = selectRow.Cells["Mã Khách Hàng"].Value.ToString();
                temp.Name = selectRow.Cells["Tên Khách Hàng"].Value.ToString();
                temp.PhoneNumber = selectRow.Cells["Số Điện Thoại"].Value.ToString();
                temp.Address = selectRow.Cells["Địa Chỉ"].Value.ToString();
                textBoxID.Text = temp.ID;
                textBoxName.Text = temp.Name;
                textBoxPhoneNumber.Text = temp.PhoneNumber;
                textBoxAddress.Text = temp.Address;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //Xóa Đối tượng được lựa chọn
           if(temp != null)
           {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa Khách Hàng này ? ", "Thông Báo", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;
                else
                {
                    try
                    {
                        GlobalConfig.Connection.DeleteCustomer(temp);
                        MessageBox.Show("Xóa Thành Công", "Thông Báo", MessageBoxButtons.OK);
                        temp = null;
                        ClearData();
                        WireData();
                    }
                    catch
                    {
                        MessageBox.Show("Có lỗi Xóa không thành công ", "Thông Báo", MessageBoxButtons.OK);
                    }
                }
            }
           else
                MessageBox.Show("Hãy chọn 1 hàng trên danh sách ", "Thông Báo", MessageBoxButtons.OK,MessageBoxIcon.Error);
  
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text != "")
            {
                buttonSave.Visible = true;
                textBoxName.ReadOnly = false;
                textBoxPhoneNumber.ReadOnly = false;
                textBoxAddress.ReadOnly = false;
            }
            else
                MessageBox.Show("Chưa có thông tin gì trên bảng thông tin KHÔNG thể sửa ", "Thông Báo", MessageBoxButtons.OK);

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Model_Customer model = new Model_Customer(textBoxName.Text,textBoxAddress.Text,textBoxPhoneNumber.Text);
            model.ID = textBoxID.Text;
            try
            {
                GlobalConfig.Connection.UpdateCustomer(model);
                MessageBox.Show($"Sửa thông tin khách hàng mã {model.ID} thành công", "Thông Báo", MessageBoxButtons.OK);
                ResetButton();
                WireData();
                buttonSave.Visible = false;
            }
            catch
            {
                MessageBox.Show("Có lỗi Sửa không thành công ", "Thông Báo", MessageBoxButtons.OK);
            }
            
        }
     
        private void textBoxFind_TextChanged(object sender, EventArgs e)
        {
            if (textBoxFind.Text == "")
            {
                WireData();
            }
            else
            {
                DataTable table = new DataTable();
                try
                {
                    if (comboBox1.Text != "--- Tìm Kiếm ---")
                    {
                        if (comboBox1.Text == "Tìm Kiếm Theo Tên Khách")
                        {
                            table = GlobalConfig.Connection.FindCustomerByName($"{textBoxFind.Text.Trim()}");
                        }
                        else if (comboBox1.Text == "Tìm Kiếm Theo Mã Khách")
                        {
                            table = GlobalConfig.Connection.FindCustomerByID(textBoxFind.Text);
                        }
                    }
                    if (table.Rows.Count > 0)
                    {
                        DanhsachKH.DataSource = null;
                        DanhsachKH.DataSource = table;
                        DanhsachKH.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                        DanhsachKH.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                        DanhsachKH.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                        DanhsachKH.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }
                    else
                        if (comboBox1.Text == "--- Tìm Kiếm ---")
                        {
                            MessageBox.Show("Hãy Chọn cách thức tìm kiếm", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Error);
                            textBoxFind.Text = "";
                        }

                }
                catch (Exception b)
                {
                    MessageBox.Show($"Xảy ra lỗi trong quá trình tìm kiếm {b} ", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }

        private void buttonThêm_Click(object sender, EventArgs e)
        {
            AddCustomer a = new AddCustomer();
            a.ShowDialog();
            WireData();
        }

        private void loadDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WireData();
        }
    }
}
