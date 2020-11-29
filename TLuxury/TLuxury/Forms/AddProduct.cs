using StoreLibrary;
using StoreLibrary.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TLuxury.Forms
{
    public partial class AddProduct : Form
    {
        //form con
        private Add addform;
        string fileName;
        bool isAdjust = false;
        string ID;
        public AddProduct(Model_Product model = null)
        {
            InitializeComponent();
            WireDataCate();
            WireDataColor();
            WireDataManufactured();
            WireDataMaterial();
            WireDataObject();
            WireDataSeason();
            WireDataSize();
            //Nếu có 1 đối tượng được truyền vào 
            if(model != null)
            {
                labelTitle.Text = "Sửa Sản Phẩm";
                ID = model.ID;
                getPicture(model.ID);
                textBox_TenSP.Text = model.Name;
                cbxChatLieu.Text = model.Material.Name;
                cbxDoituong.Text = model.Object.Name;
                cbxKichco.Text = model.Size.Size;
                cbxMauSac.Text = model.Color.Name;
                cbxMua.Text = model.Season.Name;
                cbxNSX.Text = model.Manufactured.Name;
                cbxSanPham.Text = model.Category.Name;
                textBox_GiaBan.Text = model.PriceSell.ToString();
                textBox_GiaNhap.Text = model.PriceEntry.ToString();
                textBox_soluong.Text = model.Quantity.ToString();
                //bật tắt nút :)
                textBox_GiaBan.Enabled = true;
                textBox_GiaNhap.Enabled = true;
                textBox_soluong.Enabled = true;
                //biến để xác định là thêm hay sửa
                isAdjust = true;
            }
        }
        private void getPicture(string ID)
        {
            string picture = GlobalConfig.Connection.find_anh(ID);
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
        private void buttonAddPicture_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    textBoxAddpicture.Text = openFileDialog1.FileName;
                    int index = System.Reflection.Assembly.GetExecutingAssembly().Location.IndexOf("bin");
                    fileName = openFileDialog1.SafeFileName;
                    MessageBox.Show(fileName);
                    File.Copy(openFileDialog1.FileName, System.Reflection.Assembly.GetExecutingAssembly().Location.Substring(0, index) + @"Resources\" + openFileDialog1.SafeFileName, true);
                    pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
                }
                catch
                {
                    MessageBox.Show("Loi dau do ");
                }
            }

        }
        private void WireDataSize()
        {
            try
            {
                List<Model_Size> size = GlobalConfig.Connection.GetAllSize();
                cbxKichco.DataSource = null;
                cbxKichco.DataSource = size;
                cbxKichco.DisplayMember = "Size";
                cbxKichco.SelectedIndex = -1;
            }
            catch
            {

            }

        }
        private void WireDataCate()
        {
            try
            {
                List<Model_Category> category = GlobalConfig.Connection.GetAllCategory();
                cbxSanPham.DataSource = null;
                cbxSanPham.DataSource = category;
                cbxSanPham.DisplayMember = "Name";
                cbxSanPham.SelectedIndex = -1;
            }
            catch
            {

            }

        }
        private void WireDataColor()
        {
            try
            {
                List<Model_Color> color = GlobalConfig.Connection.GetAllColor();
                cbxMauSac.DataSource = null;
                cbxMauSac.DataSource = color;
                cbxMauSac.DisplayMember = "Name";
                cbxMauSac.SelectedIndex = -1;
            }
            catch
            {

            }
        }
        private void WireDataMaterial()
        {
            try
            {
                List<Model_RawMaterial> material = GlobalConfig.Connection.GetModel_RawMaterials();
                cbxChatLieu.DataSource = null;
                cbxChatLieu.DataSource = material;
                cbxChatLieu.DisplayMember = "Name";
                cbxChatLieu.SelectedIndex = -1;
            }
            catch
            {

            }
        }
        private void WireDataManufactured()
        {
            try
            {
                List<Model_Manufactured> manufac = GlobalConfig.Connection.GetAllManufactured();
                cbxNSX.DataSource = null;
                cbxNSX.DataSource = manufac;
                cbxNSX.DisplayMember = "Name";
                cbxNSX.SelectedIndex = -1;
            }
            catch
            {

            }
        }
        private void WireDataSeason()
        {
            try
            {
                List<Model_Season> season = GlobalConfig.Connection.GetAllSeason();
                cbxMua.DataSource = null;
                cbxMua.DataSource = season;
                cbxMua.DisplayMember = "Name";
                cbxMua.SelectedIndex = -1;
            }
            catch
            {

            }

        }
        private void WireDataObject()
        {
            try
            {
                List<Model_Object> obj = GlobalConfig.Connection.GetAllObject();
                cbxDoituong.DataSource = null;
                cbxDoituong.DataSource = obj;
                cbxDoituong.DisplayMember = "Name";
                cbxDoituong.SelectedIndex = -1;
            }
            catch
            {

            }
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
                Model_Product model = new Model_Product(Name, cate, size, material, color, obj, season, manufactured, quantity, priceEntry, priceSell);
                if (textBoxAddpicture.Text != "")
                {
                    model.Picture = fileName;
                }
                try
                {
                    if (isAdjust == false)
                    {
                        GlobalConfig.Connection.InsertNewProduct(model);
                        MessageBox.Show("Thêm Sản Phẩm Thành Công !", "Thông Báo", MessageBoxButtons.OK);
                        this.Dispose();
                    }

                    else
                    {
                        //dòng 319 chưa có ID nên lúc sửa phải gán lại ID , biến ID là biến toàn cục
                        model.ID = ID;
                        //nếu thay đổi ảnh thì vào chỗ if này 
                        if (textBoxAddpicture.Text != "")
                            model.Picture = fileName;
                        else
                            //nếu k có thay đổi gì thì lấy link ảnh từ db
                            model.Picture = GlobalConfig.Connection.find_anh(model.ID);
                        //update thôi 
                        GlobalConfig.Connection.UpdateProduct(model);
                        MessageBox.Show("Sửa Sản Phẩm Thành Công !", "Thông Báo", MessageBoxButtons.OK);
                        this.Dispose();
                    }

                }
                catch
                {
                    MessageBox.Show("Lỗi Thêm Nhân viên vào Database Liên hệ Thảo để fix :)", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
        }

        private void textBox_GiaNhap_TextChanged(object sender, EventArgs e)
        {
            if (textBox_GiaNhap.Text != "")
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
