using System;

class ExactProduct
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        decimal result = 1;

        for (int i = 0; i < n; i++)
        {
            result *= decimal.Parse(Console.ReadLine());
        }

        Console.WriteLine(result);
    }
}

