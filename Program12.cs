//using System;
//using System.IO;
//using System.Text.Json;
//using System.Text.Json.Nodes;

//class Program12
//{
//    static void Main(string[] args)
//    {
//        string file1 = "data1.json";
//        string file2 = "data2.json";

//        if (File.Exists(file1) && File.Exists(file2))
//        {
//            string json1 = File.ReadAllText(file1);
//            string json2 = File.ReadAllText(file2);

//            JsonObject obj1 = JsonNode.Parse(json1).AsObject();
//            JsonObject obj2 = JsonNode.Parse(json2).AsObject();

//            foreach (var kvp in obj2)
//            {
//                obj1[kvp.Key] = kvp.Value; 
//            }

//            string mergedJson = JsonSerializer.Serialize(obj1, new JsonSerializerOptions { WriteIndented = true });
//            Console.WriteLine(mergedJson);
//        }
//        else
//        {
//            Console.WriteLine("One or both files are missing");
//        }
//    }
//}
