using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expo.QueryOperators
{
    class Critica
    {
        public int IdReceta { set; get; }
        public string TextoDeCritica{ set; get; }

        public Critica() { }

        public Critica(int IdReceta, string TextoDeCritica)
        {
            this.IdReceta = IdReceta;
            this.TextoDeCritica = TextoDeCritica;
        }
    }
}
