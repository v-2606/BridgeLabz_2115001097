using System;

class Book{
	
     private string Title;
	 private string Author;
	 private double Price;
	 
	 
	 public  Book(string Title, string Author ,double Price){
	  this.Title=Title;
	  this.Author=Author;
	  this.Price=Price;
	  
	 }
	 
	 public void DetailDisplay(){
	 
	 Console.WriteLine("Title of Book :" +Title);
	 Console.WriteLine("Author of Book :" +Author);
	 Console.WriteLine("Price of Book :"+Price);
	  
	 }
	 
	 }
	 
	 class BookDetails {
		 
		 public static void Main(string[] args){
		Console.WriteLine("Enter Title:");
		string Title= Console.ReadLine();
		
		Console.WriteLine("Enter Author :");
		string Author= Console.ReadLine();
		
		Console.WriteLine("Enter Price :");
		double Price=Convert.ToDouble(Console.ReadLine());
		
		Book book= new Book(Title,Author,Price);
		book. DetailDisplay();
		
	 
	 }


}