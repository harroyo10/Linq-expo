using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Expo.UnitTesting
{
    [TestClass]
    public class QueryTest
    {

        Ingrediente[] ingredientes = { new Ingrediente { Nombre = "Azucar", Calorias = 500 },
                                       new Ingrediente { Nombre = "Huevos", Calorias = 100 },
                                       new Ingrediente { Nombre = "Leche", Calorias = 150 },
                                       new Ingrediente { Nombre = "Harina", Calorias = 50 },
                                       new Ingrediente { Nombre = "Mantequilla", Calorias = 200 } };

        [TestMethod]
        public void Where()
        {
            
            List<Ingrediente> listaActual = ingredientes
                                                .Where(x => x.Calorias >= 200)
                                                .ToList();

            List<Ingrediente> listaEsperada = new List<Ingrediente> { ingredientes[0],
                                                                      ingredientes[4] };
            
            CollectionAssert.AreEqual(listaActual, listaEsperada);
            
        }

        [TestMethod]
        public void Select()
        {
            var query = ingredientes.Select(x => x.Nombre);

            Assert.IsNotInstanceOfType(ingredientes, typeof(IEnumerable<string>));
            Assert.IsInstanceOfType(query, typeof(IEnumerable<string>));
        }

        [TestMethod]
        public void Take()
        {

            List<Ingrediente> listaActual = ingredientes
                                                .Take(3)
                                                .ToList();

            List<Ingrediente> listaEsperada = new List<Ingrediente> { ingredientes[0],
                                                                      ingredientes[1],
                                                                      ingredientes[2] };

            CollectionAssert.AreEqual(listaActual, listaEsperada);

        }

        [TestMethod]
        public void OrderBy()
        {
            string[] ingredientes = { "Huevos",
                                      "Mantequilla",
                                      "Leche",
                                      "Azucar",
                                      "Harina",};

            List<string> listaActual = ingredientes
                                .OrderBy(x => x)
                                .ToList();

            List<string> listaEsperada = new List<string> { "Azucar",
                                                            "Harina",
                                                            "Huevos",
                                                            "Leche",
                                                            "Mantequilla" };
                                                                    
            CollectionAssert.AreEqual(listaActual, listaEsperada);
        }

        [TestMethod]
        public void Concat()
        {
            string[] pastelDeManzana = { "Manzana", "Azucar", "Canela" };
            string[] pastelDePollo = { "Pollo", "Jamon", "Sal", "Queso" };

            List<string> listaActual = pastelDeManzana.Concat(pastelDePollo)
                                            .ToList();

            List<string> listaEsperada = new List<string>
                       { "Manzana", "Azucar", "Canela", "Pollo", "Jamon", "Sal", "Queso" };

            CollectionAssert.AreEqual(listaActual, listaEsperada);
        }

        [TestMethod]
        public void ToArray()
        {
            IEnumerable<string> ingredientes = new List<string> { "Manzana", "Azucar", "Harina" };

            string[] listaActual = ingredientes.ToArray();

            Assert.IsNotInstanceOfType(ingredientes, typeof(string[]));
            Assert.IsInstanceOfType(listaActual, typeof(string[]));
        }

        [TestMethod]
        public void Contains()
        {
            int[] numeros = { 1, 2, 3 };

            bool estaElDos = numeros.Contains(2);
            bool estaElCinco = numeros.Contains(5);

            Assert.IsTrue(estaElDos);
            Assert.IsFalse(estaElCinco);
        }

        [TestMethod]
        public void Count()
        {
            int[] numeros = { 1, 2, 3 };

            int cantidadDeElementosReal = numeros.Count();
            int cantidadDeElementosEsperado = 3;

            Assert.AreEqual(cantidadDeElementosReal, cantidadDeElementosEsperado);
        }
    }
}
