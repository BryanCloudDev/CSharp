using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases.Models
{
    internal class Bebida
    {
        public string nombre { get; set; }
        public int cantidad { get; set; }

        public Bebida(string nombre, int cantidad) // el constructor al igual que en Dart se llama igual que su clase contenedora
        {
            this.nombre = nombre;
            this.cantidad = cantidad;
        }

        public void Beberse(int cuantoBebio)
        {
            this.cantidad -= cuantoBebio;
        }
    }
}
