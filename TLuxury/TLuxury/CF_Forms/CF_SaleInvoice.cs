using StoreLibrary;
using System;
using System.Data;
using System.Windows.Forms;

namespace TLuxury.Forms
{
    public partial class CF_HOADON : Form
    {
        public CF_HOADON()
        {
            InitializeComponent();
            WireData();
            comboBox1.SelectedIndex = 0;
        }
        private void WireData()
        {
            try
            {
                DataTable table = new DataTable();
                DateTime start = DateStart.Value.AddDays(-1);
                DateTime end = DateEnd.Value;
                table = GlobalConfig.Connection.GetAllSellBills(start, end);
                DanhsachHoaDon.DataSource = null;
                DanhsachHoaDon.DataSource = table;
            }
            catch (Exception t)
            {
                MessageBox.Show($"Lỗi câu lenh SQL Dòng 35 {t}");
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
                    //=================================== Hóa đơn bán ======================================================
                    if (comboBox1.Text != "--- Tìm Kiếm ---")
                    {
                        if (comboBox1.Text == "Tìm Theo Tên Khách Hàng")
                        {
                            try
                            {
                                table = GlobalConfig.Connection.FindSaleInvoiceBy_CusName($"{textBoxFind.Text.Trim()}");
                            }
                            catch (Exception t)
                            {
                                MessageBox.Show($"Lỗi câu lenh SQL  {t}");
                            }
                        }
                        else if (comboBox1.Text == "Tìm Theo Mã Hóa Đơn")
                        {
                            try
                            {
                                table = GlobalConfig.Connection.FindSaleInvoiceBy_ID($"{textBoxFind.Text.Trim()}");
                            }
                            catch (Exception t)
                            {
                                MessageBox.Show($"Lỗi câu lenh SQL  {t}");
                            }
                        }
                        else if (comboBox1.Text == "Tìm Theo Tên Nhân Viên")
                        {
                            try
                            {
                                table = GlobalConfig.Connection.FindSaleInvoiceBy_EmName($"{textBoxFind.Text.Trim()}");
                            }
                            catch (Exception t)
                            {
                                MessageBox.Show($"Lỗi câu lenh SQL  {t}");
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

        private void DanhsachHoaDon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            SaleDetails f = new SaleDetails(DanhsachHoaDon.Rows[e.RowIndex].Cells["Mã Hóa Đơn"].Value.ToString(), DanhsachHoaDon.Rows[e.RowIndex].Cells["Ngày Bán"].Value.ToString());
            f.ShowDialog();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            MainForm.Intance.OpenChildForm(new CF_BANHANG(), (Button)sender);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Có Chắc muốn xóa hóa đơn này ", "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    string id = DanhsachHoaDon.CurrentRow.Cells[0].Value.ToString();
                    GlobalConfig.Connection.DeleteSaleInvoice(id);
                    WireData();
                    MessageBox.Show($"Xóa Thành công hóa đơn mã {id}");
                }
                catch
                {
                    MessageBox.Show("Lỗi Không Xóa được");
                }
            }
        }
    }
}
