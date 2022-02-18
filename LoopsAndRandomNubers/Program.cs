using System;

namespace LoopsAndRandomNubers
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada PIN koodi;
            //programm võrdleb sesestatud PIN koodi arvuga 1234
            //kui sisestatud pin kood on 1234 siis konsool kuvab tere tulemast
            //kui sisestatud parool on vale siis kuvab konsool vale pin proovi uuesti
            //kasutajal on kolm katset. i < 3


            int i = 0; //i - iteration

            while(i < 3) //While-loop
            {
                Console.WriteLine("Sisesta PIN: ");
                int userPIN = Convert.ToInt32(Console.ReadLine());

                if (userPIN == 1234)
                {
                    Console.WriteLine("Tere tulemast!");
                    break;
                }
                else
                {
                    //i = i + 1; == i++
                    i++;
                    Console.WriteLine($"Vale PIN. {3 - i} katset jaanud.");
                }
                
            }

            Console.WriteLine("Kena paeva!");

        }
    }
}
