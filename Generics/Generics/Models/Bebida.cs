using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.Models
{
    internal class Bebida
    {
        public string Name { get; set; }
        public int Amount { get; set; }
        public Bebida(string Name, int Amount)
        {
            this.Name = Name;
            this.Amount = Amount;
        }
    }
}
