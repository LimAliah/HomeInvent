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
    public partial class Supplier : Form
    {
        public Supplier()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            int sid;
            if (int.TryParse(textBox1.Text, out sid))
            {
                // Parsing succeeded, you can use productid safely
                MessageBox.Show("Supplier ID: " + sid);
            }
            else
            {
                // Parsing failed, handle the error gracefully
                MessageBox.Show("Please enter a valid number.");
            }

            string name = textBox2.Text;
            string contact = textBox3.Text;



            string query = "INSERT INTO Suppliers (SId, Name, Contact) VALUES (@SId, @Name, @Contact)";
            using (MySqlConnection conn = new DatabaseConnection().GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@SId", sid);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Contact", contact);
                    cmd.ExecuteNonQuery();

                }
            }
            MessageBox.Show("Record Inserted Successfully");
            SupplierLoad();
        }

        private void Supplier_Load(object sender, EventArgs e)
        {
            SupplierLoad();
        }
        private void SupplierLoad()
        {
            string query = "SELECT * FROM Suppliers";
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int sid;
            if (int.TryParse(textBox1.Text, out sid))
            {
                // Parsing succeeded, you can use productid safely
                MessageBox.Show("Supplier ID: " + sid);
            }
            else
            {
                // Parsing failed, handle the error gracefully
                MessageBox.Show("Please enter a valid number.");
            }

            string name = textBox2.Text;
            string contact = textBox3.Text;



            string query = "UPDATE Suppliers SET Name=@Name, Contact=@Contact WHERE SId=@SId";
            using (MySqlConnection conn = new DatabaseConnection().GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@SId", sid);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Contact", contact);
                    cmd.ExecuteNonQuery();

                }
            }
            MessageBox.Show("Record Updated Successfully");
            SupplierLoad();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int sid = int.Parse(textBox1.Text);
         

            


            string query = "DELETE Suppliers WHERE SId=@SId";
            using (MySqlConnection conn = new DatabaseConnection().GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@SId", sid);
            
                    cmd.ExecuteNonQuery();

                }
            }
            MessageBox.Show("Record Deleted Successfully");
            SupplierLoad();
        }
    }
    }


