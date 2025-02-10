//using System;
//using System.Collections.Generic;

//abstract class Product
//{
//    private int productId;
//    private string name;
//    private double price;

//    public Product(int id, string name, double price)
//    {
//        this.productId = id;
//        this.name = name ?? "Unknown";
//        this.price = price;
//    }

//    public double GetPrice() => price;

//    public virtual void DisplayDetails()
//    {
//        Console.WriteLine($"ID: {productId}, Name: {name}, Price: {price}");
//    }

//    public abstract double CalculateDiscount();
//}


//interface ITaxable
//{
//    double CalculateTax();
//    string GetTaxDetails();
//}


//class Electronics : Product, ITaxable
//{
//    public Electronics(int id, string name, double price) : base(id, name, price) { }

//    public override double CalculateDiscount() => GetPrice() * 0.7; // 7% discount
//    public double CalculateTax() => GetPrice() * 0.18; // 18% GST
//    public string GetTaxDetails() => "18% GST on Electronics";
//}


//class Clothing : Product, ITaxable
//{
//    public Clothing(int id, string name, double price) : base(id, name, price) { }

//    public override double CalculateDiscount() => GetPrice() * 0.10; // 10% discount
//    public double CalculateTax() => GetPrice() * 0.12; // 12% GST
//    public string GetTaxDetails() => "12% GST on Clothing";
//}

//class Groceries : Product
//{
//    public Groceries(int id, string name, double price) : base(id, name, price) { }

//    public override double CalculateDiscount() => GetPrice() * 0.05; // 5% discount
//}


//class Ecommerce
//{
//    static void Main(string[] args)
//    {
//        List<Product> products = new List<Product>();


//        Console.WriteLine("Enter number of products:");
//        int numProducts = int.Parse(Console.ReadLine());

//        for (int i = 0; i < numProducts; i++)
//        {
//            Product product = null;

//            while (product == null)  
//            {
//                Console.WriteLine("Enter Product Type (Electronics/Clothing/Groceries):");
//                string type = Console.ReadLine()?.Trim().ToLower();

//                if (type != "electronics" && type != "clothing" && type != "groceries")
//                {
//                    Console.WriteLine(" Invalid product type!  enter a valid type (Electronics, Clothing, or Groceries).");
//                    continue;
//                }

//                Console.WriteLine("Enter Product ID:");
//                int id = int.Parse(Console.ReadLine());

//                Console.WriteLine("Enter Product Name:");
//                string name = Console.ReadLine();

//                Console.WriteLine("Enter Price:");
//                double price = double.Parse(Console.ReadLine());

//                if (type == "electronics")
//                    product = new Electronics(id, name, price);
//                else if (type == "clothing")
//                    product = new Clothing(id, name, price);
//                else if (type == "groceries")
//                    product = new Groceries(id, name, price);
//                else
//                    Console.WriteLine(" Invalid product type! enter  (Electronics, Clothing, or Groceries).");
//            }

//            products.Add(product);
//        }


//        Console.WriteLine("\nFinal Product Prices:");
//        foreach (var product in products)
//        {
            
//            double discount = product.CalculateDiscount();
//            double tax = 0;
//            string taxDetails = "No Tax";

//            if (product is ITaxable taxable)
//            {
//                tax = taxable.CalculateTax();
//                taxDetails = taxable.GetTaxDetails();
//            }

//            double finalPrice = product.GetPrice() + tax - discount;

          
//            product.DisplayDetails();
//            Console.WriteLine($"Discount: -{discount}");
//            Console.WriteLine($"Tax: +{tax} ({taxDetails})");
//            Console.WriteLine($"Final Price: {finalPrice}\n");
//        }

//    }
//}

