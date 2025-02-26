//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text.Json;

//class Person
//{
//    public string Name { get; set; }
//    public string Email { get; set; }
//    public int Age { get; set; }
//}

//class Program7
//{
//    static void Main(string[] args)
//    {
//        string jsonString = @"[
//            { ""Name"": ""Amit Sharma"", ""Email"": ""amit@example.com"", ""Age"": 30 },
//            { ""Name"": ""Rahul Verma"", ""Email"": ""rahul@example.com"", ""Age"": 24 },
//            { ""Name"": ""Sneha Mehta"", ""Email"": ""sneha@example.com"", ""Age"": 27 }
//        ]";

//        List<Person> people = JsonSerializer.Deserialize<List<Person>>(jsonString);

//        var filteredPeople = people.Where(p => p.Age > 25).ToList();

//        string resultJson = JsonSerializer.Serialize(filteredPeople, new JsonSerializerOptions { WriteIndented = true });

//        Console.WriteLine(resultJson);
//    }
//}
