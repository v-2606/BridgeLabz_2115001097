using System;

class ToggleCase {
    static void Main(string[] args) {
        Console.Write("Enter the string: ");
        string str = Console.ReadLine();

        string toggledString = ToggleCharacterCase(str);
        Console.WriteLine("Toggled case string: " + toggledString);
    }

    public static string ToggleCharacterCase(string str) {
        char[] charArray = str.ToCharArray();  // Convert string to char array

        for (int i = 0; i < charArray.Length; i++) {
            if (char.IsUpper(charArray[i])) {
                charArray[i] = char.ToLower(charArray[i]);  
            } else if (char.IsLower(charArray[i])) {
                charArray[i] = char.ToUpper(charArray[i]);  
            }
        }

        return new string(charArray);  
    }
}
