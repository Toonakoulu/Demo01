﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht08
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kysyy kolme kokonaislukua ja tulostaa niistä suurimman.
            int luku1, luku2, luku3;
            Console.Write("Anna luku > ");
            luku1 = int.Parse(Console.ReadLine());
            Console.Write("Anna luku > ");
            luku2 = int.Parse(Console.ReadLine());
            Console.Write("Anna luku > ");
            luku3 = int.Parse(Console.ReadLine());

            if (luku1 > luku2 && luku1 > luku3)
            {
                Console.WriteLine("Suurin luku on {0}.", luku1);
            }
            else if (luku2 > luku1 && luku2 > luku3)
            {
                Console.WriteLine("Suurin luku on {0}.", luku2);
            }
            else if (luku3 > luku1 && luku3 > luku2)
            {
                Console.WriteLine("Suurin luku on {0}.", luku3);
            }
            // wait enter
            Console.ReadLine();
        }
    }
}
