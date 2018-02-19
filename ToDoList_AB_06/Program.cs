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
            while (true)
            {
                // Gribu pievienot lietu
                Console.WriteLine("Lūdzu ievadi darāmo lietu: ");
                string todoTask = Console.ReadLine();
                list.AddNewToDo(todoTask);
                // dzēst visas darāmās lietas 
                // Izvadīt darāmās lietas uz ekrāna
                list.ShowAllTodos();
            }
        }
    }
}
