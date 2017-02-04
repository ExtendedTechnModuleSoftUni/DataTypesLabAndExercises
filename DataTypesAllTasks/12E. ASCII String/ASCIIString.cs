using System;

class ASCIIString
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        ConvertDigitToString(n);
    }

    static void ConvertDigitToString(int n)
    {
        char[] symbolsToText = new char[n];

        for (int i = 0; i < n; i++)
        {
            int digit = int.Parse(Console.ReadLine());

            symbolsToText[i] = (char)digit;
        }

        Console.WriteLine(string.Join("", symbolsToText));
    }
}

