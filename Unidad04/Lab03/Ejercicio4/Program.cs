using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataTable dtEmpresas = new DataTable("Empresas");

            dtEmpresas.Columns.Add("CustomerID", typeof(string));
            dtEmpresas.Columns.Add("CompanyName", typeof(string));

            //Objeto SQLConnection
            SqlConnection myconn = new SqlConnection();
            //Indicamos el Connection String
            myconn.ConnectionString =
                "Data Source=localhost\\SQLExpress;Initial Catalog=myDataBase";
            /*
            SqlCommand mycommand = new SqlCommand();

            mycommand.CommandText = "SELECT CustomerID, CompanyName FROM Customers";
            mycommand.Connection = myconn;

            //Creamos un adaptador
            SqlDataAdapter myadap =
                new SqlDataAdapter("SELECT CustomerID, CompanyName, CompanyName FROM Customers", myconn);

            myconn.Open();

            SqlDataReader mydr = mycommand.ExecuteReader();
            dtEmpresas.Load(mydr);

            myconn.Close();
            */
            SqlDataAdapter myAdap =
                new SqlDataAdapter("SELECT CustomerID, CompanyName FROM Customers", myconn);

            myconn.Open();
            //Cargo el contenido del result set obtenido de la base de datos en el objeto datatable
            myAdap.Fill(dtEmpresas);
            myconn.Close();


            //Mostramos los datos
            Console.WriteLine("Listado de Empresas: ");
            foreach (DataRow rowEmpresas in dtEmpresas.Rows)
            {
                string idEmpresa = rowEmpresas["CustomerID"].ToString();
                string nombreEmpresa = rowEmpresas["CompanyName"].ToString();
                Console.WriteLine(idEmpresa + " - " + nombreEmpresa);

            }
            Console.ReadKey();


            //Indico el CustomerId que deseo modificar
            Console.WriteLine("Escriba el CustomerID que desea modificar: ");
            string custId = Console.ReadLine();

            //Me traigo una coleccion de dataRows que contengan ese customerid
            DataRow[] rwEmpresas = dtEmpresas.Select("CustomerID = '" + custId + "'");
            if (rwEmpresas.Length != 1)
            {
                Console.WriteLine("CustomerID no encontrado");
                Console.ReadLine();
                return;
            }
            //Primer datarow de la coleccion
            DataRow rowMiEmpresa = rwEmpresas[0];
            string nombreActual = rowMiEmpresa["CompanyName"].ToString();
            Console.WriteLine("Nombre actual de la empresa: " + nombreActual);
            Console.WriteLine("Escriba el nuevo nombre: ");
            string nuevoNombre = Console.ReadLine();

            //Metodo beginedit del datarow 
            rowMiEmpresa.BeginEdit();
            //Modifico el valor del campo
            rowMiEmpresa["CompanyName"] = nuevoNombre;
            //Se finaliza llamando al metodo EndEdit()
            rowMiEmpresa.EndEdit();

            //Se crea un objeto Command para guardar los cambios
            SqlCommand updCommand = new SqlCommand();
            updCommand.Connection = myconn;
            //Indico la cadena TSQL
            updCommand.CommandText =
                "UPDATE Customers SET CompanyName = @CompanyName WHERE CustomerID = @CustomerID";
            //Indico los parametros que estoy utilizando, el tipo de dato, la longitud y el nombre del campo del datatable
            updCommand.Parameters.Add("@CompanyName", SqlDbType.NVarChar, 50, "CompanyName");
            updCommand.Parameters.Add("@CustomerID", SqlDbType.NVarChar, 5, "CustomerID");

            //Adjunto el objeto updcommand al dataAdapter
            myAdap.UpdateCommand = updCommand;
            //Luego llamamos al metodo update
            myAdap.Update(dtEmpresas);


        }
    }
}
