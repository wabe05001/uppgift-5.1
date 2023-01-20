using System;

namespace Upgift_5_1
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("hur många meningar vill du skriva?");
            int antal = int.Parse(Console.ReadLine());
            string[] meningar = new string[antal];

            for (int i = 0; i < antal; i++)
            {
                Console.WriteLine("skriv in en mening");
                meningar[i] = Console.ReadLine();

            }
            Console.WriteLine("Här är dina meningar");
            for (int i = 0; i < antal; i++)
            {
                Console.WriteLine($"\n{meningar[i]}");
            }


            

        }
    }

}