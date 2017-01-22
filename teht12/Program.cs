using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] luvut = new int[5];
            int luku0, luku1, luku2, luku3, luku4;

            // Kysytään lukuja
            Console.Write("Anna luku > ");
            luku0 = int.Parse(Console.ReadLine());
            luvut[0] = luku0;
            Console.Write("Anna luku > ");
            luku1 = int.Parse(Console.ReadLine());
            luvut[1] = luku1;
            Console.Write("Anna luku > ");
            luku2 = int.Parse(Console.ReadLine());
            luvut[2] = luku2;
            Console.Write("Anna luku > ");
            luku3 = int.Parse(Console.ReadLine());
            luvut[3] = luku3;
            Console.Write("Anna luku > ");
            luku4 = int.Parse(Console.ReadLine());
            luvut[4] = luku4;

            for (int i = 4; i < luvut.Length; i--) Console.WriteLine(luvut[i]);
                            


            // wait enter
            Console.ReadLine();
        }
    }
}
