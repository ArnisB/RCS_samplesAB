using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication_AB04
{
    class Program
    {
        static void Main(string[] args)
        {
            string UI = "X";

            while (true)
            {
                Console.WriteLine("Izdari izvēli");
                Console.WriteLine("A - Rinķa laukums");
                Console.WriteLine("B  Divu skaitļu saskaitīšana");
                Console.WriteLine("C - Vai divi skaitļi dalaas");
                Console.WriteLine("X - izbeigt programmu");
                UI = Console.ReadLine();
                if (UI == "A")
                {
                    // Norādaam funkciju (apļa laukums), kuru vajag izsaukt 
                    CC();
                }
                else if (UI == "B")
                {
                    // SK(skatļu summa) - Norādaam funkciju, kuru vajag izsaukt 
                    SK();
                }
                else if (UI == "C")
                {
                    // Vai dalās skaitļi - Norādaam funkciju, kuru vajag izsaukt 
                    vaidalas();
                }
                else if (UI == "X"|| UI=="12345")
                {
                    Console.WriteLine("Paldies par darbu !");
                    Console.ReadLine();
                    break;
                }
                else
                {
                    Console.WriteLine("Nesapratu ko ievadīji");
                }
                Console.ReadLine();
            }
        }

        // Izveidoju f-ju dalīšanas spēju pārbaudei 
        static void vaidalas()
        {
            double DD1 = ImNo("Ievadiet dalamo D1)");
            double DD2 = ImNo("Ievadiet dalamo D2)");
            double modulo = DD1 % DD2;
            if (modulo == 0)
            {
                Console.WriteLine("Skatļi dalās");
                Console.ReadLine();
            }
            {
                Console.WriteLine("Skatļi nedalās");
                Console.ReadLine();
            }
        }

        // SK - skaitļu summas  funkcija 
        static void SK()
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

        // CalculatedCircle - rinķa laukuma funkcija 
        static void CC()
        {
            // izveidojam mainīgo kur glabāt rādiusu
            double radius;
            // Izveidojam reuzltata mainiigo 
            double result;
            // Pieškira radiusa mainigam veertiibu.
            radius = ImNo("Lūdzu ievadiet rādiusu apaļu skaitli");
            // veicam apreeķināšanas operāciju
            result = radius * radius * 3.14;
            // Paraadam rezultaatu 
            Console.WriteLine("rezultāts " + result);
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
            // Apzīmējums ja If izpildās, kas jādara !!!!! 
            else
            {
                Console.WriteLine("Pareizs skatlis, malacis !!!");
            }
            // nobeigums f-jai ja izieta visa funkcija un neiestrēgst iegšējā aplī 
            return D;
        }
    }
}
              