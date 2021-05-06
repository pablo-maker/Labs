using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Clases;

namespace LabClases1
{
    class Program
    {
        static void Main(string[] args)
        {
            A claseA = new A();
            claseA.MostrarNombre();
            claseA.M1();
            claseA.M2();
            claseA.M3();

            A claseA2 = new A("Test");
            claseA2.MostrarNombre();

            B claseB = new B();
            claseB.MostrarNombre();
            claseB.M1();
            claseB.M2();
            claseB.M3();
            claseB.M4();
        }
    }
}
