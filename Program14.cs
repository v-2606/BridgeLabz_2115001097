//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Text.Json;

//class Program14
//{
//    static void Main(string[] args)
//    {
//        string filePath = "C:\\Users\\varsh\\OneDrive\\Desktop\\JsonAssignment\\data.csv";

//        if (File.Exists(filePath))
//        {
//            string[] lines = File.ReadAllLines(filePath);

//            string[] headers = lines[0].Split(',');

//            List<Dictionary<string, string>> jsonList = new List<Dictionary<string, string>>();

//            for (int i = 1; i < lines.Length; i++)
//            {
//                string[] values = lines[i].Split(',');
//                Dictionary<string, string> obj = new Dictionary<string, string>();

//                for (int j = 0; j < headers.Length; j++)
//                {
//                    obj[headers[j]] = values[j];
//                }

//                jsonList.Add(obj);
//            }

//            string jsonString = JsonSerializer.Serialize(jsonList, new JsonSerializerOptions { WriteIndented = true });
//            Console.WriteLine(jsonString);
//        }
//        else
//        {
//            Console.WriteLine("CSV file not found!");
//        }
//    }
//}
