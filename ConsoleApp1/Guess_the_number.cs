using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Guess_the_number
    { 

       static bool validare(int a)
    {
            if (a < 0)
                return false;
            if (a > 100)
                return false;
            return true;

        }

        static void Main(string[] args)
        {

            Random rng = new Random();
            int r = rng.Next(0, 100);
            bool ok = true, ok2=true;
            Console.WriteLine("Numarul este intre 0 si 100.");
            Console.WriteLine("Ghiceste numarul!");
            string str = Console.ReadLine();
            int numar = int.Parse(str);
         
            if (numar == r)
            {
                Console.WriteLine("CORECT!");
                
                   }

            while (ok==true)
            {
                if (validare(numar) == false)
                {
                    Console.WriteLine("Numarul ales nu este valid");
                    ok2 = false;
                }
                else
                    ok2 = true;
                if (numar!=r)
                {
                    Console.WriteLine("Mai incearca odata!");
                    if(r>numar)
                        Console.WriteLine("Numarul introdus e mai mic decat numarul care trebuie ghicit!");
                    else if(ok2==true)
                        Console.WriteLine("Numarul introdus e mai mare decat numarul care trebuie ghicit!");
                    Console.WriteLine();

                    str = Console.ReadLine();
                     numar = int.Parse(str);

                }
                else
                {
                    Console.WriteLine("CORECT!");
                    ok=false;

                }

            }

        }


    }
}
