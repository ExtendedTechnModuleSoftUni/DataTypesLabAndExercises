using System;

class Transport
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double capacity = 24.0;

        double courses = Math.Ceiling(n / capacity);

        Console.WriteLine(courses);
    }
}

