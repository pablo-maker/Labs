using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jugada
{
    public class Jugada
    {
        private int _intentos;
        private int _numero;

        public int Intentos
        {
            get => _intentos;
            set => _intentos = value;
        }
        public int Numero
        {
            get => _numero;
            set => _numero = value;
        }
        public Jugada(int maxNumero)
        {
            Random rnd = new Random();
            Numero = rnd.Next(0,maxNumero);
        }
        public bool Comparar(int num)
        {
            Intentos++;
            if (num == Numero)
            {
                Console.WriteLine("Correcto! El numero es " + Numero);
                return true;
            }
            else
            {
                Console.WriteLine("Incorrecto!");
                return false;
            }
        }
    }
}
