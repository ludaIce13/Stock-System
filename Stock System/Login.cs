﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //TO-DO: Check Login Username & Password
            SqlConnection con = new SqlConnection("Data Source=TAQ13\\MSSQLSERVER01;Initial Catalog=\"Stock Exchange\";Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT * FROM [dbo].[Login] where Username = '" + textBox1.Text + "' and Password = '" + textBox2.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)


            {
                this.Hide();
                StockSystem main = new StockSystem();
                main.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username & Password..!", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                button1_Click(sender, e);

            }
        }
    }
}
