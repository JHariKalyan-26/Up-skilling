using System;

class Program
{
    static void ModifyRef(ref int number)
    {
        number += 10;
    }

    static void ModifyOut(out int number)
    {
        number = 100;
    }

    static void DisplayIn(in int number)
    {
        Console.WriteLine("In parameter value: " + number);
    }

    static void Main()
    {
        int refValue = 20;
        Console.WriteLine("Before ref: " + refValue);
        ModifyRef(ref refValue);
        Console.WriteLine("After ref: " + refValue);

        int outValue;
        ModifyOut(out outValue);
        Console.WriteLine("Out value: " + outValue);

        int inValue = 50;
        DisplayIn(in inValue);
    }
}