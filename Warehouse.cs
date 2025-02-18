//using System;

//public abstract class WarehouseItem
//{
//    public string Name { get; set; }
//    public double Price { get; set; }

//    public WarehouseItem(string name, double price)
//    {
//        Name = name;
//        Price = price;
//    }


//    public abstract void DisplayDetails();
//}


//public class Electronics : WarehouseItem
//{
//    public string Brand { get; set; }

//    public Electronics(string name, double price, string brand) : base(name, price)
//    {
//        Brand = brand;
//    }

//    public override void DisplayDetails()
//    {
//        Console.WriteLine($"Electronics: {Name}, Price: {Price}, Brand: {Brand}");
//    }
//}

//public class Groceries : WarehouseItem
//{
//    public string ExpiryDate { get; set; }

//    public Groceries(string name, double price, string expiryDate) : base(name, price)
//    {
//        ExpiryDate = expiryDate;
//    }

//    public override void DisplayDetails()
//    {
//        Console.WriteLine($"Groceries: {Name}, Price: {Price}, Expiry: {ExpiryDate}");
//    }
//}

//public class Furniture : WarehouseItem
//{
//    public string Material { get; set; }

//    public Furniture(string name, double price, string material) : base(name, price)
//    {
//        Material = material;
//    }

//    public override void DisplayDetails()
//    {
//        Console.WriteLine($"Furniture: {Name}, Price: {Price}, Material: {Material}");
//    }
//}


//public class Storage<T> where T : WarehouseItem
//{
//    private List<T> items = new List<T>();


//    public void AddItem(T item)
//    {
//        items.Add(item);
//    }


//    public void DisplayAllItems()
//    {
//        foreach (var item in items)
//        {
//            item.DisplayDetails();
//        }
//    }
//}


//class WareHouse
//{
//    static void Main(string[] args)
//    {
//        Storage<Electronics> electronicsStorage = new Storage<Electronics>();
//        Storage<Groceries> groceriesStorage = new Storage<Groceries>();
//        Storage<Furniture> furnitureStorage = new Storage<Furniture>();


//        electronicsStorage.AddItem(new Electronics("Laptop", 12.50, "Dell"));
//        electronicsStorage.AddItem(new Electronics("phone", 6.99, "OPPO "));

//        groceriesStorage.AddItem(new Groceries("Apple", 2.50, "2025-03-01"));
//        groceriesStorage.AddItem(new Groceries("Milk", 1.99, "2025-02-28"));

//        furnitureStorage.AddItem(new Furniture("Chair", 5.00, "Wood"));
//        furnitureStorage.AddItem(new Furniture("Table", 1.00, "Metal"));


//        Console.WriteLine("Electronics Items:");
//        electronicsStorage.DisplayAllItems();

//        Console.WriteLine("\nGroceries Items:");
//        groceriesStorage.DisplayAllItems();

//        Console.WriteLine("\nFurniture Items:");
//        furnitureStorage.DisplayAllItems();
//    }
//}

