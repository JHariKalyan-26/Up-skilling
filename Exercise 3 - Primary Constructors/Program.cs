using System;

public class Person(string name, int age)
{
    public string Name { get; } = name;
    public int Age { get; } = age;

    public void Display()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

class Program
{
    static void Main()
    {
        Person person = new Person("Hari Kalyan", 20);
        person.Display();
    }
}