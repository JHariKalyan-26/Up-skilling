using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 10, 20, 30, 40, 50 };

        Console.WriteLine("For Loop:");
        for (int i = 0; i < numbers.Length; i++)
            Console.WriteLine(numbers[i]);

        Console.WriteLine("Foreach Loop:");
        foreach (int number in numbers)
            Console.WriteLine(number);

        Console.WriteLine("While Loop:");
        int j = 0;
        while (j < numbers.Length)
        {
            Console.WriteLine(numbers[j]);
            j++;
        }

        Console.WriteLine("Do-While Loop:");
        int k = 0;
        do
        {
            Console.WriteLine(numbers[k]);
            k++;
        } while (k < numbers.Length);
    }
}