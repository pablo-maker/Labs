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

        public string MostrarNombre()
        {
            return NombreInstancia;
        }
        public string M1()
        {
            return "Metodo M1 invocado";
        }
        public string M2()
        {
            return "Metodo M2 invocado";
        }
        public string M3()
        {
            return "Metodo M3 invocado";
        }


    }
}
