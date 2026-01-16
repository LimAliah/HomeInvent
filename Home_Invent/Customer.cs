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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Home_Invent
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnInsertC_Click(object sender, EventArgs e)
        {
            int customerid;
            if (int.TryParse(textBox1.Text, out customerid))
            {
                // Parsing succeeded, you can use productid safely
                MessageBox.Show("Customer ID: " + customerid);
            }
            else
            {
                // Parsing failed, handle the error gracefully
                MessageBox.Show("Please enter a valid number.");
            }

            string customername = textBox2.Text;
            string contact = (textBox3.Text);



            string query = "INSERT INTO Customers (CustomerId, CustomerName, Contact) VALUES (@CustomerId, @CustomerName, @Contact)";
            using (MySqlConnection conn = new DatabaseConnection().GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CustomerId", customerid);
                    cmd.Parameters.AddWithValue("@CustomerName", customername);
                    cmd.Parameters.AddWithValue("@Contact", contact);

                    cmd.ExecuteNonQuery();

                }
            }
            MessageBox.Show("Record Insert Successfully");
            CustomerLoad();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            CustomerLoad();
        }
        private void CustomerLoad()
        {
            string query = "SELECT * FROM Customers";
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

        private void btnUpdateC_Click(object sender, EventArgs e)
        {
            int customerid;
            if (int.TryParse(textBox1.Text, out customerid))
            {
                // Parsing succeeded, you can use productid safely
                MessageBox.Show("Customer ID: " + customerid);
            }
            else
            {
                // Parsing failed, handle the error gracefully
                MessageBox.Show("Please enter a valid number.");
            }

            string customername = textBox2.Text;
            string contact = (textBox3.Text);



            string query = "UPDATE Customers SET CustomernName=@CustomerName, Contact=@Contact WHERE CustomerId=@CustomerId";
            using (MySqlConnection conn = new DatabaseConnection().GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CustomerId", customerid);
                    cmd.Parameters.AddWithValue("@CustomerName", customername);
                    cmd.Parameters.AddWithValue("@Contact", contact);

                    cmd.ExecuteNonQuery();

                }
            }
            MessageBox.Show("Record Updated Successfully");
            CustomerLoad();
        }

        private void btnDeleteD_Click(object sender, EventArgs e)
        {
            int customerid;
            if (int.TryParse(textBox1.Text, out customerid))
            {
                // Parsing succeeded, you can use productid safely
                MessageBox.Show("Customer ID: " + customerid);
            }
            else
            {
                // Parsing failed, handle the error gracefully
                MessageBox.Show("Please enter a valid number.");
            }


            string query = "DELETE FROM Customers WHERE CustomerId=@CustomerId";
            using (MySqlConnection conn = new DatabaseConnection().GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CustomerId", customerid);
                    

                    cmd.ExecuteNonQuery();

                }
            }
            MessageBox.Show("Record Deleted Successfully");
            CustomerLoad();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            string query = "SELECT * FROM Customers";
        }
    }
}

