using System;

class RemoveDuplicates{
    static string RemoveDuplicate(string word){
	
	string Resultant_String ="";
	  for (int i= 0; i<word.Length ; i++) {
       if(!Resultant_String.Contains(word[i].ToString())){
		   Resultant_String+=word[i];
	   }
	}
	return Resultant_String;
	}
  public static void Main(string[] args){
	  
	  Console.WriteLine("enter string ");
      string word = Console.ReadLine();
	  
	  Console.WriteLine("modified string after Removed Duplicate "+RemoveDuplicate(word));
	  
  
  }

}