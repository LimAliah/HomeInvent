using MySql.Data.MySqlClient;
using Mysqlx.Crud;
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
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int orderid;
            if (int.TryParse(textBox1.Text, out orderid))
            {
                // Parsing succeeded, you can use productid safely
                MessageBox.Show("Order ID: " + orderid);
            }
            else
            {
                // Parsing failed, handle the error gracefully
                MessageBox.Show("Please enter a valid number.");
            }



            string query = "DELETE Orders FROM Orders WHERE OrderId=@OrderId";
            using (MySqlConnection conn = new DatabaseConnection().GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@OrderId", orderid);
                

                    cmd.ExecuteNonQuery();

                }
            }
            MessageBox.Show("Record Deleted Successfully");
            OrderLoad();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int orderid;
            if (int.TryParse(textBox1.Text, out orderid))
            {
                // Parsing succeeded, you can use productid safely
                MessageBox.Show("Order ID: " + orderid);
            }
            else
            {
                // Parsing failed, handle the error gracefully
                MessageBox.Show("Please enter a valid number.");
            }

            int productid = int.Parse(textBox2.Text);
            int customerid = int.Parse(textBox3.Text);
            int quantity = int.Parse(textBox4.Text);
            string orderdate = dateTimePicker1.Value.ToString("yy-MM-dd");



            string query = "UPDATE Orders SET ProductId=@ProductId, CustomerId=@CustomerId Quantity=@Quantity, OrderDate=@OrderDate WHERE OrderId=@OrderId";
            using (MySqlConnection conn = new DatabaseConnection().GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@OrderId", orderid);
                    cmd.Parameters.AddWithValue("@ProductId", productid);
                    cmd.Parameters.AddWithValue("@CustomerId", customerid);
                    cmd.Parameters.AddWithValue("@Quantity", quantity);
                    cmd.Parameters.AddWithValue("@OrderDate", dateTimePicker1.Value);

                    cmd.ExecuteNonQuery();

                }
            }
            MessageBox.Show("Record Updated Successfully");
            OrderLoad();
        }


        private void btnInsert_Click(object sender, EventArgs e)
        {
            int orderid;
            if (int.TryParse(textBox1.Text, out orderid))
            {
                // Parsing succeeded, you can use productid safely
                MessageBox.Show("Order ID: " + orderid);
            }
            else
            {
                // Parsing failed, handle the error gracefully
                MessageBox.Show("Please enter a valid number.");
            }

            int productid = int.Parse(textBox2.Text);
            int customerid = int.Parse(textBox3.Text);
            int quantity = int.Parse(textBox4.Text);
            string orderdate = dateTimePicker1.Value.ToString("yy-MM-dd");



            string query = "INSERT INTO Orders (OrderId, ProductId, CustomerId, Quantity, OrderDate) VALUES (@OrderId, @ProductId, @CustomerId, @Quantity, @OrderDate)";

            using (MySqlConnection conn = new DatabaseConnection().GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@OrderId", orderid);
                    cmd.Parameters.AddWithValue("@ProductId", productid);
                    cmd.Parameters.AddWithValue("@CustomerId", customerid);
                    cmd.Parameters.AddWithValue("@Quantity", quantity);
                    cmd.Parameters.AddWithValue("@OrderDate", dateTimePicker1.Value); // or .ToString("yyyy-MM-dd HH:mm:ss")

                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Record Insert Successfully");
            OrderLoad();
        }



        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Order_Load(object sender, EventArgs e)
        {
            OrderLoad();
        }
        private void OrderLoad()
        {
            string query = "SELECT * FROM Orders";
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
    }
}


