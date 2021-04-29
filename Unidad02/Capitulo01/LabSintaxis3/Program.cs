using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arregloStrings; //Definicion de un Arreglo de strings
            arregloStrings = new string[5]; //De 5 elementos

            int cantIteraciones = 5;

            Console.WriteLine("Ingresar texto:");

            for (int i = 0; i < cantIteraciones; i++)
            {
                Console.WriteLine("\n"+(i+1)+" de "+cantIteraciones);
                arregloStrings[i] = Console.ReadLine();
            }
            for (int i = 4; i >= 0; i--)
            {
                Console.WriteLine("\n" + arregloStrings[i]);
            }
        }
    }
}
