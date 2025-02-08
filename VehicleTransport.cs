//using System;

//class Vehicle
//{
//    public int MaxSpeed { get; set; }
//    public string FuelType { get; set; }

//    public Vehicle(int maxSpeed, string fuelType)
//    {
//        MaxSpeed = maxSpeed;
//        FuelType = fuelType;
//    }

//    public virtual void DisplayInfo()
//    {
//        Console.WriteLine("Max Speed: " + MaxSpeed + " km/h");
//        Console.WriteLine("Fuel Type: " + FuelType);
//    }
//}

//class Car : Vehicle
//{
//    public int SeatCapacity { get; set; }

//    public Car(int maxSpeed, string fuelType, int seatCapacity) : base(maxSpeed, fuelType)
//    {
//        SeatCapacity = seatCapacity;
//    }

//    public override void DisplayInfo()
//    {
//        base.DisplayInfo();
//        Console.WriteLine("Seat Capacity: " + SeatCapacity);
//    }
//}

//class Truck : Vehicle
//{
//    public int LoadCapacity { get; set; }

//    public Truck(int maxSpeed, string fuelType, int loadCapacity) : base(maxSpeed, fuelType)
//    {
//        LoadCapacity = loadCapacity;
//    }

//    public override void DisplayInfo()
//    {
//        base.DisplayInfo();
//        Console.WriteLine("Load Capacity: " + LoadCapacity + " kg");
//    }
//}

//class Motorcycle : Vehicle
//{
//    public bool HasSidecar { get; set; }

//    public Motorcycle(int maxSpeed, string fuelType, bool hasSidecar) : base(maxSpeed, fuelType)
//    {
//        HasSidecar = hasSidecar;
//    }

//    public override void DisplayInfo()
//    {
//        base.DisplayInfo();
//        Console.WriteLine("Has Sidecar: " + HasSidecar);
//    }
//}

//class VehicleTransport
//{
//    static void Main(string[] args)
//    {
//        Console.Write("Enter Car's Max Speed: ");
//        int carSpeed = int.Parse(Console.ReadLine());
//        Console.Write("Enter Car's Fuel Type: ");
//        string carFuel = Console.ReadLine();
//        Console.Write("Enter Car's Seat Capacity: ");
//        int seatCapacity = int.Parse(Console.ReadLine());

//        Console.Write("Enter Truck's Max Speed: ");
//        int truckSpeed = int.Parse(Console.ReadLine());
//        Console.Write("Enter Truck's Fuel Type: ");
//        string truckFuel = Console.ReadLine();
//        Console.Write("Enter Truck's Load Capacity (kg): ");
//        int loadCapacity = int.Parse(Console.ReadLine());

//        Console.Write("Enter Motorcycle's Max Speed: ");
//        int bikeSpeed = int.Parse(Console.ReadLine());
//        Console.Write("Enter Motorcycle's Fuel Type: ");
//        string bikeFuel = Console.ReadLine();
//        Console.Write("Does Motorcycle have a sidecar? (true/false): ");
//        bool hasSidecar = bool.Parse(Console.ReadLine());

//        Vehicle[] vehicles = new Vehicle[3];
//        vehicles[0] = new Car(carSpeed, carFuel, seatCapacity);
//        vehicles[1] = new Truck(truckSpeed, truckFuel, loadCapacity);
//        vehicles[2] = new Motorcycle(bikeSpeed, bikeFuel, hasSidecar);

//        Console.WriteLine("\nVehicle Details:\n");
//        foreach (Vehicle vehicle in vehicles)
//        {
//            vehicle.DisplayInfo();
//            Console.WriteLine();
//        }
//    }
//}
