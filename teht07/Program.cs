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
            int vuosi;
            Console.Write("Kerrohan ikäsi > ");
            ikä = int.Parse(Console.ReadLine());

            // Katsotaan onko vuosi neljällä jaollinen jnejnejne.
            if (ikä < 18)
            {
                Console.WriteLine("Alaikäinen.");
            }
            else if (18 < ikä && ikä < 65)
            {
                Console.WriteLine("Aikuinen.");
            }
            else if (ikä > 65)
            {
                Console.WriteLine("Seniori");
            }
            // wait enter
            Console.ReadLine();
        }
    }
}
