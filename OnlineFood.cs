  //using System;
  //  using System.Collections.Generic;

  //  abstract class FoodItem
  //  {
  //      protected string itemName;
  //      protected double price;
  //      protected int quantity;

  //      public FoodItem(string itemName, double price, int quantity)
  //      {
  //          this.itemName = itemName;
  //          this.price = price;
  //          this.quantity = quantity;
  //      }

  //      public void GetItemDetails()
  //      {
  //          Console.WriteLine($"Item: {itemName}, Price: {price}, Quantity: {quantity}");
  //      }

  //      public abstract double CalculateTotalPrice();
  //  }

    
  //  interface IDiscountable
  //  {
  //      void ApplyDiscount(double discountRate);
  //      void GetDiscountDetails();
  //  }

   
  //  class VegItem : FoodItem, IDiscountable
  //  {
  //      private double additionalCharge = 5.0; 

  //      public VegItem(string itemName, double price, int quantity) : base(itemName, price, quantity) { }

  //      public override double CalculateTotalPrice()
  //      {
  //          return (price * quantity) + additionalCharge;
  //      }

  //      public void ApplyDiscount(double discountRate)
  //      {
  //          price -= price * discountRate / 100;
  //          Console.WriteLine($"Discount, New price: {price}");
  //      }

  //      public void GetDiscountDetails()
  //      {
  //          Console.WriteLine("Veg items 10% discount.");
  //      }
  //  }

  
  //  class NonVegItem : FoodItem, IDiscountable
  //  {
  //      private double additionalCharge = 5.0; 

  //      public NonVegItem(string itemName, double price, int quantity) : base(itemName, price, quantity) { }

  //      public override double CalculateTotalPrice()
  //      {
  //          return (price * quantity) + additionalCharge;
  //      }

  //      public void ApplyDiscount(double discountRate)
  //      {
  //          price -= price * discountRate / 100;
  //          Console.WriteLine($"Discount applied! New price: {price}");
  //      }

  //      public void GetDiscountDetails()
  //      {
  //          Console.WriteLine("Non-Veg items get up to 5% discount.");
  //      }
  //  }

  //  class OnlineFood
  //  {
  //      static void Main()
  //      {
  //          List<FoodItem> orders = new List<FoodItem>();

  //          Console.WriteLine("Enter Food Type (1 for Veg, 2 for Non-Veg): ");
  //          int choice = int.Parse(Console.ReadLine());

  //          Console.Write("Enter Item Name: ");
  //          string itemName = Console.ReadLine();

  //          Console.Write("Enter Price: ");
  //          double price = double.Parse(Console.ReadLine());

  //          Console.Write("Enter Quantity: ");
  //          int quantity = int.Parse(Console.ReadLine());

  //          FoodItem foodItem;

  //          switch (choice)
  //          {
  //              case 1:
  //                  foodItem = new VegItem(itemName, price, quantity);
  //                  break;
  //              case 2:
  //                  foodItem = new NonVegItem(itemName, price, quantity);
  //                  break;
  //              default:
  //                  Console.WriteLine("Invalid choice.");
  //                  return;
  //          }

  //          orders.Add(foodItem);
  //          foodItem.GetItemDetails();
  //          Console.WriteLine($"Total Price: {foodItem.CalculateTotalPrice()}");

  //          if (foodItem is IDiscountable discountableItem)
  //          {
  //              discountableItem.GetDiscountDetails();
  //              Console.WriteLine("Enter discount percentage to apply: ");
  //              double discountRate = double.Parse(Console.ReadLine());
  //              discountableItem.ApplyDiscount(discountRate);
  //              Console.WriteLine($"Final Price: {foodItem.CalculateTotalPrice()}");
  //          }
  //      }
  //  }

