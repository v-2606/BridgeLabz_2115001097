//using System;
//using System.IO;

//class UserInput
//{
    
//    public static void ReadInputAndWriteToFile(string filePath)
//    {
//        using (StreamWriter writer = new StreamWriter(filePath))
//        {
//            Console.WriteLine("Enter text, write to the file ( 'exit' fer stop):");
//            string input;

//            while ((input = Console.ReadLine()) != "exit")
//            {
//                writer.WriteLine(input);
//            }
//        }

//        Console.WriteLine("Data written to file successfully.");
//    }

//    static void Main(string[] args)
//    {
//        Console.Write("Enter the file path: ");
//        string filePath = Console.ReadLine();

        
//        ReadInputAndWriteToFile(filePath);
//    }
//}
