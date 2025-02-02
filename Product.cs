//using System;

//class Product
//{
//    private string productName;
//    private double price;
//    private static int totalProducts = 0;

//    public Product(string productName, double price)
//    {
//        this.productName = productName;
//        this.price = price;
//        totalProducts++;
//    }

//    public void DisplayProductDetails()
//    {
//        Console.WriteLine("Product Name: " + productName);
//        Console.WriteLine("Price: $" + price);
//    }

//    public static void DisplayTotalProducts()
//    {
//        Console.WriteLine("Total Products Created: " + totalProducts);
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Enter the number of products: ");
//        int numProducts = Convert.ToInt32(Console.ReadLine());

//        Product[] products = new Product[numProducts];

//        for (int i = 0; i < numProducts; i++)
//        {
//            Console.WriteLine("\nEnter details for Product " + (i + 1) + ":");

//            Console.Write("Enter product name: ");
//            string productName = Console.ReadLine();

//            Console.Write("Enter product price: ");
//            double price = Convert.ToDouble(Console.ReadLine());

//            products[i] = new Product(productName, price);
//        }

//        Console.WriteLine("\n Details");
//        foreach (var product in products)
//        {
//            product.DisplayProductDetails();
//            Console.WriteLine();
//        }

//        Product.DisplayTotalProducts();
//    }
//}

