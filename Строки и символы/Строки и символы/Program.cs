using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Строки_и_символы
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(ConcatenateStrings("fff", "gggg"));
            //Console.WriteLine(SubstringMethod("fjfkivje"));
            //string[] strings = { "mvm", "efgjmjdjcv", "wekgkd" };
            //Console.WriteLine(ReplaceWords("Hello world", "world", "universe"));
        }
        
        public static string ConcatenateStrings(string a, string b)
        {
            a = a + b;
            return a;
        }
        public static string GreetUser(string name, int age)
        {
            int count = 0;
            for (int i = 0; i < $"Hello, {name}!\nYou are {age} years old.".Length; i++)
            {
                if (char.IsUpper($"Hello, {name}!\nYou are {age} years old."[i])) count++;
            }

            Console.WriteLine($"Number of characters per line {$"Hello, {name}!\nYou are {age} years old.".Length}" +
                $" uppercase {count} lowercase");
            Console.WriteLine();

            return $"Hello, {name}!\nYou are {age} years old.";
        }
        public static string SubstringMethod(string sub)
        {
            return sub.Substring(0, 5);
        }
        public static string ArrayStringBuilder(string[] sb)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < sb.Length; i++)
            {
                stringBuilder.Append(sb[i]+" ");
            }

            return stringBuilder.ToString();
        }
        public static string ReplaceWords(string inputString, string wordToReplace, string replacementWord)
        {
            return inputString.Replace(wordToReplace, replacementWord);
        }

    }
}
