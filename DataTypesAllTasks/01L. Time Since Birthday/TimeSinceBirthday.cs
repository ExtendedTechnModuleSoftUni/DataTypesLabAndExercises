using System;

class TimeSinceBirthday
{
    static void Main()
    {
        byte inputYears = byte.Parse(Console.ReadLine());

        ushort days = (ushort)(inputYears * 365);
        int hours = days * 24;
        long minutes = hours * 60;

        Console.WriteLine($"{inputYears} years = {days} days = {hours} hours = {minutes} minutes.");

    }
}

