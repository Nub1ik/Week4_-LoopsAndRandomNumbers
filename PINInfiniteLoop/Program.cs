using System;

namespace PINInfiniteLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada PIN koodi;
            //programm võrdleb sesestatud PIN koodi arvuga 1234
            //kui sisestatud pin kood on 1234 siis konsool kuvab tere tulemast
            //kui sisestatud parool on vale siis kuvab konsool vale pin proovi uuesti
            //katsete arv on piiramatu

            bool loopActive = true;  //boolean --> true/false
            int i = 0;


            while (loopActive)
            {
                Console.WriteLine("Sisesta PIN: ");
                int userPIN = Convert.ToInt32(Console.ReadLine());

                if(userPIN == 1234)
                {
                    i++;
                    Console.WriteLine("Tere tulemast");
                    Console.WriteLine($"Sisestasid PINi {i} korda");
                    loopActive = false;
                }
                else
                {
                    i++;
                    Console.WriteLine("Vale PIN. Palun proovi uuesti");
                    Console.WriteLine($"Oled sisestanud valet PINi {i} korda");
                }

                
            }


            Console.WriteLine("Kena Paeva!");


        }
    }
}
