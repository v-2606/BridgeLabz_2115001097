//using System;
//using Newtonsoft.Json;
//using Newtonsoft.Json.Linq;
//using System.Xml.Linq;

//class Program13
//{
//    static void Main(string[] args)
//    {
//        string jsonString = @"{
//            ""name"": ""Amit Sharma"",
//            ""email"": ""amit@example.com"",
//            ""age"": 30
//        }";

      
//        JObject json = JObject.Parse(jsonString);
//        XDocument xml = JsonConvert.DeserializeXNode(json.ToString(), "Root");

//        Console.WriteLine(xml);
//    }
//}
