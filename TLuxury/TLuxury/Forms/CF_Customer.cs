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
        Model_Customer temp ;
        public CF_Customer()
        {
            InitializeComponent();

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

        private void CF_Customer_Load(object sender, EventArgs e)
        {
            WireData();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddCustomer a = new AddCustomer();
            a.ShowDialog();
            WireData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                temp = new Model_Customer();
                DataGridViewRow selectRow = this.DanhsachKH.Rows[e.RowIndex];
                temp.ID = selectRow.Cells["Mã KH"].Value.ToString();
                temp.Name = selectRow.Cells["Tên KH"].Value.ToString();
                temp.PhoneNumber = selectRow.Cells["Số Điện Thoại"].Value.ToString();
                temp.Address = selectRow.Cells["Địa Chỉ"].Value.ToString();
                textBoxID.Text = temp.ID;
                textBoxName.Text = temp.Name;
                textBoxPhoneNumber.Text = temp.PhoneNumber;
                textBoxAddress.Text = temp.Address;
            }
        }

        private void ClearData()
        {
            textBoxID.Text = "";
            textBoxName.Text = "";
            textBoxPhoneNumber.Text = "";
            textBoxAddress.Text = "";
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
           if(temp != null)
           {
                try 
                {
                        GlobalConfig.Connection.DeleteCustomer(temp); temp = null;
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
           else
                MessageBox.Show("Hãy chọn 1 hàng trên danh sách ", "Thông Báo", MessageBoxButtons.OK,MessageBoxIcon.Error);
  
        }
    }
}
