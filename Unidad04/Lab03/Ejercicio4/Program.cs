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
        }
    }
}
