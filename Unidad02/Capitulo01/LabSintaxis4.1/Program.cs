using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese primer numero a sumar:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese segundo numero a sumar:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int resultado = num1 + num2;

            Console.WriteLine("El resultado de la suma de " + num1 + " y " + num2 + " es " + resultado);
        }
    }
}
