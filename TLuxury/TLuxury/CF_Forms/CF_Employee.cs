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
    public partial class CF_Employee : Form
    {
        Model_Employee model = new Model_Employee();
        string rolename;
        public CF_Employee()
        {
            InitializeComponent();
            WireData();
            LoadRole();
            comboBox1.SelectedIndex = 0;
        }
        private void WireData()
        {
            try
            {
                DataTable table = GlobalConfig.Connection.GetAllEmployees();
                DanhsachNhanVien.DataSource = null;
                DanhsachNhanVien.DataSource = table;
            }
            catch(Exception t)
            {
                MessageBox.Show($"Lỗi SQL line 36 {t}", "Thông báo");
            }
        }
        private void LoadRole()
        {
            try
            {
                List<Model_Role> model = GlobalConfig.Connection.GetAllRole();
                comboBoxRole.DataSource = null;
                comboBoxRole.DataSource = model;
                comboBoxRole.DisplayMember = "Name";
                comboBoxRole.SelectedIndex = -1;
            }
            catch
            {
                MessageBox.Show("Lỗi lấy dữ liệu chức vụ", "Thông báo");
            }

        }
        private void ClearText()
        {
            textBoxAddress.Text = "";
            textBoxID.Text = "";
            textBoxName.Text = "";
            textBoxPhoneNumber.Text = "";
            radioButtonNam.Checked = false;
            radioButtonNu.Checked = false;
            comboBoxRole.SelectedIndex = -1;
        }
        private void FillText(string id,string name,char gender,DateTime dateofbirth,string phonenumber,string rolename,string add)
        {
            textBoxID.Text = id;
            textBoxName.Text = name;
            textBoxAddress.Text = add;
            comboBoxRole.Text = rolename;
            textBoxPhoneNumber.Text = phonenumber;
            dateOfbirth.Value = dateofbirth;
            if (gender == 'M') radioButtonNam.Checked = true;
            else radioButtonNu.Checked = true;
        }
        private void ActiveBtn()
        {
            textBoxAddress.ReadOnly = false;
            textBoxName.ReadOnly = false;
            textBoxPhoneNumber.ReadOnly = false;
            comboBoxRole.Enabled = true;
            dateOfbirth.Enabled = true;
            radioButtonNam.Enabled = true;
            radioButtonNu.Enabled = true;
        }
        private void DeActiveBtn()
        {
            textBoxAddress.ReadOnly = true;
            textBoxName.ReadOnly = true;
            textBoxPhoneNumber.ReadOnly = true;
            comboBoxRole.Enabled = false;
            dateOfbirth.Enabled = false;
            radioButtonNam.Enabled = false;
            radioButtonNu.Enabled = false;
        }
        private void DanhsachNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {               
                DataGridViewRow selectRow = this.DanhsachNhanVien.Rows[e.RowIndex];
                model.ID = selectRow.Cells["Mã Nhân Viên"].Value.ToString();
                model.Name = selectRow.Cells["Tên Nhân Viên"].Value.ToString();
                if (selectRow.Cells["Giới Tính"].Value.ToString() == "Nam")
                    model.Sex = 'M';
                else
                    model.Sex = 'F';
                model.DateOfBirth = DateTime.Parse(selectRow.Cells["Ngày Sinh"].Value.ToString());
                model.PhoneNumber = selectRow.Cells["Số Điện Thoại"].Value.ToString();
                rolename = selectRow.Cells["Tên Chức Vụ"].Value.ToString();
                model.Address = selectRow.Cells["Địa Chỉ"].Value.ToString();
                FillText(model.ID, model.Name, model.Sex, model.DateOfBirth, model.PhoneNumber, rolename, model.Address);
            }
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            ActiveBtn();
            buttonSave.Visible = true;

        }
        private bool Validation()
        {
            if(textBoxName.Text == "")
            {
                MessageBox.Show("Tên Không được để trống", "Thông Báo", MessageBoxButtons.OK);
                return false;
            }
            if(textBoxPhoneNumber.Text =="")
            {
                MessageBox.Show("Số điện thoại không được để trống", "Thông Báo", MessageBoxButtons.OK);
                return false;
            }
            if(DateTime.Now.Year - dateOfbirth.Value.Year <18)
            {
                MessageBox.Show("Chỉ nhận nhân viên trên 18 tuổi", "Thông Báo", MessageBoxButtons.OK);
                return false;
            }
            if(comboBoxRole.Text == "")
            {
                MessageBox.Show("Cần chọn chức vụ cho nhân viên", "Thông Báo", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if(Validation())
            {
                Model_Employee em = new Model_Employee();
                Model_Role role = new Model_Role();
                em.ID = textBoxID.Text;
                em.Name = textBoxName.Text;
                em.DateOfBirth = dateOfbirth.Value;
                em.Address = textBoxAddress.Text;
                em.PhoneNumber = textBoxPhoneNumber.Text;
                role = (Model_Role)comboBoxRole.SelectedItem;
                em.Role = role;
                if (radioButtonNam.Checked == true)
                    em.Sex = 'M';
                else
                    em.Sex = 'F';
                try
                {
                    GlobalConfig.Connection.UpdateEmployee(em);
                    WireData();
                }
                catch(Exception t)
                {
                    MessageBox.Show($"Lỗi không update được  {t}");
                }
                finally
                {
                    DeActiveBtn();
                }

            }
      
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            AddEmployee add = new AddEmployee();
            add.ShowDialog();
            WireData();
        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {
            DeActiveBtn();
        }

        private void textBoxPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text == "")
            {
                MessageBox.Show("hãy chọn vào 1 nhân viên trên danh sách", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if(MessageBox.Show("Bạn có chắc muốn xóa nhân viên này","Thông Báo",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    GlobalConfig.Connection.DeleteEmployee(textBoxID.Text);
                    WireData();
                    ClearText();
                    MessageBox.Show($"Xóa Thành Công Nhân viên MÃ {textBoxID.Text}", "Thông Báo", MessageBoxButtons.OK);
                }
                catch
                {
                    MessageBox.Show("Có Lỗi Không xóa được");
                }
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
                        if (comboBox1.Text == "Tìm Kiếm Theo Tên Nhân Viên")
                        {
                            table = GlobalConfig.Connection.FindEmployeeBy_Name($"{textBoxFind.Text.Trim()}");
                        }
                        else if (comboBox1.Text == "Tìm Kiếm Theo Mã Nhân Viên")
                        {
                            table = GlobalConfig.Connection.FindEmployeeBy_ID(textBoxFind.Text);
                        }
                    }
                    if (table.Rows.Count > 0)
                    {
                        DanhsachNhanVien.DataSource = null;
                        DanhsachNhanVien.DataSource = table;
                    }
                    else
                        if (comboBox1.Text == "--- Tìm Kiếm ---")
                        {
                            MessageBox.Show("Hãy Chọn cách thức tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            textBoxFind.Text = "";
                        }
                }
                catch (Exception b)
                {
                    MessageBox.Show($"Xảy ra lỗi trong quá trình tìm kiếm {b} ", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }
    }
}
