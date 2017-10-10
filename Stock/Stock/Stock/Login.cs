﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Stock
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            UserNameTextBox.Text = "";
            PasswordTextBox.Clear();
            UserNameTextBox.Focus();

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            //TO DO: Check Login UserName & Password

            SqlConnection con = new SqlConnection("Data Source = .\\SQLEXPRESS;Initial Catalog=Stock;Integrated Security=True");

            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT *
                                                     FROM [dbo].[Login] where UserName = '" + UserNameTextBox.Text + "' and Password = '" + PasswordTextBox.Text + "'", con);

            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                this.Hide();
                StockMain main = new StockMain();
                main.Show();

            }

            else
            {
                MessageBox.Show("Invalid Username & Password..","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearButton_Click(sender, e);

            }

        }
    }
}
