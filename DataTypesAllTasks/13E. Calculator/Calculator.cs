using System;

class Calculator
{
    static void Main()
    {
        int firstOperand = int.Parse(Console.ReadLine());
        char indication = char.Parse(Console.ReadLine());
        int secondOperand = int.Parse(Console.ReadLine());

        CalculateNumbers(firstOperand, indication, secondOperand);
    }

    static void CalculateNumbers(int firstOperand, char indication, int secondOperand)
    {
        long result = 0;

        switch (indication)
        {
            case '+':
                result = firstOperand + secondOperand;
                break;
            case '-':
                result = firstOperand - secondOperand;
                break;
            case '*':
                result = firstOperand * secondOperand;
                break;
            case '/':
                result = firstOperand / secondOperand;
                break;
        }

        Console.WriteLine($"{firstOperand} {indication} {secondOperand} = {result}");
    }
}

