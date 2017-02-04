using System;

class TrickyStrings
{
    static void Main(string[] args)
    {
        string delimeter = Console.ReadLine();
        int n = int.Parse(Console.ReadLine());
 
        SeparatingStringByDelimeter(delimeter, n);
    }

    private static void SeparatingStringByDelimeter(string delimeter, int n)
    {
        string[] outputWords = new string[n];

        for (int i = 0; i < n; i++)
        {
            string inputWords = Console.ReadLine();

            outputWords[i] = inputWords;
        }

        Console.WriteLine(string.Join(delimeter, outputWords));
    }
}

