using System;

class ReverseString{
    static string Reverse_String(string word){
	string wordd =" ";
	  for (int i = word.Length-1; i >= 0; i--) {
       wordd+=word[i];
	
	}
	  
	return wordd;
	}
  public static void Main(string[] args){
	  
	  Console.WriteLine("enter string ");
      string word = Console.ReadLine();
	  
	  Console.WriteLine("reversed string : "+Reverse_String(word));
	  
  
  }

}