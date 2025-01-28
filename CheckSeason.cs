using System;

class CheckSeason{
		static void Season(int month, int day){
		 if ((month == 3 && day >= 20) || 
            (month == 4) || 
            (month == 5) || 
            (month == 6 && day <= 20)) {
           Console.WriteLine("It's a Spring Season");
        } else {
           Console.WriteLine("Not a Spring Season");
        }
		}
  static void Main (string[] args){
  
  Console.WriteLine("Enter the Month");
  int Month=Convert.ToInt32(Console.ReadLine());
  
  Console.WriteLine("Enter the Day");
  int Day=Convert.ToInt32(Console.ReadLine());
  Season( Month ,Day);
  
  }

}