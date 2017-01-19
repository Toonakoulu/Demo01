using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht05
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kysytään sekuntimäärä
            int input, sekuntti, minuutti, tunti;
            Console.Write("Anna sekunnit > ");
            input = int.Parse(Console.ReadLine());

            // Jakolaskua ja jakojäännöstä.
            if (input < 60)
                sekuntti = input;
                minuutti = sekuntti / 60;
                tunti = minuutti / 60;
            {
                Console.WriteLine("Antamasi sekuntiaika on {0} tuntia, {1} minuuttia ja {3} sekunttia.", tunti, minuutti, sekuntti);
            }

        }
    }
}
