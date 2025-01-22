using System;
class totalQuantity{
  static void Quantity(double unitPrice ,double quantity ){
    	double TotalPurchase = unitPrice*quantity   ;
		Console.WriteLine("unit price "+unitPrice +"\n quantity" +quantity +"\n total purchase" +TotalPurchase);
  }
  static void Main(String[] args)
    {
        Console.Write("Enter unit price: ");
        double unitPrice = Convert.ToDouble(Console.ReadLine());
		 Console.Write("Enter quntity: ");
        double quantity= Convert.ToDouble(Console.ReadLine());
	Quantity(unitPrice, quantity);
}
}