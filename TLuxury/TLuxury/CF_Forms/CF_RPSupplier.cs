using StoreLibrary;
using StoreLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
namespace TLuxury.CF_Forms
{
    public partial class CF_RPSupplier : Form
    {
        public CF_RPSupplier()
        {
            InitializeComponent();
            WireData();
        }

        private void CF_RPSupplier_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxNCC.Text != "")
            {
                Model_Supplier s = (Model_Supplier)comboBoxNCC.SelectedItem;
                try
                {
                    DataTable table = GlobalConfig.Connection.ReportSupplier(s.ID);
                    DanhsachNCC.DataSource = null;
                    DanhsachNCC.DataSource = table;
                }
                catch
                {

                }

            }
        }
        private void WireData()
        {
            try
            {
                List<Model_Supplier> sup = GlobalConfig.Connection.GetAllSupplier_List();
                comboBoxNCC.DataSource = sup;
                comboBoxNCC.DisplayMember = "Name";
                comboBoxNCC.SelectedIndex = -1;
            }
            catch
            {

            }
        }
        private void PrintTable(Excel.Worksheet wsheet,DataGridView data,int rowheader,int colheader)
        {
            int j = 0; //j là biến đếm vị trí header từ trái sang phải
                       //cho vòng lặp i từ 2 vì sẽ in ra ở cột số 2 trong excel
            for (int i = colheader; i < data.Columns.Count + colheader; i++)
            {
                wsheet.Cells[rowheader, i] = data.Columns[j].HeaderText;
                j++;
            }            
            //Tiếp tục lặp đến dữ liệu
            int col = colheader;  //vẫn in từ cột header
            int row = rowheader + 1;  //hàng trên in header rồi nên chuyển sang hàng tiếp theo in dữ liệu
                          //Duyệt bảng như ma trận 2 chiều bình thường
            for (int i = 0; i < data.Rows.Count; i++)
            {
                for (int k = 0; k < data.Columns.Count; k++)
                {
                    //kiểm tra nếu đi hết 1 cột của 1 hàng thì reset về vị trí đầu tiên
                    if (col > data.Columns.Count + colheader - 1) col = colheader;
                    wsheet.Cells[row, col] = data.Rows[i].Cells[k].Value.ToString();
                    col++;
                }
                row++;
            }
        }
        private void XuatBaoCao_Click(object sender, EventArgs e)
        {
            if (DanhsachNCC.Rows.Count > 1 || comboBoxNCC.Text != "")
            {
                Model_Supplier supplier = (Model_Supplier)comboBoxNCC.SelectedItem;
                string tencuahang = "Cửa Hàng Quần Áo TLuxury";
                string DiaChi = "Địa Chỉ : Số 3 Cầu Giấy, Ngọc Khánh,Đống Đa ,Hà Nội";
                string TieudeBaoCao = $"Báo Cáo Danh Sách Hóa Đơn Nhập Của Nhà Cung Cấp {supplier.Name.Substring(9)}";
                //tạo đối tượng excel
                Excel.Application ex = new Excel.Application();
                //tạo workbook trong đối tượng excel
                Excel.Workbook wbook = ex.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
                //tạo worksheet trong workbook
                Excel.Worksheet wsheet = wbook.Worksheets[1];

                ex.DisplayAlerts = false;
                wsheet.Name = "Báo Cáo";

                Excel.Range TenCuaHang = (Excel.Range)wsheet.Cells[1, 1];
                TenCuaHang.Font.Size = 15;
                TenCuaHang.Font.Color = Color.Blue;
                TenCuaHang.Font.Bold = true;
                TenCuaHang.Value = tencuahang;

                Excel.Range Diachi = (Excel.Range)wsheet.Cells[2, 1];
                Diachi.Font.Size = 13;
                Diachi.Value = DiaChi;

                Excel.Range Title = (Excel.Range)wsheet.Cells[6, 1];
                wsheet.get_Range("A6:I6").Merge(true);
                Title.Font.Size = 17;
                Title.Font.Color = Color.Red;
                Title.Font.Bold = true;
                Title.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                Title.Value = TieudeBaoCao;
                //IN Báo Cáo
                wsheet.get_Range("E8:I8").HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                PrintTable(wsheet, DanhsachNCC, 8, 2);              
                ex.Columns["B:H"].AutoFit();    //chỉnh sao cho cột tự động vừa với thông tin ở trong
                wbook.Activate();
                SaveFileDialog save = new SaveFileDialog();

                save.Filter = "Excel Document(*.xlsx)|*.xlsx  |Word Document(*.doc) |*.doc|All files(*.*)|*.*";
                save.AddExtension = true;
                save.DefaultExt = ".xlsx";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        wbook.SaveAs(save.FileName.ToString());

                        MessageBox.Show("Xuất Báo Cáo Thành Công", "Thông Báo");
                    }
                    catch(System.Runtime.InteropServices.COMException)
                    {
                        MessageBox.Show("Cửa sổ excel hiện đang mở không thể thực hiện thay đổi");
                    }
                    catch(Exception t)
                    {
                        MessageBox.Show($"Có Lỗi không lưu được excel {t}");
                    }
                    finally
                    {           
                        ex.Quit();
                        Process[] excelProcesses = Process.GetProcessesByName("excel");
                        foreach (Process p in excelProcesses)
                        {
                            if (string.IsNullOrEmpty(p.MainWindowTitle)) 
                            {
                                p.Kill();
                            }
                        }
                    }
                }

            }
            else
                MessageBox.Show("Không có gì để Báo Cáo , hãy kiểm tra đã chọn nhà cung cấp chưa", "Thông Báo");

        }

        private void DanhsachNCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
