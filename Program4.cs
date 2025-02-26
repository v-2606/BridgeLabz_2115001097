//using System;
//using System.Text.Json;
//using System.Text.Json.Nodes;

//class Program4
//{
//    static void Main(string[] args)
//    {
//        string json1 = @"{ ""name"": ""V Singh"", ""email"": ""amit@example.com"" }";
//        string json2 = @"{ ""age"": 25, ""city"": ""Delhi"" }";

//        JsonObject obj1 = JsonNode.Parse(json1).AsObject();
//        JsonObject obj2 = JsonNode.Parse(json2).AsObject();

//        foreach (var kvp in obj2)
//        {
//            obj1[kvp.Key] = JsonSerializer.Deserialize<JsonNode>(kvp.Value.ToJsonString());
//        }

//        Console.WriteLine(obj1.ToJsonString(new JsonSerializerOptions { WriteIndented = true }));
//    }
//}
