//using System;

//class Item
//{
//    public int ItemID;
//    public string ItemName;
//    public int Quantity;
//    public double Price;
//    public Item Next;

//    public Item(int id, string name, int qty, double price)
//    {
//        ItemID = id;
//        ItemName = name;
//        Quantity = qty;
//        Price = price;
//        Next = null;
//    }
//}

//class Inventory
//{
//    private Item head;

  
//    public void AddAtBeginning(int id, string name, int qty, double price)
//    {
//        Item newItem = new Item(id, name, qty, price);
//        newItem.Next = head;
//        head = newItem;
//    }


//    public void AddAtEnd(int id, string name, int qty, double price)
//    {
//        Item newItem = new Item(id, name, qty, price);
//        if (head == null)
//        {
//            head = newItem;
//            return;
//        }
//        Item temp = head;
//        while (temp.Next != null)
//        {
//            temp = temp.Next;
//        }
//        temp.Next = newItem;
//    }

   
//    public void RemoveItem(int id)
//    {
//        if (head == null)
//        {
//            Console.WriteLine("Inventory is empty.");
//            return;
//        }
//        if (head.ItemID == id)
//        {
//            head = head.Next;
//            Console.WriteLine("Item removed.");
//            return;
//        }
//        Item temp = head;
//        while (temp.Next != null && temp.Next.ItemID != id)
//        {
//            temp = temp.Next;
//        }
//        if (temp.Next == null)
//        {
//            Console.WriteLine("Item not found.");
//            return;
//        }
//        temp.Next = temp.Next.Next;
//        Console.WriteLine("Item removed.");
//    }

  
//    public void UpdateQuantity(int id, int newQty)
//    {
//        Item temp = head;
//        while (temp != null)
//        {
//            if (temp.ItemID == id)
//            {
//                temp.Quantity = newQty;
//                Console.WriteLine("Quantity updated.");
//                return;
//            }
//            temp = temp.Next;
//        }
//        Console.WriteLine("Item not found.");
//    }

//    public void SearchItem(string query)
//    {
//        Item temp = head;
//        bool found = false;
//        while (temp != null)
//        {
//            if (temp.ItemID.ToString() == query || temp.ItemName.Equals(query, StringComparison.OrdinalIgnoreCase))
//            {
//                Console.WriteLine("ID: " + temp.ItemID + ", Name: " + temp.ItemName + ", Qty: " + temp.Quantity + ", Price: " + temp.Price);
//                found = true;
//            }
//            temp = temp.Next;
//        }
//        if (!found) Console.WriteLine("Item not found.");
//    }


//    public void CalculateTotalValue()
//    {
//        double total = 0;
//        Item temp = head;
//        while (temp != null)
//        {
//            total += temp.Quantity * temp.Price;
//            temp = temp.Next;
//        }
//        Console.WriteLine("Total Inventory Value: " + total);
//    }

   
//    public void DisplayItems()
//    {
//        if (head == null)
//        {
//            Console.WriteLine("Inventory is empty.");
//            return;
//        }
//        Item temp = head;
//        while (temp != null)
//        {
//            Console.WriteLine("ID: " + temp.ItemID + ", Name: " + temp.ItemName + ", Qty: " + temp.Quantity + ", Price: " + temp.Price);
//            temp = temp.Next;
//        }
//    }
//}

//class Inventor
//{
//    static void Main(string[] args)
//    {
//        Inventory inventory = new Inventory();

//        while (true)
//        {
//            Console.WriteLine("\n1. Add Item at Beginning\n2. Add Item at End\n3. Remove Item\n4. Update Quantity\n5. Search Item\n6. Total Inventory Value\n7. Display Items\n8. Exit");
//            Console.Write("Enter choice: ");
//            int choice = int.Parse(Console.ReadLine());

//            switch (choice)
//            {
//                case 1:
//                case 2:
//                    Console.Write("Enter ID: ");
//                    int id = int.Parse(Console.ReadLine());
//                    Console.Write("Enter Name: ");
//                    string name = Console.ReadLine();
//                    Console.Write("Enter Quantity: ");
//                    int qty = int.Parse(Console.ReadLine());
//                    Console.Write("Enter Price: ");
//                    double price = double.Parse(Console.ReadLine());

//                    if (choice == 1) inventory.AddAtBeginning(id, name, qty, price);
//                    else inventory.AddAtEnd(id, name, qty, price);
//                    break;

//                case 3:
//                    Console.Write("Enter ID to remove: ");
//                    int removeId = int.Parse(Console.ReadLine());
//                    inventory.RemoveItem(removeId);
//                    break;

//                case 4:
//                    Console.Write("Enter ID to update quantity: ");
//                    int updateId = int.Parse(Console.ReadLine());
//                    Console.Write("Enter new Quantity: ");
//                    int newQty = int.Parse(Console.ReadLine());
//                    inventory.UpdateQuantity(updateId, newQty);
//                    break;

//                case 5:
//                    Console.Write("Enter ID or Name to search: ");
//                    string searchQuery = Console.ReadLine();
//                    inventory.SearchItem(searchQuery);
//                    break;

//                case 6:
//                    inventory.CalculateTotalValue();
//                    break;

//                case 7:
//                    inventory.DisplayItems();
//                    break;

//                case 8:
//                    return;

//                default:
//                    Console.WriteLine("Invalid choice.");
//                    break;
//            }
//        }
//    }
//}
