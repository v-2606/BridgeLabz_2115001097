//using System;
//using System.Collections.Generic;
//using System.Text.Json;

//class Person
//{
//    public string Name { get; set; }
//    public string Email { get; set; }
//    public int Age { get; set; }
//}

//class Program9
//{
//    static void Main(string[] args)
//    {
//        List<Person> people = new List<Person>
//        {
//            new Person { Name = "Amit Sharma", Email = "amit@example.com", Age = 30 },
//            new Person { Name = "Rahul Verma", Email = "rahul@example.com", Age = 24 },
//            new Person { Name = "Sneha Mehta", Email = "sneha@example.com", Age = 27 }
//        };

//        string jsonString = JsonSerializer.Serialize(people, new JsonSerializerOptions { WriteIndented = true });

//        Console.WriteLine(jsonString);
//    }
//}
