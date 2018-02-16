using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skaitlusumma_AB03
{
    class Program
    {
        static void Main(string[] args)
        {
           
            // Norādaam funkciju, kuru vajag izsaukt 
            SK();
        }

        // SK - skaitļu summas  funkcija 
        static void SK()
        // CTR+K un tad D - viss tiek sakārtots 
        {
            // izveidojam mainīgo kur glabāt skatli 1
            double S1;
            // Izveidojam mainigo kur glabāt skatli 2
            double S2;
            // izveidojam mainīro - rezutāts R
            double R;
            // Pieškira Skatlim 1 mainiga vērtiibu.
            S1 = ImNo("Ievadi skaitli 1");
            // Pieškira Skatlim 2 mainiga veertiibu.
            S2 = ImNo("Ievadi skaitli 2");
            // veicam apreeķināšanas operāciju
            R = S1 + S2;
            // Paraadam rezultaatu 
            Console.WriteLine("rezultāts " + R);
            Console.ReadLine();
        }
        // Izveidojam funkciju lai dabūtu no ekrāna txt info skaitli. 
        // atceries - No ekrāna nolasa tikai un vienīgi txt. 
        static double ImNo(string msg)
        {
            // izvadaam funkcijai iedoto paziņojumu. msg ir arguments no iepr. funkcijas 
            Console.WriteLine(msg);
            // nolasaam lietotaaja ievadi no ekraana un ierakstam teksata mainiigo - tas ir teksts
            string IT = Console.ReadLine();
            // izveidojam mainigo, kur glabāt  skaitli - nu jau skaitlis 
            double D;
            // Pārveidojam ievadīto tekstu par skaitli un veicam pārbaudes
           // Bool - nodrošina false vai try
            bool PRB = double.TryParse(IT, out D);
            if (PRB == false)
            {
                Console.WriteLine("Slikts skaitlis\"" + IT + " \" \\vajag tikai skaitli");
                Console.WriteLine("Ievadi pareizu skaitli");
                // Palaižam funkciju funkcijā  - sākam no jauna - lai iet nākamo apli līdz pareizi !
                D = ImNo(msg);
            }
            // Apzīmējums ja If izpildās kas jādara !!!!! 
            else
            {
                Console.WriteLine("Pareizs skatlis, malacis !!!");
            }
            // nobeigums f-jai ja izieta visa funkcija un neiestrēgst iegšējā aplī 
            return D;
        }
    }
}