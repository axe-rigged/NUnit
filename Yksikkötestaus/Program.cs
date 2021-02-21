using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yksikkötestaus
{
    class Program
    {
        static void Main(string[] args)
        {
            var fizzer = new FizzBuzz();

            Console.WriteLine("FizzBuzz tehtävä");
            Console.WriteLine("Anna numero 1-100\n");


            int lol = int.Parse(Console.ReadLine());
            var lol2 = fizzer.Luku(lol);
            Console.WriteLine(lol2);

            Console.ReadKey();
        }
    }
}
