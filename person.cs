//using System;

//class Person
//{
//    private string name;
//    private int age;

//    public Person(string name, int age)
//    {
//        this.name = name;
//        this.age = age;
//    }

//    public Person(Person other)
//    {
//        this.name = other.name;
//        this.age = other.age;
//    }

//    public void Display()
//    {
//        Console.WriteLine("Name: " + name);
//        Console.WriteLine("Age: " + age);
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.Write("Enter Name: ");
//        string name = Console.ReadLine();

//        Console.Write("Enter Age: ");
//        int age = Convert.ToInt32(Console.ReadLine());

//        Person person1 = new Person(name, age);

        
//        Person person2 = new Person(person1);

//        Console.WriteLine("\nOriginal Person Details:");
//        person1.Display();

//        Console.WriteLine("\nCopied Person Details:");
//        person2.Display();
//    }
//}

