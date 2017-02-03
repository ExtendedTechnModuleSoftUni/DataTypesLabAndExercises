using System;

class FromTerabytesToBits
{
    static void Main()
    {
        double teraBytes = double.Parse(Console.ReadLine());

        decimal bits = (decimal)(teraBytes * (Math.Pow(1024.0, 4) * 8));

        Console.WriteLine(bits);
    }
}

