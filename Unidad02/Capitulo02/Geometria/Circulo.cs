using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Circulo
    {
        private int m_radio;

        public int Radio
        {
            get => m_radio;
            set
            {
                m_radio = value;
            }
        }

        public void CalcularPerimetro()
        {
            double perimetro = 2.0 * 3.14 * Radio;
            Console.WriteLine("Perimetro: " + perimetro);
        }

        public void CalcularSuperfie()
        {
            double superficie = 3.14 * (Radio^2);
            Console.WriteLine("Superficie: " + superficie);
        }
    }
}
