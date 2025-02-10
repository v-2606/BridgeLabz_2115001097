//using System;
//using System.Collections.Generic;

//abstract class LibraryItem
//{
//    public string ItemId { get; private set; }
//    public string Title { get; private set; }
//    public string Author { get; private set; }

//    public LibraryItem(string itemId, string title, string author)
//    {
//        ItemId = itemId;
//        Title = title;
//        Author = author;
//    }

//    public abstract int GetLoanDuration();

//    public void GetItemDetails()
//    {
//        Console.WriteLine("ID: " + ItemId + ", Title: " + Title + ", Author: " + Author);
//    }
//}

//interface IReservable
//{
//    void ReserveItem();
//    bool CheckAvailability();
//}

//class Book : LibraryItem, IReservable
//{
//    private bool isReserved;

//    public Book(string itemId, string title, string author) : base(itemId, title, author) { }

//    public override int GetLoanDuration()
//    {
//        return 14;
//    }

//    public void ReserveItem()
//    {
//        isReserved = true;
//        Console.WriteLine(Title + " has been reserved.");
//    }

//    public bool CheckAvailability()
//    {
//        return !isReserved;
//    }
//}

//class Magazine : LibraryItem
//{
//    public Magazine(string itemId, string title, string author) : base(itemId, title, author) { }

//    public override int GetLoanDuration()
//    {
//        return 7;
//    }
//}

//class DVD : LibraryItem, IReservable
//{
//    private bool isReserved;

//    public DVD(string itemId, string title, string author) : base(itemId, title, author) { }

//    public override int GetLoanDuration()
//    {
//        return 5;
//    }

//    public void ReserveItem()
//    {
//        isReserved = true;
//        Console.WriteLine(Title + " has been reserved.");
//    }

//    public bool CheckAvailability()
//    {
//        return !isReserved;
//    }
//}

//class LibraryManagement
//{
//    static void Main()
//    {
//        List<LibraryItem> items = new List<LibraryItem>();

//        Console.Write("Enter number of items: ");
//        int numItems = int.Parse(Console.ReadLine());

//        for (int i = 0; i < numItems; i++)
//        {
//            LibraryItem item = null;
//            while (item == null)
//            {
//                Console.Write("\nEnter Item Type (Book/Magazine/DVD): ");
//                string type = Console.ReadLine().Trim().ToLower();

//                if (type != "book" && type != "magazine" && type != "dvd")
//                {
//                    Console.WriteLine("Invalid type! Please enter 'Book', 'Magazine', or 'DVD'.");
//                    continue;
//                }

//                Console.Write("Enter Item ID: ");
//                string itemId = Console.ReadLine();

//                Console.Write("Enter Title: ");
//                string title = Console.ReadLine();

//                Console.Write("Enter Author: ");
//                string author = Console.ReadLine();

//                if (type == "book") item = new Book(itemId, title, author);
//                else if (type == "magazine") item = new Magazine(itemId, title, author);
//                else if (type == "dvd") item = new DVD(itemId, title, author);
//            }

//            items.Add(item);
//            Console.WriteLine(item.GetType().Name + " (" + item.ItemId + ") added successfully\n");
//        }

//        Console.WriteLine("\nLibrary Items:");
//        foreach (var item in items)
//        {
//            item.GetItemDetails();
//            Console.WriteLine("Loan Duration: " + item.GetLoanDuration() + " days");

//            if (item is IReservable reservableItem)
//            {
//                Console.Write("Reserve item? (yes/no): ");
//                string choice = Console.ReadLine().Trim().ToLower();
//                if (choice == "yes") reservableItem.ReserveItem();
//                Console.WriteLine("Availability: " + (reservableItem.CheckAvailability() ? "Available" : "Reserved"));
//            }

//            Console.WriteLine();
//        }
//    }
//}
