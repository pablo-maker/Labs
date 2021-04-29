using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis4._8
{
    class Program
    {
        static void Main(string[] args)
        {
            int intentos = 0;
            bool claveEsCorrecta = false;
            string clave = "clave";

            while (intentos < 4 && !claveEsCorrecta)
            {
                Console.WriteLine("Ingrese la clave:");
                string contra = Console.ReadLine();
                if (contra == clave)
                {
                    Console.WriteLine("Clave correcta.");
                    claveEsCorrecta = true;
                }
                else
                {
                    intentos++;
                }
            }
            

        }
    }
}
