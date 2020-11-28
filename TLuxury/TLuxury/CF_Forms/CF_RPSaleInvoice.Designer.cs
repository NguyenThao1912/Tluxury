namespace TLuxury.CF_Forms
{
    partial class CF_RPSaleInvoice
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonbaoCao = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxThang = new System.Windows.Forms.ComboBox();
            this.DanhsachSP = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.labelAmount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DanhsachSP)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonbaoCao
            // 
            this.buttonbaoCao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonbaoCao.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonbaoCao.Location = new System.Drawing.Point(805, 66);
            this.buttonbaoCao.Name = "buttonbaoCao";
            this.buttonbaoCao.Size = new System.Drawing.Size(113, 43);
            this.buttonbaoCao.TabIndex = 17;
            this.buttonbaoCao.Text = "Xuất Báo Cáo";
            this.buttonbaoCao.UseVisualStyleBackColor = true;
            this.buttonbaoCao.Click += new System.EventHandler(this.buttonXuatBaoCao_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Leelawadee UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(216, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(627, 30);
            this.label2.TabIndex = 16;
            this.label2.Text = "Báo Cáo Danh Sách Hóa Đơn Và Tổng Tiền Bán Hàng Theo Tháng";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "Chọn Tháng";
            // 
            // comboBoxThang
            // 
            this.comboBoxThang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxThang.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxThang.FormattingEnabled = true;
            this.comboBoxThang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboBoxThang.Location = new System.Drawing.Point(416, 74);
            this.comboBoxThang.Name = "comboBoxThang";
            this.comboBoxThang.Size = new System.Drawing.Size(271, 29);
            this.comboBoxThang.TabIndex = 14;
            this.comboBoxThang.SelectedIndexChanged += new System.EventHandler(this.comboBoxThang_SelectedIndexChanged);
            // 
            // DanhsachSP
            // 
            this.DanhsachSP.AllowDrop = true;
            this.DanhsachSP.AllowUserToAddRows = false;
            this.DanhsachSP.AllowUserToResizeColumns = false;
            this.DanhsachSP.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DanhsachSP.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DanhsachSP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DanhsachSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DanhsachSP.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(148)))), ((int)(((byte)(181)))));
            this.DanhsachSP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DanhsachSP.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.DanhsachSP.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DanhsachSP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DanhsachSP.ColumnHeadersHeight = 30;
            this.DanhsachSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DanhsachSP.DefaultCellStyle = dataGridViewCellStyle7;
            this.DanhsachSP.EnableHeadersVisualStyles = false;
            this.DanhsachSP.GridColor = System.Drawing.SystemColors.ControlLight;
            this.DanhsachSP.Location = new System.Drawing.Point(58, 136);
            this.DanhsachSP.MultiSelect = false;
            this.DanhsachSP.Name = "DanhsachSP";
            this.DanhsachSP.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DanhsachSP.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DanhsachSP.RowHeadersVisible = false;
            this.DanhsachSP.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.DanhsachSP.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DanhsachSP.RowTemplate.Height = 30;
            this.DanhsachSP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DanhsachSP.Size = new System.Drawing.Size(966, 478);
            this.DanhsachSP.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 21);
            this.label3.TabIndex = 18;
            this.label3.Text = "Năm";
            // 
            // textBoxYear
            // 
            this.textBoxYear.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxYear.Location = new System.Drawing.Point(123, 74);
            this.textBoxYear.MaxLength = 4;
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(46, 29);
            this.textBoxYear.TabIndex = 19;
            this.textBoxYear.Text = "2020";
            this.textBoxYear.TextChanged += new System.EventHandler(this.textBoxYear_TextChanged);
            this.textBoxYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxYear_KeyPress);
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelAmount.Location = new System.Drawing.Point(464, 112);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(79, 17);
            this.labelAmount.TabIndex = 20;
            this.labelAmount.Text = "Tổng Tiền :";
            // 
            // CF_RPSaleInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 654);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonbaoCao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxThang);
            this.Controls.Add(this.DanhsachSP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CF_RPSaleInvoice";
            this.Text = "CF_RPSaleInvoice";
            ((System.ComponentModel.ISupportInitialize)(this.DanhsachSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonbaoCao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxThang;
        private System.Windows.Forms.DataGridView DanhsachSP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.Label labelAmount;
    }
}