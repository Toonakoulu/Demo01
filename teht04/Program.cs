using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht04
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kysytään ikä
            double ikä;
            Console.Write("Kerrohan ikäsi > ");
            ikä = double.Parse(Console.ReadLine());

            // Katsotaan mihin väliin ikä sopii
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
