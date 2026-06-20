using System;

public record Employee
{
    public int Id { get; init; }
    public string Name { get; init; }
}

class Program
{
    static void Main()
    {
        Employee emp1 = new() { Id = 1, Name = "Hari" };

        Employee emp2 = emp1 with { Name = "Kalyan" };

        Console.WriteLine(emp1);
        Console.WriteLine(emp2);
    }
}