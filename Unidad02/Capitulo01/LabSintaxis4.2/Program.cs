using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un año:");
            int anio = Convert.ToInt32(Console.ReadLine());
            if (anio % 4 == 0 && (anio % 400 == 0 || anio % 100 != 0  ))
            {
                        Console.WriteLine("El año " + anio + " es bisiesto");
            }
            else
            {
                Console.WriteLine("El año " + anio + " no es bisisto");
            }
        }
    }
}
