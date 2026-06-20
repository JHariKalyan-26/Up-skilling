using System;
using System.Threading;

class Program
{
    static object lock1 = new();
    static object lock2 = new();

    static void Main()
    {
        bool acquired = Monitor.TryEnter(lock1, 1000);

        if (acquired)
        {
            try
            {
                Console.WriteLine("Lock acquired safely");
            }
            finally
            {
                Monitor.Exit(lock1);
            }
        }
    }
}