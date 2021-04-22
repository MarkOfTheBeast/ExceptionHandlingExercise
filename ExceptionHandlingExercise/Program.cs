using System;
using System.Collections.Generic;
using System.IO;

namespace ExceptionHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            var arr = new char[] { '1', '2', '3', '4', '5', '6', 'a', 'b', 'c' };
            var numbers = new List<int>();
            string init = "";

            foreach (char ch in arr)
            {
                try
                {
                    init = ch.ToString();
                    int num = int.Parse(init);
                    numbers.Add(num);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"Unable to Parse '{ch}'");
                }
                           
            }
            Console.WriteLine();
            Console.WriteLine("Int values parsed:");
            foreach (int num in numbers)
            { Console.Write($"{num} "); }
        }
    }
}
