using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht09
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku, summa;
            summa = 0;
            // Tehdään silmukka, mikä kysyy lukuja, kunnes annettu luku on 0.
            while (true)
            {
                Console.Write("Anna luku > ");
                luku = int.Parse(Console.ReadLine());
                if (luku == 0) break;
                summa = summa + luku;
            }
            Console.WriteLine("Lukujen summa on {0}.", summa);




            // wait enter
            Console.ReadLine();
        }
    }
}
