using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos.Models
{
    internal class Cerveza
    {
        public string nombre;
        public int cantidad;
        public Cerveza(string nombre, int cantidad)
        {
            this.nombre = nombre;
            this.cantidad = cantidad;
        }
    }
}
