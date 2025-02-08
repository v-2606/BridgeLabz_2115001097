//using System;

//interface IRefuelable
//{
//    void Refuel();
//}

//class Vehicle
//{
//    public int MaxSpeed { get; set; }
//    public string Model { get; set; }

//    public Vehicle(string model, int maxSpeed)
//    {
//        Model = model;
//        MaxSpeed = maxSpeed;
//    }

//    public string GetVehicleDetails()
//    {
//        return $"Model: {Model}, Max Speed: {MaxSpeed} km/h";
//    }
//}

//class ElectricVehicle : Vehicle
//{
//    public int BatteryCapacity { get; set; }

//    public ElectricVehicle(string model, int maxSpeed, int batteryCapacity)
//        : base(model, maxSpeed)
//    {
//        BatteryCapacity = batteryCapacity;
//    }

//    public void Charge()
//    {
//        Console.WriteLine($"The electric vehicle {Model} is charging. Battery capacity: {BatteryCapacity} kWh.");
//    }

//    public string GetDetails()
//    {
//        return $"{GetVehicleDetails()}, Battery Capacity: {BatteryCapacity} kWh";
//    }
//}

//class PetrolVehicle : Vehicle, IRefuelable
//{
//    public int FuelTankCapacity { get; set; }

//    public PetrolVehicle(string model, int maxSpeed, int fuelTankCapacity)
//        : base(model, maxSpeed)
//    {
//        FuelTankCapacity = fuelTankCapacity;
//    }

//    public void Refuel()
//    {
//        Console.WriteLine($"The petrol vehicle {Model} is refueling. Fuel tank capacity: {FuelTankCapacity} liters.");
//    }

//    public string GetDetails()
//    {
//        return $"{GetVehicleDetails()}, Fuel Tank Capacity: {FuelTankCapacity} liters";
//    }
//}

//class VehicleManagementSystem
//{
//    static void Main(string[] args)
//    {
//        Console.Write("Enter Electric Vehicle Model: ");
//        string evModel = Console.ReadLine();
//        Console.Write("Enter Max Speed (km/h): ");
//        int evSpeed = int.Parse(Console.ReadLine());
//        Console.Write("Enter Battery Capacity (kWh): ");
//        int evBattery = int.Parse(Console.ReadLine());

//        ElectricVehicle electricVehicle = new ElectricVehicle(evModel, evSpeed, evBattery);

//        Console.Write("\nEnter Petrol Vehicle Model: ");
//        string pvModel = Console.ReadLine();
//        Console.Write("Enter Max Speed (km/h): ");
//        int pvSpeed = int.Parse(Console.ReadLine());
//        Console.Write("Enter Fuel Tank Capacity (liters): ");
//        int pvFuel = int.Parse(Console.ReadLine());

//        PetrolVehicle petrolVehicle = new PetrolVehicle(pvModel, pvSpeed, pvFuel);

//        Console.WriteLine("\nVehicle Details:\n");

//        Console.WriteLine(electricVehicle.GetDetails());
//        electricVehicle.Charge();

//        Console.WriteLine(petrolVehicle.GetDetails());
//        petrolVehicle.Refuel();
//    }
//}
