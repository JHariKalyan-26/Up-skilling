using System;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        File.WriteAllText("sample.txt", "Hello FileStream");

        using FileStream fs =
            new FileStream("sample.txt", FileMode.Open);

        using StreamReader sr =
            new StreamReader(fs);

        Console.WriteLine(sr.ReadToEnd());

        using MemoryStream ms = new MemoryStream();

        byte[] data =
            Encoding.UTF8.GetBytes("Memory Stream Data");

        ms.Write(data, 0, data.Length);

        Console.WriteLine($"Bytes Written: {ms.Length}");
    }
}