using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis2
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputTexto;
            inputTexto = Console.ReadLine();
            if (inputTexto != "")
            {
                Console.WriteLine("Texto ingresado");
            }
            else
            {
                Console.WriteLine("Error, no se ingreso ningun texto");
            }
        }
    }
}
