//using System;
//using System.Diagnostics;
//using System.IO;

//class FileReadComparison
//{
//    static void Main(string[] args)
//    {
//        string filePath = "largefile.txt";

//        MeasureTime("StreamReader", () => ReadWithStreamReader(filePath));
//        MeasureTime("FileStream", () => ReadWithFileStream(filePath));
//    }

//    static void ReadWithStreamReader(string filePath)
//    {
//        using (StreamReader reader = new StreamReader(filePath))
//        {
//            while (reader.Read() != -1) { }
//        }
//    }

//    static void ReadWithFileStream(string filePath)
//    {
//        using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
//        {
//            byte[] buffer = new byte[4096];
//            while (fs.Read(buffer, 0, buffer.Length) > 0) { }
//        }
//    }

//    static void MeasureTime(string method, Action operation)
//    {
//        Stopwatch stopwatch = Stopwatch.StartNew();
//        operation();
//        stopwatch.Stop();
//        Console.WriteLine($"{method} Time: {stopwatch.ElapsedMilliseconds} ms");
//    }
//}
