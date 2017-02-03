using System;

class Program
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        double squareA = Math.Pow(a, 2);
        double squareB = Math.Pow(b, 2);
        double squareC = Math.Pow(c, 2);


        if (TriangleValidation(a, b, c))
        {
            Console.WriteLine("Triangle is valid.");
            GetRightAngle(squareA, squareB, squareC);
        }
        else
        {
            Console.WriteLine("Invalid Triangle.");

        }
    }

    static void GetRightAngle(double squareA, double squareB, double squareC)
    {
        if (squareA + squareB == squareC)
        {
            Console.WriteLine("Triangle has a right angle between sides a and b");
        }
        else if (squareA + squareC == squareB)
        {
            Console.WriteLine("Triangle has a right angle between sides a and c");
        }
        else if (squareB + squareC == squareA)
        {
            Console.WriteLine("Triangle has a right angle between sides b and c");
        }
        else
        {
            Console.WriteLine("Triangle has no right angles");
        }
    }

    static bool TriangleValidation(double a, double b, double c)
    {
        bool isValid = false;

        if (a + b > c && a + c > b && b + c > a)
        {
            isValid = true;
        }

        return isValid;
    }
}

