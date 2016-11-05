using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expo.QueryOperators
{
    class Receta
    {
        public int Id { set; get; }
        public string Nombre { set; get; }

        public Receta() { }

        public Receta(int Id, string Nombre)
        {
            this.Id = Id;
            this.Nombre = Nombre;
        }
    }
}
