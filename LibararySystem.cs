//using System;

//class Book
//{
//    public string Name { get; set; }
//    public string Writer { get; set; }
//    public string Category { get; set; }
//    public int BookId { get; set; }
//    public bool Available { get; set; }
//    public Book Next { get; set; }
//    public Book Prev { get; set; }

//    public Book(string name, string writer, string category, int bookId, bool available)
//    {
//        Name = name;
//        Writer = writer;
//        Category = category;
//        BookId = bookId;
//        Available = available;
//        Next = Prev = null;
//    }
//}

//class Library
//{
//    private Book start, end;
//    private int totalBooks;

//    public void AddBookStart(string name, string writer, string category, int bookId, bool available)
//    {
//        Book newBook = new Book(name, writer, category, bookId, available);
//        if (start == null)
//        {
//            start = end = newBook;
//        }
//        else
//        {
//            newBook.Next = start;
//            start.Prev = newBook;
//            start = newBook;
//        }
//        totalBooks++;
//    }

//    public void AddBookEnd(string name, string writer, string category, int bookId, bool available)
//    {
//        Book newBook = new Book(name, writer, category, bookId, available);
//        if (end == null)
//        {
//            start = end = newBook;
//        }
//        else
//        {
//            end.Next = newBook;
//            newBook.Prev = end;
//            end = newBook;
//        }
//        totalBooks++;
//    }

//    public void RemoveBook(int bookId)
//    {
//        if (start == null) return;
//        if (start.BookId == bookId)
//        {
//            start = start.Next;
//            if (start != null) start.Prev = null;
//            totalBooks--;
//            return;
//        }
//        Book temp = start;
//        while (temp != null && temp.BookId != bookId)
//        {
//            temp = temp.Next;
//        }
//        if (temp == null) return;
//        if (temp.Next != null) temp.Next.Prev = temp.Prev;
//        if (temp.Prev != null) temp.Prev.Next = temp.Next;
//        if (temp == end) end = temp.Prev;
//        totalBooks--;
//    }

//    public void DisplayBooks()
//    {
//        Book temp = start;
//        while (temp != null)
//        {
//            Console.WriteLine($"Book: {temp.Name}, Writer: {temp.Writer}, Category: {temp.Category}, ID: {temp.BookId}, Available: {temp.Available}");
//            temp = temp.Next;
//        }
//    }
//}

//class LibrarySystem
//{
//    static void Main(string[] args)
//    {
//        Library library = new Library();
//        Console.WriteLine("Enter number of books to add:");
//        int numBooks = int.Parse(Console.ReadLine());

//        for (int i = 0; i < numBooks; i++)
//        {
//            Console.WriteLine("Enter Book Name:");
//            string name = Console.ReadLine();
//            Console.WriteLine("Enter Writer Name:");
//            string writer = Console.ReadLine();
//            Console.WriteLine("Enter Category:");
//            string category = Console.ReadLine();
//            Console.WriteLine("Enter Book ID:");
//            int bookId = int.Parse(Console.ReadLine());
//            Console.WriteLine("Is the book available? (true/false):");
//            bool available = bool.Parse(Console.ReadLine());

//            library.AddBookEnd(name, writer, category, bookId, available);
//        }

//        Console.WriteLine("Library Collection:");
//        library.DisplayBooks();
//    }
//}
