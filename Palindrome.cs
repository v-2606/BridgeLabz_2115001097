using System;

class Palindrome
{
     
static string Input()
    {
        Console.Write("Enter a string: ");
        return Console.ReadLine();
    }

    static bool IsPalindrome(string str)
    {
        str = str.ToLower().Replace(" ", "").Replace(",", "").Replace(".", "");
        int left = 0, right = str.Length - 1;
       
        while (left < right)
        {
            if (str[left] != str[right])
                return false;
            left++;
            right--;
        }
        return true;
    }

    static void DisplayResult(string str, bool isPalindrome)
    {
        if (isPalindrome)
            Console.WriteLine(str +" is  palindrome.");
        else
            Console.WriteLine(str +" is not  palindrome.");
    }
  static void Main(string [] args)
 {
      string input = Input();
        bool result = IsPalindrome(input);
        DisplayResult(input, result);
        Console.ReadLine();
       
 }
 }