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
    public partial class CF_Products : Form
    {

        public CF_Products()
        {
            InitializeComponent();
            WireData();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        private void WireData()
        {
            List<Model_Color> listColor = GlobalConfig.Connection.GetAllColor();
            DanhsachMau.DataSource = listColor;
            List<Model_RawMaterial> listCL = GlobalConfig.Connection.GetModel_RawMaterials();
            DanhsachCL.DataSource = listCL;
            List<Model_Object> listObj = GlobalConfig.Connection.GetAllObject();
            DanhsachDoiTuong.DataSource = listObj;
            List<Model_Manufactured> listNSX = GlobalConfig.Connection.GetAllManufactured();
            DanhsachNSX.DataSource = listNSX;
            List<Model_Season> listSS = GlobalConfig.Connection.GetAllSeason();
            DanhsachMua.DataSource = listSS;
            List<Model_Category> listLoai = GlobalConfig.Connection.GetAllCategory();
            DanhsachLoai.DataSource = listLoai;
            List<Model_Size> listSize = GlobalConfig.Connection.GetAllSize();
            DanhsachKichCo.DataSource = listSize;

            DataTable tbSanPham = GlobalConfig.Connection.GetAllProducts();
            DanhsachSP.DataSource = tbSanPham;
        }

        private void DanhsachMau_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                txtMaMau.Text = DanhsachMau.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenMau.Text = DanhsachMau.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void btnSuaMau_Click(object sender, EventArgs e)
        {
            Model_Color cl = new Model_Color();
            cl.ID = int.Parse(txtMaMau.Text);
            cl.Name = txtTenMau.Text;
            GlobalConfig.Connection.UpdateColor(cl);
            WireData();
        }

        private void btnThemMau_Click(object sender, EventArgs e)
        {
            Add themmau = new Add(2);
            themmau.ShowDialog();
            WireData();
        }

        private void btnXoaMau_Click(object sender, EventArgs e)
        {
            if (txtMaMau.Text != "")
            {
                try
                {
                    Model_Color cl = new Model_Color();
                    cl.ID = int.Parse(txtMaMau.Text);
                    cl.Name = txtTenMau.Text;
                    GlobalConfig.Connection.DeleteColor(cl);
                    WireData();
                }
                catch (Exception t ){ MessageBox.Show($"Co loi xay ra{t.ToString()}");
                }
            }
            else MessageBox.Show("Hay chon mau can xoa");
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            AddProduct themSP = new AddProduct();
            themSP.ShowDialog();
            WireData();
        }
    }
}
