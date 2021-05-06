using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LabClases5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido!");
            Juego.Juego a = new Juego.Juego();
            a.ComenzarJuego();
        }
    }
}
