using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UzminiNU_AB05
{
    class Program
    {
        static void Main(string[] args)
        {
            // paprasīt lietotājam,cik lielu skaitli grib minēt 
            Console.WriteLine("Ievadi  apaļu maksimālo skaitli, līdz kuram gribi minēt:  ");
            int MaxN = int.Parse(Console.ReadLine());
            // Izveidojam mainīgo , kur glabāt ģenerēto skaitli GNG -  ģenerētais gadījuma skaitlis
            Random GNG;
            GNG = new Random();
            // Pieprasam gad sk. generatoram skaitli  - skaitli ko minēt 
            int MS = GNG.Next(1, MaxN);
            //Izveidojam f-ju ar mainamo skaitli, kā argumentu 
            min(MS);
        }
        // Izveidojam un sākam kodēt  minēšanas funkciju 
        static void min(int MS)
        {
            while (true)
            {
                Console.WriteLine("Ievadi kāds ir iedomātais skaitlis:  ");
            int SkV = int.Parse(Console.ReadLine());
            Console.ReadLine();
            // Izveidojam ciklu minēšanai 
                // parbaude
                if (SkV == MS)
                {
                    Console.WriteLine("Apsveicu tu uzminēji ");
                    Console.ReadLine();
                    break;
                }
                else if (SkV > MS)
                {
                    Console.WriteLine("Pa lielu, dod mazāku skaitli ");
                    //Palaižam funkciju no jauna jo while (true)
                }
                else
                {
                    Console.WriteLine("Pa mazu, dod lielāku skaitli ");
                    //Palaižam funkciju no jauna jo while (true)
                }
            }

        }
    }
}
