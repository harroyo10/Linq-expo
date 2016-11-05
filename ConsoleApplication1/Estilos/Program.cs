using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 9, 5, 7, 6, 4, 1, 2, 3, 8, 0 };

            // Query sintax
            IEnumerable<int> query_sintax = from n in numeros
                                            orderby n
                                            where n > 4
                                            select n;


            // Method sintax
            IEnumerable<int> method_sintax = numeros
                                            .Where(n => n > 4)
                                            .OrderBy(n => n);

            Console.WriteLine("QUERY SINTAX:");
            foreach (int item in query_sintax)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\n\n---------------------\n");
            Console.WriteLine("METHOD SINTAX:");
            foreach (int item in method_sintax)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("");
            Console.ReadLine();
        }
    }
}
