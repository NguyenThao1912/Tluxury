﻿using StoreLibrary;
using StoreLibrary.Models;
using System;
using System.Windows.Forms;

namespace TLuxury.Forms
{
    public partial class AddSupplier : Form
    {
        public AddSupplier()
        {
            InitializeComponent();
        }
        private bool ValidateForm()
        {
            if (textBoxName.Text == "")
            {
                MessageBox.Show("Tên Nhà Cung Cấp Không được để trống ! ", "Thông Báo", MessageBoxButtons.OK);
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
            return true;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                Model_Supplier model = new Model_Supplier(textBoxName.Text, textBoxAddress.Text, textBoxPhoneNumber.Text);
                //Chạy lệnh SQL
                try
                {
                    GlobalConfig.Connection.InsertNewSupplier(model);
                }
                catch
                {

                }
                MessageBox.Show("Nhập Thành Công", "Thông Báo", MessageBoxButtons.OK);
                this.Dispose();
            }
        }

        private void textBoxPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
