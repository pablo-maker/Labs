using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona
{
    public class Persona
    {
        private string _nombre;
        private string _apellido;
        private int _edad;
        private int _dni;

        public string Nombre
        {
            get => _nombre;
            set => _nombre = value;
        }
        public string Apellido
        {
            get => _apellido;
            set => _apellido = value;
        }
        public int Edad
        {
            get => _edad;
            set => _edad = value;
        }
        public int DNI
        {
            get => _dni;
            set => _dni = value;
        }

        public Persona(string nom,string ape,int edad,int dni)
        {
            Nombre = nom;
            Apellido = ape;
            Edad = edad;
            DNI = dni;
            Console.WriteLine("Persona instanciada");
        }
        ~Persona()
        {
            Console.WriteLine("Persona destruida");
        }

        public void GetFullName()
        {
            Console.WriteLine(Nombre + " " + Apellido);
        }

        public void GetAge(int anio)
        {
            Console.WriteLine("Nacimiento: " + (anio - Edad));
        }
    }
}
