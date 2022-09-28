using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sqlConnection.Models
{
    internal class Cerveza : Bebida, IBebidaAlcoholica
    {
        public Cerveza(string Name, int Amount) : base(Name,Amount)
        {
        }
        public int Alcohol { get; set; }

        public string Brand { get; set; }
        public void MaxRecomended()
        {
            Console.WriteLine("El maximo permitido son 10 cervezas");
        }
    }
}
