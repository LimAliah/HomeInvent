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
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            int inid;
            if (int.TryParse(textBox1.Text, out inid))
            {
                // Parsing succeeded, you can use productid safely
                MessageBox.Show("Inventory ID: " + inid);
            }
            else
            {
                // Parsing failed, handle the error gracefully
                MessageBox.Show("Please enter a valid number.");
            }

            int productid = int.Parse(textBox2.Text);
            int quantity = int.Parse(textBox2.Text);



            string query = "INSERT INTO Inventory (InId, ProductId, Quantity) VALUES (@InId, @ProductId, @Quantity)";
            using (MySqlConnection conn = new DatabaseConnection().GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@InId", inid );
                    cmd.Parameters.AddWithValue("@ProductId", productid);
                    cmd.Parameters.AddWithValue("@Quantity", quantity);
                    cmd.ExecuteNonQuery();

                }
            }
            MessageBox.Show("Record Inserted Successfully");
            InventoryLoad();
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            InventoryLoad();
        }

        private void InventoryLoad()
        {
            string query = "SELECT * FROM Inventory";
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
            int inid;
            if (int.TryParse(textBox1.Text, out inid))
            {
                // Parsing succeeded, you can use productid safely
                MessageBox.Show("Inventory ID: " + inid);
            }
            else
            {
                // Parsing failed, handle the error gracefully
                MessageBox.Show("Please enter a valid number.");
            }

            int productid = int.Parse(textBox2.Text);
            int quantity = int.Parse(textBox2.Text);



            string query = "UPDATE Inventory SET ProductId=@ProductId, Quantity=@Quantity WHERE InventoryId=@InventoryId";
            using (MySqlConnection conn = new DatabaseConnection().GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@InId", inid);
                    cmd.Parameters.AddWithValue("@ProductId", productid);
                    cmd.Parameters.AddWithValue("@Quantity", quantity);
                    cmd.ExecuteNonQuery();

                }
            }
            MessageBox.Show("Record Updated Successfully");
            InventoryLoad();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int inid = int.Parse(textBox1.Text);

            string query = "DELETE FROM Inventory WHERE InventoryId=@InventoryId";
            using (MySqlConnection conn = new DatabaseConnection().GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@InId", inid);
                    cmd.ExecuteNonQuery();

                }
            }
            MessageBox.Show("Record Updated Successfully");
            InventoryLoad();
        }
    }
}
