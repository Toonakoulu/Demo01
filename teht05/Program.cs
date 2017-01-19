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
            int input, tunti, minuutti, sekuntti;
            Console.Write("Anna sekunnit > ");
            input = int.Parse(Console.ReadLine());

            // Jakolaskua ja jakojäännöstä.
            tunti = input / 3600;
            minuutti = input % 3600 / 60;
            sekuntti = input % 3600 % 60;
                           
            Console.WriteLine("Antamasi sekuntiaika on {0} tunti, {1} minuutti ja {2} sekuntti.", tunti, minuutti, sekuntti);
            
            // wait enter
            Console.ReadLine();
        }
    }
}
