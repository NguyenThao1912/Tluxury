﻿using StoreLibrary;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
namespace TLuxury.CF_Forms
{
    public partial class CF_RPCustomer : Form
    {
        public CF_RPCustomer()
        {
            InitializeComponent();
            WireData();
        }
        private void WireData()
        {
            try
            {
                if (textBoxYear.Text != "")
                {
                    DataTable table = GlobalConfig.Connection.ReportTop5Cus(int.Parse(textBoxYear.Text));
                    if(table.Rows.Count > 0)
                    {
                        DanhsachKH.DataSource = null;
                        DanhsachKH.DataSource = table;
                    }
                    else
                    {
                        MessageBox.Show("Không có dữ liệu cho tháng này ", "Thông Báo", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Lỗi gì đó chưa biêt !! {e}");
            }
        }
        //CAI NAY de IN bang datagridview ra truyen dung thong tin la duoc
        private void PrintTable(Excel.Worksheet wsheet, DataGridView data, int rowheader, int colheader)
        {
            char[] a = { ' ', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'K', 'L', 'M', 'N', 'O' };
            string b;
            int j = 0; //j là biến đếm vị trí header từ trái sang phải
                       //cho vòng lặp i từ 2 vì sẽ in ra ở cột số 2 trong excel
            for (int i = colheader; i < data.Columns.Count + colheader; i++)
            {
                wsheet.Cells[rowheader, i] = data.Columns[j].HeaderText;
                b = a[i] + rowheader.ToString();
                wsheet.get_Range(b).ColumnWidth = 15;
                wsheet.get_Range(b).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
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
                    Excel.Range temp = (Excel.Range)wsheet.Cells[row, col];
                    temp.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    col++;
                }
                row++;
            }
        }
        private void buttonXuatBaoCao_Click(object sender, EventArgs e)
        {
            //dữ liệu
            DataGridView datasource = DanhsachKH;

            if (datasource.Rows.Count > 1 || datasource.Text != "")
            {
                //nơi in datagrid
                int rowPrint = 8; //hàng 8
                int colprint = 3; //cột 2

                //các tiêu đề
                string Ten = "Nguyễn Thảo zzz";
                string DiaChi = "Địa Chỉ : H_ N__";
                string TieudeBaoCao = $"Báo Cáo Danh Sách Khách Hàng Mua Nhiều Nhất";


                char[] col = { ' ', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'K', 'L', 'M', 'N', 'O' };
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
                TenCuaHang.Value = Ten;

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

                wsheet.get_Range("E8:I8").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                //==========================================================================
                PrintTable(wsheet, datasource, rowPrint, colprint);
                //========================================================================
                //ex.Columns["B:H"].AutoFit();    //chỉnh sao cho cột tự động vừa với thông tin ở trong dùng thì bỏ // đi
                //thêm khung vào bảng

                string firstcell = col[colprint] + rowPrint.ToString();
                string lastcell = col[colprint + datasource.ColumnCount - 1] + (rowPrint + datasource.Rows.Count).ToString();
                wsheet.get_Range(firstcell + ":" + lastcell).Borders.Weight = Excel.XlBorderWeight.xlMedium;

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
                    catch (System.Runtime.InteropServices.COMException)
                    {
                        MessageBox.Show("Cửa sổ excel hiện đang mở không thể thực hiện thay đổi");
                    }
                    catch (Exception t)
                    {
                        MessageBox.Show($"Có Lỗi không lưu được excel {t}");
                    }
                    finally
                    {
                        ex.Quit();
                    }
                }

            }
            else
                MessageBox.Show("Không có gì để Báo Cáo ", "Thông Báo");

        }

        private void textBoxYear_TextChanged(object sender, EventArgs e)
        {
            WireData();
        }

        private void textBoxYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
