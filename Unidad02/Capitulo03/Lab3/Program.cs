using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        public class Ciudad
        {
            public Ciudad (string nom, int cod)
            {
                this.Nombre = nom;
                this.Codigo = cod;
            }

            private string _nombre;
            private int _codigo;

            public string Nombre
            {
                get => _nombre;
                set => _nombre = value;
            }
            public int Codigo
            {
                get => _codigo;
                set => _codigo = value;
            }
        }
        static void Main(string[] args)
        {
            Ciudad c1 = new Ciudad("Rosario", 2000);
            Ciudad c2 = new Ciudad("Arroyo Seco", 2128);
            Ciudad c3 = new Ciudad("Monje", 2212);
            Ciudad c4 = new Ciudad("San Lorenzo", 2200);
            ArrayList ciudades = new ArrayList();
            ciudades.Add(c1);
            ciudades.Add(c2);
            ciudades.Add(c3);
            ciudades.Add(c4);

            Console.WriteLine("Ingrese nombre a buscar: ");
            string s = (Console.ReadLine().ToLower());

            var query = from Ciudad c in ciudades
                          where c.Nombre.ToLower().StartsWith(s)
                          select c;
            
            foreach (Ciudad ciu in query)
                Console.WriteLine("Ciudad: " + ciu.Nombre +"    Codigo postal: " + ciu.Codigo);
        }
    }
}
