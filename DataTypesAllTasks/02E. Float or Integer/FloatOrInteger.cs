using System;

class FloatOrInteger
{
    static void Main()
    {
        decimal input = decimal.Parse(Console.ReadLine());

        Console.WriteLine(Math.Round(input));
    }
}

