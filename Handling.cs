//using System;
//using System.IO;

//public class Handling
//{
//    static void Main(string[] args)
//    {
//        string filePath = "data.txt";

//        try
//        {
         
//            string content = File.ReadAllText(filePath);
//            Console.WriteLine("File Contents:\n" + content);
//        }
//        catch (FileNotFoundException)
//        {
           
//            Console.WriteLine("File not found");
//        }
//        catch (IOException ex)
//        {
//            Console.WriteLine("An error occurred: " + ex.Message);
//        }
//    }
//}
