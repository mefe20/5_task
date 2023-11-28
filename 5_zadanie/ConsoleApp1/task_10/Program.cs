static void Main()
{
    {
        decimal[] prices = new decimal[20]
        {
                                            1M, 860M, 72M, 120M, 54M,
                                            160M, 210M, 135M, 155M, 20M,
                                            30M, 55M, 125M, 182M, 235M,
                                            19M, 25M, 140M, 165M, 520M
        };

        decimal total = 0;
        for (int o = 0; o < prices.Length; o++)
        {
            total += prices[o];
        }

        decimal averagePrice = total / prices.Length;

        int countBelowAverage = 0;
        for (int o = 0; o < prices.Length; o++)
        {
            if (prices[o] < averagePrice)
            {
                countBelowAverage++;
            }
        }

        Console.WriteLine($"average cost of goods: {averagePrice}");
        Console.WriteLine($"the number of products with a price below the average: {countBelowAverage}");
    }
}
                            