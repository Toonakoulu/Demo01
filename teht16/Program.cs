using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht16
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku, sLuku, kierros = 0;
            Random rand = new Random();
            sLuku = rand.Next(100);

            do
            {
                Console.Write("Arvaa luku > ");
                luku = int.Parse(Console.ReadLine());

                kierros++;
                if (luku < sLuku) Console.WriteLine("Luku on suurempi.");
                else if (luku > sLuku) Console.WriteLine("Luku on pienempi.");
                else if (luku == sLuku) Console.WriteLine("Hienoa, arvasit luvun " + kierros + ". kerralla.");

            } while (luku != sLuku);


            // wait enter
            Console.ReadLine();
        }
    }
}
