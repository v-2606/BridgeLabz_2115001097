using System;

class VoterAge{
		static void CheckAge(int Age){
		if(Age>=18)
		{
		Console.WriteLine("Person Can vote");
		}
		else
		Console.WriteLine("Can not Vote because age is below 18");
		
		}

  static void Main (string[] args){
  
  Console.WriteLine("Enter the Age");
  int Age=Convert.ToInt32(Console.ReadLine());
  CheckAge(Age);
  
  }

}