using System;

class VariableInHexadecimalFormat
{
    static void Main(string[] args)
    {
        string HexadecimalNum = Console.ReadLine();

        Console.WriteLine(Convert.ToInt32(HexadecimalNum, 16));
    }
}

