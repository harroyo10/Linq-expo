using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expo.QueryOperators
{
    public class QueryOperator
    {

        public QueryOperator() { }

        public void GroupByOperator()
        {
            Ingrediente[] ingredientes = { new Ingrediente { Nombre = "Azucar", Calorias = 500 },
                                           new Ingrediente { Nombre = "Leche", Calorias = 100 },
                                           new Ingrediente { Nombre = "Mantequilla", Calorias = 500 },
                                           new Ingrediente { Nombre = "Harina", Calorias = 50 },
                                           new Ingrediente { Nombre = "Avena", Calorias = 50 },
                                           new Ingrediente { Nombre = "Huevos", Calorias = 100 } };
            
            IEnumerable<IGrouping<int, Ingrediente>> query = ingredientes.GroupBy(x => x.Calorias);
            
            foreach (IGrouping<int, Ingrediente> grupo in query)
            {
                Console.WriteLine("Ingredientes con {0} calorias", grupo.Key);

                foreach (Ingrediente ingrediente in grupo) {
                    Console.WriteLine(" - {0}", ingrediente.Nombre); }
            }
            Console.ReadLine();
        }

        public void JoinOperator()
        {
            Receta[] recetas = {
                        new Receta {Id = 1, Nombre = "Pure de papas"},
                        new Receta {Id = 2, Nombre = "Casado con pollo"},
                        new Receta {Id = 3, Nombre = "Pizza de jamon"}};

            Critica[] reviews = {
                        new Critica {IdReceta = 1, TextoDeCritica = "Delicioso!"},
                        new Critica {IdReceta = 1, TextoDeCritica = "No muy bueno :("},
                        new Critica {IdReceta = 1, TextoDeCritica = "Muy bueno"},
                        new Critica {IdReceta = 2, TextoDeCritica = "Muy grande"},
                        new Critica {IdReceta = 2, TextoDeCritica = "Me encanto"} };

            var query = recetas.Join(
                                 reviews,
                                 (Receta outerKey) => outerKey.Id,
                                 (Critica innerKey) => innerKey.IdReceta,
                                 (receta, critica) => receta.Nombre + " - " + critica.TextoDeCritica);
            
            foreach (string item in query) {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
