using System;
using System.Reflection;

class Person
{
    private int age = 25;
}

class Program2
{
    static void Main(string[] args)
    {
        Person p = new Person();
        Type type = typeof(Person);
        FieldInfo field = type.GetField("age", BindingFlags.NonPublic | BindingFlags.Instance);

        field.SetValue(p, 30);
        Console.WriteLine("Updated Age: " + field.GetValue(p));
    }
}
