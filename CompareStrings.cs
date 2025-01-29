using System;

class CompareStrings {
    static void Main() {
        Console.Write("Enter the first string: ");
        string str1 = Console.ReadLine();

        Console.Write("Enter the second string: ");
        string str2 = Console.ReadLine();

        int result = CompareStringsLexicographically(str1, str2);

        if (result < 0) {
            Console.WriteLine("\"" + str1 + "\" comes before \"" + str2 + "\" in lexicographical order");
        } else if (result > 0) {
            Console.WriteLine("\"" + str2 + "\" comes before \"" + str1 + "\" in lexicographical order");
        } else {
            Console.WriteLine("Both strings are equal.");
        }
    }

    public static int CompareStringsLexicographically(string str1, string str2) {
        int minLength = Math.Min(str1.Length, str2.Length);

        for (int i = 0; i < minLength; i++) {
            if (str1[i] < str2[i]) {
                return -1;  // str1 comes before str2
            } else if (str1[i] > str2[i]) {
                return 1;   // str2 comes before str1
            }
        }

        // If all characters are equal, compare the lengths
        if (str1.Length < str2.Length) {
            return -1;  // str1 is smaller because it's shorter
        } else if (str1.Length > str2.Length) {
            return 1;   // str1 is greater because it's longer
        }

        return 0;  // Both strings are equal
    }
}
