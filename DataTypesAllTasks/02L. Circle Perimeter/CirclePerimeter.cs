using System;

class CirclePerimeter
{
    static void Main()
    {
        double radius = double.Parse(Console.ReadLine());

        Console.WriteLine("{0:f12}", 2 * Math.PI * radius);
    }
}

