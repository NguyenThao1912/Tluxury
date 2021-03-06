﻿using StoreLibrary;
using StoreLibrary.Models;
using System;
using System.Windows.Forms;

namespace TLuxury.Forms
{
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private bool ValidateForm()
        {
            if (textBoxName.Text == "")
            {
                MessageBox.Show("Tên Khách Hàng Không được để trống ! ", "Thông Báo", MessageBoxButtons.OK);
                return false;
            }
            if (textBoxAddress.Text == "")
            {
                MessageBox.Show("Địa Chỉ Không được để trống ! ", "Thông Báo", MessageBoxButtons.OK);
                return false;
            }
            if (textBoxPhoneNumber.Text == "")
            {
                MessageBox.Show("Số điện thoại Không được để trống ! ", "Thông Báo", MessageBoxButtons.OK);
                return false;
            }
            if (textBoxPhoneNumber.Text.Length < 10)
            {
                MessageBox.Show("Số điện thoại Phải có ít nhất 10 số ! ", "Thông Báo", MessageBoxButtons.OK);
                return false;
            }
            if (textBoxPhoneNumber.Text.Length > 15)
            {
                MessageBox.Show("Số điện thoại không được quá 15 số ! ", "Thông Báo", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void textBoxPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                Model_Customer model = new Model_Customer(textBoxName.Text, textBoxAddress.Text, textBoxPhoneNumber.Text);
                try
                {
                    GlobalConfig.Connection.InsertNewCustomer(model);
                    MessageBox.Show("Thêm Thành công", "Thông báo", MessageBoxButtons.OK);
                    this.Dispose();
                }
                catch
                {
                    MessageBox.Show("Có lỗi xảy ra khi truy vấn SQL liên hệ thảo fix ", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }
    }
}
