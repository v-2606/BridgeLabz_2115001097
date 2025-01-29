using System;

class ReplaceWord {
    static void Main(string[] args) {
        Console.Write("Enter the sentence: ");
        string sentence = Console.ReadLine();

        Console.Write("Enter the word to replace: ");
        string wordToReplace = Console.ReadLine();

        Console.Write("Enter the new word: ");
        string newWord = Console.ReadLine();

        string modifiedSentence = ReplaceWordInSentence(sentence, wordToReplace, newWord);
        Console.WriteLine("Modified sentence: " + modifiedSentence);
    }

    public static string ReplaceWordInSentence(string sentence, string wordToReplace, string newWord) {
        string[] words = sentence.Split(' ');
        for (int i = 0; i < words.Length; i++) {
            if (words[i] == wordToReplace) {
                words[i] = newWord;
            }
        }

        return string.Join(" ", words);
    }
}
