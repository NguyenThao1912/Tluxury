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
    public partial class Add : Form
    {
        public static int Type { get; set; }
        public Add(int type)
        {            
            InitializeComponent();
            Type = type;
            SetUp();
        }
        private void SetUp()
        {
            if(Type == 1)
            {
                //Form them loai
                labelTitle.Text = "Thêm Loại Sản Phẩm";

                label_Input.Text = "Loại Sản Phẩm";
                //SQL
            }
            else if(Type == 2)
            {
                labelTitle.Text = "Thêm Màu Sản Phẩm";

                label_Input.Text = "Tên Màu";
                //Sql

            }
            else if(Type == 3)
            {
                labelTitle.Text = "Thêm Nhà Sản Xuất";

                label_Input.Text = "Nhà sản xuất";
                //Sql
          
            }
            else if(Type == 4)
            {
                labelTitle.Text = "Thêm Nguyên Liệu";

                label_Input.Text = "Tên Nguyên Liệu";
                //Sql
         
            }
            else if(Type == 5)
            {
                labelTitle.Text = "Thêm Đối tượng sử dụng";

                label_Input.Text = "Tên Đối tượng";
                //Sql
         
            }
            else if(Type == 6)
            {
                labelTitle.Text = "Thêm Mùa";

                label_Input.Text = "Tên Mùa";
                //Sql
       
            }
            else if(Type == 7)
            {
                labelTitle.Text = "Thêm Kích Cỡ";

                label_Input.Text = "Tên Kích Cỡ";
                //Sql
            }
            else if(Type == 8)
            {
                labelTitle.Text = "Thêm Chức vụ";

                label_Input.Text = "Tên Chức Vụ";
                //Sql
            }
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (textbox_Input.Text != "")
            {
                //Category
                if (Type == 1)
                {
                    Model_Category model = new Model_Category();
                    model.Name = textbox_Input.Text;
                    try
                    {
                        GlobalConfig.Connection.CreateNew_Category(model);
                    }
                    catch
                    {
                        MessageBox.Show("Lỗi Câu lệnh SQL Thêm loại Sản Phẩm  :( We are sorry about this", "Thông Báo", MessageBoxButtons.OK);
                        return;
                    }
                }
                //Color
                else if (Type == 2)
                {
                    Model_Color model = new Model_Color();
                    model.Name = textbox_Input.Text;
                    try
                    {
                        GlobalConfig.Connection.CreateNew_Color(model);
                    }
                    catch
                    {
                        MessageBox.Show("Lỗi Câu lệnh SQL Thêm Màu Sắc  :( We are sorry about this", "Thông Báo", MessageBoxButtons.OK);
                        return;
                    }
                }
                //Manufactured
                else if (Type == 3)
                {
                    Model_Manufactured model = new Model_Manufactured();
                    model.Name = textbox_Input.Text;
                    try
                    {
                        GlobalConfig.Connection.CreateNew_Manufactured(model);
                    }
                    catch
                    {
                        MessageBox.Show("Lỗi Câu lệnh SQL Thêm Nhà Sản Xuất  :( We are sorry about this", "Thông Báo", MessageBoxButtons.OK);
                        return;
                    }

                }
                //Material
                else if (Type == 4)
                {
                    Model_RawMaterial model = new Model_RawMaterial();
                    model.Name = textbox_Input.Text;
                    try
                    {
                        GlobalConfig.Connection.CreateNew_RawMaterial(model);
                    }
                    catch
                    {
                        MessageBox.Show("Lỗi Câu lệnh SQL Thêm Nguyên Liệu  :( We are sorry about this", "Thông Báo", MessageBoxButtons.OK);
                        return;
                    }

                }
                //Object
                else if (Type == 5)
                {
                    Model_Object model = new Model_Object();
                    model.Name = textbox_Input.Text;
                    try
                    {
                        GlobalConfig.Connection.CreateNew_Object(model);
                    }
                    catch 
                    {
                        MessageBox.Show("Lỗi Câu lệnh SQL Thêm Đối Tượng  :( We are sorry about this", "Thông Báo", MessageBoxButtons.OK);
                        return;
                    }

                }
                //Season
                else if (Type == 6)
                {
                    Model_Season model = new Model_Season();
                    model.Name = textbox_Input.Text;
                    try
                    {
                        GlobalConfig.Connection.CreateNew_Season(model);
                    }
                    catch 
                    {
                        MessageBox.Show("Lỗi Câu lệnh SQL Thêm Mùa  :( We are sorry about this", "Thông Báo", MessageBoxButtons.OK);
                        return;
                    }

                }
                //Size
                else if (Type == 7)
                {
                    Model_Size model = new Model_Size();
                    model.Size = textbox_Input.Text;
                    try
                    {
                        GlobalConfig.Connection.CreateNew_Size(model);
                    }
                    catch 
                    {
                        MessageBox.Show("Lỗi Câu lệnh SQL Thêm Kích cỡ :( We are sorry about this", "Thông Báo", MessageBoxButtons.OK);
                        return;
                    }

                }
                //Role
                else if (Type == 8)
                {
                    Model_Role model = new Model_Role();
                    model.Name = textbox_Input.Text;
                    try
                    {
                        GlobalConfig.Connection.CreateNew_Role(model);
                    }
                    catch 
                    {
                        MessageBox.Show("Lỗi Câu lệnh SQL Thêm Chức Vụ  :( We are sorry about this", "Thông Báo", MessageBoxButtons.OK);
                        return;
                    }
 
                }
                MessageBox.Show("Nhập Thông tin Thành Công ", "Thông Báo", MessageBoxButtons.OK);
                this.Dispose();
            }
            else
                MessageBox.Show("Xin hãy kiểm tra lại thông tin ", "Thông Báo", MessageBoxButtons.OK);
        }
    }
}
