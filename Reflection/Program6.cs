//using System;
//using System.Reflection;

//[AttributeUsage(AttributeTargets.Class)]
//class AuthorAttribute : Attribute
//{
//    public string Name { get; }
//    public AuthorAttribute(string name) => Name = name;
//}

//[Author("John Doe")]
//class SampleClass { }

//class Program6
//{
//    static void Main(string[] args)
//    {
//        Type type = typeof(SampleClass);
//        var attribute = (AuthorAttribute)Attribute.GetCustomAttribute(type, typeof(AuthorAttribute));
//        Console.WriteLine($"Author: {attribute?.Name}");
//    }
//}
