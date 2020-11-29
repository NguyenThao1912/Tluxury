using StoreLibrary;
using System;
using System.Data;
using System.Windows.Forms;

namespace TLuxury.Forms
{
    public partial class EntryDetails : Form
    {
        int quantity;
        decimal money;
        string ID;
        string SupplierName;
        string dayentry;
        public EntryDetails(string id, string Dayentry)
        {
            ID = id;
            dayentry = Dayentry;
            InitializeComponent();
            WireData();
        }
        private void WireData()
        {
            try
            {
                DataTable table = GlobalConfig.Connection.GetAllEntryDetails(ID, out quantity, out money, out SupplierName);
                labelID.Text = "Mã Hóa Đơn : " + ID.ToString();
                labelName.Text = "Tên Nhà Cung Cấp : " + SupplierName;
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

        private void EntryDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
