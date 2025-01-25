using System;
class VoteCheck{
  static void Check(int[] num){
  
  for(int i=0;i<num.Length;i++){
  
  if(num[i]<0)
  Console.WriteLine("Invalid Number");
  else if(num[i]>=18){
  Console.WriteLine("Person can vote");
  }
  else Console.WriteLine("Person can not vote");
  
  }
  }
  static void Main(String[] args){
	int[] num=new int[10];
	
	Console.WriteLine("Enter Age of 10 Students");
	
	for(int i=0;i<num.Length;i++){
	num[i]=Convert.ToInt32(Console.ReadLine());
	}
	
	Check(num);
  }
  
  
  
}

