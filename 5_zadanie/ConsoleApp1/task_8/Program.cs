internal class program
{
    static void Main()
    {
        Console.WriteLine("enter the size of the pyramid:");
        int levels = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= levels; i++)
        {

            Console.Write(new string(' ', levels - i));

            for (int j = 1; j <= i; j++)
            {
                Console.Write(j);
            }

            for (int j = i - 1; j >= 1; j--)
            {
                Console.Write(j);
            }

            Console.WriteLine();
        }
    }
}