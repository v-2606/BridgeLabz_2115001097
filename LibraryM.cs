//using System;

//class Book
//{
//    public string ISBN;
//    protected string title;
//    private string author;

//    public Book(string ISBN, string title, string author)
//    {
//        this.ISBN = ISBN;
//        this.title = title;
//        this.author = author;
//    }

//    public string Author
//    {
//        get { return author; }
//        set { author = value; }
//    }

//    public void DisplayBookDetails()
//    {
//        Console.WriteLine("ISBN:" + ISBN);
//        Console.WriteLine("Title:" + title);
//        Console.WriteLine("Author: " + author);
//    }
//}

//class EBook : Book
//{
//    public EBook(string ISBN, string title, string author)
//        : base(ISBN, title, author)
//    {
//    }

//    public void DisplayEBookDetails()
//    {
//        Console.WriteLine("EBook ISBN:" + ISBN);
//        Console.WriteLine("EBook Title:" + title);
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.Write("Enter ISBN: ");
//        string isbn = Console.ReadLine();

//        Console.Write("Enter Title: ");
//        string title = Console.ReadLine();

//        Console.Write("Enter Author: ");
//        string author = Console.ReadLine();

//        Book book1 = new Book(isbn, title, author);
//        book1.DisplayBookDetails();

//        Console.Write("\nEnter ISBN for EBook: ");
//        string ebookIsbn = Console.ReadLine();

//        Console.Write("Enter Title for EBook: ");
//        string ebookTitle = Console.ReadLine();

//        Console.Write("Enter Author for EBook: ");
//        string ebookAuthor = Console.ReadLine();

//        EBook ebook1 = new EBook(ebookIsbn, ebookTitle, ebookAuthor);
//        ebook1.DisplayEBookDetails();

//        Console.WriteLine("\nUpdating Author Name:");
//        ebook1.Author = "Updated Author";
//        Console.WriteLine("Updated Author: " + ebook1.Author);

//        ebook1.DisplayEBookDetails();
//    }
//}


