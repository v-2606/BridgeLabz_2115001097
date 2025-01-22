using System;

class Profit_Loss{
	public int ProfitLoss(int CostPrice , int SellingPrice){
	return (SellingPrice-CostPrice);
	}
	public double ProfitPercentage(int CostPrice , int SellingPrice){
	int profit= SellingPrice-CostPrice;
	 return ((double)profit/CostPrice)*100;
	}
}

class Profit{
	static void Main(String[] args){
	int SellingPrice=191;
	int CostPrice=129;
	
	Profit_Loss profit_loss = new Profit_Loss ();
	
	int Profit_Value=profit_loss.ProfitLoss( CostPrice, SellingPrice );
	double Profit_Percentage=profit_loss.ProfitPercentage( CostPrice, SellingPrice );;
	Console.WriteLine("The cost Price is INR "+CostPrice +"and selling price is INR "+ SellingPrice +"\n The Profit is INR " + Profit_Value +" and the Profit Percentage is "+ Profit_Percentage );
	Console.ReadLine();
	}

}