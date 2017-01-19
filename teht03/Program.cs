using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kysy luvut
            double luku1, luku2, luku3, summa, keskiarvo;
            Console.Write("Anna luku > ");
            luku1 = double.Parse(Console.ReadLine());
            Console.Write("Anna luku > ");
            luku2 = double.Parse(Console.ReadLine());
            Console.Write("Anna luku > ");
            luku3 = double.Parse(Console.ReadLine());

            // summa ja keskiarvo
            summa = luku1 + luku2 + luku3;
            keskiarvo = summa / 3;

            // tulosta summa ja keskiarvo
            Console.WriteLine("Lukujen summa on {0}.", summa);
            Console.WriteLine("Lukujen keskiarvo on {0}.", keskiarvo);

            // wait enter
            Console.ReadLine();
        }
        
    }
}
