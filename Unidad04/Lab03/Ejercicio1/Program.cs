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
            DataColumn colIDAlumno = new DataColumn("IDAlumno", typeof(int));
            colIDAlumno.ReadOnly = true; //Readonly
            colIDAlumno.AutoIncrement = true; //Autoincremental
            colIDAlumno.AutoIncrementSeed = 0; //Primer numero es 0
            colIDAlumno.AutoIncrementStep = 1; //incremento de a 1
            DataColumn colNombre = new DataColumn("Nombre", typeof(string));
            DataColumn colApellido = new DataColumn("Apellido", typeof(string));
            
            dtAlumnos.Columns.Add(colNombre);
            dtAlumnos.Columns.Add(colApellido);
            dtAlumnos.Columns.Add(colIDAlumno);

            //Establer colIDAlumno como pk
            dtAlumnos.PrimaryKey = new DataColumn[] { colIDAlumno };

            DataRow rwAlumno = dtAlumnos.NewRow();

            rwAlumno[colApellido] = "Perez";
            rwAlumno[colNombre] = "Marcelo";

            dtAlumnos.Rows.Add(rwAlumno);

            DataRow rwAlumno2 = dtAlumnos.NewRow();
            rwAlumno2["Apellido"] = "Perez";
            rwAlumno2["Nombre"] = "Juan";

            dtAlumnos.Rows.Add(rwAlumno2);

            /* Ejercicio 1
             * 
             * Console.WriteLine("Listado de Alumnos:");
            foreach (DataRow row in dtAlumnos.Rows)
            {
                Console.WriteLine(row["Apellido"].ToString() + "," + row["Nombre"].ToString());
            }*/

            DataTable dtCursos = new DataTable("Cursos");
            DataColumn colIDCurso = new DataColumn("IDCurso", typeof(int));
            colIDCurso.ReadOnly = true; //Readonly
            colIDCurso.AutoIncrement = true; //Autoincremental
            colIDCurso.AutoIncrementSeed = 0; //Primer numero es 0
            colIDCurso.AutoIncrementStep = 1; //incremento de a 1
            DataColumn colCurso = new DataColumn("Curso", typeof(string));
            dtCursos.Columns.Add(colIDCurso);
            dtCursos.Columns.Add(colCurso);
            dtCursos.PrimaryKey = new DataColumn[] { colIDCurso };

            DataRow rwCurso = dtCursos.NewRow();
            rwCurso[colCurso] = "Informatica";
            dtCursos.Rows.Add(rwCurso);

            DataSet dsUniversidad = new DataSet();
            dsUniversidad.Tables.Add(dtAlumnos);
            dsUniversidad.Tables.Add(dtCursos);

            //DataTable para crear la relación muchos a muchos entre las tablas alumno y cursos
            DataTable dtAlumnos_Cursos = new DataTable("Alumnos_Cursos");
            DataColumn col_ac_IDAlumno = new DataColumn("IDAlumno", typeof(int));
            DataColumn col_ac_IDCurso = new DataColumn("IDCurso", typeof(int));
            dtAlumnos_Cursos.Columns.Add(col_ac_IDCurso);
            dtAlumnos_Cursos.Columns.Add(col_ac_IDAlumno);

            dsUniversidad.Tables.Add(dtAlumnos_Cursos);

            //Creacion de la relacion
            DataRelation relAlumno_ac = new DataRelation("Alumno_Cursos", colIDAlumno, col_ac_IDAlumno);
            DataRelation relCurso_ac = new DataRelation("Cursos_Alumnos", colIDCurso, col_ac_IDCurso);
            dsUniversidad.Relations.Add(relAlumno_ac);
            dsUniversidad.Relations.Add(relCurso_ac);

            //Agregamos registros
            DataRow rwAlumnoscursos = dtAlumnos_Cursos.NewRow();
            rwAlumnoscursos[col_ac_IDAlumno] = 0; //Alumno Juan Perez
            rwAlumnoscursos[col_ac_IDCurso] = 0; //Curos Informatica
            dtAlumnos_Cursos.Rows.Add(rwAlumnoscursos);

            rwAlumnoscursos = dtAlumnos_Cursos.NewRow();
            rwAlumnoscursos[col_ac_IDAlumno] = 1; //Alumno Marcelo Perez
            rwAlumnoscursos[col_ac_IDCurso] = 0; //Curos Informatica
            dtAlumnos_Cursos.Rows.Add(rwAlumnoscursos);

            //Recorremos los registros para mostrarlos
            Console.WriteLine("Por favor ingrese el nombre del curso:");
            string materia = Console.ReadLine();
            Console.WriteLine("Listado de Alumnos del curso " + materia);
            DataRow[] row_CursoInf = dtCursos.Select("Curso = '" + materia + "'");
            foreach (DataRow rowCu in row_CursoInf)
            {
                DataRow[] row_AlumnosInf = rowCu.GetChildRows(relCurso_ac);
                foreach (DataRow rowAl in row_AlumnosInf)
                {
                    Console.WriteLine(rowAl.GetParentRow(relAlumno_ac)[colApellido].ToString() +", "
                        + rowAl.GetParentRow(relAlumno_ac)[colNombre].ToString());
                };

            }

            Console.ReadKey();

        }
    }
}
