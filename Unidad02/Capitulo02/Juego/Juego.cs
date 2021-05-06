using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Jugada;

namespace Juego
{
    public class Juego
    {
        private int _record;
        public int Record
        {
            get => _record;
            set => _record = value;
        }
        public void ComenzarJuego()
        {
            bool salir = false;
            while (salir == false)
            {
                Console.WriteLine("\n1)Nueva Partida");
                Console.WriteLine("\n2)Record");
                Console.WriteLine("\n3)Salir");
                Console.WriteLine("\nIngrese una opcion:");

                ConsoleKeyInfo opcion = Console.ReadKey();
                Console.Write("\r\n");
                switch (opcion.Key)
                {
                    case ConsoleKey.D1:

                        Jugada.Jugada partida = new Jugada.Jugada(PreguntarMaximo());
                        bool resultado = false;
                        string reintentar = "s";
                        while (resultado == false && reintentar != "n")
                        {
                            resultado = partida.Comparar(PreguntarNumero());
                            Console.WriteLine("Intentos: " + partida.Intentos);
                            if (resultado == false)
                            {
                                Console.WriteLine("Reintentar? s/n");
                                reintentar = Console.ReadLine().ToLower();
                            }

                        }
                        if (resultado && reintentar != "n")
                        {
                            CompararRecord(partida.Intentos);
                        }
                        else if (resultado == false && reintentar == "n")
                        {
                            Console.WriteLine("Mas suerte para la proxima");
                        }

                        break;
                    case ConsoleKey.D2:
                        Console.WriteLine("El record es: " + Record); 
                        break;
                    case ConsoleKey.D3:
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Error, seleccione una opcion de las anteriores");
                        break;
                }
            }
            
            

        }
        private void CompararRecord(int intentos)
        {
            if (Record == 0)
            {
                Record = intentos;
                Console.WriteLine("Nuevo Record!!");

            }
            else if (intentos < Record)
            {
                Console.WriteLine("Nuevo Record!!");
                Record = intentos;
            }
        }
        private void Continuar()
        {
            

        }
        private int PreguntarMaximo()
        {
            Console.WriteLine("Ingrese el numero maximo:");
            try
            {
                int numero = Convert.ToInt32(Console.ReadLine());
                return numero;
            }
            catch
            {
                Console.WriteLine("Error. Ingrese un numero > 0");
                return 0;
            }
        }
        private int PreguntarNumero()
        {
            Console.WriteLine("Ingrese un numero:");
            try
            {
                int numero = Convert.ToInt32(Console.ReadLine());
                return numero;
            }
            catch
            {
                Console.WriteLine("Error. Ingrese un numero > 0");
                return 0;
            }
        }
    }
}
