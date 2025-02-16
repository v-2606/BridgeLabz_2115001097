//using System;
//using System.Text;
//using System.Diagnostics;

//class Compare
//{
  
//    public static string ConcatenateWithStringBuilder(string[] input)
//    {
        
//        StringBuilder result = new StringBuilder();

     
//        foreach (string str in input)
//        {
//            result.Append(str);
//        }

//        return result.ToString();
//    }

//    public static string ConcatenateWithString(string[] input)
//    {
//        string result = string.Empty;

//        foreach (string str in input)
//        {
//            result += str;
//        }

//        return result;
//    }

//    static void Main(string[]args)
//    {
     
//        Console.Write("Enter  of strings: ");
//        int length = int.Parse(Console.ReadLine());

//        string[] input = new string[length];
//        for (int i = 0; i < length; i++)
//        {
//            Console.Write("Enter string " + (i + 1) + ": ");
//            input[i] = Console.ReadLine();
//        }

//        Stopwatch stopwatch = new Stopwatch();

//        stopwatch.Start();
//        string sbResult = ConcatenateWithStringBuilder(input);
//        stopwatch.Stop();
//        Console.WriteLine("StringBuilder time: " + stopwatch.ElapsedMilliseconds + " ms");

        
//        stopwatch.Restart();
//        string strResult = ConcatenateWithString(input);
//        stopwatch.Stop();
//        Console.WriteLine("String concatenation time: " + stopwatch.ElapsedMilliseconds + " ms");
//    }
//}
