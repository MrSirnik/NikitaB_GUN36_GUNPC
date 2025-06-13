using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Циклы
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Fibonaccy
            int variable_exchange;
            int number1 = 0;
            int number2 = 1;
            Console.WriteLine(number1);

            for (int i = 0; i < 9;  i++)
            {
                Console.WriteLine(number2);
                variable_exchange = number1;
                number1 = number2;
                number2 = variable_exchange + number2;
            }

            Console.WriteLine("-------------------------------------");
            //Even numbers
            
            for (int i = 2; i < 21; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("-------------------------------------");
            //Multiplication table

            for(int i = 1; i < 6; i++)
            {
                for (int j = 1; j < 11; j++)
                {
                    Console.WriteLine($"{i} * {j} = { i * j }");
                }
                Console.WriteLine();
            }

            Console.WriteLine("-------------------------------------");
            //Password

            string password = "qwerty";
            do
            {
                Console.WriteLine("Введите пароль: ");


            } while (password != Console.ReadLine());

            Console.WriteLine("Это правильный пароль");

            Console.ReadLine();
        }
    }
}
