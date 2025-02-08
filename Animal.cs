//using System;

//class Animal
//{
//    public string Name { get; set; }
//    public int Age { get; set; }

//    public Animal(string name, int age)
//    {
//        Name = name;
//        Age = age;
//    }

//    public virtual void MakeSound()
//    {
//        Console.WriteLine("Animal makes a sound");
//    }
//}

//class Dog : Animal
//{
//    public Dog(string name, int age) : base(name, age) { }

//    public override void MakeSound()
//    {
//        Console.WriteLine("Bark");
//    }
//}

//class Cat : Animal
//{
//    public Cat(string name, int age) : base(name, age) { }

//    public override void MakeSound()
//    {
//        Console.WriteLine("Meow");
//    }
//}

//class Bird : Animal
//{
//    public Bird(string name, int age) : base(name, age) { }

//    public override void MakeSound()
//    {
//        Console.WriteLine("Chirp");
//    }
//}

//class Animal
//{
//    static void Main(string[] args)
//    {
//        Console.Write("Enter Dog name: ");
//        string dogName = Console.ReadLine();
//        Console.Write("Enter Dog age: ");
//        int dogAge = int.Parse(Console.ReadLine());

//        Console.Write("Enter Cat name: ");
//        string catName = Console.ReadLine();
//        Console.Write("Enter Cat age: ");
//        int catAge = int.Parse(Console.ReadLine());

//        Console.Write("Enter Bird name: ");
//        string birdName = Console.ReadLine();
//        Console.Write("Enter Bird age: ");
//        int birdAge = int.Parse(Console.ReadLine());

//        Animal dog = new Dog(dogName, dogAge);
//        Animal cat = new Cat(catName, catAge);
//        Animal bird = new Bird(birdName, birdAge);

//        Console.WriteLine("\nAnimal Sounds:");
//        dog.MakeSound();
//        cat.MakeSound();
//        bird.MakeSound();
//    }
//}
