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
        public override void aplicarCambios()
        {
            using (MySqlConnection Conn = new MySqlConnection(connectionString))
            {
                MySqlCommand cmdInsert = new MySqlCommand("INSERT INTO contactos VALUES(@id,@nombre,@apellido,@email,@telefono)", Conn);
                cmdInsert.Parameters.Add("@id", MySqlDbType.Int32);
                cmdInsert.Parameters.Add("@nombre", MySqlDbType.VarChar);
                cmdInsert.Parameters.Add("@apellido", MySqlDbType.VarChar);
                cmdInsert.Parameters.Add("@email", MySqlDbType.VarChar);
                cmdInsert.Parameters.Add("@telefono", MySqlDbType.VarChar);

                MySqlCommand cmdUpdate = new MySqlCommand(
                "UPDATE contactos SET nombre=@nombre, apellido=@apellido,email=@email,telefono=@telefono where id=@id", Conn);
                cmdUpdate.Parameters.Add("@id", MySqlDbType.Int32);
                cmdUpdate.Parameters.Add("@nombre", MySqlDbType.VarChar);
                cmdUpdate.Parameters.Add("@apellido", MySqlDbType.VarChar);
                cmdUpdate.Parameters.Add("@email", MySqlDbType.VarChar);
                cmdUpdate.Parameters.Add("@telefono", MySqlDbType.VarChar);

                MySqlCommand cmdDelete = new MySqlCommand("DELETE FROM contactos WHERE id=@id", Conn);
                cmdDelete.Parameters.Add("@id", MySqlDbType.Int32);

                DataTable filasNuevas = this.misContactos.GetChanges(DataRowState.Added);//Buscamos filas que fueron agregadas
                DataTable filasBorradas = this.misContactos.GetChanges(DataRowState.Deleted);//Buscamos filas que fueron borradas
                DataTable filasModificadas = this.misContactos.GetChanges(DataRowState.Modified);//Buscamos filas que fueron modificadas

                Conn.Open();

                if (filasNuevas != null)
                {
                    foreach (DataRow fila in filasNuevas.Rows)
                    {
                        cmdInsert.Parameters["@id"].Value = fila["id"];
                        cmdInsert.Parameters["@nombre"].Value = fila["nombre"];
                        cmdInsert.Parameters["@apellido"].Value = fila["apellido"];
                        cmdInsert.Parameters["@email"].Value = fila["email"];
                        cmdInsert.Parameters["@telefono"].Value = fila["telefono"];
                        cmdInsert.ExecuteNonQuery();
                    }
                }
                if (filasBorradas != null)
                {
                    foreach (DataRow fila in filasBorradas.Rows)
                    {
                        cmdDelete.Parameters["@id"].Value = fila["id", DataRowVersion.Original];
                        cmdDelete.ExecuteNonQuery();
                    }
                }
                if (filasModificadas != null)
                {
                    foreach (DataRow fila in filasModificadas.Rows)
                    {
                        cmdUpdate.Parameters["@id"].Value = fila["id"];
                        cmdUpdate.Parameters["@nombre"].Value = fila["nombre"];
                        cmdUpdate.Parameters["@apellido"].Value = fila["apellido"];
                        cmdUpdate.Parameters["@email"].Value = fila["email"];
                        cmdUpdate.Parameters["@telefono"].Value = fila["telefono"];
                        cmdUpdate.ExecuteNonQuery();
                    }
                }

                Conn.Close();
                this.misContactos.AcceptChanges();
            }
        }

    }
}
