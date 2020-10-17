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
    public partial class AddProduct : Form
    {
        //form con
        private Add addform ;
        public AddProduct()
        {
            InitializeComponent();
            WireDataCate();
            WireDataColor();
            WireDataManufactured();
            WireDataMaterial();
            WireDataObject();
            WireDataSeason();
            WireDataSize();
        }
        private void buttonAddPicture_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            textBoxAddpicture.Text = openFileDialog1.FileName;
        }
        private void WireDataSize()
        {
            List<Model_Size> size = GlobalConfig.Connection.GetAllSize();
            cbxKichco.DataSource = null;
            cbxKichco.DataSource = size;
            cbxKichco.DisplayMember = "Size";
            cbxKichco.SelectedIndex = -1;
        }
        private void WireDataCate()
        {
            List<Model_Category> category = GlobalConfig.Connection.GetAllCategory();
            cbxSanPham.DataSource = null;
            cbxSanPham.DataSource = category;
            cbxSanPham.DisplayMember = "Name";
            cbxSanPham.SelectedIndex = -1;
        }
        private void WireDataColor()
        {
            List<Model_Color> color = GlobalConfig.Connection.GetAllColor();
            cbxMauSac.DataSource = null;
            cbxMauSac.DataSource = color;
            cbxMauSac.DisplayMember = "Name";
            cbxMauSac.SelectedIndex = -1;
        }
        private void WireDataMaterial()
        {
            List<Model_RawMaterial> material = GlobalConfig.Connection.GetModel_RawMaterials();
            cbxChatLieu.DataSource = null;
            cbxChatLieu.DataSource = material;
            cbxChatLieu.DisplayMember = "Name";
            cbxChatLieu.SelectedIndex = -1;
        }
        private void WireDataManufactured()
        {
            List<Model_Manufactured> manufac = GlobalConfig.Connection.GetAllManufactured();
            cbxNSX.DataSource = null;
            cbxNSX.DataSource = manufac;
            cbxNSX.DisplayMember = "Name";
            cbxNSX.SelectedIndex = -1;
        }
        private void WireDataSeason()
        {

            List<Model_Season> season = GlobalConfig.Connection.GetAllSeason();
            cbxMua.DataSource = null;
            cbxMua.DataSource = season;
            cbxMua.DisplayMember = "Name";
            cbxMua.SelectedIndex = -1;
        }
        private void WireDataObject()
        {
            List<Model_Object> obj = GlobalConfig.Connection.GetAllObject();
            cbxDoituong.DataSource = null;
            cbxDoituong.DataSource = obj;
            cbxDoituong.DisplayMember = "Name";
            cbxDoituong.SelectedIndex = -1;
        }
        private void buttonThemLoai_Click(object sender, EventArgs e)
        {
            addform = new Add(1);
            addform.ShowDialog();
            WireDataCate();
        }

        private void buttonAddColor_Click(object sender, EventArgs e)
        {
            addform = new Add(2);
            addform.ShowDialog();
            WireDataColor();
        }

        private void buttonAddManufactured_Click(object sender, EventArgs e)
        {
            addform = new Add(3);
            addform.ShowDialog();
            WireDataManufactured();
        }

        private void buttonAddMaterial_Click(object sender, EventArgs e)
        {
            addform = new Add(4);
            addform.ShowDialog();
            WireDataMaterial();
        }

        private void buttonAddObject_Click(object sender, EventArgs e)
        {
            addform = new Add(5);
            addform.ShowDialog();
            WireDataObject();
        }

        private void buttonAddSeason_Click(object sender, EventArgs e)
        {
            addform = new Add(6);
            addform.ShowDialog();
            WireDataSeason();
        }

        private void buttonThemSize_Click(object sender, EventArgs e)
        {
            addform = new Add(7);
            addform.ShowDialog();
            WireDataSize();
        }

        private void OnlyNumber(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private bool ValidateForm()
        {
            if (textBox_TenSP.Text == "")
            {
                MessageBox.Show("Hãy Nhập Tên Sản Phẩm !", "Thông Báo", MessageBoxButtons.OK);
                return false;
            }
            if (cbxSanPham.SelectedIndex == -1)
            {
                MessageBox.Show("Hãy chọn Loại Sản Phẩm !", "Thông Báo", MessageBoxButtons.OK);
                return false;
            }
            if (cbxKichco.SelectedIndex == -1)
            {
                MessageBox.Show("Hãy chọn Kích cỡ !", "Thông Báo", MessageBoxButtons.OK);
                return false;
            }
            if (cbxChatLieu.SelectedIndex == -1)
            {
                MessageBox.Show("Hãy chọn chất liệu !", "Thông Báo", MessageBoxButtons.OK);
                return false;
            }
            if (cbxMauSac.SelectedIndex == -1)
            {
                MessageBox.Show("Hãy chọn Màu Sắc !", "Thông Báo", MessageBoxButtons.OK);
                return false;
            }
            if (cbxDoituong.SelectedIndex == -1)
            {
                MessageBox.Show("Hãy chọn Đối tượng !", "Thông Báo", MessageBoxButtons.OK);
                return false;
            }
            if (textBox_GiaNhap.Text == "")
            {
                MessageBox.Show("Hãy Nhập Giá Nhập !", "Thông Báo", MessageBoxButtons.OK);
                return false;
            }
            if (textBox_GiaBan.Text == "")
            {
                MessageBox.Show("Hãy Nhập Giá Bán !", "Thông Báo", MessageBoxButtons.OK);
                return false;
            }
            if (cbxNSX.SelectedIndex == -1)
            {
                MessageBox.Show("Hãy chọn Nhà Sản Xuất !", "Thông Báo", MessageBoxButtons.OK);
                return false;
            }
            if (cbxMua.SelectedIndex == -1)
            {
                MessageBox.Show("Hãy chọn Mùa !", "Thông Báo", MessageBoxButtons.OK);
                return false;
            }
            if (textBox_soluong.Text == "")
            {
                MessageBox.Show("Hãy Nhập Số lượng !", "Thông Báo", MessageBoxButtons.OK);
                return false;
            }

            return true;
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                Model_Category cate = (Model_Category)cbxSanPham.SelectedItem;
                Model_Color color = (Model_Color)cbxMauSac.SelectedItem;
                Model_Object obj = (Model_Object)cbxDoituong.SelectedItem;
                Model_RawMaterial material = (Model_RawMaterial)cbxChatLieu.SelectedItem;
                Model_Season season = (Model_Season)cbxMua.SelectedItem;
                Model_Size size = (Model_Size)cbxKichco.SelectedItem;
                int quantity = int.Parse(textBox_soluong.Text);
                string Name = textBox_TenSP.Text;
                decimal priceEntry = decimal.Parse(textBox_GiaNhap.Text);
                decimal priceSell = decimal.Parse(textBox_GiaBan.Text);
                Model_Manufactured manufactured = (Model_Manufactured)cbxNSX.SelectedItem;
                Model_Product model = new Model_Product(Name,cate,size,material,color,obj,season,manufactured,quantity,priceEntry,priceSell);
                if (textBoxAddpicture.Text != "")
                {
                    model.Picture = textBoxAddpicture.Text;
                }
                try
                {
                    GlobalConfig.Connection.InsertNewProduct(model);
                }
                catch
                {
                    MessageBox.Show("Lỗi Thêm Nhân viên vào Database Liên hệ Thảo để fix :)", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Thêm Sản Phẩm Thành Công !", "Thông Báo", MessageBoxButtons.OK);
                this.Dispose();
            }
        }

        private void textBox_GiaNhap_TextChanged(object sender, EventArgs e)
        {
            if(textBox_GiaNhap.Text != "")
            {
                float t = float.Parse(textBox_GiaNhap.Text);
                textBox_GiaBan.Text = (t + t * 0.1).ToString();
            }

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cbxMua_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
