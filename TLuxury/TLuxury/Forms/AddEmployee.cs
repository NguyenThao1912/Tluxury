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
    public partial class AddEmployee : Form
    {
        Add child;
        public AddEmployee()
        {
            InitializeComponent();
            WireData();
        }
        private void WireData()
        {
            List<Model_Role> model = GlobalConfig.Connection.GetAllRole();
            cbxRole.DataSource = null;
            cbxRole.DataSource = model;
            cbxRole.DisplayMember = "Name";
            cbxRole.SelectedIndex = -1;
        }
        private bool ValidateForm()
        {
            if(textBoxFirstName.Text == "")
            {
                MessageBox.Show("Tên không được để trống", "Thông Báo", MessageBoxButtons.OK);
                return false;
            }
            if(textBoxLastName.Text == "")
            {
                MessageBox.Show("Họ Không được để trống", "Thông Báo", MessageBoxButtons.OK);
                return false;
            }
            if(textBoxPhoneNumber.Text =="")
            {
                MessageBox.Show("Số điện thoại không được để trống", "Thông Báo", MessageBoxButtons.OK);
                return false;
            }
            if(textBoxAddress.Text == "")
            {
                MessageBox.Show("Địa chỉ không được để trống", "Thông Báo", MessageBoxButtons.OK);
                return false;
            }
            if(textBoxPhoneNumber.Text.Length <10)
            {
                MessageBox.Show("Số Điện Thoại Phải có >10 số", "Thông Báo", MessageBoxButtons.OK);
                return false;             
            }
            if(rbFeMale.Checked ==false && rbMale.Checked == false)
            {
                MessageBox.Show("hãy Tích vào giới tính", "Thông Báo", MessageBoxButtons.OK);
                return false;
            }
            if(cbxRole.SelectedIndex == -1)
            {
                MessageBox.Show("Chức vụ không được để trống", "Thông Báo", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void buttonAddRole_Click(object sender, EventArgs e)
        {
            child = new Add(8);
            child.ShowDialog();
            WireData();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if(ValidateForm())
            {
                char Sex;
                if (rbMale.Checked == true) Sex = 'M';
                else Sex = 'F';
                Model_Role role = (Model_Role)cbxRole.SelectedItem;
                Model_Employee model = new Model_Employee(textBoxFirstName.Text,
                    textBoxLastName.Text,
                    Sex,dateTimePicker1.Value.Date,
                    textBoxPhoneNumber.Text,
                    textBoxAddress.Text,
                    role);
                try
                {
                    GlobalConfig.Connection.InsertNewEmployee(model);
                }
                catch
                {
                    MessageBox.Show("Lỗi Thêm Nhân viên vào Database Liên hệ Thảo để fix :)", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Thêm nhân viên Thành công", "Thông Báo", MessageBoxButtons.OK);
                this.Dispose();
            }

        }
    }
}
