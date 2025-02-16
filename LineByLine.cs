
//using System;
//using System.IO;

//class LineByLine
//    {
//        public static void ReadFileLineByLine(string filePath)
//        {
//            using (StreamReader reader = new StreamReader(filePath))
//            {
//                string line;
//                while ((line = reader.ReadLine()) != null)
//                {
//                    Console.WriteLine(line);
//                }
//            }
//        }

//        static void Main(string[] args)
//        {
//            Console.Write("Enter the file path: ");
//            string filePath = Console.ReadLine();

//            Console.WriteLine("\nReading file content:");
//            ReadFileLineByLine(filePath);
//        }
//    }
