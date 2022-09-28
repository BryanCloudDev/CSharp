using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using interfaces.Models;

namespace interfaces.Models
{
    class Cerveza : Bebida, IBebidaAlcoholica
    {
        public int Alcohol { get; set; }

        public void MaximoRecomendado()
        {
            Console.WriteLine("El maximo permitido son 10");
        }
        public Cerveza(string Name, int Amount) : base(Name, Amount)
        {
        }

        //public int Alcohol { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
