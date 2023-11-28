using System;
using System.IO;
public class program
{
    public static void Main()
    {
        double number1, number2, number3, number4;

        Console.Write("enter the 1 number: ");
        number1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("enter the 2 number: ");
        number2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("enter the 3 number: ");
        number3 = Convert.ToDouble(Console.ReadLine());

        Console.Write("enter the 4 number: ");
        number4 = Convert.ToDouble(Console.ReadLine());

        double result = (number1 + number2 + number3 + number4) / 4;
        Console.WriteLine("the average of {0}, {1}, {2}, {3} is: {4} ",
     number1, number2, number3, number4, result);
    }
}
