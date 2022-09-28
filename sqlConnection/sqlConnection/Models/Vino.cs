using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sqlConnection.Models
{
    internal class Vino : Bebida, IBebidaAlcoholica
    {
        public Vino(string Name, int Amount) : base(Name, Amount)
        {
        }
        public int Alcohol { get; set; }

        public string Brand { get; set; }
        public void MaxRecomended()
        {
            Console.WriteLine("El maximo permitido son 3 copas");
        }
    }
}
