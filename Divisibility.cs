using System;

class Divisibility{
  static void Main (string[] args){
  
  Console.WriteLine("Enter the number");
  int num=Convert.ToInt32(Console.ReadLine());
  
  if((num%5)==0)
  {
	  Console.WriteLine(" is the number "+num+" divisible by 5 \n yes");
  }
  else
	  Console.WriteLine(" is the number "+num+"divisible by 5 No");
  } 

}