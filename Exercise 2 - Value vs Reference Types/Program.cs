using System;

class Student
{
    public string Name;
}

class Program
{
    static void ModifyValue(int number)
    {
        number = 100;
    }

    static void ModifyReference(Student student)
    {
        student.Name = "Updated Name";
    }

    static void Main()
    {
        int num = 10;
        Student s = new Student { Name = "Hari" };

        Console.WriteLine("Before Value Type: " + num);
        ModifyValue(num);
        Console.WriteLine("After Value Type: " + num);

        Console.WriteLine("Before Reference Type: " + s.Name);
        ModifyReference(s);
        Console.WriteLine("After Reference Type: " + s.Name);
    }
}