using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList_AB_06
{
    class TodooList
    {
        // Šis ir konstruktors, kurš tiek izsaukts, kad izveidots objekts
        // objekts, konstruktors nekad neko neatgriež un vienm;er
        // saucas tāpat kā klase
        public TodooList()
        {
            todoEntries = new List<string>();
        }
        List<string> todoEntries;

        public void AddNewToDo(string task)
        {
            // ja Visual studio nevar atrast klasi tad uzspiežam uz klases nosaukumu tad uzspiežam uz klases nosaukuma un CNTR + .
            Console.WriteLine("Uzdevums pievienots: " + task);
            todoEntries.Add(task);
        }
        public void ShowAllTodos()
        {
            // izsaucam pirmo elementu no saraksta izmantojot indeksatoru
            // alt versija izm piesk operat for(int skaititajs = 0; skaititajs < todoEntries.Count; skaititajs += 1)
            // = for(int skaititajs = 0; skaititajs < todoEntries.Count; skaititajs = skaititajs++)
            // vārdu jeb mainīgo skaititājs visusrvar aizstāt ar burtu piem i
            for (int skaititajs = 0; skaititajs < todoEntries.Count; skaititajs = skaititajs + 1)
            {
                Console.WriteLine("Izvadi sarakstu: " + todoEntries[skaititajs]);
            }
        }
     }
}




        

  