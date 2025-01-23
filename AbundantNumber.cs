using System;
class AbundantNumber{
	static void AbundantNum(int num){
	int OriginalNumber=num;
	 int sum=0;
	 for(int i=1;i<=num/2;i++){
	 if((num%i)==0){
	 sum=sum+i;
	 }
	 }
	if(sum>OriginalNumber)
	 Console.WriteLine("Number is Abundant Number");
	 else
	 {
	 	 Console.WriteLine("Number is Not a Abundant Number");
	 }
	 }
	 static void Main(String[] args){
		Console.WriteLine("Enter the number");
		int number=Convert.ToInt32(Console.ReadLine());
		AbundantNum(number);
	 }
}