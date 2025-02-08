//using System;

//class Order
//{
//    public int OrderId { get; set; }
//    public DateTime OrderDate { get; set; }

//    public Order(int orderId, DateTime orderDate)
//    {
//        OrderId = orderId;
//        OrderDate = orderDate;
//    }

//    public virtual string GetOrderStatus()
//    {
//        return "Order placed";
//    }
//}

//class ShippedOrder : Order
//{
//    public string TrackingNumber { get; set; }

//    public ShippedOrder(int orderId, DateTime orderDate, string trackingNumber)
//        : base(orderId, orderDate)
//    {
//        TrackingNumber = trackingNumber;
//    }

//    public override string GetOrderStatus()
//    {
//        return "Order shipped";
//    }
//}

//class DeliveredOrder : ShippedOrder
//{
//    public DateTime DeliveryDate { get; set; }

//    public DeliveredOrder(int orderId, DateTime orderDate, string trackingNumber, DateTime deliveryDate)
//        : base(orderId, orderDate, trackingNumber)
//    {
//        DeliveryDate = deliveryDate;
//    }

//    public override string GetOrderStatus()
//    {
//        return "Order delivered";
//    }
//}

//class OrderManagement
//{
//    static DateTime GetValidDate(string message)
//    {
//        DateTime date;
//        while (true)
//        {
//            Console.Write(message);
//            string input = Console.ReadLine();
//            if (DateTime.TryParse(input, out date))
//            {
//                return date;
//            }
//            Console.WriteLine("Invalid date format! Please enter again (YYYY-MM-DD).");
//        }
//    }

//    static void Main()
//    {
//        Console.Write("Enter Order ID: ");
//        int orderId;
//        while (!int.TryParse(Console.ReadLine(), out orderId))
//        {
//            Console.WriteLine("Invalid input! Please enter a valid numeric Order ID.");
//        }

//        DateTime orderDate = GetValidDate("Enter Order Date (YYYY-MM-DD): ");

//        Console.Write("Enter Tracking Number (if shipped, else press Enter): ");
//        string trackingNumber = Console.ReadLine();
//        if (string.IsNullOrEmpty(trackingNumber))
//        {
//            trackingNumber = "N/A";
//        }

//        DateTime deliveryDate = DateTime.MinValue; // Default value to avoid unassigned variable error
//        bool isDelivered = false;

//        Console.Write("Enter Delivery Date (if delivered, else press Enter): ");
//        string deliveryInput = Console.ReadLine();
//        if (!string.IsNullOrEmpty(deliveryInput) && DateTime.TryParse(deliveryInput, out deliveryDate))
//        {
//            isDelivered = true;
//        }

//        Order order;

//        if (isDelivered)
//        {
//            order = new DeliveredOrder(orderId, orderDate, trackingNumber, deliveryDate);
//        }
//        else if (!string.IsNullOrEmpty(trackingNumber) && trackingNumber != "N/A")
//        {
//            order = new ShippedOrder(orderId, orderDate, trackingNumber);
//        }
//        else
//        {
//            order = new Order(orderId, orderDate);
//        }

//        Console.WriteLine("\nOrder Status:");
//        Console.WriteLine("Order ID: " + order.OrderId + ", Status: " + order.GetOrderStatus());
//    }
//}
