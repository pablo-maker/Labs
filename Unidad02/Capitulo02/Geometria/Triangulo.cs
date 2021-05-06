using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geometria
{
    public class Triangulo
    {
        private int _lado1;
        private int _lado2;
        private int _lado3;
        private int _altura;
        private int _base;

        public int Lado1
        {
            get => _lado1;
            set
            {
                _lado1 = value;
            }
        }
        public int Lado2
        {
            get => _lado2;
            set
            {
                _lado2 = value;
            }
        }
        public int Lado3
        {
            get => _lado3;
            set
            {
                _lado3 = value;
            }
        }
        public int Altura
        {
            get => _altura;
            set
            {
                _altura = value;
            }
        }
        public int Base
        {
            get => _base;
            set
            {
                _base = value;
            }
        }
        public void CalcularPerimetro()
        {
            Console.WriteLine("Perimetro: " + (Lado1 + Lado2 + Lado3));
        }

        public void CalcularSuperficie()
        {
            Console.WriteLine("Superficie: " + (Base * Altura / 2));
        }
    }
}