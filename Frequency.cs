//using System;
//using System.Collections.Generic;

//class Frequency
//{
//    static Dictionary<string, int> GetFrequency(List<string> items)
//    {
//        Dictionary<string, int> frequencyMap = new Dictionary<string, int>();

//        foreach (var item in items)
//        {
//            if (frequencyMap.ContainsKey(item))
//                frequencyMap[item]++;
//            else
//                frequencyMap[item] = 1;
//        }

//        return frequencyMap;
//    }

//    static void Main(string[] args)
//    {
//        List<string> items = new List<string> { "apple", "banana", "apple", "orange" };
//        Dictionary<string, int> result = GetFrequency(items);

//        foreach (var pair in result)
//        {
//            Console.WriteLine(pair.Key + ": " + pair.Value);
//        }
//    }
//}
