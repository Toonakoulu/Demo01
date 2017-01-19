using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht07
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kysytään vuosi
            int vuosi, karkvuosi;
            Console.Write("Anna vuosi > ");
            vuosi = int.Parse(Console.ReadLine());

            // Katsotaan onko vuosi neljällä jaollinen jnejnejne.

            karkvuosi = vuosi % 4;
            karkvuosi = vuosi % 400;

            if (karkvuosi == 0)
            {
                Console.WriteLine("Vuosi on karkausvuosi.");
            }
            else if (karkvuosi != 0)
            {
                Console.WriteLine("Vuosi ei ole karkausvuosi.");
            }
            
            /* toinen ratkaisu___________________
             * if (vuosi %4 == 0 && vuosi % 100 != 0 || vuosi % 400 == 0) {tru dat}
             * else {not tru}
             */

            // wait enter
            Console.ReadLine();
        }
    }
}
