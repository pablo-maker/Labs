﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class B : A
    {
        public B() : base("Instancia de B")
        {

        }
        public void M4()
        {
            Console.WriteLine("Metodo del hijo invocado");
            //return "Metodo del hijo invocado";
        }
    }
}
