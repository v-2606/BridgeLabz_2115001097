//using System;
//using System.Collections.Generic;


//public abstract class ProductCategory
//{
//    public string CategoryName { get; set; }

//    public ProductCategory(string categoryName)
//    {
//        CategoryName = categoryName;
//    }
//}


//public class BookCategory : ProductCategory
//{
//    public BookCategory() : base("Books") { }
//}

//public class ClothingCategory : ProductCategory
//{
//    public ClothingCategory() : base("Clothing") { }
//}


//public interface IProduct
//{
//    string Name { get; set; }
//    double Price { get; set; }
//    void DisplayProduct();
//}


//public class Product<T> : IProduct where T : ProductCategory
//{
//    public string Name { get; set; }
//    public double Price { get; set; }
//    public T Category { get; set; }

//    public Product(string name, double price, T category)
//    {
//        Name = name;
//        Price = price;
//        Category = category;
//    }

//    public void DisplayProduct()
//    {
//        Console.WriteLine("Product: " + Name + ", Price: " + Price.ToString("C") + ", Category: " + Category.CategoryName);
//    }
//}

//public static class Marketplace
//{
 
//    public static void ApplyDiscount<T>(T product, double percentage) where T : IProduct
//    {
//        if (percentage < 0 || percentage > 100)
//        {
//            Console.WriteLine("Invalid discount percentage.");
//            return;
//        }

//        product.Price -= product.Price * (percentage / 100);
//        Console.WriteLine("Discount applied: New Price of " + product.Name + " is " + product.Price.ToString("C"));
//    }
//}


//class MarketPlace
//{
//    static void Main(string[] args)
//    {
//        var book = new Product<BookCategory>("C# Programming", 49.99, new BookCategory());
//        var shirt = new Product<ClothingCategory>("T-Shirt", 19.99, new ClothingCategory());

     
//        Console.WriteLine("Initial Products:");
//        book.DisplayProduct();
//        shirt.DisplayProduct();

//        Marketplace.ApplyDiscount(book, 10);
//        Marketplace.ApplyDiscount(shirt, 20);

       
//        Console.WriteLine("\nUpdated Products:");
//        book.DisplayProduct();
//        shirt.DisplayProduct();
//    }
//}
