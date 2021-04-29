using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
            Console.WriteLine("Ingrese nombre del Mes:");
            string mes = Console.ReadLine();
            for (int i=0; i< meses.Length; i++)
            {
                if (mes == meses[i])
                    Console.WriteLine("El numero del mes " + mes + " es " + (i + 1));
            }
        }
    }
}
