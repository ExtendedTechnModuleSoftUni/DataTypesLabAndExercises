using System;

class IncrementVariable
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        byte byteValue = 0;
        byte overflowCounter = 0;
        bool isOverflow = false;

        for (int i = 0; i < n; i++)
        {
            byteValue++;

            if (byteValue == 0)
            {
                overflowCounter++;
                byteValue = 0;
                isOverflow = true;
            }
        }

        if (isOverflow)
        {
            Console.WriteLine($"{byteValue}\nOverflowed {overflowCounter} times");
        }
        else
        {
            Console.WriteLine(byteValue);
        }
    }
}

