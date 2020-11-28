using StoreLibrary;
using StoreLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace TLuxury.Forms
{
    public partial class CF_BANHANG : Form
    {
        public CF_BANHANG()
        {
            InitializeComponent();
        }

        private List<string> idhang = new List<string>();
        private Model_SaleInvoice model;

        public delegate void sendma(string id, string ten);


        private void BANHANG_Load(object sender, EventArgs e)
        {
            GetEmployee();
            reset();
        }

        private bool checkma(string ma)
        {
            if (idhang.Contains(ma))
                return false;
            return true;
        }

        private void reset()
        {
            try
            {
                labeltime.Text = DateTime.Now.ToString("MM/dd/yyyy");
                DataTable model = GlobalConfig.Connection.GetAllProducts();
                dataGridViewhanghoa.DataSource = null;
                dataGridViewhanghoa.DataSource = model;
                dataGridViewhanghoa.Columns["Mã Sản Phẩm"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridViewhanghoa.Columns["Tên Sản Phẩm"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridViewhanghoa.Columns["Loại Sản Phẩm"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridViewhanghoa.Columns["Kích Cỡ"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridViewhanghoa.Columns["Nguyên Liệu"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridViewhanghoa.Columns["Màu Sắc"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridViewhanghoa.Columns["Đối Tượng"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridViewhanghoa.Columns["Mùa"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridViewhanghoa.Columns["Nhà Sản Xuất"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridViewhanghoa.Columns["Số Lượng"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridViewhanghoa.Columns["Giá Bán"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception r)
            {
                MessageBox.Show($"lỗi sql  {r}");
            }
        }

        private void GetEmployee()
        {
            try
            {
                List<Model_Employee> employees = GlobalConfig.Connection.GetAllEmployee_List();
                comboBox1.DataSource = null;
                comboBox1.DataSource = employees;
                comboBox1.DisplayMember = "Name";
                comboBox1.SelectedIndex = -1;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Thông Báo", MessageBoxButtons.OK);
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells[0].Value == null)
            {
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                return;
            }

            //ktra nhâp chữ
            DataGridViewCell cuCell = dataGridView1.CurrentCell;
            string mainStr = dataGridView1.CurrentCell.Value.ToString();
            for (int scan = 0; scan < mainStr.Length; scan++)
            {
                if (Char.IsDigit(mainStr[scan])) { }
                else
                {
                    MessageBox.Show("Chỉ được nhập số, và phải > 0", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dataGridView1.CurrentRow.Cells[4].Value = 1;
                    dataGridView1.CurrentRow.Cells[7].Value = 0;
                    dataGridView1.ClearSelection();
                    dataGridView1.CurrentCell = cuCell;
                    dataGridView1.CurrentCell.Selected = true;
                    return;
                }
            }
            //ktra số lượng
            if (int.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString()) >
                getsoluong(dataGridView1.CurrentRow.Cells[0].Value.ToString()) || int.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString()) < 1)
            {
                dataGridView1.CurrentRow.Cells[4].Value = 1;
                MessageBox.Show("Không được nhỏ hơn 1 hoặc quá số lượng hiện có", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //KHOẢNG KHUYẾN MÃI
            if (int.Parse(dataGridView1.CurrentRow.Cells[6].Value.ToString()) > 100 || int.Parse(dataGridView1.CurrentRow.Cells[6].Value.ToString()) < 0)
            {
                MessageBox.Show("giá trị khuyến mãi không được nhỏ hơn 0 và lớn hơn 100", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataGridView1.CurrentRow.Cells[6].Value = 0;
                return;
            }

            dataGridView1.CurrentRow.Cells[7].Value =
                decimal.Parse(dataGridView1.CurrentRow.Cells[5].Value.ToString()) *
                decimal.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString()) *
                (1 - (decimal.Parse(dataGridView1.CurrentRow.Cells[6].Value.ToString()) / 100))
                ;

            int dem = 0; float tongtien = 0, khachtra = 0; ;
            for (var VARIABLE = 0; VARIABLE <= dataGridView1.Rows.Count - 1; VARIABLE++)
            {
                if (dataGridView1.Rows[VARIABLE].Cells[4].Value != null)
                    dem += int.Parse(dataGridView1.Rows[VARIABLE].Cells[4].Value.ToString());
                if (dataGridView1.Rows[VARIABLE].Cells[7].Value != null)
                    tongtien += float.Parse(dataGridView1.Rows[VARIABLE].Cells[4].Value.ToString()) * float.Parse(dataGridView1.Rows[VARIABLE].Cells[5].Value.ToString());
                if (dataGridView1.Rows[VARIABLE].Cells[7].Value != null)
                    khachtra += float.Parse(dataGridView1.Rows[VARIABLE].Cells[7].Value.ToString());
            }

            labeltongtien.Text = "" + tongtien;
            labeltongsoluong.Text = "" + (dem);
            labelkhachtra.Text = "" + khachtra;
            labelgiamgia.Text = float.Parse(labeltongtien.Text) -
                float.Parse(labelkhachtra.Text) + "";
        }

        private void dataGridViewhanghoa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count == 0) return;
            //het hang
            if (int.Parse(dataGridViewhanghoa.CurrentRow.Cells[9].Value.ToString()) == 0)
            {
                MessageBox.Show("Sản phẩm đã hết", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
   
            //sp đã đc chọn
            if (checkma(dataGridViewhanghoa.CurrentRow.Cells[0].Value.ToString()) == false)
            {
                MessageBox.Show("Sản phẩm đã được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                idhang.Add(dataGridViewhanghoa.CurrentRow.Cells[0].Value.ToString());

                Model_Product product = new Model_Product();
                DataGridViewRow currentRow = new DataGridViewRow();
                currentRow = dataGridViewhanghoa.CurrentRow;
                product.ID = currentRow.Cells[0].Value.ToString();
                product.Name = currentRow.Cells[1].Value.ToString();
                Model_Color cloColor = new Model_Color();
                cloColor.Name = currentRow.Cells[5].Value.ToString();
                product.Color = cloColor;
                Model_Size modelSize = new Model_Size();
                modelSize.Size = currentRow.Cells[3].Value.ToString();
                product.Size = modelSize;
                product.PriceSell = decimal.Parse(currentRow.Cells[10].Value.ToString());

                DataGridViewRow addRow = (DataGridViewRow)dataGridView1.Rows[0].Clone();

                addRow.Cells[0].Value = product.ID;
                addRow.Cells[1].Value = product.Name;
                addRow.Cells[2].Value = product.Size.Size;
                addRow.Cells[3].Value = product.Color.Name;
                addRow.Cells[4].Value = 1;
                addRow.Cells[5].Value = product.PriceSell;
                addRow.Cells[6].Value = 0;
                addRow.Cells[7].Value = product.PriceSell;

                dataGridView1.Rows.Add(addRow);
                int dem = 0;
                float tongtien = 0;
                for (var VARIABLE = 0; VARIABLE <= dataGridView1.Rows.Count - 1; VARIABLE++)
                {
                    if (dataGridView1.Rows[VARIABLE].Cells[4].Value != null)
                        dem += int.Parse(dataGridView1.Rows[VARIABLE].Cells[4].Value.ToString());
                    if (dataGridView1.Rows[VARIABLE].Cells[7].Value != null)
                        tongtien += float.Parse(dataGridView1.Rows[VARIABLE].Cells[7].Value.ToString());
                }

                labeltongsoluong.Text = " " + (dem);
                labeltongtien.Text = " " + tongtien;
                labelkhachtra.Text = float.Parse(labeltongtien.Text) - float.Parse(labelgiamgia.Text) + "";
            }
        }

        private void buttonthanhtoan_Click(object sender, EventArgs e)
        {
            if (textBoxthanhtoan.Text == "") textBoxthanhtoan.Text = "0";
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Chọn nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (textBoxmakh.Text == "")
            {
                MessageBox.Show("Chọn khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Model_Employee nhanvien = (Model_Employee)comboBox1.SelectedItem;
            if (float.Parse(textBoxthanhtoan.Text) < float.Parse(labelkhachtra.Text))
            {
                MessageBox.Show("Số tiền khách trả chưa đủ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                model = GlobalConfig.Connection.Insert_SaleInvoice(nhanvien.ID, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), textBoxmakh.Text, decimal.Parse(labelkhachtra.Text));
            }
            catch (Exception r)
            {
                MessageBox.Show($"{r.ToString()} Lỗi câu lệnh sql ~ 1 ~ line 186", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            for (var VARIABLE = 0; VARIABLE <= dataGridView1.Rows.Count - 1; VARIABLE++)
            {
                try
                {
                    if (dataGridView1.Rows[VARIABLE].Cells[4].Value != null || dataGridView1.Rows[VARIABLE].Cells[6].Value != null || dataGridView1.Rows[VARIABLE].Cells[7].Value != null)
                        GlobalConfig.Connection.insert_hoadonban_chitiet(
                            model.ID,
                            dataGridView1.Rows[VARIABLE].Cells[0].Value.ToString(),
                            float.Parse(dataGridView1.Rows[VARIABLE].Cells[6].Value.ToString()),
                            int.Parse(dataGridView1.Rows[VARIABLE].Cells[4].Value.ToString()),
                            decimal.Parse(dataGridView1.Rows[VARIABLE].Cells[7].Value.ToString())
                        );
                }
                catch
                {
                    MessageBox.Show(" Lỗi câu lệnh sql ~ 2 ~ line 199", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            model = null;

            labeltienthua.Text = "" + (float.Parse(textBoxthanhtoan.Text) - float.Parse(labelkhachtra.Text));
            reset();
            MessageBox.Show("Lập hóa đơn thành công", "Thông báo", MessageBoxButtons.OK);
            button1.PerformClick();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addkhach_banhang frm = new addkhach_banhang(nhankhach);
            
            frm.ShowDialog();
            
        }

        private void nhankhach(string id, string ten)
        {
            this.textBoxmakh.Text = id;
            this.textBoxtenkh.Text = ten;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            labeltongtien.Text = "0";
            labelkhachtra.Text = "0";
            labelgiamgia.Text = "0";
            labeltongsoluong.Text = "0";
            labeltienthua.Text = "0";
            textBoxmakh.Text = "";
            textBoxtenkh.Text = "";
            textBoxthanhtoan.Text = "";
            idhang.Clear();
            reset();
        }

        private void textBoxthanhtoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private int getsoluong(string id)
        {
            for (var VARIABLE = 0; VARIABLE <= dataGridViewhanghoa.Rows.Count - 1; VARIABLE++)
            {
                if (dataGridViewhanghoa.Rows[VARIABLE].Cells[0].Value != null && dataGridViewhanghoa.Rows[VARIABLE].Cells[9].Value != null)
                    if (dataGridViewhanghoa.Rows[VARIABLE].Cells[0].Value.ToString() == id)
                        return int.Parse(dataGridViewhanghoa.Rows[VARIABLE].Cells[9].Value.ToString());
            }
            return 0;
        }

        private void textBoxtimhang_TextChanged(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table = GlobalConfig.Connection.FindhanghoaByName($"{textBoxtimhang.Text.Trim()}");
            dataGridViewhanghoa.DataSource = null;
            dataGridViewhanghoa.DataSource = table;
            dataGridViewhanghoa.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewhanghoa.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewhanghoa.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewhanghoa.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewhanghoa.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewhanghoa.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewhanghoa.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewhanghoa.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewhanghoa.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewhanghoa.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewhanghoa.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void dataGridView1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            int dem = 0;
            float tongtien = 0;
            for (var VARIABLE = 0; VARIABLE <= dataGridView1.Rows.Count - 1; VARIABLE++)
            {
                if (dataGridView1.Rows[VARIABLE].Cells[4].Value != null)
                    dem += int.Parse(dataGridView1.Rows[VARIABLE].Cells[4].Value.ToString());
                if (dataGridView1.Rows[VARIABLE].Cells[7].Value != null)
                    tongtien += float.Parse(dataGridView1.Rows[VARIABLE].Cells[7].Value.ToString());
            }

            labeltongsoluong.Text = " " + (dem);
            labeltongtien.Text = " " + tongtien;
            labelkhachtra.Text = float.Parse(labeltongtien.Text) - float.Parse(labelgiamgia.Text) + "";
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            idhang.Remove(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            
        }

        private void dataGridViewhanghoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string picture = GlobalConfig.Connection.find_anh(dataGridViewhanghoa.Rows[e.RowIndex].Cells[0].Value.ToString());
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string picture = GlobalConfig.Connection.find_anh(dataGridViewhanghoa.Rows[e.RowIndex].Cells[0].Value.ToString());
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
}

