using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht06
{
    class Program
    {
        static void Main(string[] args)
        {
            double matka, kulutus, hinta;
            kulutus = 7.02 / 100;
            hinta = 1.595;

            // Kysytään matkan mitta
            Console.Write("Anna matka (km) > ");
            matka = double.Parse(Console.ReadLine());

            // Lasketaan arvoja
            kulutus = matka * kulutus;
            hinta = kulutus * hinta;

            // Printataan tulokset
            Console.WriteLine("Bensaa kuluu {0}, kustannus {1} euroa.", kulutus, hinta);

            // wait enter
            Console.ReadLine();
        }
    }
}
