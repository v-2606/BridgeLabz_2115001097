//using System;

//class LinearSearch2
//{
//    public static string FindSentenceWithWord(string[] sentences, string word)
//    {
//        foreach (string sentence in sentences)
//        {
//            if (sentence.Contains(word))
//            {
//                return sentence;
//            }
//        }
//        return "Word not found .";
//    }

//    static void Main(string[] args)
//    {
//        Console.Write("Enter the number of sentences: ");
//        int n = int.Parse(Console.ReadLine());

//        string[] sentences = new string[n];
//        Console.WriteLine("Enter the sentences:");

//        for (int i = 0; i < n; i++)
//        {
//            sentences[i] = Console.ReadLine();
//        }

//        Console.Write("Enter  word to search : ");
//        string word = Console.ReadLine();

//        string result = FindSentenceWithWord(sentences, word);
//        Console.WriteLine("First sentence : " + result);
//    }
//}
