using System;

class SubstringOccurrences {
    static void Main() {
        Console.Write("Enter the string: ");
        string str = Console.ReadLine();

        Console.Write("Enter the substring to count: ");
        string substring = Console.ReadLine();

        int count = CountSubstringOccurrences(str, substring);
        Console.WriteLine("The substring \"" + substring + "\" occurs " + count + " time(s) in the string.");
    }

    public static int CountSubstringOccurrences(string str, string substring) {
        int count = 0;
        int index = 0;

        while ((index = str.IndexOf(substring, index)) != -1) {
            count++;
            index += substring.Length;
        }

        return count;
    }
}
