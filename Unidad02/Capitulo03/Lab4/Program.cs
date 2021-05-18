using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        public class Empleado
        {
            public Empleado(int id, string nom, double suel)
            {
                this.Nombre = nom;
                this.Id = id;
                this.Sueldo = suel;
            }

            private int _id;
            private string _nombre;
            private double _sueldo;

            public int Id
            {
                get => _id;
                set => _id = value;
            }
            public string Nombre
            {
                get => _nombre;
                set => _nombre = value;
            }
            public double Sueldo
            {
                get => _sueldo;
                set => _sueldo = value;
            }
        }
        static void Main(string[] args)
        {
            List<Empleado> listaEmpleados = new List<Empleado>();
            string op = "";
            while (op != "n")
            {
                Console.WriteLine("Nuevo Empleado:");
                Console.WriteLine("Ingrese ID:");
                int i = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese Nombre:");
                string n = Console.ReadLine();
                Console.WriteLine("Ingrese Sueldo:");
                double s = Convert.ToDouble(Console.ReadLine());

                Empleado e = new Empleado(i, n, s);

                listaEmpleados.Add(e);

                Console.WriteLine("Ingresar otro empleado? s/n");
                op = Console.ReadLine().ToLower();
            }
            var orden1 = from Empleado em in listaEmpleados
                        orderby em.Sueldo ascending
                        select em;
            var orden2 = from Empleado em in listaEmpleados
                         orderby em.Sueldo descending
                         select em;

            Console.WriteLine("Lista ordenada por sueldos Ascendentes: ");
            foreach (Empleado emp in orden1)
                Console.WriteLine("ID: " + emp.Id + "   Nombre: " + emp.Nombre + "  Sueldo: " + emp.Sueldo);

            Console.WriteLine("Lista ordenada por sueldos Descendentes: ");
            foreach (Empleado emp in orden2)
                Console.WriteLine("ID: " + emp.Id + "   Nombre: " + emp.Nombre + "  Sueldo: " + emp.Sueldo);
        }
    }
}
