using System;
public class program
{
    public static void Main()
    {
        Console.WriteLine("select the input temperature scale:\r\n1. Celsius\r\n2. Kelvin\r\n3. Fahrenheit");
        int nam = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter the temperature indicator (degrees):");
        double temp = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("select the scale type to convert:\r\n1. Celsius\r\n2. Kelvin\r\n3. Fahrenheit\r\n");
        int nam2 = Convert.ToInt32(Console.ReadLine());
        if (nam == 1 & nam2 == 1)
        {
            Console.WriteLine("u have chosen: Celsius > Celsius");
            Console.WriteLine("conversion result: " + temp);
        }
        else if (nam == 1 & nam2 == 2)
        {
            Console.WriteLine("u have chosen: Celsius > Kelvin");
            double kel = temp + 273;
            Console.WriteLine("conversion result: " + kel);

        }
        else if (nam == 1 & nam2 == 3)
        {
            Console.WriteLine("u have chosen: Celsius > Fahrenheit");
            double far = (temp + 273) * 1.8 - 459;
            Console.WriteLine("conversion result: " + far);
        }
        else if (nam == 2 & nam2 == 1)
        {
            Console.WriteLine("u have chosen: Kelvin > Celsius");
            double cel = temp - 273;
            Console.WriteLine("conversion result: " + cel);
        }
        else if (nam == 2 & nam2 == 2)
        {
            Console.WriteLine("u have chosen: Kelvin > Kelvin");
            Console.WriteLine("conversion result: " + temp);
        }
        else if (nam == 2 & nam2 == 3)
        {
            Console.WriteLine("u have chosen: Kelvin > Fahrenheit");
            double far2 = temp * 1.8 - 459;
            Console.WriteLine("conversion result: " + far2);

        }
        else if (nam == 3 & nam2 == 1)
        {
            Console.WriteLine("u have chosen: Fahrenheit > Celsius");
            double cel2 = (temp - 32) / 1.8;
            Console.WriteLine("conversion result: " + cel2);
        }
        else if (nam == 3 & nam2 == 2)
        {
            Console.WriteLine("u have chosen: Fahrenheit > Kelvin");
            double kel2 = (temp + 459) / 1.8;
            Console.WriteLine("conversion result: " + kel2);
        }
        else if (nam == 3 & nam2 == 3)
        {
            Console.WriteLine("u have chosen: Fahrenheit > Fahrenheit");
            Console.WriteLine("conversion result: " + temp);

        }
    }
}
