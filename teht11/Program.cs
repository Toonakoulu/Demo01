using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht11
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kysy luku
            int number;
            Console.Write("Anna luku > ");
            string line = Console.ReadLine();
            number = int.Parse(line);

            // Tehdään looppi mikä printtaa halutun määrän tähtiä
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine();
                for (int a = 0; a < number; a++)
                {
                    Console.Write("*");
                }
            }; 
                    
            



            // wait enter
            Console.ReadLine();
        }
    }

}
    
             


            
        
    

