namespace TLuxury.Forms
{
    partial class CF_HOADON
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CF_HOADON));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_find = new System.Windows.Forms.Button();
            this.textBox_find = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_luu = new System.Windows.Forms.Button();
            this.button_chitiet = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_tongtien = new System.Windows.Forms.TextBox();
            this.textBox_date = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_khachhang = new System.Windows.Forms.TextBox();
            this.textBox_nhanvien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelDataGrid = new System.Windows.Forms.Panel();
            this.DanhsachKH = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.button_sua = new System.Windows.Forms.Button();
            this.button_them = new System.Windows.Forms.Button();
            this.button_xoa = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DanhsachKH)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_find);
            this.groupBox2.Controls.Add(this.textBox_find);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(29, 115);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(561, 172);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm Kiếm";
            // 
            // button_find
            // 
            this.button_find.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_find.Location = new System.Drawing.Point(421, 110);
            this.button_find.Margin = new System.Windows.Forms.Padding(4);
            this.button_find.Name = "button_find";
            this.button_find.Size = new System.Drawing.Size(128, 32);
            this.button_find.TabIndex = 9;
            this.button_find.Text = "Tìm ";
            this.button_find.UseVisualStyleBackColor = true;
            // 
            // textBox_find
            // 
            this.textBox_find.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_find.Location = new System.Drawing.Point(27, 110);
            this.textBox_find.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_find.Name = "textBox_find";
            this.textBox_find.Size = new System.Drawing.Size(365, 29);
            this.textBox_find.TabIndex = 9;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Mã Khách",
            "Tên Khách"});
            this.comboBox1.Location = new System.Drawing.Point(173, 44);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(148, 36);
            this.comboBox1.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 52);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 23);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tìm Kiếm Theo";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Leelawadee UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(22, 9);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(123, 37);
            this.labelTitle.TabIndex = 11;
            this.labelTitle.Text = "Hóa Đơn";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.button_luu);
            this.groupBox1.Controls.Add(this.button_chitiet);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox_tongtien);
            this.groupBox1.Controls.Add(this.textBox_date);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox_khachhang);
            this.groupBox1.Controls.Add(this.textBox_nhanvien);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(29, 293);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(561, 433);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin Hóa Đơn";
            // 
            // button_luu
            // 
            this.button_luu.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_luu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(168)))), ((int)(((byte)(0)))));
            this.button_luu.FlatAppearance.BorderSize = 0;
            this.button_luu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_luu.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_luu.ForeColor = System.Drawing.Color.White;
            this.button_luu.Image = ((System.Drawing.Image)(resources.GetObject("button_luu.Image")));
            this.button_luu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_luu.Location = new System.Drawing.Point(283, 366);
            this.button_luu.Margin = new System.Windows.Forms.Padding(4);
            this.button_luu.Name = "button_luu";
            this.button_luu.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.button_luu.Size = new System.Drawing.Size(139, 59);
            this.button_luu.TabIndex = 17;
            this.button_luu.Text = "Lưu";
            this.button_luu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_luu.UseVisualStyleBackColor = false;
            this.button_luu.Click += new System.EventHandler(this.button_luu_Click);
            // 
            // button_chitiet
            // 
            this.button_chitiet.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_chitiet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(168)))), ((int)(((byte)(0)))));
            this.button_chitiet.FlatAppearance.BorderSize = 0;
            this.button_chitiet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_chitiet.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_chitiet.ForeColor = System.Drawing.Color.White;
            this.button_chitiet.Image = ((System.Drawing.Image)(resources.GetObject("button_chitiet.Image")));
            this.button_chitiet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_chitiet.Location = new System.Drawing.Point(27, 366);
            this.button_chitiet.Margin = new System.Windows.Forms.Padding(4);
            this.button_chitiet.Name = "button_chitiet";
            this.button_chitiet.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.button_chitiet.Size = new System.Drawing.Size(139, 59);
            this.button_chitiet.TabIndex = 18;
            this.button_chitiet.Text = "Chi tiết";
            this.button_chitiet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_chitiet.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 263);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 23);
            this.label7.TabIndex = 10;
            this.label7.Text = "Tổng Tiền";
            // 
            // textBox_tongtien
            // 
            this.textBox_tongtien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox_tongtien.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_tongtien.Location = new System.Drawing.Point(27, 290);
            this.textBox_tongtien.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_tongtien.Name = "textBox_tongtien";
            this.textBox_tongtien.ReadOnly = true;
            this.textBox_tongtien.Size = new System.Drawing.Size(395, 29);
            this.textBox_tongtien.TabIndex = 9;
            // 
            // textBox_date
            // 
            this.textBox_date.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox_date.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_date.Location = new System.Drawing.Point(232, 66);
            this.textBox_date.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_date.Name = "textBox_date";
            this.textBox_date.ReadOnly = true;
            this.textBox_date.Size = new System.Drawing.Size(190, 29);
            this.textBox_date.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(228, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ngày Lập";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 187);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Khách Hàng";
            // 
            // textBox_khachhang
            // 
            this.textBox_khachhang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox_khachhang.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_khachhang.Location = new System.Drawing.Point(29, 214);
            this.textBox_khachhang.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_khachhang.Name = "textBox_khachhang";
            this.textBox_khachhang.ReadOnly = true;
            this.textBox_khachhang.Size = new System.Drawing.Size(393, 29);
            this.textBox_khachhang.TabIndex = 5;
            // 
            // textBox_nhanvien
            // 
            this.textBox_nhanvien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox_nhanvien.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_nhanvien.Location = new System.Drawing.Point(29, 142);
            this.textBox_nhanvien.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_nhanvien.Name = "textBox_nhanvien";
            this.textBox_nhanvien.ReadOnly = true;
            this.textBox_nhanvien.Size = new System.Drawing.Size(393, 29);
            this.textBox_nhanvien.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 115);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhân Viên";
            // 
            // textBoxID
            // 
            this.textBoxID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxID.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxID.Location = new System.Drawing.Point(29, 66);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(144, 29);
            this.textBoxID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Hóa Đơn";
            // 
            // panelDataGrid
            // 
            this.panelDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDataGrid.Controls.Add(this.DanhsachKH);
            this.panelDataGrid.Location = new System.Drawing.Point(611, 132);
            this.panelDataGrid.Margin = new System.Windows.Forms.Padding(4);
            this.panelDataGrid.Name = "panelDataGrid";
            this.panelDataGrid.Size = new System.Drawing.Size(680, 507);
            this.panelDataGrid.TabIndex = 13;
            // 
            // DanhsachKH
            // 
            this.DanhsachKH.AllowDrop = true;
            this.DanhsachKH.AllowUserToResizeColumns = false;
            this.DanhsachKH.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DanhsachKH.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DanhsachKH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DanhsachKH.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(148)))), ((int)(((byte)(181)))));
            this.DanhsachKH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DanhsachKH.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.DanhsachKH.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DanhsachKH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DanhsachKH.ColumnHeadersHeight = 25;
            this.DanhsachKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DanhsachKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DanhsachKH.EnableHeadersVisualStyles = false;
            this.DanhsachKH.GridColor = System.Drawing.SystemColors.ControlLight;
            this.DanhsachKH.Location = new System.Drawing.Point(0, 0);
            this.DanhsachKH.Margin = new System.Windows.Forms.Padding(4);
            this.DanhsachKH.MultiSelect = false;
            this.DanhsachKH.Name = "DanhsachKH";
            this.DanhsachKH.ReadOnly = true;
            this.DanhsachKH.RowHeadersVisible = false;
            this.DanhsachKH.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.DanhsachKH.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DanhsachKH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DanhsachKH.Size = new System.Drawing.Size(680, 507);
            this.DanhsachKH.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(836, 87);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(242, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "Danh Sách Hóa Đơn";
            // 
            // button_sua
            // 
            this.button_sua.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(158)))), ((int)(((byte)(0)))));
            this.button_sua.FlatAppearance.BorderSize = 0;
            this.button_sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_sua.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_sua.ForeColor = System.Drawing.Color.White;
            this.button_sua.Image = ((System.Drawing.Image)(resources.GetObject("button_sua.Image")));
            this.button_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_sua.Location = new System.Drawing.Point(784, 659);
            this.button_sua.Margin = new System.Windows.Forms.Padding(4);
            this.button_sua.Name = "button_sua";
            this.button_sua.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.button_sua.Size = new System.Drawing.Size(139, 59);
            this.button_sua.TabIndex = 16;
            this.button_sua.Text = "Sửa";
            this.button_sua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_sua.UseVisualStyleBackColor = false;
            this.button_sua.Click += new System.EventHandler(this.button_sua_Click);
            // 
            // button_them
            // 
            this.button_them.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(245)))));
            this.button_them.FlatAppearance.BorderSize = 0;
            this.button_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_them.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_them.ForeColor = System.Drawing.Color.White;
            this.button_them.Image = ((System.Drawing.Image)(resources.GetObject("button_them.Image")));
            this.button_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_them.Location = new System.Drawing.Point(1152, 661);
            this.button_them.Margin = new System.Windows.Forms.Padding(4);
            this.button_them.Name = "button_them";
            this.button_them.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.button_them.Size = new System.Drawing.Size(139, 59);
            this.button_them.TabIndex = 15;
            this.button_them.Text = "Thêm ";
            this.button_them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_them.UseVisualStyleBackColor = false;
            this.button_them.Click += new System.EventHandler(this.button_them_Click);
            // 
            // button_xoa
            // 
            this.button_xoa.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(60)))), ((int)(((byte)(0)))));
            this.button_xoa.FlatAppearance.BorderSize = 0;
            this.button_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_xoa.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_xoa.ForeColor = System.Drawing.Color.White;
            this.button_xoa.Image = ((System.Drawing.Image)(resources.GetObject("button_xoa.Image")));
            this.button_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_xoa.Location = new System.Drawing.Point(969, 659);
            this.button_xoa.Margin = new System.Windows.Forms.Padding(4);
            this.button_xoa.Name = "button_xoa";
            this.button_xoa.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.button_xoa.Size = new System.Drawing.Size(139, 59);
            this.button_xoa.TabIndex = 14;
            this.button_xoa.Text = "Xóa";
            this.button_xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_xoa.UseVisualStyleBackColor = false;
            // 
            // CF_HOADON
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 733);
            this.Controls.Add(this.button_sua);
            this.Controls.Add(this.button_them);
            this.Controls.Add(this.button_xoa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panelDataGrid);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CF_HOADON";
            this.Text = "CF_HOADON";
            this.Load += new System.EventHandler(this.CF_HOADON_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DanhsachKH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_find;
        private System.Windows.Forms.TextBox textBox_find;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_khachhang;
        private System.Windows.Forms.TextBox textBox_nhanvien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelDataGrid;
        private System.Windows.Forms.DataGridView DanhsachKH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_luu;
        private System.Windows.Forms.Button button_sua;
        private System.Windows.Forms.Button button_them;
        private System.Windows.Forms.Button button_xoa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_tongtien;
        private System.Windows.Forms.TextBox textBox_date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_chitiet;
    }
}