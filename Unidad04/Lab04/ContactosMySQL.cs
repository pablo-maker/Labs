using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Lab04
{
    class ContactosMySQL : Contactos
    {
        protected string connectionString
        {
            get
            {
                return "server=localhost;database=net;uid=root;";
            }
        }
        public override DataTable getTabla()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                MySqlCommand cmdSelect = new MySqlCommand("SELECT * FROM contactos", conn);
                conn.Open();
                MySqlDataReader reader = cmdSelect.ExecuteReader();
                DataTable contactos = new DataTable();
                if (reader != null)
                {
                    contactos.Load(reader);
                }
                conn.Close();
                return contactos;
            }
        }
    }
}
