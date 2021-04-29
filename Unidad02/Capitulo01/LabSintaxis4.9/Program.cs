using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis4._9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese numero de pisos");
            int n = Convert.ToInt32(Console.ReadLine());
            n++;
            for (int i = 0; i < n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                    Console.Write(" ");
                for (int j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.Write("\n");
            }
        }
    }
}
