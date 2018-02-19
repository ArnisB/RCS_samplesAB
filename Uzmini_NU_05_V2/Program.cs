using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UzminiNU_AB_05_V2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Paprasīt lietotājam cik piegājienos uzminēsi skaitli 
            Console.WriteLine("Ievadi cik gājienos spēsi uzminēt skaitli");
            int MeSk = int.Parse(Console.ReadLine());
            // paprasīt lietotājam,cik lielu skaitli viņš grib minēt 
            Console.WriteLine("Ievadi  apaļu maksimālo skaitli, līdz kuram no sākuma skaitļa 1 gribi minēt:  ");
            int MaxN = int.Parse(Console.ReadLine());
            // Izveidojam mainīgo, kur glabāt ģenerēto skaitli GNG -  ģenerētais gadījuma skaitlis
            Random GNG;
            GNG = new Random();
            // Pieprasam gad sk. generatoram skaitli  - skaitli ko minēt 
            int MS = GNG.Next(1, MaxN + 1);
            // Veicam gājienu skaita pārbaudi 
            for (int a = 1; a < MeSk+1; a = a + 1)
            {
                Console.WriteLine("Ievadi  skaitli !!!!!");
                Console.WriteLine("Gājiens: " + a + ". no " + MeSk + ". Ievadi kāds ir manis iedomātais skaitlis:  ");
                int SkV = int.Parse(Console.ReadLine());
                // Izveidojam ciklu minēšanai 
                // parbaude
                if (SkV == MS)
                {
                    Console.WriteLine("Apsveicu tu uzminēji !!!!!");
                    Console.ReadLine();
                    return;
                }
                else if (SkV > MS)
                {
                    Console.WriteLine("Skaitlis pa lielu !!!!!! ");
                    //Palaižās for komandas cikls gājienu skaita pārbaudei
                }
                else
                {
                    Console.WriteLine("Skaitlis pa mazu !!!!!");
                    //Palaižās for komandas cikls gājienu skaita pārbaudei
                }
            }
            // for komandas cikli beigušies, pziņojums par neveiksmi !
            Console.WriteLine("Uzminēt Tev nesanāca, jo gājieni beidzās!!! Ha Ha Ha ! ");
            Console.WriteLine("Minamais skaitlis bija: " + MS + " !");
            Console.ReadLine();
        }
    }
}

