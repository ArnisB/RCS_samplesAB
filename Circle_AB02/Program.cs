using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_AB02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Norādaam funkciju, kuru vajag izsaukt 
            CC();
        }

        // CalculatedCircle - rinķa laukuma funkcija 
        static void CC()
        // CTR+K un tad D - viss tiek sakārtots 
        {
            // izveidojam mainīgo kur glabāt rādiusu
            int radius;
            // Izveidojam reuzltata mainiigo 
            double result;
            // Pieškira radiusa mainigam veertiibu.
            radius = RR("Lūdzu ievadiet rādiusu apaļu skaitli");
            // veicam apreeķināšanas operāciju
            result = radius * radius * 3.14;
            // Paraadam rezultaatu 
            Console.WriteLine("rezultāts " + result);
            Console.ReadLine();
        }
        static int RR(string msg)
        {
            // izvadaam funkcijai iedoto paziņojumu. msg ir arguments no iepr. funkcijas 
            Console.WriteLine(msg);
            // nolasaam lietotaaja ievadi no ekraana unierakstam teksata mainiigo
            string texInput = Console.ReadLine();
            // izveidojam mainiigo, kur glabāt apaļo skaitli 
            int parsedNumer;
            // Pārveidojam ievadīto tekstu par skaitli 
            parsedNumer = int.Parse(texInput);
            return parsedNumer;
        }
    }
}
