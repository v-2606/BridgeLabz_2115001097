

//using System;
//using System.IO;

//    class WordOccurence
//    {

//        public static int CountWordOccurrences(string filePath, string word)
//        {
//            int count = 0;
//            using (StreamReader reader = new StreamReader(filePath))
//            {
//                string line;
//                while ((line = reader.ReadLine()) != null)
//                {
//                    string[] words = line.Split(new char[] { ' ', '\t', '.', ',', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
//                    foreach (string w in words)
//                    {
//                        if (w.Equals(word, StringComparison.OrdinalIgnoreCase))
//                        {
//                            count++;
//                        }
//                    }
//                }
//            }
//            return count;
//        }

//        static void Main(string[] args)
//        {
//            Console.Write("Enter the file path: ");
//            string filePath = Console.ReadLine();

//            Console.Write("Enter the word to count: ");
//            string word = Console.ReadLine();

//            int occurrences = CountWordOccurrences(filePath, word);
//            Console.WriteLine($"The word '{word}' appears {occurrences} times in the file.");
//        }
//    }




