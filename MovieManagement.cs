//using System;

//class Movie
//{
//    public string Title;
//    public string Director;
//    public int Year;
//    public double Rating;
//    public Movie Prev;
//    public Movie Next;

//    public Movie(string title, string director, int year, double rating)
//    {
//        Title = title;
//        Director = director;
//        Year = year;
//        Rating = rating;
//        Prev = null;
//        Next = null;
//    }
//}

//class MovieList
//{
//    private Movie head;
//    private Movie tail;

//    public void InsertAtBeginning(string title, string director, int year, double rating)
//    {
//        Movie newMovie = new Movie(title, director, year, rating);
//        if (head == null)
//        {
//            head = tail = newMovie;
//        }
//        else
//        {
//            newMovie.Next = head;
//            head.Prev = newMovie;
//            head = newMovie;
//        }
//    }

//    public void InsertAtEnd(string title, string director, int year, double rating)
//    {
//        Movie newMovie = new Movie(title, director, year, rating);
//        if (tail == null)
//        {
//            head = tail = newMovie;
//        }
//        else
//        {
//            tail.Next = newMovie;
//            newMovie.Prev = tail;
//            tail = newMovie;
//        }
//    }

    
//    public void InsertAtPosition(int pos, string title, string director, int year, double rating)
//    {
//        if (pos <= 0)
//        {
//            Console.WriteLine("Invalid Position");
//            return;
//        }

//        if (pos == 1)
//        {
//            InsertAtBeginning(title, director, year, rating);
//            return;
//        }

//        Movie newMovie = new Movie(title, director, year, rating);
//        Movie temp = head;
//        int count = 1;

//        while (temp != null && count < pos - 1)
//        {
//            temp = temp.Next;
//            count++;
//        }

//        if (temp == null)
//        {
//            Console.WriteLine("Invalid Position");
//            return;
//        }

//        newMovie.Next = temp.Next;
//        newMovie.Prev = temp;
//        if (temp.Next != null)
//            temp.Next.Prev = newMovie;
//        temp.Next = newMovie;

//        if (newMovie.Next == null)
//            tail = newMovie;
//    }

//    public void DeleteMovie(string title)
//    {
//        if (head == null)
//        {
//            Console.WriteLine("List is empty.");
//            return;
//        }

//        Movie temp = head;

//        while (temp != null)
//        {
//            if (temp.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
//            {
//                if (temp.Prev != null)
//                    temp.Prev.Next = temp.Next;
//                else
//                    head = temp.Next;

//                if (temp.Next != null)
//                    temp.Next.Prev = temp.Prev;
//                else
//                    tail = temp.Prev;

//                Console.WriteLine("Movie '" + title + "' deleted.");
//                return;
//            }
//            temp = temp.Next;
//        }
//        Console.WriteLine("Movie not found.");
//    }

   
//    public void SearchByDirector(string director)
//    {
//        Movie temp = head;
//        bool found = false;

//        while (temp != null)
//        {
//            if (temp.Director.Equals(director, StringComparison.OrdinalIgnoreCase))
//            {
//                Console.WriteLine("Title: " + temp.Title + ", Year: " + temp.Year + ", Rating: " + temp.Rating);
//                found = true;
//            }
//            temp = temp.Next;
//        }

//        if (!found)
//            Console.WriteLine("No movies found for director: " + director);
//    }


//    public void SearchByRating(double rating)
//    {
//        Movie temp = head;
//        bool found = false;

//        while (temp != null)
//        {
//            if (temp.Rating == rating)
//            {
//                Console.WriteLine("Title: " + temp.Title + ", Director: " + temp.Director + ", Year: " + temp.Year);
//                found = true;
//            }
//            temp = temp.Next;
//        }

//        if (!found)
//            Console.WriteLine("No movies found with rating: " + rating);
//    }


//    public void UpdateRating(string title, double newRating)
//    {
//        Movie temp = head;

//        while (temp != null)
//        {
//            if (temp.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
//            {
//                temp.Rating = newRating;
//                Console.WriteLine("Rating updated for '" + title + "' to " + newRating);
//                return;
//            }
//            temp = temp.Next;
//        }
//        Console.WriteLine("Movie not found.");
//    }


//    public void DisplayForward()
//    {
//        if (head == null)
//        {
//            Console.WriteLine("No movies to display.");
//            return;
//        }

//        Movie temp = head;
//        while (temp != null)
//        {
//            Console.WriteLine("Title: " + temp.Title + ", Director: " + temp.Director + ", Year: " + temp.Year + ", Rating: " + temp.Rating);
//            temp = temp.Next;
//        }
//    }

//    public void DisplayReverse()
//    {
//        if (tail == null)
//        {
//            Console.WriteLine("No movies to display.");
//            return;
//        }

//        Movie temp = tail;
//        while (temp != null)
//        {
//            Console.WriteLine("Title: " + temp.Title + ", Director: " + temp.Director + ", Year: " + temp.Year + ", Rating: " + temp.Rating);
//            temp = temp.Prev;
//        }
//    }
//}


//class MovieManagement
//{
//    static void Main(string[] args)
//    {
//        MovieList movies = new MovieList();

//        while (true)
//        {
//            Console.WriteLine("\n1. Add Movie\n2. Delete Movie\n3. Search by Director\n4. Search by Rating\n5. Update Rating\n6. Display Movies (Forward)\n7. Display Movies (Reverse)\n8. Exit");
//            Console.Write("Enter your choice: ");

//            if (!int.TryParse(Console.ReadLine(), out int choice))
//            {
//                Console.WriteLine("Invalid input. Please enter a number.");
//                continue;
//            }

//            switch (choice)
//            {
//                case 1:
//                    Console.Write("Enter Title: ");
//                    string title = Console.ReadLine();
//                    Console.Write("Enter Director: ");
//                    string director = Console.ReadLine();
//                    Console.Write("Enter Year of Release: ");
//                    int year = int.Parse(Console.ReadLine());
//                    Console.Write("Enter Rating: ");
//                    double rating = double.Parse(Console.ReadLine());
//                    movies.InsertAtEnd(title, director, year, rating);
//                    break;

//                case 2:
//                    Console.Write("Enter Movie Title to delete: ");
//                    string delTitle = Console.ReadLine();
//                    movies.DeleteMovie(delTitle);
//                    break;

//                case 3:
//                    Console.Write("Enter Director to search: ");
//                    string searchDirector = Console.ReadLine();
//                    movies.SearchByDirector(searchDirector);
//                    break;

//                case 4:
//                    Console.Write("Enter Rating to search: ");
//                    double searchRating = double.Parse(Console.ReadLine());
//                    movies.SearchByRating(searchRating);
//                    break;

//                case 5:
//                    Console.Write("Enter Movie Title to update rating: ");
//                    string updateTitle = Console.ReadLine();
//                    Console.Write("Enter new Rating: ");
//                    double newRating = double.Parse(Console.ReadLine());
//                    movies.UpdateRating(updateTitle, newRating);
//                    break;

//                case 6:
//                    movies.DisplayForward();
//                    break;

//                case 7:
//                    movies.DisplayReverse();
//                    break;

//                case 8:
//                    return;

//                default:
//                    Console.WriteLine("Invalid choice.");
//                    break;
//            }
//        }
//    }
//}
