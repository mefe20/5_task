using System;
using System.Collections.Generic;

public class program
{
    public static void Main()
    {
        int[] first_array = { 10, 2, 8, -1 };

        int[] second_array = { 4, -9, 65, -10 };

        Console.WriteLine("1: [{0}]", string.Join(", ", first_array));
        Console.WriteLine("\n");
        Console.WriteLine("2: [{0}]", string.Join(", ", second_array));
        Console.WriteLine("\n");
        Console.WriteLine("result: ");


        for (int i = 0; i < first_array.Length; i++)
        {
            Console.Write(first_array[i] * second_array[i] + " ");
        }

        Console.WriteLine("\n");
    }
}
