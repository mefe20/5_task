using System;
using System.Linq;

internal class program
{
    public class Example
    {
        public static void Main()
        {
            int[] arr = { 8, 4, -2, 1, 10 };

            Console.WriteLine("the largest number - " + arr.Max());
            Console.WriteLine("the smallest number - " + arr.Min());
        }
    }
}