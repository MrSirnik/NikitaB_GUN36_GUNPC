using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Коллекции
{
    internal class Program
    {
        private class ListTask
        {
            private List<string> listOfInts = new List<string> {"5", "8", "64"};
            private string LOI;
            public void TaskLoop()
            {
                while (true)
                {
                    Console.WriteLine("Введите '-exit' чтоб выйти");
                    Console.Write("Введите значение для конца списка: ");
                    LOI = Console.ReadLine();
                    if (LOI == "-exit" || LOI == "-Exit")
                    {
                         break;
                    }
                    listOfInts.Add(LOI);

                    for (int i = 0; i < listOfInts.Count; i++)
                    {
                        Console.WriteLine(listOfInts[i]);
                    }

                    Console.WriteLine("Введите '-exit' чтоб выйти");
                    Console.Write("Введите значение для середины списка: ");
                    LOI = Console.ReadLine();
                    if (LOI == "-exit" || LOI == "-Exit")
                    {
                        break;
                    }
                    listOfInts.Add(LOI);

                    for (int i = 0; i < listOfInts.Count; i++)
                    {
                        Console.WriteLine(listOfInts[i]);
                    }
                    listOfInts.Insert((int)(listOfInts.Count / 2), LOI);
                }
            }
        }

            private class LinkedListTask
            {
                private class Node { } // Узел списка

                public void TaskLoop()
                {
                    // проверка ввода и вывод результата
                }
            }

            static void Main(string[] args)
            {
                Console.WriteLine("Enter 1,2 or 3 to check task 1,2 or 3");
                int task = int.Parse(Console.ReadLine()); // Используйте tryParse
                switch (task)
                {
                    case 1:
                        var listTask = new ListTask();
                        listTask.TaskLoop();
                        break;
                    case 2:
                        
                        break;
                    case 3:
                        
                        break;
            }
            }
        }
    }