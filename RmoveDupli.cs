//using System;
//using System.Text;
//using System.Collections.Generic;

//class RmoveDupli
//{
  
//    public static string RemoveDuplicates(string input)
//    {
       
//        StringBuilder result = new StringBuilder();

     
//        HashSet<char> seen = new HashSet<char>();

//        foreach (char c in input)
//        {
            
//            if (!seen.Contains(c))
//            {
//                seen.Add(c);
//                result.Append(c);
//            }
//        }

//        return result.ToString();
//    }

//    static void Main(string[]args)
//    {
//        Console.Write("Enter a string: ");
//        string input = Console.ReadLine();

        
//        string result = RemoveDuplicates(input);
//        Console.WriteLine("String after removing duplicates: " + result);
//    }
//}

