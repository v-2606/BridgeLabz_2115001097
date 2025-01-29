using System;

class PalindromeCheck{
    static bool Palindrome(string word){
	string copy=word;
	string wordd =" ";
	  for (int i = word.Length-1; i >= 0; i--) {
       wordd+=word[i];
	
	}
	return copy==word ;
	  
	
	}
  public static void Main(string[] args){
	  
	  Console.WriteLine("enter string ");
      string word = Console.ReadLine();
	  
	  Console.WriteLine("Palindrome: "+Palindrome(word));
	  
  
  }

}