//using System;

//class Book
//{
//    public string Title { get; set; }
//    public int PublicationYear { get; set; }

//    public Book(string title, int publicationYear)
//    {
//        Title = title;
//        PublicationYear = publicationYear;
//    }

//    public virtual void DisplayInfo()
//    {
//        Console.WriteLine("Book Title: " + Title);
//        Console.WriteLine("Publication Year: " + PublicationYear);
//    }
//}

//class Author : Book
//{
//    public string Name { get; set; }
//    public string Bio { get; set; }

//    public Author(string title, int publicationYear, string name, string bio) : base(title, publicationYear)
//    {
//        Name = name;
//        Bio = bio;
//    }

//    public override void DisplayInfo()
//    {
//        base.DisplayInfo();
//        Console.WriteLine("Author Name: " + Name);
//        Console.WriteLine("Author Bio: " + Bio);
//    }
//}

//class LibrarySystem
//{
//    static void Main(string[] args)
//    {
//        Console.Write("Enter Book Title: ");
//        string title = Console.ReadLine();
//        Console.Write("Enter Publication Year: ");
//        int publicationYear = int.Parse(Console.ReadLine());
//        Console.Write("Enter Author Name: ");
//        string authorName = Console.ReadLine();
//        Console.Write("Enter Author Bio: ");
//        string authorBio = Console.ReadLine();

//        Author bookWithAuthor = new Author(title, publicationYear, authorName, authorBio);
//        Console.WriteLine("\nBook Details:\n");
//        bookWithAuthor.DisplayInfo();
//    }
//}
