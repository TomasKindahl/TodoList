﻿using System;
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

            // Declarations:
            string command;
            string[] commandWord;
            List<Activity> todoList;

            // REPL (do-while-loop):
            do
            {
                Console.Write("> ");
                command = Console.ReadLine();
                commandWord = command.Split(' ');
                if (command == "quit")
                {
                    Console.WriteLine("Bye!");
                }
                else if (commandWord[0] == "load")
                {
                    Console.WriteLine("Reading file {0}", commandWord[1]);
                    todoList = ReadTodoListFile(commandWord[1]);
                }
                else 
                {
                    Console.WriteLine("Unknown command: {0}", command);
                }
            } while (command != "quit");
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
    }
}
