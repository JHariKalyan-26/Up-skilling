using System;

class Program
{
    static (int, string) GetData()
    {
        return (101, "Hari Kalyan");
    }

    static void Main()
    {
        var (id, name) = GetData();

        Console.WriteLine($"ID: {id}");
        Console.WriteLine($"Name: {name}");
    }
}