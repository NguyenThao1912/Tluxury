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
    public partial class CF_Supplier : Form
    {
        Model_Supplier temp;
        public CF_Supplier()
        {
            InitializeComponent();
            WireData();
            comboBox1.SelectedItem = "--- Tìm Kiếm ---";
        }
        private void WireData()
        {
            DataTable model = GlobalConfig.Connection.GetAllSuppliers();
            DanhsachNCC.DataSource = null;
            DanhsachNCC.DataSource = model;
            DanhsachNCC.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DanhsachNCC.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DanhsachNCC.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DanhsachNCC.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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
        private void buttonThêm_Click(object sender, EventArgs e)
        {
            AddSupplier sup = new AddSupplier();
            sup.ShowDialog();
            WireData();
        }
        private void DanhsachNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (textBoxName.ReadOnly == false)
                    ResetButton();
                temp = new Model_Supplier();
                DataGridViewRow selectRow = this.DanhsachNCC.Rows[e.RowIndex];
                temp.ID = selectRow.Cells["Mã Nhà Cung Cấp"].Value.ToString();
                temp.Name = selectRow.Cells["Tên Nhà Cung Cấp"].Value.ToString();
                temp.PhoneNumber = selectRow.Cells["Số Điện Thoại"].Value.ToString();
                temp.Address = selectRow.Cells["Địa Chỉ"].Value.ToString();
                textBoxID.Text = temp.ID;
                textBoxName.Text = temp.Name;
                textBoxPhoneNumber.Text = temp.PhoneNumber;
                textBoxAddress.Text = temp.Address;
            }
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
            Model_Supplier model = new Model_Supplier(textBoxName.Text, textBoxAddress.Text, textBoxPhoneNumber.Text);
            model.ID = textBoxID.Text;
            try
            {
                GlobalConfig.Connection.UpdateSupplier(model);
                MessageBox.Show($"Sửa thông tin Nhà Cung Cấp mã {model.ID} thành công", "Thông Báo", MessageBoxButtons.OK);
                ResetButton();
                WireData();
                buttonSave.Visible = false;
            }
            catch
            {
                MessageBox.Show("Có lỗi Sửa không thành công ", "Thông Báo", MessageBoxButtons.OK);
            }
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (temp != null)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa Nhà Cung Cấp này ? ", "Thông Báo", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;
                else
                {
                    try
                    {
                        GlobalConfig.Connection.DeleteSupplier(temp);
                        temp = null;
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
                MessageBox.Show("Hãy chọn 1 hàng trên danh sách ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        if (comboBox1.Text == "Tìm Theo Tên NCC")
                        {
                            table = GlobalConfig.Connection.FindSupplierByName($"{textBoxFind.Text.Trim()}");
                        }
                        else if (comboBox1.Text == "Tìm Theo Mã NCC")
                        {
                            table = GlobalConfig.Connection.FindSupplierByID(textBoxFind.Text);
                        }
                    }
                    if (table.Rows.Count > 0)
                    {
                        DanhsachNCC.DataSource = null;
                        DanhsachNCC.DataSource = table;
                        DanhsachNCC.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                        DanhsachNCC.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                        DanhsachNCC.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                        DanhsachNCC.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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
        private void ItemNum1_Click(object sender, EventArgs e)
        {
            WireData();
        }

        private void comboBox1_MouseLeave(object sender, EventArgs e)
        {
            textBoxFind.Text = "";
        }
    }
}
