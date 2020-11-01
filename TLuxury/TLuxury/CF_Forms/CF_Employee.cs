﻿using StoreLibrary;
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
        }
        private void WireData()
        {
            DataTable table = GlobalConfig.Connection.GetAllEmployees();
            DanhsachNhanVien.DataSource = null;
            DanhsachNhanVien.DataSource = table;
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

        private void buttonSave_Click(object sender, EventArgs e)
        {
            DeActiveBtn();
        }
    }
}
