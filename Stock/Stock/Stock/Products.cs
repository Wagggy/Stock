using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock
{
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }

        private void Products_Load(object sender, EventArgs e)
        
        {
            StatusComboBox.SelectedIndex = 0;
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = .\\SQLEXPRESS;Initial Catalog=Stock;Integrated Security=True");
            
            //Insert Logic
            con.Open();

            bool status = false;

            if (StatusComboBox.SelectedIndex == 0) 
            {

                status = true;
            }

            else
            {
                status = false;
            }

            var sqlQuery = "";

            if (IfProductsExists(con, ProductCodeTextBox.Text)) 
            {

                sqlQuery = @"UPDATE [Products] SET [ProductName] = '" + ProductNameTextBox.Text + "',[Status] = '" + status + "'WHERE [ProductCode] = '" + ProductCodeTextBox.Text + "'";
            
            }

            else
            {
                sqlQuery = @"INSERT INTO [dbo].[Products] ([ProductCode], [ProductName],[Status]) VALUES
                           ('" + ProductCodeTextBox.Text + "','" + ProductNameTextBox.Text + "','" + status + "')";
            }

            SqlCommand cmd = new SqlCommand(sqlQuery,con);

            cmd.ExecuteNonQuery();

            con.Close();

            // Reading Data

            LoadData();

        }


        private bool IfProductsExists(SqlConnection con, string productCode) 
        {

            //SqlConnection con = new SqlConnection("Data Source = .\\SQLEXPRESS;Initial Catalog=Stock;Integrated Security=True");

            SqlDataAdapter sda = new SqlDataAdapter(" SELECT 1 FROM [Products] WHERE[ProductCode] = '" + productCode + "'", con);

            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                return true;
            }

            else
            {
                return false;
            }
            
        }



       // Function to load data on form load
        public void LoadData()
        {

            SqlConnection con = new SqlConnection("Data Source = .\\SQLEXPRESS;Initial Catalog=Stock;Integrated Security=True");

            SqlDataAdapter sda = new SqlDataAdapter(" SELECT * FROM [dbo].[Products]", con);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            // ctrl, K, X, then Visual C# then select Foreach

            dataGridView1.Rows.Clear();  // Clears the data grid view row after in

            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item["ProductCode"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item["ProductName"].ToString();


                if ((bool)item["Status"])
                {

                    dataGridView1.Rows[n].Cells[2].Value = "Active";
                }

                else
                {
                    dataGridView1.Rows[n].Cells[2].Value = "Deactive";
                }

            }

        }// End of the Function
    

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            ProductCodeTextBox.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            ProductNameTextBox.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();

            if (dataGridView1.SelectedRows[0].Cells[2].Value.ToString() == "Active")
            {

                StatusComboBox.SelectedIndex = 0;
            }

            else
            {
                StatusComboBox.SelectedIndex = 1;
            }


        }

        private void DeleteItemButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = .\\SQLEXPRESS;Initial Catalog=Stock;Integrated Security=True");



            var sqlQuery = "";

            if (IfProductsExists(con, ProductCodeTextBox.Text))
            {
                con.Open();

                sqlQuery = @"DELETE FROM [Products] WHERE [ProductCode] = '" + ProductCodeTextBox.Text + "'";

                SqlCommand cmd = new SqlCommand(sqlQuery, con);

                cmd.ExecuteNonQuery();

                con.Close();

            }

            else
            {
                MessageBox.Show("Record Not Found....!");
            }

           

            // Reading Data

            LoadData();


        }
    }


}
