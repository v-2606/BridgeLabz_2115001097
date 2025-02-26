//using System;
//using Newtonsoft.Json;
//using Newtonsoft.Json.Linq;
//using Newtonsoft.Json.Schema;

//class Program5
//{
//    static void Main(string[] args)
//    {
//        string jsonString = @"{
//            ""name"": ""Amit Sharma"",
//            ""email"": ""amit@example.com"",
//            ""age"": 25
//        }";

//        string schemaString = @"{
//            ""type"": ""object"",
//            ""properties"": {
//                ""name"": { ""type"": ""string"" },
//                ""email"": { ""type"": ""string"", ""format"": ""email"" },
//                ""age"": { ""type"": ""integer"", ""minimum"": 18 }
//            },
//            ""required"": [""name"", ""email"", ""age""]
//        }";

//        JSchema schema = JSchema.Parse(schemaString);
//        JObject jsonObject = JObject.Parse(jsonString);

//        if (jsonObject.IsValid(schema, out IList<string> errors))
//        {
//            Console.WriteLine("JSON is valid.");
//        }
//        else
//        {
//            Console.WriteLine("JSON is invalid:");
//            foreach (string error in errors)
//            {
//                Console.WriteLine($"- {error}");
//            }
//        }
//    }
//}
