using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList_AB_06
{
    class Program
    {
        static void Main(string[] args)
        {
            TodooList list = new TodooList();
            {
                list.LoadFromFile();// lejupielādējam info no faila
                Console.WriteLine("Fails todos.txt lejupielādēts datora atmiņā  ");// paziņojam, ka visu izdarījām
                Console.WriteLine("    ");// Izdrukājam tukšu rindu
            }
            while (true)
            {
                Console.WriteLine(" ");
                Console.WriteLine("--------------- *********** --------------- ");
                Console.WriteLine(" ");
                Console.WriteLine("Izvēlies darbību kuru gribi veikt: ");
                Console.WriteLine("a vai add vai pievienot - ja vēlies pievienot ierakstu: ");
                Console.WriteLine("at - ja vēliest atzimēt vai darbiņš izpildīts  !!! ");
                Console.WriteLine("b vai  izvads    - parādīt visu sarakstu  !!! ");
                Console.WriteLine("c - dzēst  vienu konkrētu ierakstu");
                Console.WriteLine("d - Dzēst  visus ierakstus");
                Console.WriteLine("s - saglabājam visu ierakstu saturu failā");
                Console.WriteLine("l - lejupielādējam informāciju no faila dzēšot visu ierakstīto ");
                Console.WriteLine("    un pēdējā sesijā failā nesaglabāto informāciju !!!");
                string UI = Console.ReadLine();
                switch (UI)
                {
                    case "pievienot": //// šo zaru var izsaukt arī ar pievienoy
                    case "add":// šo zaru var izsaukt arī ar add
                    case "a":
                        // ievadām darāmo lietu 
                        Console.WriteLine("Lūdzu ievadi darāmo lietu: ");
                        string todoTask = Console.ReadLine();
                        list.AddNewToDo(todoTask);
                        break;
                    case ("izvads"):// no ī zava rar izsaukt ar dibuā
                    case "b":
                        // Izvadīt darāmās lietas uz ekrāna
                        Console.WriteLine("          ");
                        Console.WriteLine(" Darāmo lietu saraksts:  ");
                        list.ShowAllTodos();
                        break;
                    case "c":
                        // dzēst visas darāmās lietas 
                        Console.WriteLine("Ievadi dzēšamo numuru: ");
                        Console.WriteLine("          ");
                        list.ShowAllTodos();
                        // izveidot lai nevar ievadīt lielāku skaitli par kopējo ierakstu skaitu. 
                        int index1 = int.Parse(Console.ReadLine());
                        list.DeleteToDo(index1 - 1);
                        break;
                    case "d":
                        // izdzēšam visu sarakstu
                        // Iespējas uzspiest F12 uz f-jas lai uzreiz tur dotos
                        list.DeleteAllTodos();
                        break;
                    case "s":
                        list.Savefile();
                        break;
                    case "l":
                        Console.WriteLine("Visa pirms tam ierakstītā un failā nesagabātā informācija tiks dzēsta !!!!! ");
                        Console.WriteLine("Ja tam piekrīti ievadi -  Yes, ja nē,  tad nospied  - enter -  !!!");
                        string DZ = Console.ReadLine();
                        if (DZ == "Yes")
                        {
                            list.DeleteAllTodos();
                            list.LoadFromFile();
                            Console.WriteLine("Ievadītā un failā nesaglabātā informācija ir dzētsa !!! ");
                            break;
                        }
                        Console.WriteLine("Sāc izvēli no jauna !!!");
                        Console.WriteLine(" ");
                        break;
                    case "at": // atzīmējam uzdevumuizdarītu 
                        // Izvadīt darāmās lietas uz ekrāna
                        Console.WriteLine("          ");
                        list.ShowAllTodos();
                        Console.WriteLine(" Ievadi  numuru, kura lieta ir paveikta:     ");
                        int doneTodoIndex = int.Parse(Console.ReadLine());
                        list.MarkTodoAsDone(doneTodoIndex - 1);
                        break;
                    default:
                        Console.WriteLine("Nav saprotams, kas ievadīts");
                        break;
                }
            }
        }
    }
}
