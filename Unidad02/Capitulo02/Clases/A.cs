using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Clases
{
    public class A
    {
        private string _nombreInstancia;

        public string NombreInstancia
        {
            get
            {
                return _nombreInstancia;
            }
            set
            {
                _nombreInstancia = value;
            }
        }

        public A()
        {
            NombreInstancia = "Instancia sin nombre";
        }
        public A(string nombre)
        {
            NombreInstancia = nombre;
        }

        public void MostrarNombre()
        {
            Console.WriteLine(NombreInstancia);
        }
        public void M1()
        {
            Console.WriteLine("Metodo M1 invocado");
        }
        public void M2()
        {
            Console.WriteLine("Metodo M2 invocado");
        }
        public void M3()
        {
            Console.WriteLine("Metodo M3 invocado");
        }

    }
}
