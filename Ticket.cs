using System;

 class Ticket
    {
        public int TicketID { get; set; }
        public string CustomerName { get; set; }
        public string MovieName { get; set; }
        public string SeatNumber { get; set; }
        public DateTime BookingTime { get; set; }
        public Ticket Next { get; set; }

        public Ticket(int ticketID, string customerName, string movieName, string seatNumber, DateTime bookingTime)
        {
            TicketID = ticketID;
            CustomerName = customerName;
            MovieName = movieName;
            SeatNumber = seatNumber;
            BookingTime = bookingTime;
            Next = null;
        }
    }

    class TicketReservationSystem
    {
        private Ticket head;
        private int count;

        public TicketReservationSystem()
        {
            head = null;
            count = 0;
        }

        public void AddTicket(int ticketID, string customerName, string movieName, string seatNumber, DateTime bookingTime)
        {
            Ticket newTicket = new Ticket(ticketID, customerName, movieName, seatNumber, bookingTime);
            if (head == null)
            {
                head = newTicket;
                head.Next = head;
            }
            else
            {
                Ticket temp = head;
                while (temp.Next != head)
                {
                    temp = temp.Next;
                }
                temp.Next = newTicket;
                newTicket.Next = head;
            }
            count++;
            Console.WriteLine("Ticket Booked Successfully!");
        }

        public void RemoveTicket(int ticketID)
        {
            if (head == null)
            {
                Console.WriteLine("No tickets available to remove.");
                return;
            }
            Ticket temp = head, prev = null;
            do
            {
                if (temp.TicketID == ticketID)
                {
                    if (prev != null)
                    {
                        prev.Next = temp.Next;
                    }
                    else
                    {
                        Ticket last = head;
                        while (last.Next != head)
                        {
                            last = last.Next;
                        }
                        head = head.Next;
                        last.Next = head;
                    }
                    count--;
                    Console.WriteLine($"Ticket {ticketID} removed successfully.");
                    return;
                }
                prev = temp;
                temp = temp.Next;
            } while (temp != head);
            Console.WriteLine("Ticket not found.");
        }

        public void DisplayTickets()
        {
            if (head == null)
            {
                Console.WriteLine("No tickets booked.");
                return;
            }
            Ticket temp = head;
            Console.WriteLine("\nBooked Tickets:");
            do
            {
                Console.WriteLine($"Ticket ID: {temp.TicketID}, Customer: {temp.CustomerName}, Movie: {temp.MovieName}, Seat: {temp.SeatNumber}, Time: {temp.BookingTime}");
                temp = temp.Next;
            } while (temp != head);
        }

        public Ticket SearchTicket(string query)
        {
            if (head == null) return null;
            Ticket temp = head;
            do
            {
                if (temp.CustomerName.Equals(query, StringComparison.OrdinalIgnoreCase) || temp.MovieName.Equals(query, StringComparison.OrdinalIgnoreCase))
                    return temp;
                temp = temp.Next;
            } while (temp != head);
            return null;
        }

        public int GetTotalTickets()
        {
            return count;
        }
    }

    class Ticket
    {
        static void Main(string[] args)
        {
            TicketReservationSystem system = new TicketReservationSystem();
            int ticketIDCounter = 100;

            while (true)
            {
                Console.WriteLine("\n Ticket Reservation System ");
                Console.WriteLine("1. Book Ticket");
                Console.WriteLine("2. Remove Ticket");
                Console.WriteLine("3. Show All Tickets");
                Console.WriteLine("4. Search Ticket");
                Console.WriteLine("5. Show Total Tickets");
                Console.WriteLine("6. Exit");
                Console.Write("Choose an option: ");

                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Customer Name: ");
                        string customerName = Console.ReadLine();
                        Console.Write("Enter Movie Name: ");
                        string movieName = Console.ReadLine();
                        Console.Write("Enter Seat Number: ");
                        string seatNumber = Console.ReadLine();
                        DateTime bookingTime = DateTime.Now;

                        system.AddTicket(ticketIDCounter++, customerName, movieName, seatNumber, bookingTime);
                        break;

                    case 2:
                        Console.Write("Enter Ticket ID to remove: ");
                        if (int.TryParse(Console.ReadLine(), out int removeTicketID))
                        {
                            system.RemoveTicket(removeTicketID);
                        }
                        else
                        {
                            Console.WriteLine("Invalid Ticket ID.");
                        }
                        break;

                    case 3:
                        system.DisplayTickets();
                        break;

                    case 4:
                        Console.Write("Enter Customer Name or Movie to search: ");
                        string searchQuery = Console.ReadLine();
                        Ticket foundTicket = system.SearchTicket(searchQuery);
                        if (foundTicket != null)
                        {
                            Console.WriteLine($"Ticket Found: ID: {foundTicket.TicketID}, Customer: {foundTicket.CustomerName}, Movie: {foundTicket.MovieName}, Seat: {foundTicket.SeatNumber}, Time: {foundTicket.BookingTime}");
                        }
                        else
                        {
                            Console.WriteLine("No matching ticket .");
                        }
                        break;

                    case 5:
                        Console.WriteLine("Total Tickets: " + system.GetTotalTickets());
                        break;

                    case 6:
                        Console.WriteLine("Exit program");
                        return;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }
    }

