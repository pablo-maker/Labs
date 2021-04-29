using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis4._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int p = 1;
            int q;
            int encontrados = 0;
            
            Console.WriteLine("Ingrese N:");
            int n = Convert.ToInt32(Console.ReadLine());

            while (encontrados < n)
            {
                q = p + 2;
                if (es_primo(p) && es_primo(q) )
                {
                    Console.WriteLine("{"+p+","+q+"}");
                    encontrados++;
                }
                p++;
            }
        }
        static bool es_primo(int n)
        {
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;

                }
            }
            return true;
        }
    }
}
