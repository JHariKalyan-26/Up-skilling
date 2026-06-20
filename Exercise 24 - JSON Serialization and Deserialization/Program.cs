using System;
using System.IO;
using System.Text.Json;

class User
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Email { get; set; }
}

class Program
{
    static void Main()
    {
        User user = new User
        {
            Name = "Hari",
            Age = 20,
            Email = "hari@gmail.com"
        };

        string json = JsonSerializer.Serialize(user);

        File.WriteAllText("user.json", json);

        string readJson = File.ReadAllText("user.json");

        User deserializedUser =
            JsonSerializer.Deserialize<User>(readJson);

        Console.WriteLine(deserializedUser.Name);
        Console.WriteLine(deserializedUser.Age);
        Console.WriteLine(deserializedUser.Email);
    }
}