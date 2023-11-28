
public class program
{
    public static void Main()
    {
        double a;
        double b;
        double total;
        char oper;

        Console.WriteLine("enter the 1 number:");
        a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("-, +, /, * or %:");
        oper = Convert.ToChar(Console.ReadLine());

        Console.WriteLine("enter the 1 number:");
        b = Convert.ToDouble(Console.ReadLine());

        if (oper == '+')
        {
            total = a + b;
            Console.WriteLine("sum " + a + " и " + b + " = " + total + ".");
        }

        else if (oper == '-')
        {
            total = a - b;
            Console.WriteLine("difference " + a + " и " + b + " = " + total + ".");
        }

        else if (oper == '*')
        {
            total = a * b;
            Console.WriteLine("multiplication " + a + " и " + b + " = " + total + ".");
        }

        else if (oper == '/')
        {
            total = a / b;
            Console.WriteLine("division " + a + " и " + b + " = " + total + ".");
        }

        else if (oper == '%')
        {
            total = a % b;
            Console.WriteLine("remains " + a + " и " + b + " = " + total + ".");
        }

        else
        {
            Console.WriteLine("unknown operator");
        }
    }

}