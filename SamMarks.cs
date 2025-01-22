using System;

class AvgMarks{
	public int Marks(int maths , int phy , int chemistry){
	return (maths+phy+chemistry)/3;
	}

}

class SamMarks{
	static void Main(string[] args){
	 
	 int maths=94;
	 int phy=95;
	 int chemistry=96;
	 
	 AvgMarks avgMarks=new AvgMarks();
	  int avg_marks=avgMarks.Marks(maths,phy,chemistry);
	  
	  Console.WriteLine("Sam's Avg marks are :" +avg_marks);
	  Console.ReadLine();
	
	
	}
	

}