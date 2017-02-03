using System;

class TravelingAtLightSpeed
{
    static void Main()
    {
        decimal inputLightYears = decimal.Parse(Console.ReadLine());

        decimal lightYearKm = inputLightYears * 9450000000000;
        decimal weeks = ((((lightYearKm / 300000) / 60) / 60) / 24) / 7;
        decimal residue = weeks - Math.Truncate(weeks);
        decimal days = residue * 7;
        residue = days - Math.Truncate(days);
        decimal hours = residue * 24;
        residue = hours - Math.Truncate(hours);
        decimal minutes = residue * 60;
        residue = minutes - Math.Truncate(minutes);
        decimal seconds = residue * 60;

        Console.WriteLine($"{(ulong)weeks} weeks");
        Console.WriteLine($"{(ulong)days} days");
        Console.WriteLine($"{(ulong)hours} hours");
        Console.WriteLine($"{(ulong)minutes} minutes");
        Console.WriteLine($"{(ulong)seconds} seconds");
    }
}

