//using System;
//using System.IO;
//using System.Text.Json;
//using System.Text.Json.Nodes;

//class Program8
//{
//    static void Main(string[] args)
//    {
//        string filePath = "C:\\Users\\varsh\\OneDrive\\Desktop\\JsonAssignment\\data.json";

//        if (File.Exists(filePath))
//        {
//            string jsonString = File.ReadAllText(filePath);
//            JsonNode jsonNode = JsonNode.Parse(jsonString);

//            PrintJson(jsonNode);
//        }
//        else
//        {
//            Console.WriteLine("File not found!");
//        }
//    }

//    static void PrintJson(JsonNode node, string indent = "")
//    {
//        if (node is JsonObject obj)
//        {
//            foreach (var kvp in obj)
//            {
//                Console.WriteLine($"{indent}{kvp.Key}: {kvp.Value}");
//                PrintJson(kvp.Value, indent + "  ");
//            }
//        }
//        else if (node is JsonArray arr)
//        {
//            int index = 0;
//            foreach (var item in arr)
//            {
//                Console.WriteLine($"{indent}[{index}]");
//                PrintJson(item, indent + "  ");
//                index++;
//            }
//        }
//    }
//}
