using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Коллекции
{
    internal class Program
    {
        class Number
        {
             public List<string> listOfInts = new List<string>();
        }
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
                    LOI.Trim();
                    if (LOI.ToLower() == "-exit")
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
                    LOI.Trim();
                    if (LOI.ToLower() == "-exit")
                    {
                        break;
                    }
                    listOfInts.Insert((int)(listOfInts.Count / 2), LOI);
                    for (int i = 0; i < listOfInts.Count; i++)
                    {
                        Console.WriteLine(listOfInts[i]);
                    }
                    
                }
            }
        }

        private class LinkedListTask
        { 
            public Dictionary<string, float> dictionary = new Dictionary<string, float>();

            public void TaskLoop()
            {
                dictionary.Add("Иван", 0);
                dictionary.Add("Иваг", 0);
                dictionary.Add("Андрей", 0);
                dictionary.Add("Иваб", 0);
                string student;

                while (true)
                {
                    Console.WriteLine("Введите имя студента ");
                    student = Console.ReadLine();
                    if (dictionary.ContainsKey(student))
                    {
                        Console.WriteLine("Введите оценку ");
                        int estimation = Convert.ToInt32(Console.ReadLine());
                        if (estimation > 1 && estimation < 6)
                        {
                            dictionary[student] = estimation;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Такого имение нет");
                        Console.WriteLine("Хотите добавить?");
                        if (Console.ReadLine().Trim().ToLower() == "да")
                        {
                            Console.WriteLine("Введите оценку ");
                            int estimation = Convert.ToInt32(Console.ReadLine());
                            if (estimation > 1 && estimation < 6)
                            {
                                dictionary[student] = estimation;
                            }
                        }
                        else { Console.WriteLine("Студент не будет добавлен"); }
                    }

                    Console.WriteLine("Введите имя студента ");
                    student = Console.ReadLine();
                    if (dictionary.ContainsKey(student))
                    {
                        Console.WriteLine(dictionary[student]);
                        //Console.WriteLine(dictionary.TryGetValue(student));
                    }
                    else
                    {
                        Console.WriteLine("Такого имение нет");
                    }
                }
            }
        }
        private class TwoLinkedList
        {
            
            public void TaskLoop()
            {
                Console.WriteLine("Введите 3 числа через Enter");
                string chislo;
                Number number = new Number();
                
                
                for (int i = 0; i < 3; i++)
                {
                    chislo = Console.ReadLine();
                    
                    if (chislo.Trim() == "")
                    {
                        i--;
                    }
                    else
                    {
                        number.listOfInts.Add(chislo);
                    }
                }
                { 
                Console.WriteLine();
                for (int i = 0; i < number.listOfInts.Count; i++)
                {
                    Console.WriteLine(number.listOfInts[i]);
                }

                Console.WriteLine();
                for (int i = number.listOfInts.Count - 1; i >= 0; i--)
                {
                    Console.WriteLine(number.listOfInts[i]);
                }
                }//Выводы
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
                    var linkedListTask = new LinkedListTask();
                    linkedListTask.TaskLoop();
                    break;
                case 3:
                    var twoLinkedList = new TwoLinkedList();
                    twoLinkedList.TaskLoop();
                    break;
            }
        }
    }
}