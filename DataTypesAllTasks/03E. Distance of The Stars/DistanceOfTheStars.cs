using System;

class DistanceOfTheStars
{
    static void Main()
    {
        decimal distanceEarthNearestStar = 4.22M * 9450000000000;
        decimal distanceGalaxyCenter = 26000M * 9450000000000;
        decimal diameter = 100000M * 9450000000000;
        decimal earthUniverse = 46500000000M * 9450000000000;

        Console.WriteLine("{0:f2}", distanceEarthNearestStar);
        Console.WriteLine("{0:f2}", distanceGalaxyCenter);
        Console.WriteLine("{0:f2}", diameter);
        Console.WriteLine("{0:f2}", earthUniverse);
    }
}

