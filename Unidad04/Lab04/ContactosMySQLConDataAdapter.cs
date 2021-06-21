﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Lab04
{
    class ContactosMySQLConDataAdapter : Contactos
    {
        protected string connectionString
        {
            get
            {
                return "server=localhost;database=net;uid=root;";
            }
        }
        public ContactosMySQLConDataAdapter() : base() //Invoca primero contructor de la clase padre contactos
        {
            this.adapater.InsertCommand = new MySqlCommand(
                "insert into contactos values(@id,@nombre,@apellido,@email,@telefono)");
            this.adapater.InsertCommand.Parameters.Add("@id", MySqlDbType.Int32, 1, "id");
            this.adapater.InsertCommand.Parameters.Add("@nombre", MySqlDbType.VarChar, 20, "nombre");
            this.adapater.InsertCommand.Parameters.Add("@apellido", MySqlDbType.VarChar, 20, "apellido");
            this.adapater.InsertCommand.Parameters.Add("@email", MySqlDbType.VarChar, 50, "email");
            this.adapater.InsertCommand.Parameters.Add("@telefono", MySqlDbType.VarChar, 10, "telefono");

            this.adapater.UpdateCommand = new MySqlCommand(
                "update contactos set nombre=@nombre, apellido=@apellido, email=@email,telefono=@telefono " +
                " where id=@id");
            this.adapater.UpdateCommand.Parameters.Add("@id", MySqlDbType.Int32, 1, "id");
            this.adapater.UpdateCommand.Parameters.Add("@nombre", MySqlDbType.VarChar, 20, "nombre");
            this.adapater.UpdateCommand.Parameters.Add("@apellido", MySqlDbType.VarChar, 20, "apellido");
            this.adapater.UpdateCommand.Parameters.Add("@email", MySqlDbType.VarChar, 50, "email");
            this.adapater.UpdateCommand.Parameters.Add("@telefono", MySqlDbType.VarChar, 10, "telefono");

            this.adapater.DeleteCommand = new MySqlCommand("delete from contactos where id=@id");
            this.adapater.DeleteCommand.Parameters.Add("@id", MySqlDbType.Int32, 1, "id");
        }
        public override DataTable getTabla()
        {
            this.adapater = new MySqlDataAdapter("select * from contactos", this.connectionString);
            DataTable contactos = new DataTable();
            this.adapater.Fill(contactos);
            return contactos;
        }
        public override void aplicarCambios()
        {
            using (MySqlConnection Conn = new MySqlConnection(this.connectionString))
            {
                this.adapater.InsertCommand.Connection = Conn;
                this.adapater.UpdateCommand.Connection = Conn;
                this.adapater.DeleteCommand.Connection = Conn;
                this.adapater.Update(this.misContactos);
            }
        }



    }
}
