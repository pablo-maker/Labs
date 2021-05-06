using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jugada;

namespace JugadaConAyuda
{
    public class JugadaConAyuda : Jugada.Jugada
    {
        public JugadaConAyuda(int max) : base(max)
        {
        
        }
        public bool Comparar(int num)
        {
            Intentos++;
            if (num == Numero)
            {
                Console.WriteLine("Correcto! El numero es " + Numero);
                return true;
            }
            else if (Math.Abs(num-Numero) <= 5)
            {
                Console.WriteLine("Incorrecto, pero muy cerca!");
                return false;
            }
            else if (Math.Abs(num - Numero) >= 5 && Math.Abs(num - Numero) <= 100)
            {
                Console.WriteLine("Incorrecto, muy lejos!");
                return false;
            }
            else
            {
                Console.WriteLine("Incorrecto, demasiado lejos!");
                return false;
            }
        }

    }
}
