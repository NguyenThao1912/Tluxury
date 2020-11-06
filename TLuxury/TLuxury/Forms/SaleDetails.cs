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
    public partial class SaleDetails : Form
    {
        string ID;
        string dayentry;
        public SaleDetails(string id, string Dayentry)
        {
            ID = id;
            dayentry = Dayentry;
            InitializeComponent();
            WireData();
        }
        private void WireData()
        {
            int quantity;
            decimal money;
            string CusName;

            try
            {
                DataTable table = GlobalConfig.Connection.GetAllSaleDetails(ID, out quantity, out money, out CusName);
                labelID.Text = "Mã Hóa Đơn : " + ID.ToString();
                labelName.Text = "Tên Khách Hàng : " + CusName;
                labelTotal.Text = "Tổng Tiền : " + money.ToString("N0", System.Globalization.CultureInfo.GetCultureInfo("de")) + " VND";
                labelQuantity.Text = "Số Lượng Sản Phẩm : " + quantity.ToString();
                labelDay.Text = "Ngày Nhập : " + dayentry.ToString();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = table;
            }
            catch (ApplicationException)
            {
                MessageBox.Show($" Lỗi Hóa Đơn Không có Sản phẩm nào ");

            }
            catch (Exception e)
            {
                MessageBox.Show($"Lỗi sql {e}");
            }
        }
    }
}
