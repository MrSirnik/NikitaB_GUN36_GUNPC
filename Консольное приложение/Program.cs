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
            var s = Console.ReadLine();
            var boolVar = true;
            if (s.Length == 0 || s.Length > 1 && !boolVar)
            {
                Console.WriteLine("Wrong sign");
                Console.ReadKey();
                return;
            }

            switch (s[0])
            {
                case '+':
                    Console.WriteLine("Result of {0} + {1} = {2}", a, b, a + b);
                    break;
                case '-':
                    Console.WriteLine("Result of {0} - {1} = {2}", a, b, a - b);
                    break;
                case '*':
                    Console.WriteLine("Result of {0} * {1} = {2}", a, b, a * b);
                    break;
                case '/':
                    Console.WriteLine("Result of {0} / {1} = {2}", a, b, a / b);
                    break;
                case '%':
                    Console.WriteLine("Result of {0} % {1} = {2}", a, b, a % b);
                    break;
                default: 
                    Console.WriteLine("Not the right thing");
                    break;
            }
            Console.WriteLine(Convert.ToString(a + b, 2) + " В двоичной системе счисления");
            Console.WriteLine(Convert.ToString(a + b, 8) + " В восьмеричной системе счисления");
            Console.WriteLine(Convert.ToString(a + b, 16) + " В шестнадцатеричной системе счисления");

            Console.Write("Введите также систему которой здесь нет, если она необходима: ");
            Console.WriteLine(Convert.ToString(a + b, Convert.ToInt32(Console.ReadLine())));

            Console.ReadKey();
        }
    }
}
