using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Консольное_приложение
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (!Int32.TryParse(Console.ReadLine(), out var a))
            {
                Console.WriteLine("NOt a number!");
                Console.ReadKey();
                return;
            }
            if (!Int32.TryParse(Console.ReadLine(), out var b))
            {
                Console.WriteLine("NOt a number!");
                Console.ReadKey();
                return;
            }
            var sign = Console.ReadLine();
            float result = 0;

            if (sign.Length == 0 || sign.Length > 1)
            {
                Console.WriteLine("Wrong sign");
                Console.ReadKey();
                return;
            }

            switch (sign[0])
            {
                case '+':
                    result = a + b;
                    Console.WriteLine("Result of {0} + {1} = {2}", a, b, result);
                    break;
                case '-':
                    result = a - b;
                    Console.WriteLine("Result of {0} - {1} = {2}", a, b, result);
                    break;
                case '*':
                    result = a * b;
                    Console.WriteLine("Result of {0} * {1} = {2}", a, b, result);
                    break;
                case '/':
                    result = a / b;
                    Console.WriteLine("Result of {0} / {1} = {2}", a, b, result);
                    break;
                case '%':
                    result = a % b;
                    Console.WriteLine("Result of {0} % {1} = {2}", a, b, result);
                    break;
                default: 
                    Console.WriteLine("Not the right thing");
                    break;
            }
            Console.WriteLine(" В двоичной системе счисления            " + Convert.ToString(Convert.ToInt32(result), 2));
            Console.WriteLine(" В восьмеричной системе счисления        " + Convert.ToString(Convert.ToInt32(result), 8));
            Console.WriteLine(" В шестнадцатеричной системе счисления   " + Convert.ToString(Convert.ToInt32(result), 16));

            Console.Write(" Введите также систему которой здесь нет, если она необходима: ");
            Console.WriteLine(Convert.ToString(Convert.ToInt32(result), Convert.ToInt32(Console.ReadLine())));

            Console.ReadKey();
        }
    }
}
