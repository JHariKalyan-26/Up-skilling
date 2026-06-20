using System;

class Student
{
    public string Name { get; set; } = "Hari";
}

class Program
{
    static void Main()
    {
        var number = 25;
        var name = "Hari Kalyan";
        var student = new Student();

        Console.WriteLine($"{number} - {number.GetType()}");
        Console.WriteLine($"{name} - {name.GetType()}");
        Console.WriteLine($"{student.Name} - {student.GetType()}");
    }
}