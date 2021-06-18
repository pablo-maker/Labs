using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataTable dtAlumnos = new DataTable();
            DataRow rwAlumno = dtAlumnos.NewRow();

            dtAlumnos.Columns.Add("Apellido");
            dtAlumnos.Columns.Add("Nombre");

            rwAlumno["Apellido"] = "Perez";
            rwAlumno["Nombre"] = "Marcelo";

            dtAlumnos.Rows.Add(rwAlumno);

            DataRow rwAlumno2 = dtAlumnos.NewRow();
            rwAlumno2["Apellido"] = "Perez";
            rwAlumno2["Nombre"] = "Juan";

            dtAlumnos.Rows.Add(rwAlumno2);

            Console.WriteLine("Listado de Alumnos:");
            foreach (DataRow row in dtAlumnos.Rows)
            {
                Console.WriteLine(row["Apellido"].ToString() + "," + row["Nombre"].ToString());
            }
        }
    }
}
