//using System;
//class CarRental
//{
//    private string customerName;
//    private string carModel;
//    private int rentalDays;
//    private double dailyRate;

//    public CarRental()
//    {
//        customerName = "Unknown";
//        carModel = "Unknown";
//        rentalDays = 0;
//        dailyRate = 0.0;
//    }

//    public CarRental(string customerName, string carModel, int rentalDays, double dailyRate)
//    {
//        this.customerName = customerName;
//        this.carModel = carModel;
//        this.rentalDays = rentalDays;
//        this.dailyRate = dailyRate;
//    }

//    public void CalculateTotalCost()
//    {
//        double totalCost = rentalDays * dailyRate;
//        Console.WriteLine("Customer Name: " + customerName);
//        Console.WriteLine("Car Model: " + carModel);
//        Console.WriteLine("Rental Days: " + rentalDays);
//        Console.WriteLine("Daily Rate: $" + dailyRate);
//        Console.WriteLine("Total Cost: $" + totalCost);
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.Write("Enter customer name: ");
//        string customerName = Console.ReadLine();

//        Console.Write("Enter car model: ");
//        string carModel = Console.ReadLine();

//        Console.Write("Enter rental days: ");
//        int rentalDays = Convert.ToInt32(Console.ReadLine());

//        Console.Write("Enter daily rental rate: ");
//        double dailyRate = Convert.ToDouble(Console.ReadLine());

//        CarRental rental = new CarRental(customerName, carModel, rentalDays, dailyRate);

//        rental.CalculateTotalCost();
//    }
//}

