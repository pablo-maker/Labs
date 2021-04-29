using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis4._3
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Ingrese N para la suma de la serie de Fibonacci:")
			int n = int.Parse(Console.ReadLine());
			int a = 0;
			int b = 1;
			int aux = 0;


			for (int i = 0; i < n; i++)
			{
				if (i == 0)
				{
					Console.Write(a);
				}
				else
				{
					aux = a;
					a = b;
					b = aux + a;
					Console.Write(", "+ a);
				}
			}
			Console.WriteLine();
		}
    }
}
