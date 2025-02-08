//using System;

//interface IWorker
//{
//    void PerformDuties();
//}

//class Person
//{
//    public string Name { get; set; }
//    public int Id { get; set; }

//    public Person(string name, int id)
//    {
//        Name = name;
//        Id = id;
//    }

//    public string GetPersonDetails()
//    {
//        return $"Name: {Name}, ID: {Id}";
//    }
//}

//class Chef : Person, IWorker
//{
//    public string Specialty { get; set; }

//    public Chef(string name, int id, string specialty) : base(name, id)
//    {
//        Specialty = specialty;
//    }

//    public void PerformDuties()
//    {
//        Console.WriteLine($"The Chef {Name} is preparing food, specializing in {Specialty}.");
//    }

//    public string GetDetails()
//    {
//        return $"{GetPersonDetails()}, Specialty: {Specialty}";
//    }
//}

//class Waiter : Person, IWorker
//{
//    public string Section { get; set; }

//    public Waiter(string name, int id, string section) : base(name, id)
//    {
//        Section = section;
//    }

//    public void PerformDuties()
//    {
//        Console.WriteLine($"The Waiter {Name} is serving food to customers in the {Section} section.");
//    }

//    public string GetDetails()
//    {
//        return $"{GetPersonDetails()}, Section: {Section}";
//    }
//}

//class RestaurantManagementSystem
//{
//    static void Main(string[] args)
//    {
//        Console.Write("Enter Chef's Name: ");
//        string chefName = Console.ReadLine();
//        Console.Write("Enter Chef's ID: ");
//        int chefId = int.Parse(Console.ReadLine());
//        Console.Write("Enter Chef's Specialty: ");
//        string chefSpecialty = Console.ReadLine();
//        Chef chef = new Chef(chefName, chefId, chefSpecialty);

//        Console.Write("\nEnter Waiter's Name: ");
//        string waiterName = Console.ReadLine();
//        Console.Write("Enter Waiter's ID: ");
//        int waiterId = int.Parse(Console.ReadLine());
//        Console.Write("Enter Waiter's Section: ");
//        string waiterSection = Console.ReadLine();
//        Waiter waiter = new Waiter(waiterName, waiterId, waiterSection);

//        Console.WriteLine("\nRestaurant Staff Details:\n");

//        Console.WriteLine(chef.GetDetails());
//        chef.PerformDuties();

//        Console.WriteLine(waiter.GetDetails());
//        waiter.PerformDuties();
//    }
//}
