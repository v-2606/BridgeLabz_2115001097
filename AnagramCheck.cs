using System;
using System.Linq; 

class AnagramCheck {
    static void Main(string[] args) {
        Console.Write("Enter the first string: ");
        string str1 = Console.ReadLine();

        Console.Write("Enter the second string: ");
        string str2 = Console.ReadLine();

        if (AreAnagrams(str1, str2)) {
            Console.WriteLine("The strings are anagrams.");
        } else {
            Console.WriteLine("The strings are not anagrams.");
        }
    }

    public static bool AreAnagrams(string str1, string str2) {
        if (str1.Length != str2.Length) {
            return false;
        }

        char[] array1 = str1.ToCharArray();
        char[] array2 = str2.ToCharArray();

        Array.Sort(array1);
        Array.Sort(array2);

        return array1.SequenceEqual(array2);
    }
}
