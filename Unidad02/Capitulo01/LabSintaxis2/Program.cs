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
            //Menu
            Console.Clear();
            Console.WriteLine("Menu:");
            Console.WriteLine("1) Mostrar la frase ingresada en MAYUSCULAS");
            Console.WriteLine("2) Mostrar la frase ingresada en minusculas");
            Console.WriteLine("3) Contar cantidad de caracteres");
            Console.Write("\r\nSeleccionar una opcion: ");

            ConsoleKeyInfo opcion = Console.ReadKey();
            Console.Write("\r\n");
            switch (opcion.Key.ToString())
            {
                case "D1":
                    Console.WriteLine(inputTexto.ToUpper());
                    break;
                case "D2":
                    Console.WriteLine(inputTexto.ToLower());
                    break;
                case "D3":
                    Console.WriteLine(inputTexto.Length);
                    break;
            }
        }
    }
}
