//using System;
//using System.IO;

//class Convert
//{
    
//    public static void ConvertByteStreamToCharStream(string filePath)
//    {
//        using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
//        using (StreamReader reader = new StreamReader(fileStream))
//        {
//            string content = reader.ReadToEnd();
//            Console.WriteLine("File content as characters:");
//            Console.WriteLine(content);
//        }
//    }

//    static void Main(string[] args)
//    {
//        Console.Write("Enter the file path: ");
//        string filePath = Console.ReadLine();

//        ConvertByteStreamToCharStream(filePath);
//    }
//}

