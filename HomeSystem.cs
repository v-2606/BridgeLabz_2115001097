﻿//using System;

//class Device
//{
//    public string DeviceId { get; set; }
//    public string Status { get; set; }

//    public Device(string deviceId, string status)
//    {
//        DeviceId = deviceId;
//        Status = status;
//    }

//    public virtual void DisplayStatus()
//    {
//        Console.WriteLine("Device ID: " + DeviceId);
//        Console.WriteLine("Status: " + Status);
//    }
//}

//class Thermostat : Device
//{
//    public int TemperatureSetting { get; set; }

//    public Thermostat(string deviceId, string status, int temperatureSetting) : base(deviceId, status)
//    {
//        TemperatureSetting = temperatureSetting;
//    }

//    public override void DisplayStatus()
//    {
//        base.DisplayStatus();
//        Console.WriteLine("Temperature Setting: " + TemperatureSetting + "°C");
//    }
//}

//class HomeSystem
//{
//    static void Main(string[] args)
//    {
//        Console.Write("Enter Device ID: ");
//        string deviceId = Console.ReadLine();
//        Console.Write("Enter Device Status (On/Off): ");
//        string status = Console.ReadLine();
//        Console.Write("Enter Temperature Setting (°C): ");
//        int temperatureSetting = int.Parse(Console.ReadLine());

//        Thermostat thermostat = new Thermostat(deviceId, status, temperatureSetting);
//        Console.WriteLine("\nDevice Status:\n");
//        thermostat.DisplayStatus();
//    }
//}
