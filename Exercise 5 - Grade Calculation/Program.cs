using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter score: ");
        int score = Convert.ToInt32(Console.ReadLine());

        string grade;

        if (score >= 90)
            grade = "A";
        else if (score >= 75)
            grade = "B";
        else if (score >= 60)
            grade = "C";
        else
            grade = "Fail";

        Console.WriteLine("Grade using if-else: " + grade);

        string switchGrade = score switch
        {
            >= 90 => "A",
            >= 75 => "B",
            >= 60 => "C",
            _ => "Fail"
        };

        Console.WriteLine("Grade using switch: " + switchGrade);
    }
}