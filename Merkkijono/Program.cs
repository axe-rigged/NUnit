using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merkkijono
{
    class Program
    {
        static void Main(string[] args)
        {
            var jono = new Merkkit();

            Console.WriteLine("Merkkijono laskia.");
            Console.WriteLine("Anna numeroita pilkulla erotettuna, esimerkiksi; 1,2,3");
            Console.WriteLine("###################################\n");

            var y = Console.ReadLine();
            Console.WriteLine("Summa näiden lukujen on: " + jono.laske(y));
            Console.ReadKey();
        }
    }
}
