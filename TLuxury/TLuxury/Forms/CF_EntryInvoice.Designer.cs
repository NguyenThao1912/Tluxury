namespace TLuxury.Forms
{
    partial class CF_EntryInvoice
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CF_EntryInvoice));
            this.panelDatagrid = new System.Windows.Forms.Panel();
            this.DanhsachHoaDon = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.DateEnd = new System.Windows.Forms.DateTimePicker();
            this.DateStart = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonThêm = new System.Windows.Forms.Button();
            this.textBoxFind = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelDatagrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DanhsachHoaDon)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.panelDatagrid.Size = new System.Drawing.Size(1064, 635);
            this.panelDatagrid.TabIndex = 12;
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
            this.DanhsachHoaDon.Size = new System.Drawing.Size(1064, 635);
            this.DanhsachHoaDon.TabIndex = 3;
            this.toolTip1.SetToolTip(this.DanhsachHoaDon, "\"Double Click Để xem thông tin\"");
            this.DanhsachHoaDon.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DanhsachHoaDon_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee UI", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 30);
            this.label1.TabIndex = 13;
            this.label1.Text = "Hóa Đơn Nhập";
            // 
            // DateEnd
            // 
            this.DateEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DateEnd.CustomFormat = "dd/M/yyyy";
            this.DateEnd.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateEnd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DateEnd.Location = new System.Drawing.Point(941, 105);
            this.DateEnd.Margin = new System.Windows.Forms.Padding(4);
            this.DateEnd.Name = "DateEnd";
            this.DateEnd.Size = new System.Drawing.Size(109, 29);
            this.DateEnd.TabIndex = 14;
            this.DateEnd.ValueChanged += new System.EventHandler(this.DateEnd_ValueChanged);
            // 
            // DateStart
            // 
            this.DateStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DateStart.CustomFormat = "dd/M/yyyy";
            this.DateStart.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateStart.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DateStart.Location = new System.Drawing.Point(734, 105);
            this.DateStart.Margin = new System.Windows.Forms.Padding(4);
            this.DateStart.Name = "DateStart";
            this.DateStart.Size = new System.Drawing.Size(114, 29);
            this.DateStart.TabIndex = 15;
            this.DateStart.Value = new System.DateTime(2019, 10, 24, 18, 44, 0, 0);
            this.DateStart.ValueChanged += new System.EventHandler(this.DateStart_ValueChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(659, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 21);
            this.label2.TabIndex = 16;
            this.label2.Text = "Từ Ngày";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(855, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 21);
            this.label3.TabIndex = 17;
            this.label3.Text = "Đến Ngày";
            // 
            // buttonThêm
            // 
            this.buttonThêm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonThêm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(245)))));
            this.buttonThêm.FlatAppearance.BorderSize = 0;
            this.buttonThêm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThêm.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThêm.ForeColor = System.Drawing.Color.White;
            this.buttonThêm.Image = ((System.Drawing.Image)(resources.GetObject("buttonThêm.Image")));
            this.buttonThêm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonThêm.Location = new System.Drawing.Point(944, 12);
            this.buttonThêm.Name = "buttonThêm";
            this.buttonThêm.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.buttonThêm.Size = new System.Drawing.Size(108, 48);
            this.buttonThêm.TabIndex = 19;
            this.buttonThêm.Text = "Thêm ";
            this.buttonThêm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonThêm.UseVisualStyleBackColor = false;
            this.buttonThêm.Click += new System.EventHandler(this.buttonThêm_Click);
            // 
            // textBoxFind
            // 
            this.textBoxFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxFind.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFind.Location = new System.Drawing.Point(21, 101);
            this.textBoxFind.Name = "textBoxFind";
            this.textBoxFind.Size = new System.Drawing.Size(404, 29);
            this.textBoxFind.TabIndex = 20;
            this.textBoxFind.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            "Tìm Theo Tên Nhà Cung Cấp",
            "Tìm Theo Tên Nhân Viên"});
            this.comboBox1.Location = new System.Drawing.Point(21, 65);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(202, 29);
            this.comboBox1.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(247)))), ((int)(((byte)(245)))));
            this.panel1.Controls.Add(this.DateEnd);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.buttonThêm);
            this.panel1.Controls.Add(this.DateStart);
            this.panel1.Controls.Add(this.textBoxFind);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1064, 138);
            this.panel1.TabIndex = 22;
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 1;
            this.toolTip1.ReshowDelay = 100;
            // 
            // CF_EntryInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(247)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1064, 615);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelDatagrid);
            this.Name = "CF_EntryInvoice";
            this.Text = "CF_EntryInvoice";
            this.panelDatagrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DanhsachHoaDon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelDatagrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DateEnd;
        private System.Windows.Forms.DateTimePicker DateStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonThêm;
        private System.Windows.Forms.DataGridView DanhsachHoaDon;
        private System.Windows.Forms.TextBox textBoxFind;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}