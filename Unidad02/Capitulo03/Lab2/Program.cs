using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listaInt = new List<int>();
            string op = "";
            while (op != "n")
            {
                Console.WriteLine("Ingrese un numero: ");
                int num = Convert.ToInt32(Console.ReadLine());
                listaInt.Add(num);
                Console.WriteLine("Ingresar otro? s/n");
                op = (Console.ReadLine().ToLower());
            }

            listaInt.ForEach(i => Console.WriteLine("{0}\t", i));

            var mayores = from n in listaInt
                       where n > 20
                       select n;
            Console.WriteLine("Los numeros mayores a 20 son: " + string.Join(", ", mayores));
        }
    }
}
