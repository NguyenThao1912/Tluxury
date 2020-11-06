using StoreLibrary;
using StoreLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace TLuxury.Forms
{
    public partial class CF_Products : Form
    {
        public CF_Products()
        {
            InitializeComponent();
            WireData();
            comboBox1.SelectedIndex = 0;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        private void WireData()
        {
            try
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
                DataTable tbSanPham = GlobalConfig.Connection.GetProductss();
                DanhsachSP.DataSource = tbSanPham;
            }
            catch
            {

            }
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
            try
            {
                GlobalConfig.Connection.UpdateColor(cl);
            }
            catch
            {

            }
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
        private void DanhsachCL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMaCL.Text = DanhsachCL.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenCL.Text = DanhsachCL.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }
        private void btnThemCL_Click(object sender, EventArgs e)
        {
            Add themCL = new Add(4);
            themCL.ShowDialog();
            WireData();
        }
        private void btnXoaCL_Click(object sender, EventArgs e)
        {
            if (txtMaCL.Text != "")
            {
                try
                {
                    Model_RawMaterial cl = new Model_RawMaterial();
                    cl.ID = int.Parse(txtMaCL.Text);
                    cl.Name = txtTenCL.Text;
                    GlobalConfig.Connection.DeleteMaterial(cl);
                    WireData();
                }
                catch (Exception t)
                {
                    MessageBox.Show($"Co loi xay ra{t.ToString()}");
                }
            }
            else MessageBox.Show("Hay chon Chat Lieu can xoa");
        }

        private void btnSuaCL_Click(object sender, EventArgs e)
        {
            Model_RawMaterial cl = new Model_RawMaterial();
            cl.ID = int.Parse(txtMaCL.Text);
            cl.Name = txtTenCL.Text;
            try
            {
                GlobalConfig.Connection.UpdateMaterial(cl);
            }
            catch
            {

            }
            WireData();
        }

        private void btnThemDT_Click(object sender, EventArgs e)
        {

            Add themDT = new Add(5);
            themDT.ShowDialog();
            WireData();
        }

        private void btnXoaDT_Click(object sender, EventArgs e)
        {
            if (txtMaDT.Text != "")
            {
                try
                {
                    Model_Object ob = new Model_Object();
                    ob.ID = int.Parse(txtMaDT.Text);
                    ob.Name = txtTenDT.Text;
                    GlobalConfig.Connection.DeleteObject(ob);
                    WireData();
                }
                catch (Exception t)
                {
                    MessageBox.Show($"Co loi xay ra{t.ToString()}");
                }
            }
            else MessageBox.Show("Hay chon Doi Tuong can xoa");
        }

        private void btnSuaDT_Click(object sender, EventArgs e)
        {
            Model_Object ob = new Model_Object();
            ob.ID = int.Parse(txtMaDT.Text);
            ob.Name = txtTenDT.Text;
            try
            {
                GlobalConfig.Connection.UpdateObject(ob);
            }
            catch
            {

            }
            WireData();
        }

        private void btnThemNSX_Click(object sender, EventArgs e)
        {

            Add themNSX = new Add(3);
            themNSX.ShowDialog();
            WireData();
        }

        private void btnXoaNSX_Click(object sender, EventArgs e)
        {
            if (txtMaNSX.Text != "")
            {
                try
                {
                    Model_Manufactured ob = new Model_Manufactured();
                    ob.ID = int.Parse(txtMaNSX.Text);
                    ob.Name = txtTenNSX.Text;
                    GlobalConfig.Connection.DeleteManuFactured(ob);
                    WireData();
                }
                catch (Exception t)
                {
                    MessageBox.Show($"Co loi xay ra{t.ToString()}");
                }
            }
            else MessageBox.Show("Hay chon NSX can xoa");
        }

        private void btnSuaNSX_Click(object sender, EventArgs e)
        {
            Model_Manufactured ob = new Model_Manufactured();
            ob.ID = int.Parse(txtMaNSX.Text);
            ob.Name = txtTenNSX.Text;
            try
            {
                GlobalConfig.Connection.UpdateManuFactured(ob);
            }
            catch
            {

            }
            WireData();
        }

        private void btnThemMua_Click(object sender, EventArgs e)
        {
            Add themMua = new Add(6);
            themMua.ShowDialog();
            WireData();
        }

        private void btnXoaMua_Click(object sender, EventArgs e)
        {
            if (txtMaMua.Text != "")
            {
                try
                {
                    Model_Season ob = new Model_Season();

                    ob.ID = int.Parse(txtMaMua.Text);
                    ob.Name = txtTenMua.Text;
                    GlobalConfig.Connection.DeleteSeason(ob);
                    WireData();
                }
                catch (Exception t)
                {
                    MessageBox.Show($"Co loi xay ra{t.ToString()}");
                }
            }
            else MessageBox.Show("Hay chon Mua can xoa");
        }

        private void btnSuaMua_Click(object sender, EventArgs e)
        {
            Model_Season ob = new Model_Season();
            ob.ID = int.Parse(txtMaMua.Text);
            ob.Name = txtTenMua.Text;
            try
            {
                GlobalConfig.Connection.UpdateSeason(ob);
            }
            catch
            {

            }
            WireData();
        }

        private void btnThemLoai_Click(object sender, EventArgs e)
        {
            Add themLoai = new Add(1);
            themLoai.ShowDialog();
            WireData();
        }

        private void btnXoaLoai_Click(object sender, EventArgs e)
        {
            if (txtMaLoai.Text != "")
            {
                try
                {
                    Model_Category ob = new Model_Category();

                    ob.ID = int.Parse(txtMaLoai.Text);
                    ob.Name = txtTenLoai.Text;
                    GlobalConfig.Connection.DeleteCategory(ob);
                    WireData();
                }
                catch (Exception t)
                {
                    MessageBox.Show($"Co loi xay ra{t.ToString()}");
                }
            }
            else MessageBox.Show("Hay chon Loai can xoa");
        }

        private void btnSuaLoai_Click(object sender, EventArgs e)
        {
            Model_Category ob = new Model_Category();
            ob.ID = int.Parse(txtMaLoai.Text);
            ob.Name = txtTenLoai.Text;
            try
            {
                GlobalConfig.Connection.UpdateCategory(ob);
                WireData();
            }
            catch
            {

            }
          
        }

        private void DanhsachDoiTuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMaDT.Text = DanhsachDoiTuong.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenDT.Text = DanhsachDoiTuong.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void DanhsachNSX_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMaNSX.Text = DanhsachNSX.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenNSX.Text = DanhsachNSX.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void DanhsachMua_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMaMua.Text = DanhsachMua.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenMua.Text = DanhsachMua.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void DanhsachLoai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMaLoai.Text = DanhsachLoai.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenLoai.Text = DanhsachLoai.Rows[e.RowIndex].Cells[1].Value.ToString();
            }

        }

        private void DanhsachKichCo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMaKichCo.Text = DanhsachKichCo.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenKichCo.Text = DanhsachKichCo.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void DanhsachMau_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMaMau.Text = DanhsachMau.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenMau.Text = DanhsachMau.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }
        
        private void btnThemKichCo_Click(object sender, EventArgs e)
        {
            Add themKichco = new Add(7);
            themKichco.ShowDialog();
            WireData();
        }


        private void btnXoaKichCo_Click(object sender, EventArgs e)
        {
            if (txtMaKichCo.Text != "")
            {
                try
                {
                    Model_Size ob = new Model_Size();

                    ob.ID = int.Parse(txtMaKichCo.Text);
                    ob.Size = txtTenKichCo.Text;
                    GlobalConfig.Connection.DeleteSize(ob);
                    WireData();
                  }
                catch (Exception t)
                {
                    MessageBox.Show($"Co loi xay ra{t.ToString()}");
                }
            }
            else MessageBox.Show("Hay chon Size can xoa");
        }

        private void btnSuaKichCo_Click(object sender, EventArgs e)
        {
            Model_Size ob = new Model_Size();
            ob.ID = int.Parse(txtMaKichCo.Text);
            ob.Size = txtTenKichCo.Text;
            try
            {
                GlobalConfig.Connection.UpdateSize(ob);
            }
            catch
            {

            }
            WireData();
        }


        private void buttonThêm_Click_1(object sender, EventArgs e)
        {
            AddProduct a = new AddProduct();
            a.ShowDialog();
            WireData();
        }

        private void buttonDelete_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tính năng chưa có thời gian làm thôi bỏ qua test nút khác đi wtf :)");
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
                    if (comboBox1.Text != "--- Tìm Kiếm ---")
                    {
                        if (comboBox1.Text == "Tìm Theo Mã Sản Phẩm")
                        {
                            table = GlobalConfig.Connection.FindProduct($"{textBoxFind.Text.Trim()}", 1);
                        }
                        else if (comboBox1.Text == "Tìm Theo Màu")
                        {
                            table = GlobalConfig.Connection.FindProduct($"{textBoxFind.Text.Trim()}", 2);
                        }
                        else if (comboBox1.Text == "Tìm Theo Loại Sản Phẩm")
                        {
                            table = GlobalConfig.Connection.FindProduct($"{textBoxFind.Text.Trim()}", 3);
                        }
                        else if (comboBox1.Text == "Tìm Theo Nguyên Liệu")
                        {
                            table = GlobalConfig.Connection.FindProduct($"{textBoxFind.Text.Trim()}", 4);
                        }
                        else if (comboBox1.Text == "Tìm Theo Nhà Sản Xuất")
                        {
                            table = GlobalConfig.Connection.FindProduct($"{textBoxFind.Text.Trim()}", 5);
                        }
                        else if (comboBox1.Text == "Tìm Theo Mùa")
                        {
                            table = GlobalConfig.Connection.FindProduct($"{textBoxFind.Text.Trim()}", 6);
                        }
                    }
                    if (table.Rows.Count > 0)
                    {
                        DanhsachSP.DataSource = null;
                        DanhsachSP.DataSource = table;
   
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
    }
}
