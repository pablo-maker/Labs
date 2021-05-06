using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geometria
{
    public class Cuadrado : Rectangulo
    {
        public void CalcularPerimetro()
        {
            Console.WriteLine("Perimetro: " + (base.Altura * 4));
        }

    }
}