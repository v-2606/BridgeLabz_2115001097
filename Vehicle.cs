//using System;
//using System.Collections.Generic;


//abstract class Vehicle
//{
//    public string VehicleNumber { get; private set; }
//    public string Type { get; private set; }
//    public double RentalRate { get; private set; }

//    public Vehicle(string vehicleNumber, string type, double rentalRate)
//    {
//        VehicleNumber = vehicleNumber;
//        Type = type;
//        RentalRate = rentalRate;
//    }

//    public abstract double CalculateRentalCost(int days);

//    public void DisplayDetails()
//    {
//        Console.WriteLine($"Vehicle: {Type}, Number: {VehicleNumber}, Rate per Day: {RentalRate}");
//    }
//}


//interface IInsurable
//{
//    double CalculateInsurance();
//    string GetInsuranceDetails();
//}

//class Car : Vehicle, IInsurable
//{
//    public Car(string vehicleNumber, double rentalRate) : base(vehicleNumber, "Car", rentalRate) { }

//    public override double CalculateRentalCost(int days) => RentalRate * days;

//    public double CalculateInsurance() => 500; 
//    public string GetInsuranceDetails() => "Car Insurance: ₹500 per year";
//}


//class Bike : Vehicle
//{
//    public Bike(string vehicleNumber, double rentalRate) : base(vehicleNumber, "Bike", rentalRate) { }

//    public override double CalculateRentalCost(int days) => RentalRate * days * 0.9; // 10% discount
//}

//class Truck : Vehicle, IInsurable
//{
//    public Truck(string vehicleNumber, double rentalRate) : base(vehicleNumber, "Truck", rentalRate) { }

//    public override double CalculateRentalCost(int days) => RentalRate * days * 1.2; 

//    public double CalculateInsurance() => 100;
//    public string GetInsuranceDetails() => "Truck Insurance: ₹100 per year";
//}


//class VehicleRentalSystem
//{
//    static void Main(string[] args)
//    {
//        List<Vehicle> vehicles = new List<Vehicle>();

//        Console.Write("Enter number of vehicles: ");
//        int numVehicles = int.Parse(Console.ReadLine());

//        for (int i = 0; i < numVehicles; i++)
//        {
//            Vehicle vehicle = null;
//            while (vehicle == null)
//            {
//                Console.Write("\nEnter Vehicle Type (Car/Bike/Truck): ");
//                string type = Console.ReadLine()?.Trim().ToLower();

//                if (type != "car" && type != "bike" && type != "truck")
//                {
//                    Console.WriteLine(" Invalid type. enter 'Car', 'Bike', or 'Truck'.");
//                    continue;
//                }

//                Console.Write("Enter Vehicle Number: ");
//                string vehicleNumber = Console.ReadLine();

//                Console.Write("Enter Rental Rate per Day: ");
//                double rentalRate = double.Parse(Console.ReadLine());

//                if (type == "car") vehicle = new Car(vehicleNumber, rentalRate);
//                else if (type == "bike") vehicle = new Bike(vehicleNumber, rentalRate);
//                else if (type == "truck") vehicle = new Truck(vehicleNumber, rentalRate);
//            }

//            vehicles.Add(vehicle);
//            Console.WriteLine($" {vehicle.Type} ({vehicle.VehicleNumber}) added \n");
//        }

//        Console.WriteLine("\n Rental & Insurance Details:");
//        foreach (var vehicle in vehicles)
//        {
//            vehicle.DisplayDetails();
//            Console.Write("Enter Rental Days: ");
//            int days = int.Parse(Console.ReadLine());

//            Console.WriteLine("Rental Cost for {days} days: {vehicle.CalculateRentalCost(days)}");

//            if (vehicle is IInsurable insurable)
//            {
//                Console.WriteLine(insurable.GetInsuranceDetails());
//                Console.WriteLine("Insurance Cost: {insurable.CalculateInsurance()}");
//            }
//            Console.WriteLine();
//        }
//    }
//}
