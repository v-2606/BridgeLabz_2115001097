using System;

class LongestWordInSentence {
    static void Main(string[] args) {
        Console.Write("Enter a sentence: ");
        string sentence = Console.ReadLine();

        string longestWord = FindLongestWord(sentence);
        Console.WriteLine("The longest word is: " + longestWord);
    }

    public static string FindLongestWord(string sentence) {
        string[] words = sentence.Split(' ');
        string longestWord = "";

        foreach (string word in words) {
            if (word.Length > longestWord.Length) {
                longestWord = word;
            }
        }

        return longestWord;
    }
}
