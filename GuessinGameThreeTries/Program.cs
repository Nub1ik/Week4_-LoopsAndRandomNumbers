using System;

namespace GuessinGameThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm gen. juhusliku nr.
            //kasutaja peab seda nr ara arvama (1- 10)
            //kui kasutaja suutis selle ara arvata, siis ta on m'ngu voitnud
            //kasutajal on kolm katset. Kui ei ole suutnud ara arvata siis mangu voidab arvuti.
            //programm genereerib juhusliku nr uhe korra.

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);

            int i = 0;
            while(i < 3)
            {
                Console.WriteLine("Arva juhuslik number.");
                int userGuess = Convert.ToInt32(Console.ReadLine());

                if(userGuess == cpuNumber)
                {
                    Console.WriteLine("Tubli, võitsid mängu!");
                    break;
                }
                else
                {
                    i++;
                    Console.WriteLine($"Arva uuesti {3 - i} katset jäänud");

                }
            }

            Console.WriteLine("Kena päeva");



        }
    }
}
