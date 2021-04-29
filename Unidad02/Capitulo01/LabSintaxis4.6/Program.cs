using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis4._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            string resultado = "";
            var map = new Dictionary<string, int>
                {
                    {"M", 1000 },
                    {"CM", 900},
                    {"D", 500},
                    {"CD", 400},
                    {"C", 100},
                    {"XC", 90},
                    {"L", 50},
                    {"XL", 40},
                    {"X", 10},
                    {"IX", 9},
                    {"V", 5},
                    {"IV", 4},
                    {"I", 1}
                };
            foreach (var par in map)
            {
                resultado += string.Join(string.Empty, Enumerable.Repeat(par.Key, num / par.Value));
                num %= par.Value;
            }
            Console.WriteLine(resultado);
        }
    }
}
