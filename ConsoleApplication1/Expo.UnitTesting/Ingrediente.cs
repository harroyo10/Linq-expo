using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expo.UnitTesting
{
    class Ingrediente
    {

        public string Nombre { set; get; }
        public int Calorias { set; get; }

        public Ingrediente(){}

        public Ingrediente(string Nombre, int Calorias)
        {
            this.Nombre = Nombre;
            this.Calorias = Calorias;
        }
    }
}
