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
    public partial class CF_Employee : Form
    {
        public CF_Employee()
        {
            InitializeComponent();
            WireData();
        }
        private void WireData()
        {
            DataTable table = GlobalConfig.Connection.GetAllEmployees();
            DanhsachNhanVien.DataSource = null;
            DanhsachNhanVien.DataSource = table;


        }
    }
}
