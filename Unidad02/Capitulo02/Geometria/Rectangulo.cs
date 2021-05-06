using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geometria
{
    public class Rectangulo : Poligono
    {
        public void CalcularPerimetro()
        {
            Console.WriteLine("Perimetro: " + (base.Altura * 2 + base.Base * 2));
        }

        public void CalcularSuperficie()
        {
            Console.WriteLine("Perimetro: " + (base.Altura * base.Base));
        }
    }
}