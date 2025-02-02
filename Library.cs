//using System;

//namespace Oops_Assignment
//{
//    class Book
//    {
//        private string title;
//        private string author;
//        private double price;
//        private bool isAvailable;

//        public Book()
//        {
//            title = "Unknown";
//            author = "Unknown";
//            price = 0.0;
//            isAvailable = true;
//        }

//        public Book(string title, string author, double price, bool isAvailable)
//        {
//            this.title = title;
//            this.author = author;
//            this.price = price;
//            this.isAvailable = isAvailable;
//        }

//        public void BorrowBook()
//        {
//            if (isAvailable)
//            {
//                isAvailable = false;
//                Console.WriteLine("You have borrowed: " + title);
//            }
//            else
//            {
//                Console.WriteLine("Sorry, " + title + " is not available.");
//            }
//        }

//        public void Display()
//        {
//            Console.WriteLine("Title: " + title + ", Author: " + author + ", Price: $" + price.ToString("F2") + ", Available: " + isAvailable);
//        }
//    }

//    class Program
//    {
//        static void Main()
//        {
//            Console.Write("Enter book title: ");
//            string title = Console.ReadLine();

//            Console.Write("Enter author name: ");
//            string author = Console.ReadLine();

//            Console.Write("Enter price of the book: ");
//            double price = Convert.ToDouble(Console.ReadLine());

//            Console.Write("Is the book available? (true/false): ");
//            bool isAvailable = Convert.ToBoolean(Console.ReadLine());

//            Book book1 = new Book(title, author, price, isAvailable);

//            book1.Display();
//            book1.BorrowBook();
//            book1.Display();
//            book1.BorrowBook();
//        }
//    }
//}

