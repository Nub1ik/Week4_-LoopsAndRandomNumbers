using System;

namespace RandomNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm gen. juhuslikku nr. (1 - 10)
            //kui gen nr. on 5 programm l]petab oma too ja soovib kasutajale kena paeva
            //kui gen nr. on midagi muud siis programm jatkab tood

            Random rnd = new Random();
            int i = 0;


            while (i != 5)
            {
                int MyRandomNumber = rnd.Next(1, 11);
                Console.WriteLine($"Juhuslik number on {MyRandomNumber}");
                if (MyRandomNumber != 5)
                {
                    continue;
                }
                i = MyRandomNumber;
            }

            Console.WriteLine("Ilusat paeva!");




        }
    }
}
