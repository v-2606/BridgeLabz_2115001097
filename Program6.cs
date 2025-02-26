//using System;
//using System.Collections.Generic;
//using System.Text.Json;

//class Car
//{
//    public string Brand { get; set; }
//    public string Model { get; set; }
//    public int Year { get; set; }
//}

//class Program6
//{
//    static void Main(string[] args)
//    {
//        List<Car> cars = new List<Car>
//        {
//            new Car { Brand = "Toyota", Model = "Corolla", Year = 2022 },
//            new Car { Brand = "Honda", Model = "Civic", Year = 2021 },
//            new Car { Brand = "Ford", Model = "Mustang", Year = 2023 }
//        };

//        string jsonString = JsonSerializer.Serialize(cars, new JsonSerializerOptions { WriteIndented = true });
//        Console.WriteLine(jsonString);
//    }
//}
