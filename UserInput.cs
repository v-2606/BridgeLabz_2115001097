﻿//using System;
//using System.IO;

//class UserInputToFile
//{
//    public static void Main(string[] args)
//    {
//        try
//        {
//            Console.Write("Enter your name: ");
//            string name;
//            using (StreamReader reader = new StreamReader(Console.OpenStandardInput()))
//            {
//                name = reader.ReadLine();
//            }

//            Console.Write("Enter your age: ");
//            string age;
//            using (StreamReader reader = new StreamReader(Console.OpenStandardInput()))
//            {
//                age = reader.ReadLine();
//            }

//            Console.Write("Enter your favorite programming language: ");
//            string language;
//            using (StreamReader reader = new StreamReader(Console.OpenStandardInput()))
//            {
//                language = reader.ReadLine();
//            }

//            using (StreamWriter writer = new StreamWriter("user_data.txt"))
//            {
//                writer.WriteLine("Name: " + name);
//                writer.WriteLine("Age: " + age);
//                writer.WriteLine("Favorite Programming Language: " + language);
//            }

//            Console.WriteLine("Data successfully written to user_data.txt");
//        }
//        catch (IOException ex)
//        {
//            Console.WriteLine("Error: " + ex.Message);
//        }
//    }
//}
