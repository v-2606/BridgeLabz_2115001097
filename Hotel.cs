//using System;

//class HotelBooking
//{
//    private string guestName;
//    private string roomType;
//    private int nights;

//    public HotelBooking()
//    {
//        guestName = "Unknown";
//        roomType = "Standard";
//        nights = 1;
//    }

//    public HotelBooking(string guestName, string roomType, int nights)
//    {
//        this.guestName = guestName;
//        this.roomType = roomType;
//        this.nights = nights;
//    }

//    public HotelBooking(HotelBooking other)
//    {
//        this.guestName = other.guestName;
//        this.roomType = other.roomType;
//        this.nights = other.nights;
//    }

//    public void Display()
//    {
//        Console.WriteLine("Guest Name: " + guestName);
//        Console.WriteLine("Room Type: " + roomType);
//        Console.WriteLine("Nights: " + nights);
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        HotelBooking defaultBooking = new HotelBooking();

//        Console.Write("Enter Guest Name: ");
//        string guestName = Console.ReadLine() ?? "Unknown";

//        Console.Write("Enter Room Type: ");
//        string roomType = Console.ReadLine() ?? "Standard";

//        Console.Write("Enter Number of Nights: ");
//        int nights = Convert.ToInt32(Console.ReadLine());

//        HotelBooking customBooking = new HotelBooking(guestName, roomType, nights);

//        HotelBooking copiedBooking = new HotelBooking(customBooking);

//        Console.WriteLine("\nDefault Booking Details:");
//        defaultBooking.Display();

//        Console.WriteLine("\nCustom Booking Details:");
//        customBooking.Display();

//        Console.WriteLine("\nCopied Booking Details:");
//        copiedBooking.Display();
//    }
//}


