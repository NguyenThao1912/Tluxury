using StoreLibrary;
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
    public partial class CF_EntryInvoice : Form
    {
        public CF_EntryInvoice()
        {
            InitializeComponent();
            WireData();
            comboBox1.SelectedItem = "--- Tìm Kiếm ---";
        }
        private void WireData()
        {
            try
            {              
                DateTime start = DateStart.Value.AddDays(-1);
                DateTime end = DateEnd.Value.AddDays(1);
                DataTable table = GlobalConfig.Connection.GetAllEntryBills(start, end);
                DanhsachHoaDon.DataSource = null;
                DanhsachHoaDon.DataSource = table;
            }
            catch (Exception t)
            {
                MessageBox.Show($"Lỗi câu lenh SQL Dòng 35 {t}");
            }
        }

        private void DateStart_ValueChanged(object sender, EventArgs e)
        {
            if (DateEnd.Value < DateStart.Value)
                DateStart.Value = new DateTime(2020, 1, 1);           
            WireData();
        }

        private void DateEnd_ValueChanged(object sender, EventArgs e)
        {
            if (DateEnd.Value < DateStart.Value)
                DateEnd.Value = DateTime.Today;
            WireData();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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
                        if (comboBox1.Text == "Tìm Theo Tên Nhà Cung Cấp")
                        { 
                            try
                            {
                                table = GlobalConfig.Connection.FindEntryInvoiceBySupplierName($"{textBoxFind.Text.Trim()}");
                            }
                            catch(Exception t)
                            {
                                MessageBox.Show($"Lỗi câu lenh SQL Dòng 70 {t}");
                            }
                        }
                        else if (comboBox1.Text == "Tìm Theo Mã Hóa Đơn")
                        {
                            try
                            {
                                table = GlobalConfig.Connection.FindEntryInvoiceByID($"{textBoxFind.Text.Trim()}");
                            }
                            catch (Exception t)
                            {
                                MessageBox.Show($"Lỗi câu lenh SQL Dòng 81 {t}");
                            }
                        }
                        else if (comboBox1.Text == "Tìm Theo Tên Nhân Viên")
                        {
                            try
                            {
                                table = GlobalConfig.Connection.FindEntryInvoiceByEmployeeName($"{textBoxFind.Text.Trim()}");
                            }
                            catch (Exception t)
                            {
                                MessageBox.Show($"Lỗi câu lenh SQL Dòng 92 {t}");
                            }
                        }
                    }
                    if (table.Rows.Count > 0)
                    {
                        DanhsachHoaDon.DataSource = null;
                        DanhsachHoaDon.DataSource = table;
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

        private void DanhsachHoaDon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            EntryDetails f = new EntryDetails(DanhsachHoaDon.Rows[e.RowIndex].Cells["Mã Hóa Đơn"].Value.ToString(), DanhsachHoaDon.Rows[e.RowIndex].Cells["Ngày Nhập"].Value.ToString());
            f.ShowDialog();          
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            AddEntryInvoice entry = new AddEntryInvoice();
            entry.ShowDialog();
            WireData();
        }
    }
}
