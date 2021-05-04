using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4 };
            double[] doubleArray = { 1.1, 2.1, 3.1, 4.1 };
            char[] charArray = { 'a', 'b', 'c', 'd' };

            //Program.toPrint(doubleArray);
            //Program.toPrint(charArray);

            //GENERIC METHODS
            Program.toPrint<int>(intArray);
            Program.toPrint<double>(doubleArray);
            Program.toPrint<char>(charArray);

            //GENERIC CLASS
            PrintArray<int> printIntArray = new PrintArray<int>(intArray);
            printIntArray.ToPrint();
            PrintArray<double> printDoubleArray = new PrintArray<double>(doubleArray);
            printDoubleArray.ToPrint();
            PrintArray<char> printCharArray = new PrintArray<char>(charArray);
            printCharArray.ToPrint();

            new PrintArray<int>(intArray).ToPrint();
            new PrintArray<double>(doubleArray).ToPrint();
            new PrintArray<char>(charArray).ToPrint();

            Console.ReadKey();
        }
        //public static void toPrint(double[] inputArray)
        //{
        //    foreach (double element in inputArray)
        //    {
        //        Console.WriteLine(element);
        //    }
        //    Console.WriteLine("-----------");
        //}
        //public static void toPrint(char[] inputArray)
        //{
        //    foreach (char element in inputArray)
        //    {
        //        Console.WriteLine(element);
        //    }
        //    Console.WriteLine("-----------");
        //}
        public static void toPrint<T>(T[] inputArray)
        {
            foreach (T element in inputArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("-----------");
        }
    }
}
