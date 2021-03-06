﻿using StoreLibrary;
using StoreLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
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
            if (e.RowIndex >= 0)
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
                catch (Exception t)
                {
                    MessageBox.Show($"Co loi xay ra{t.ToString()}");
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

        private void buttonSua_Click(object sender, EventArgs e)
        {
            string ID, Name, Cate, Size, material, color, objectt, season, manu, quantity, pic = "Khong co anh", entryPrice, sellPrice;
            Model_Product pro = null;
            DataGridViewRow d = DanhsachSP.CurrentRow;
            if (d.Index >= 0)
            {
                //Lấy thông tin từ datagrid view
                ID = d.Cells[0].Value.ToString();
                Name = d.Cells[1].Value.ToString();
                Cate = d.Cells[2].Value.ToString();
                Size = d.Cells[3].Value.ToString();
                material = d.Cells[4].Value.ToString();
                color = d.Cells[5].Value.ToString();
                objectt = d.Cells[6].Value.ToString();
                season = d.Cells[7].Value.ToString();
                manu = d.Cells[8].Value.ToString();
                quantity = d.Cells[9].Value.ToString();
                entryPrice = d.Cells[10].Value.ToString();
                sellPrice = d.Cells[11].Value.ToString();
                try
                {
                    pic = GlobalConfig.Connection.find_anh(ID);
                }
                catch
                {

                }
                //cho thông tin vào 1 đối tượng
                pro = new Model_Product(ID, Name, Cate, Size, material, color, objectt, season, manu, quantity, entryPrice, sellPrice, pic);
                //truyền đối tượng sang form addproduct để update :)
                AddProduct a = new AddProduct(pro);
                a.Text = "Sửa sản Phẩm";
                a.ShowDialog();
                WireData();
            }

        }
        private void DanhsachSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    string picture = GlobalConfig.Connection.find_anh(DanhsachSP.Rows[e.RowIndex].Cells[0].Value.ToString());
                    if (picture != "Khong co anh")
                    {
                        int index = System.Reflection.Assembly.GetExecutingAssembly().Location.IndexOf("bin");
                        string resource = System.Reflection.Assembly.GetExecutingAssembly().Location.Substring(0, index) + @"Resources\" + picture;
                        pictureBox1.Image = new Bitmap(resource);
                    }
                    else
                    {
                        int index = System.Reflection.Assembly.GetExecutingAssembly().Location.IndexOf("bin");
                        string resource = System.Reflection.Assembly.GetExecutingAssembly().Location.Substring(0, index) + @"Resources\" + "macdinh.png";
                        pictureBox1.Image = new Bitmap(resource);
                    }
                    return;
                }
                catch
                {
                    MessageBox.Show("Loi dau do");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Filter = "";
            if (textBoxID.Text != "")
                Filter += $"Product.ID LIKE '%' + '{textBoxID.Text}' + '%' and ";
            if (textBoxName.Text != "")
                Filter += $"Product.Name LIKE '%' + N'{textBoxName.Text}' + '%' and ";
            if (textBoxCate.Text != "")
                Filter += $"Category.Name LIKE '%' + N'{textBoxCate.Text}' + '%' and ";
            if (textBoxSize.Text != "")
                Filter += $"Size.Size LIKE '%' + N'{textBoxSize.Text}' + '%' and ";
            if (textBoxMaterial.Text != "")
                Filter += $"RawMaterial.Name LIKE '%' + N'{textBoxMaterial.Text}' + '%' and ";
            if (textBoxColor.Text != "")
                Filter += $"Color.Name LIKE '%' + N'{textBoxColor.Text}' + '%' and ";
            if (textBoxObject.Text != "")
                Filter += $"Object.Name LIKE '%' + N'{textBoxObject.Text}' + '%' and ";
            if (textBoxSeason.Text != "")
                Filter += $"Season.Name LIKE '%' + N'{textBoxSeason.Text}'+ '%' and ";
            if (textBoxManufac.Text != "")
                Filter += $"Manufactured.Name LIKE '%' + N'{textBoxManufac.Text}' + '%' and ";
            if (Filter.Length > 0)
            {
                try
                {
                    DanhsachSP.DataSource = GlobalConfig.Connection.FindProduct(Filter);
                }
                catch
                {

                }
            }
            else
                return;
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxCate.Text = "";
                textBoxColor.Text = "";
                textBoxID.Text = "";
                textBoxManufac.Text = "";
                textBoxMaterial.Text = "";
                textBoxName.Text = "";
                textBoxObject.Text = "";
                textBoxSize.Text = "";
                textBoxSeason.Text = "";
                DanhsachSP.DataSource = GlobalConfig.Connection.GetProductss();
            }
            catch
            {

            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow d = DanhsachSP.CurrentRow;
            if (d.Index >= 0)
            {              
                string ID;
                if (MessageBox.Show("Bạn Có Chắc muôn xóa sản phẩm này ", "Announcement", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        if (d.Index >= 0)
                        {
                            ID = d.Cells[0].Value.ToString();
                            Model_Product a = new Model_Product();
                            a.ID = ID;
                            GlobalConfig.Connection.DeleteProduct(a);
                            WireData();
                            MessageBox.Show("Xóa Thành Công Sản Phẩm ");
                        }
                    }
                    catch(Exception t)
                    {
                        MessageBox.Show($"xóa Không thành công  {t.Message}");
                    }
                }

            }
        }
    }
}
