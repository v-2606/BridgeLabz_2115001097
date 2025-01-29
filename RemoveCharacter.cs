using System;

class RemoveCharacter {
    static void Main(string[] args) {
        Console.Write("Enter the string: ");
        string str = Console.ReadLine();

        Console.Write("Enter the character to remove: ");
        char charToRemove = Console.ReadLine()[0];  // Read the first character as input

        string result = RemoveCharacterFromString(str, charToRemove);
        Console.WriteLine("Modified string: " + result);
    }

    public static string RemoveCharacterFromString(string str, char charToRemove) {
        string result = "";

        foreach (char c in str) {
            if (c != charToRemove) {
                result += c;
            }
        }

        return result;
    }
}
