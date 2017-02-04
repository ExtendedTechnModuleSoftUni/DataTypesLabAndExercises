using System;
using System.Collections.Generic;

class DigitsWithWords
{
    static void Main()
    {
        string stringDigit = Console.ReadLine();

        Dictionary<string, int> result = new Dictionary<string, int>();

        result["zero"] = 0;
        result["one"] = 1;
        result["two"] = 2;
        result["three"] = 3;
        result["four"] = 4;
        result["five"] = 5;
        result["six"] = 6;
        result["seven"] = 7;
        result["eight"] = 8;
        result["nine"] = 9;

        if (result.ContainsKey(stringDigit))
        {
            Console.WriteLine(result[stringDigit]);
        }
    }
}

