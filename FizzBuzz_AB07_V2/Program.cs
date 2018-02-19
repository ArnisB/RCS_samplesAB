using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz_AB07_V2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ievadam skaitli no kura sāksim Fizz Buzz, definējam mainīgo a
            Console.WriteLine("Ievadi apaļu skaitli no kura sākt Fizz Bazz:  ");
            long a = long.Parse(Console.ReadLine());
            //Ievadam skaitli līdz kuram veiksim Fizz Buzz, definējam mainīgo b
            Console.WriteLine("Ievadi apaļu skaitli līdz kuram veikt Fizz Bazz:  ");
            long b = long.Parse(Console.ReadLine());
            Console.WriteLine("   "); // idrukājam atdalošu tukšu rindu !!!
            Console.WriteLine("Sākam !!!  "); // Ziņojam ka uzsākam darbību !!!
            Console.WriteLine("   "); // idrukājam atdalošu tukšu rindu !!!
            //Sākam veidot algoritmu Fizz Buzzam izmantojot komandu - for
            for (long c = a; c <= b; c = c + 1)
            {
                // Veidojam pārbaudāmos mainīgos  ! 
                double tris = c % 3;
                double pieci = c % 5;
                double pp = tris + pieci;
                // veicam atbilstošās pārbaudes un izdrukas uz ekrāna izmantojot - If komandu 
                if (pp == 0)
                {
                    Console.WriteLine("FizzBuzz " + c);
                }
                else if (tris == 0)
                {
                    Console.WriteLine("Fizz  " + c);
                }
                else if (pieci == 0)
                {
                    Console.WriteLine("Buzz  " + c);
                }
                else
                {
                    Console.WriteLine(c);
                }
            }
            Console.WriteLine("   "); // idrukājam atdalošu tukšu rindu !!!
            Console.WriteLine("GATAVS !!!! "); // ziņojam, ka gatavs  !!!
            // apstādina programmu lai redzētu rezultātu !
            Console.ReadLine();
        }
    }
}

