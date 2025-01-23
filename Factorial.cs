using System;
class Factorial{
 static void factorial(int num){
 int product=1;
 int i=1;
 while(i<=num){
 product=product*i;
 i++;
 }
 Console.WriteLine("Factorial is "+product);
 }
 
 static void Main (string[] args){
  Console.WriteLine("Enter the number");
  int num=Convert.ToInt32(Console.ReadLine());
factorial(num);
  }
}


