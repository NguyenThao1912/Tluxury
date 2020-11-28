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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CF_HOADON));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonThem = new System.Windows.Forms.Button();
            this.textBoxFind = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.DateEnd = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DateStart = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.panelDatagrid = new System.Windows.Forms.Panel();
            this.DanhsachHoaDon = new System.Windows.Forms.DataGridView();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelDatagrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DanhsachHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(247)))), ((int)(((byte)(245)))));
            this.panel1.Controls.Add(this.buttonDelete);
            this.panel1.Controls.Add(this.buttonThem);
            this.panel1.Controls.Add(this.textBoxFind);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.DateEnd);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.DateStart);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 138);
            this.panel1.TabIndex = 24;
            // 
            // buttonThem
            // 
            this.buttonThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(245)))));
            this.buttonThem.FlatAppearance.BorderSize = 0;
            this.buttonThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThem.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThem.ForeColor = System.Drawing.Color.White;
            this.buttonThem.Image = ((System.Drawing.Image)(resources.GetObject("buttonThem.Image")));
            this.buttonThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonThem.Location = new System.Drawing.Point(958, 12);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.buttonThem.Size = new System.Drawing.Size(108, 48);
            this.buttonThem.TabIndex = 24;
            this.buttonThem.Text = "Thêm ";
            this.buttonThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonThem.UseVisualStyleBackColor = false;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // textBoxFind
            // 
            this.textBoxFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxFind.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFind.Location = new System.Drawing.Point(22, 99);
            this.textBoxFind.Name = "textBoxFind";
            this.textBoxFind.Size = new System.Drawing.Size(404, 29);
            this.textBoxFind.TabIndex = 22;
            this.textBoxFind.TextChanged += new System.EventHandler(this.textBoxFind_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "--- Tìm Kiếm ---",
            "Tìm Theo Mã Hóa Đơn",
            "Tìm Theo Tên Khách Hàng",
            "Tìm Theo Tên Nhân Viên"});
            this.comboBox1.Location = new System.Drawing.Point(22, 63);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(221, 29);
            this.comboBox1.TabIndex = 23;
            // 
            // DateEnd
            // 
            this.DateEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DateEnd.CustomFormat = "dd/M/yyyy";
            this.DateEnd.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateEnd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DateEnd.Location = new System.Drawing.Point(957, 105);
            this.DateEnd.Margin = new System.Windows.Forms.Padding(4);
            this.DateEnd.Name = "DateEnd";
            this.DateEnd.Size = new System.Drawing.Size(109, 29);
            this.DateEnd.TabIndex = 14;
            this.DateEnd.Value = new System.DateTime(2020, 12, 31, 19, 26, 0, 0);
            this.DateEnd.ValueChanged += new System.EventHandler(this.DateEnd_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee UI", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 30);
            this.label1.TabIndex = 13;
            this.label1.Text = "Hóa Đơn Bán";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(675, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 21);
            this.label2.TabIndex = 16;
            this.label2.Text = "Từ Ngày";
            // 
            // DateStart
            // 
            this.DateStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DateStart.CustomFormat = "dd/M/yyyy";
            this.DateStart.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateStart.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DateStart.Location = new System.Drawing.Point(750, 105);
            this.DateStart.Margin = new System.Windows.Forms.Padding(4);
            this.DateStart.Name = "DateStart";
            this.DateStart.Size = new System.Drawing.Size(114, 29);
            this.DateStart.TabIndex = 15;
            this.DateStart.Value = new System.DateTime(2020, 1, 1, 18, 44, 0, 0);
            this.DateStart.ValueChanged += new System.EventHandler(this.DateStart_ValueChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(871, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 21);
            this.label3.TabIndex = 17;
            this.label3.Text = "Đến Ngày";
            // 
            // panelDatagrid
            // 
            this.panelDatagrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDatagrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelDatagrid.Controls.Add(this.DanhsachHoaDon);
            this.panelDatagrid.Location = new System.Drawing.Point(0, 139);
            this.panelDatagrid.Name = "panelDatagrid";
            this.panelDatagrid.Size = new System.Drawing.Size(1080, 516);
            this.panelDatagrid.TabIndex = 23;
            // 
            // DanhsachHoaDon
            // 
            this.DanhsachHoaDon.AllowDrop = true;
            this.DanhsachHoaDon.AllowUserToAddRows = false;
            this.DanhsachHoaDon.AllowUserToResizeColumns = false;
            this.DanhsachHoaDon.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DanhsachHoaDon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DanhsachHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DanhsachHoaDon.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(148)))), ((int)(((byte)(181)))));
            this.DanhsachHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DanhsachHoaDon.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.DanhsachHoaDon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DanhsachHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DanhsachHoaDon.ColumnHeadersHeight = 30;
            this.DanhsachHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DanhsachHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DanhsachHoaDon.EnableHeadersVisualStyles = false;
            this.DanhsachHoaDon.GridColor = System.Drawing.SystemColors.ControlLight;
            this.DanhsachHoaDon.Location = new System.Drawing.Point(0, 0);
            this.DanhsachHoaDon.MultiSelect = false;
            this.DanhsachHoaDon.Name = "DanhsachHoaDon";
            this.DanhsachHoaDon.ReadOnly = true;
            this.DanhsachHoaDon.RowHeadersVisible = false;
            this.DanhsachHoaDon.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.DanhsachHoaDon.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DanhsachHoaDon.RowTemplate.Height = 30;
            this.DanhsachHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DanhsachHoaDon.Size = new System.Drawing.Size(1080, 516);
            this.DanhsachHoaDon.TabIndex = 3;
            this.DanhsachHoaDon.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DanhsachHoaDon_CellDoubleClick);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(60)))), ((int)(((byte)(0)))));
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Image = ((System.Drawing.Image)(resources.GetObject("buttonDelete.Image")));
            this.buttonDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDelete.Location = new System.Drawing.Point(848, 12);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.buttonDelete.Size = new System.Drawing.Size(104, 48);
            this.buttonDelete.TabIndex = 25;
            this.buttonDelete.Text = "Xóa";
            this.buttonDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // CF_HOADON
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 654);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelDatagrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CF_HOADON";
            this.Text = "CF_HOADON";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelDatagrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DanhsachHoaDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker DateEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DateStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelDatagrid;
        private System.Windows.Forms.DataGridView DanhsachHoaDon;
        private System.Windows.Forms.TextBox textBoxFind;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Button buttonDelete;
    }
}