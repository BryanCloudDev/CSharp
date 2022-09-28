using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces.Models
{
    //como buenas practicas las interfaces empiezan con una I mayuscula
    internal interface IBebidaAlcoholica
    {
        //en C# si se pueden tener atributos adentro de una interfaz
        public int Alcohol { get; set; }

        public void MaximoRecomendado();
    }
}
