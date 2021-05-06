using System;
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
        public string M4()
        {
            return "Metodo del hijo invocado";
        }
    }
}
