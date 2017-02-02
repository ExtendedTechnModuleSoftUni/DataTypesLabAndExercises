using System;

class ExchangeVariableValues
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        int temp = b;

        b = a;
        a = temp;

        Console.WriteLine($"{a} \n{b}");
    }
}

