//using System;
//using System.IO;
//using System.Text.Json;

//class Program3
//{
//    static void Main(string[] args)
//    {
       
//        string filePath = "C:\\Users\\varsh\\OneDrive\\Desktop\\JsonAssignment\\data.json";

//        if (File.Exists(filePath))
//        {
          
//            string jsonString = File.ReadAllText(filePath);

          
//            using JsonDocument doc = JsonDocument.Parse(jsonString);
//            JsonElement root = doc.RootElement;

//            string name = root.GetProperty("name").GetString();
//            string email = root.GetProperty("email").GetString();

            
//            Console.WriteLine($"Name: {name}");
//            Console.WriteLine($"Email: {email}");
//        }
//        else
//        {
//            Console.WriteLine("File not found!");
//        }
//    }
//}
