using System;

class Student
{
    public required string Name { get; set; }
    public required int Age { get; set; }
}

class Program
{
    static void Main()
    {
        Student s = new()
        {
            Name = "Hari",
            Age = 20
        };

        Console.WriteLine($"{s.Name} - {s.Age}");
    }
}