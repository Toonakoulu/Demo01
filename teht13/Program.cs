using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht13
{
    class Program
    {
        static void Main(string[] args)
        {
            int p1, p2, p3, p4, p5, kokp, finp;

            // Kysytään pistemäärät
            Console.Write("Anna pisteet > ");
            p1 = int.Parse(Console.ReadLine());
            Console.Write("Anna pisteet > ");
            p2 = int.Parse(Console.ReadLine());
            Console.Write("Anna pisteet > ");
            p3 = int.Parse(Console.ReadLine());
            Console.Write("Anna pisteet > ");
            p4 = int.Parse(Console.ReadLine());
            Console.Write("Anna pisteet > ");
            p5 = int.Parse(Console.ReadLine());


            int suurin=0, pienin=0;
            // Tsiigataan tosi alkeellisesti et mikä on pienin ja mikä suurin
            if (p1 > p2 && p1 > p3 && p1 > p4 && p1 > p5) suurin = p1;
            else if (p2 > p1 && p2 > p3 && p2 > p4 && p2 > p5) suurin = p2;
            else if (p3 > p1 && p3 > p2 && p3 > p4 && p3 > p5) suurin = p3;
            else if (p4 > p1 && p4 > p2 && p4 > p3 && p4 > p5) suurin = p4;
            else if (p5 > p1 && p5 > p2 && p5 > p3 && p5 > p4) suurin = p5;

            if (p1 < p2 && p1 < p3 && p1 < p4 && p1 < p5) pienin = p1;
            else if (p2 < p1 && p2 < p3 && p2 < p4 && p2 < p5) pienin = p2;
            else if (p3 < p1 && p3 < p2 && p3 < p4 && p3 < p5) pienin = p3;
            else if (p4 < p1 && p4 < p2 && p4 < p3 && p4 < p5) pienin = p4;
            else if (p5 < p1 && p5 < p2 && p5 < p3 && p5 < p4) pienin = p5;

            // Jos pienin ja suurin samoja lukuja niin ei osaa vähentää niitä kokonaissummasta. GG.
            kokp = p1 + p2 + p3 + p4 + p5;
            finp = kokp - suurin - pienin;

            Console.WriteLine("Kokonaispisteet ovat {0}.", finp);
            

            // wait enter
            Console.ReadLine();
        }
    }
}
