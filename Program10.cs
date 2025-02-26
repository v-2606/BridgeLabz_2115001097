//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text.Json;

//class User
//{
//    public string Name { get; set; }
//    public string Email { get; set; }
//    public int Age { get; set; }
//}

//class Program10
//{
//    static void Main(string[] args)
//    {
//        string jsonString = @"[
//            { ""Name"": ""Amit Sharma"", ""Email"": ""amit@example.com"", ""Age"": 30 },
//            { ""Name"": ""Rahul Verma"", ""Email"": ""rahul@example.com"", ""Age"": 24 },
//            { ""Name"": ""Sneha Mehta"", ""Email"": ""sneha@example.com"", ""Age"": 27 }
//        ]";

//        List<User> users = JsonSerializer.Deserialize<List<User>>(jsonString);

//        var filteredUsers = users.Where(u => u.Age > 25).ToList();

//        string resultJson = JsonSerializer.Serialize(filteredUsers, new JsonSerializerOptions { WriteIndented = true });

//        Console.WriteLine(resultJson);
//    }
//}
