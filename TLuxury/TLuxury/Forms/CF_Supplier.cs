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
    public partial class CF_Supplier : Form
    {
        public CF_Supplier()
        {
            InitializeComponent();
            WireData();
        }
        private void WireData()
        {
            DataTable model = GlobalConfig.Connection.GetAllSuppliers();
            DanhsachNCC.DataSource = null;
            DanhsachNCC.DataSource = model;
            DanhsachNCC.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DanhsachNCC.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DanhsachNCC.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DanhsachNCC.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void ResetButton()
        {
            textBoxName.ReadOnly = true;
            textBoxPhoneNumber.ReadOnly = true;
            textBoxAddress.ReadOnly = true;
            buttonSave.Visible = false;
        }
        private void ClearData()
        {
            textBoxID.Text = "";
            textBoxName.Text = "";
            textBoxPhoneNumber.Text = "";
            textBoxAddress.Text = "";
        }
        private void buttonThêm_Click(object sender, EventArgs e)
        {
            AddSupplier sup = new AddSupplier();
            sup.ShowDialog();
            WireData();
        }
    }
}
