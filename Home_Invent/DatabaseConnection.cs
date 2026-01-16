using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Invent
{
    internal class DatabaseConnection
    {
        private MySqlConnection connection;

        public DatabaseConnection()
        {
            string constring = "Server=localhost;Database=inventorydb;Uid=root;Pwd=1234567;";
            connection = new MySqlConnection(constring);
        }

        public MySqlConnection GetConnection() 
        {
            return connection;
                

               
        }
    }
}
