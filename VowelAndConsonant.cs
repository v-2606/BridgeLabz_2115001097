using System;

class VowelAndConsonant{
    static int checkVowel(string wordd){
	int count=0;
	  for (int i = 0; i < wordd.Length; i++) {
       char word  = wordd[i];
	if(word=='a'||word=='i'||word=='e'||word=='o'||word=='u'||word=='A'||word=='E' ||word=='I'||word=='O'||word=='U'){
	 count+=1;
	}
	  }
	return count;
	}
  public static void Main(string[] args){
      string word = Console.ReadLine();
	  
	  int Consonant=(word.Length - checkVowel(word));
	  
	  Console.WriteLine("Total vowel : "+checkVowel(word));
	  Console.WriteLine("Total consonant : "+Consonant);
  
  }

}