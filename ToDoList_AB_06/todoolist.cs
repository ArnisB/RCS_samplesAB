using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList_AB_06
{
    class TodooList
    {
        // Šis ir konstruktors, kurš tiek izsaukts, kad izveidots objekts
        // objekts, konstruktors nekad neko neatgriež un vienmēr
        // saucas tāpat kā klase
        public TodooList()
        {
            todoEntries = new List<TodoListEntry>();
        }
        List<TodoListEntry> todoEntries;
        string failins = @"C:\Users\ArnisB\Desktop\PRG\Progmari\todos.xtx";

        public void AddNewToDo(string task)
        {
            // ja Visual studio nevar atrast klasi tad uzspiežam uz klases nosaukumu tad uzspiežam uz klases nosaukuma un CNTR + .
            Console.WriteLine("Uzdevums pievienots: " + task);
            TodoListEntry usersTodo = new TodoListEntry();
            usersTodo.Name = task;
            todoEntries.Add(usersTodo);
        }
        public void ShowAllTodos()
        {
            // izsaucam pirmo elementu no saraksta izmantojot indeksatoru
            // alt versija izm piesk operat for(int skaititajs = 0; skaititajs < todoEntries.Count; skaititajs += 1)
            // = for(int skaititajs = 0; skaititajs < todoEntries.Count; skaititajs = skaititajs++)
            // vārdu jeb mainīgo skaititājs visusrvar aizstāt ar burtu piem i
            for (int skaititajs = 0; skaititajs < todoEntries.Count; skaititajs = skaititajs + 1)
            {
                //Izvadām bez enter galā 
                Console.Write((skaititajs + 1) + "   " + todoEntries[skaititajs].Name);
                if (todoEntries[skaititajs].IsComplete)
                {
                    // Tad uzrakstāmuz ekrāna DONE
                    Console.WriteLine(" - PAVEIKTS !!!!!");
                }
                // nospiežam enter
                Console.WriteLine();
            }
        }
        public void DeleteToDo(int index1)
        {
            if (index1 >= todoEntries.Count)
            {
                Console.WriteLine("----- **** Tāds ieraksts neeksistē, sāc no jauna !!!! ----***** ");
                Console.WriteLine("");
            }
            else
            {
                todoEntries.RemoveAt(index1);
                Console.WriteLine(" ");
                Console.WriteLine(" Ieraksts " + (index1 + 1) + " dzēsts ");
            }
        }
        public void DeleteAllTodos()
        {
            todoEntries.Clear();
        }
        public void Savefile()
        {
            string failins = @"C:\Users\ArnisB\Desktop\PRG\Progmari\todos.xtx";
            File.Delete(failins);

            for (int i = 0; i < todoEntries.Count; i++)
            {
                // append - pievienot tekstā
                string nameofTodo = todoEntries[i].Name;
                File.AppendAllText(failins, nameofTodo + "\r\n");
                //implementējam ielādi no faila izmantojot fukciju
                // file.readAllLines(path)
                bool xxx = todoEntries[i].IsComplete;
                File.AppendAllText(failins, xxx + "\r\n");
            }
        }
        public void LoadFromFile()
        {
            if (!File.Exists(failins))
            {
                return;
            }
            String[] alllineFromFile = File.ReadAllLines(failins);
            //dodamies cauri sarakstam ar texta rindām, kuras ielādētas no faila
            for (var index = 0; index < alllineFromFile.Length; index += 2)
            {
                string listEntry = alllineFromFile[index];
                TodoListEntry fileTodo = new TodoListEntry();
                //LIst entry failā ierakstīta viena teksta rinda 
                fileTodo.Name = listEntry;
                fileTodo.IsComplete = bool.Parse(alllineFromFile[index + 1]);
                todoEntries.Add(fileTodo);
            }
            Console.WriteLine("Informācija no faila ielādēta");

        }
        public void MarkTodoAsDone(int doneTodoIndex)
        {
           //Izveido atzīmi padarīts vai nē 
            TodoListEntry doneTodo = todoEntries[doneTodoIndex];
            doneTodo.IsComplete = true;
        }
    }
}
