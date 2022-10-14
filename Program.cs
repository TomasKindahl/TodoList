using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList
{
    class Program
    {
        class Activity
        {
            public string date;
            public string state;
            public string title;
            public Activity(string D, string S, string T)
            {
                date = D; state = S; title = T;
            }
            // NYI: public void Print -- skriver en rad
        }
        static void Main(string[] args)
        {
            // Greetings:
            Console.WriteLine("Hello and welcome to todo list!");
            Console.WriteLine("To quit type 'quit', for help type 'help'!");
            Console.WriteLine("Hej från mig!");
            // Declarations:
            string command;
            string[] commandWord;
            List<Activity> todoList;

            // REPL (do-while-loop):

        }

        private static List<Activity> ReadTodoListFile(string fileName)
        {
            List<Activity> todoList = new List<Activity>();
            using (StreamReader sr = new StreamReader(fileName))
            {
                while (sr.Peek() >= 0) // Is next char an EndOfFile sign?
                {
                    string[] lword = sr.ReadLine().Split('#');
                    /* FAS2: */
                    Activity A = new Activity(lword[0], lword[1], lword[2]);
                    // Console.WriteLine("{0} - {1} - {2}", A.date, A.state, A.title);
                    todoList.Add(A);
                }
            }
            return todoList;
        }
        static void Dynamiskt()
        {
            Console.WriteLine("Tja");
        }
    }
}
