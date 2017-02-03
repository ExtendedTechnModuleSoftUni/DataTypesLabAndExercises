using System;

class DataOverflow
{
    static void Main()
    {
        decimal firstNumber = decimal.Parse(Console.ReadLine());
        decimal secondNumber = decimal.Parse(Console.ReadLine());

        decimal max = Math.Max(firstNumber, secondNumber);
        decimal min = Math.Min(firstNumber, secondNumber);

        byte byteMaxValue = byte.MaxValue;
        ushort ushortMaxValue = ushort.MaxValue;
        uint uintMaxValue = uint.MaxValue;
        ulong ulongMaxValue = ulong.MaxValue;


        GetBiggerType(max, byteMaxValue, ushortMaxValue, uintMaxValue, ulongMaxValue);
        GetSmallerType(max, min, byteMaxValue, ushortMaxValue, uintMaxValue, ulongMaxValue);


    }

    public static void GetSmallerType(decimal max, decimal min, byte byteMaxValue, ushort ushortMaxValue, uint uintMaxValue, ulong ulongMaxValue)
    {
        string smallerType = "";

        if (min <= byteMaxValue)
        {
            smallerType = "byte";
        }
        else if (min <= ushortMaxValue)
        {
            smallerType = "ushort";
        }
        else if (min <= uintMaxValue)
        {
            smallerType = "uint";
        }
        else
        {
            smallerType = "ulong";
        }

        Console.WriteLine($"smaller type: {smallerType}");

        if (smallerType == "byte")
        {
            Console.WriteLine($"{max} can overflow byte {Math.Round(max / byteMaxValue)} times");
        }
        else if (smallerType == "ushort")
        {
            Console.WriteLine($"{max} can overflow ushort {Math.Round(max / ushortMaxValue)} times");
        }
        else if (smallerType == "uint")
        {
            Console.WriteLine($"{max} can overflow uint {Math.Round(max / uintMaxValue)} times");
        }
        else
        {
            Console.WriteLine($"{max} can overflow ulong {Math.Round(max / ulongMaxValue)} times");
        }
    }

    static void GetBiggerType(decimal max, byte byteMaxValue, ushort ushortMaxValue, uint uintMaxValue, ulong ulongMaxValue)
    {
        string biggerType = "";

        if (max <= byteMaxValue)
        {
            biggerType = "byte";
        }
        else if (max <= ushortMaxValue)
        {
            biggerType = "ushort";
        }
        else if (max <= uintMaxValue)
        {
            biggerType = "uint";
        }
        else
        {
            biggerType = "ulong";
        }

        Console.WriteLine($"bigger type: {biggerType}");
    }
}

