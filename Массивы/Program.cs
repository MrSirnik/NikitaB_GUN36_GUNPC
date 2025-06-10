using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Массивы
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] fibonacci_numbers = { 0, 1, 1, 2, 3, 5, 8, 13 };
            string[] month = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            int[,] two_dimensional_array = new int[,] { { 2, 3, 4 }, { Convert.ToInt32(Math.Pow(2, 2)), Convert.ToInt32(Math.Pow(4, 2)), Convert.ToInt32(Math.Pow(4, 2)) },
                { Convert.ToInt32(Math.Pow(2, 3)), Convert.ToInt32(Math.Pow(3, 3)), Convert.ToInt32(Math.Pow(4, 3)) } };
            double[] array = { 1, 2, 3, 4, 5 };
            double[] ePi = { Math.E, Math.PI };
            double[] log10 = { Math.Log10(1), Math.Log10(10), Math.Log10(100), Math.Log10(1000) };

            double[][] polyline_array_double = new double[3][];
            polyline_array_double[0] = new double[] { 1, 2, 3, 4, 5 };
            polyline_array_double[1] = new double[] { Math.E, Math.PI };
            polyline_array_double[2] = new double[] { Math.Log10(1), Math.Log10(10), Math.Log10(100), Math.Log10(1000) };
 
            int[] array0 = { 1, 2, 3, 4, 5 };
            int[] array1 = { 7, 8, 9, 10, 11, 12, 13 };

            Console.WriteLine("Исходные массивы:");
            Console.WriteLine("array0: " + string.Join(", ", array0));
            Console.WriteLine("array1: " + string.Join(", ", array1));
            Console.WriteLine();

            Array.Copy(array0, 0, array1, 2, 3);
            Console.WriteLine("После Array.Copy(array0, 0, array1, 2, 3):");
            Console.WriteLine("array0: " + string.Join(", ", array0));
            Console.WriteLine("array1: " + string.Join(", ", array1));
            Console.WriteLine();

            Array.Resize(ref array0, array0.Length * 2);
            Console.WriteLine("После Array.Resize(ref array0, array0.Length * 2):");
            Console.WriteLine("array0: " + string.Join(", ", array0));
            Console.WriteLine("array1: " + string.Join(", ", array1));


            Console.ReadKey();
        }
    }
}
