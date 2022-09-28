using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces.Models
{
    class Vino : Bebida, IBebidaAlcoholica
    {
        public int Alcohol { get; set; }

        public void MaximoRecomendado()
        {
            Console.WriteLine("El maximo permitido son 3 copas");
        }
        public Vino(string Name, int Amount) : base(Name, Amount)
        {
        }

        //public int Alcohol { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
