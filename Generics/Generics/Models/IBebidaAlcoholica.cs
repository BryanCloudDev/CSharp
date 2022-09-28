using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.Models
{
    internal interface IBebidaAlcoholica
    {
        public int Alcohol { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }

        public void MaxRecomended();
    }
}
