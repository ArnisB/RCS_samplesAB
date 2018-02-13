using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heloword_AB01
{
    class Program
    {
        static void Main(string[] args)
        {
            // izsaucam sevis izveidoto funkcju
            SayHello();
            // izsaucam otru izveidoto fukciju 
            SayHelloToUser();
            // izsaucam trešu fukciju
            SayHellogadi();
        }
        static void SayHelloToUser()
        {
            // Palūdzam lietotājam ievadīt vārdu
            Console.WriteLine("Ievadi savu vārdu:");
            // izveidojam mainigo kur galbāt ievadīto vetribu
            string usersName;
        // Paprasam konsolei ievadīt tekstu, saglabājam rezultātu mainīgi 
            usersName=Console.ReadLine();
            Console.WriteLine("Sveiks:"+ usersName + " !");
            Console.ReadLine();
        }
        static void SayHellogadi()
        {
            // Palūdzam lietotājam ievadīt vārdu
            Console.WriteLine("Ievadi savu gadu skaitu:");
            // izveidojam mainigo kur galbāt ievadīto vetribu
            string gadi;
            // Paprasam konsolei ievadīt tekstu, saglabājam rezultātu mainīgi 
          gadi = Console.ReadLine();
            Console.WriteLine("Tev ir: " + gadi + " gadi");
            Console.ReadLine();
        }

    

    static void SayHello()
        {
          Console.WriteLine("Hello word! GGGG");
          Console.ReadLine();
        }
     }
}
