using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home_Invent
{
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int productid;
            if (!int.TryParse(textBox1.Text, out productid))
            {
                MessageBox.Show("Please enter a valid Product ID.");
                return;
            }

            string productname = textBox2.Text;

            int price;
            if (!int.TryParse(textBox3.Text, out price))
            {
                MessageBox.Show("Please enter a valid Price.");
                return;
            }

            int quantity;
            if (!int.TryParse(textBox4.Text, out quantity))
            {
                MessageBox.Show("Please enter a valid Quantity.");
                return;
            }

            string query = "UPDATE Products SET ProductName=@ProductName, Price=@Price, Quantity=@Quantity WHERE ProductId=@ProductId";
            using (MySqlConnection conn = new DatabaseConnection().GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ProductId", productid);
                    cmd.Parameters.AddWithValue("@ProductName", productname);
                    cmd.Parameters.AddWithValue("@Price", price);
                    cmd.Parameters.AddWithValue("@Quantity", quantity);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                        MessageBox.Show("Record Updated Successfully");
                    else
                        MessageBox.Show("No record found with that Product ID.");
                }
            }
            ProductLoad();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int productid;
            if (!int.TryParse(textBox1.Text, out productid))
            {
                MessageBox.Show("Please enter a valid Product ID.");
                return;
            }

            string query = "DELETE FROM Products WHERE ProductId=@ProductId";
            using (MySqlConnection conn = new DatabaseConnection().GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ProductId", productid);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                        MessageBox.Show("Record Deleted Successfully");
                    else
                        MessageBox.Show("No record found with that Product ID.");
                }
            }
            ProductLoad();
        }

        private void btnInsert_Click_1(object sender, EventArgs e)
        {
            int productid;
            if (int.TryParse(textBox1.Text, out productid))
            {
                // Parsing succeeded, you can use productid safely
                MessageBox.Show("Product ID: " + productid);
            }
            else
            {
                // Parsing failed, handle the error gracefully
                MessageBox.Show("Please enter a valid number.");
            }

            string productname = textBox2.Text;
            int price = int.Parse(textBox3.Text);
            string quantity = textBox4.Text;


            string query = "INSERT INTO Products (ProductId, ProductName, Price, Quantity) VALUES (@ProductId, @ProductName, @Price, @Quantity)";
            using (MySqlConnection conn = new DatabaseConnection().GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ProductId", productid);
                    cmd.Parameters.AddWithValue("@ProductName", productname);
                    cmd.Parameters.AddWithValue("@Price", price);
                    cmd.Parameters.AddWithValue("@Quantity", quantity);
                    cmd.ExecuteNonQuery();

                }
            }
            MessageBox.Show("Record Insert Successfully");
            ProductLoad();
        }

        private void Product_Load(object sender, EventArgs e)
        {
            ProductLoad();
        }

        private void ProductLoad()
        {
            string query = "SELECT * FROM Products";
            using (MySqlConnection conn = new DatabaseConnection().GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Force refresh
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = dataTable;
                        dataGridView1.AutoGenerateColumns = true;
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

