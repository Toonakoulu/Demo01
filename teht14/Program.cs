using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht14
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            { // ikuinen silmukka
                Console.Write("Anna luku > ", "Paina 6 jotta pääset pois");
                int asana = int.Parse(Console.ReadLine());
                if (asana >= 6) break;
            }
            for (int i = 0; i < 10; i++) Console.Write("*");




            // wait enter
            Console.ReadLine();
        }
    }
}
