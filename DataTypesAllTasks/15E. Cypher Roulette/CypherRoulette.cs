using System;
using System.Collections.Generic;

class CypherRoulette
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        RollingText(n);
    }

    static void RollingText(int n)
    {
        int spinCounter = 0;
        List<string> text = new List<string>();
        string[] arr = new string[2 * n];
        int start = 0;
        for (int i = 0; i < n; i++, start++)
        {
            string wordOrCommand = Console.ReadLine();

            if (wordOrCommand != "spin" && spinCounter % 2 == 0)
            {
                if (text.Count > 0)
                {
                    if (text[text.Count - 1] == (wordOrCommand))
                    {
                        text.Clear();
                    }
                    else
                    {
                        text.Add(wordOrCommand);
                    }
                }
                else
                {
                    text.Add(wordOrCommand);
                }
            }
            else if (wordOrCommand == "spin")
            {
                arr[start] = wordOrCommand;

                if (start > 1)
                {
                    if (arr[start] == arr[start - 1])
                    {
                        text.Clear();
                    }
                }            

                spinCounter++;
                i--;
            }
            else
            {
                text.Insert(0, wordOrCommand);
            }
        }

        Console.WriteLine(string.Join("", text));
    }
}