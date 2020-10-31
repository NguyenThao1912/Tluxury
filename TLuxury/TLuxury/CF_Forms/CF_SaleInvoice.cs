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
    public partial class CF_HOADON : Form
    {
        public CF_HOADON()
        {
            InitializeComponent();
            
        }
        private void WireData()
        {
            try
            {
                DataTable table = new DataTable();
                DateTime start = DateStart.Value.AddDays(-1);
                DateTime end = DateEnd.Value;
                table = GlobalConfig.Connection.GetAllEntryBills(start, end);
                DanhsachHoaDon.DataSource = null;
                DanhsachHoaDon.DataSource = table;
            }
            catch (Exception t)
            {
                MessageBox.Show($"Lỗi câu lenh SQL Dòng 35 {t}");
            }

        }
    }
}
