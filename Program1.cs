using Newtonsoft.Json;
using System;

class Program1
{
    static void Main(string[] args)
    {
        

        var jsonObject = new
        {
            name = "Amit",
            age = 25,
            email = "Amit@example.com"
        };

      

        string jsonString = JsonConvert.SerializeObject(jsonObject, Formatting.Indented);

      
        Console.WriteLine(jsonString);

      
        Console.ReadLine();
    }
}