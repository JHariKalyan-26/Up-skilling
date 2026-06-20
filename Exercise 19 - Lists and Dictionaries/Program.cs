using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> names = new()
        {
            "Hari",
            "Kalyan",
            "Rebel"
        };

        Dictionary<int, string> students = new()
        {
            {1,"Hari"},
            {2,"Kalyan"}
        };

        foreach (var name in names)
            Console.WriteLine(name);

        foreach (var item in students)
            Console.WriteLine($"{item.Key} {item.Value}");
    }
}