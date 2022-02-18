using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm gen. juhusliku nr.
            //kasutaja peab seda nr ara arvama (1- 10)
            //kui kasutaja suutis selle ara arvata, siis ta on m'ngu voitnud
            //katsete arv on piiramatu
            //programm genereerib juhusliku nr uhe korra

            Console.WriteLine("Tere, mängid juhusliku numbri mängu.");
            Console.WriteLine("Palun sisesta siia enda arvatav juhuslik number.");

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);

            bool loopActive = true;
            int i = 0;

            while (loopActive)
            {
                    int userGuess = Convert.ToInt32(Console.ReadLine());

                if(userGuess == cpuNumber)
                {
                    i++;
                    Console.WriteLine("Tubli, sa võitsid mängu!");
                    Console.WriteLine($"Arvastid juhuslikku numbrit {i} korda");
                    loopActive = false;
                }
                else
                {
                    i++;
                    Console.WriteLine("Vale number. Proovi uuesti.");
                    Console.WriteLine($"Oled arvanud {i} korda valesti.");


                }
            }

            Console.WriteLine("Ilusat paeva!");
        }
    }
}
