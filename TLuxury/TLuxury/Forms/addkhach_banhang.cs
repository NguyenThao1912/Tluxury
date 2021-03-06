﻿using StoreLibrary;
using System;
using System.Data;
using System.Windows.Forms;

namespace TLuxury.Forms
{
    public partial class addkhach_banhang : Form
    {
        public addkhach_banhang()
        {
            InitializeComponent();
        }

        public addkhach_banhang(CF_BANHANG.sendma sendma)
        {
            InitializeComponent();
            this.send = sendma;
        }
        public CF_BANHANG.sendma send;
        private void addkhach_banhang_Load(object sender, EventArgs e)
        {
            laydata();
        }

        private void laydata()
        {
            DataTable model = GlobalConfig.Connection.GetAllCustomers();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = model;
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.send(this.textBox1.Text, this.textBox2.Text);

            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                laydata();
            }
            else
            {
                DataTable table = new DataTable();
                table = GlobalConfig.Connection.FindCustomerByName($"{textBox3.Text.Trim()}");
                try
                {
                    if (table.Rows.Count > 0)
                    {
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = table;
                        dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                        dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }

                }
                catch (Exception b)
                {
                    MessageBox.Show($"Xảy ra lỗi trong quá trình tìm kiếm {b} ", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddCustomer add = new AddCustomer();
            add.Show();
        }
    }
}
