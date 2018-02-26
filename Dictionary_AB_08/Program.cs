using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_AB_08
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ievadi vārdu kura burtus izmantot meklēšanai 
            Console.WriteLine("Ievadi burtus no kuriem veidot vārdus");
            String UL = Console.ReadLine();
            //  ieladējam visu vārdus no vārdnīcas 
            string[] WFD = File.ReadAllLines(@"C:\Users\ArnisB\Desktop\PRG\Progmari\words.txt");
            //Izmantojot ciklu apstrādājam vārdus 
            foreach (var WD in WFD)
            {
                // Izveidojam mainīgo - ja/ne
                bool navburts = false;
                // Izveidojam ciklu , apstrādājam burtu katrā vārdā
                for (int i = 0; i < UL.Length; i++)
                {
                    char CurrentSymbol = UL[i];
                    //Pārbaudam vai burts atrodas vārdnīcas vārdā
                    if (WD.Contains(CurrentSymbol) == false)
                    {

                        // ja neatrodas burts, tad piefiksējam, ka nav labs
                        navburts = true;
                    }
                  
                }
                //Pārbaudām vai visis vārdnīcas vārda burti atrodami lietotaja ievadītajā vārdā !
                //Izmantojot ciklu , apstrādājam katru burtu vārdnīcas vārdā
                foreach (char symbol in WD)
                {
                    // Pārbaudam vai burts ir atrasts lietotāja ievadītajā vārdā
                    if (UL.Contains(symbol) == false)
                    {
                        //Ja neatrodas , tad piefiksējam, ka lieks burts ir atrasts 
                        navburts = true;
                    }
                }
                // Kad vārdu apstrāde beigusies
                //pārbaudam vai vai vārdnīcas vārdā ir atrasti nevajadzīgi burti
                if (navburts == false) Console.ReadLine();
                {
                    // Ja nav tad izvadam uz ekrāna
                    Console.WriteLine(WD);
                }
            }
        }
    }





























































































}
