using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases.Models
{
    internal class Cerveza : Bebida //con los 2 puntos podemos aplicar la herencia en C# a una clase hija
    {
        public Cerveza( string nombre, int cantidad) : base(nombre, cantidad)
        {

        }
    }
}
