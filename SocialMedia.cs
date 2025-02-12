//using System;
//using System.Collections.Generic;

//namespace SocialMediaNetwork
//{
//    class User
//    {
//        public int UserID { get; set; }
//        public string Name { get; set; }
//        public int Age { get; set; }
//        public List<int> FriendIDs { get; set; }
//        public User Next { get; set; }

//        public User(int userID, string name, int age)
//        {
//            UserID = userID;
//            Name = name;
//            Age = age;
//            FriendIDs = new List<int>();
//            Next = null;
//        }
//    }

//    class SocialMediaManager
//    {
//        private User head;

//        public void AddUser(int userID, string name, int age)
//        {
//            User newUser = new User(userID, name, age);
//            if (head == null)
//            {
//                head = newUser;
//            }
//            else
//            {
//                User temp = head;
//                while (temp.Next != null)
//                    temp = temp.Next;
//                temp.Next = newUser;
//            }
//            Console.WriteLine($"User {name} added successfully!");
//        }

//        public void AddFriendConnection(int userID1, int userID2)
//        {
//            User user1 = FindUserByID(userID1);
//            User user2 = FindUserByID(userID2);
//            if (user1 != null && user2 != null)
//            {
//                if (!user1.FriendIDs.Contains(userID2))
//                    user1.FriendIDs.Add(userID2);
//                if (!user2.FriendIDs.Contains(userID1))
//                    user2.FriendIDs.Add(userID1);
//                Console.WriteLine($"{user1.Name} and {user2.Name} are now friends!");
//            }
//            else
//            {
//                Console.WriteLine("Invalid User IDs! Friendship not created.");
//            }
//        }

//        public void DisplayFriends(int userID)
//        {
//            User user = FindUserByID(userID);
//            if (user != null)
//            {
//                Console.WriteLine($"Friends of {user.Name}:");
//                foreach (int friendID in user.FriendIDs)
//                {
//                    User friend = FindUserByID(friendID);
//                    if (friend != null)
//                        Console.WriteLine($"UserID: {friend.UserID}, Name: {friend.Name}");
//                }
//            }
//            else
//            {
//                Console.WriteLine("User not found!");
//            }
//        }

//        public User FindUserByID(int userID)
//        {
//            User temp = head;
//            while (temp != null)
//            {
//                if (temp.UserID == userID)
//                    return temp;
//                temp = temp.Next;
//            }
//            return null;
//        }
//    }

//    class Program
//    {
//        static void Main()
//        {
//            SocialMediaManager manager = new SocialMediaManager();

//            while (true)
//            {
//                Console.WriteLine("\nSocial Media Friend Management");
//                Console.WriteLine("1. Add User");
//                Console.WriteLine("2. Add Friend Connection");
//                Console.WriteLine("3. Display Friends");
//                Console.WriteLine("4. Exit");
//                Console.Write("Enter your choice: ");
                
//                int choice;
//                if (!int.TryParse(Console.ReadLine(), out choice))
//                {
//                    Console.WriteLine("Invalid input! Please enter a number.");
//                    continue;
//                }

//                switch (choice)
//                {
//                    case 1:
//                        Console.Write("Enter User ID: ");
//                        int userID = int.Parse(Console.ReadLine());
//                        Console.Write("Enter Name: ");
//                        string name = Console.ReadLine();
//                        Console.Write("Enter Age: ");
//                        int age = int.Parse(Console.ReadLine());
//                        manager.AddUser(userID, name, age);
//                        break;

//                    case 2:
//                        Console.Write("Enter First User ID: ");
//                        int userID1 = int.Parse(Console.ReadLine());
//                        Console.Write("Enter Second User ID: ");
//                        int userID2 = int.Parse(Console.ReadLine());
//                        manager.AddFriendConnection(userID1, userID2);
//                        break;

//                    case 3:
//                        Console.Write("Enter User ID to Display Friends: ");
//                        int searchID = int.Parse(Console.ReadLine());
//                        manager.DisplayFriends(searchID);
//                        break;

//                    case 4:
//                        Console.WriteLine("Exiting program...");
//                        return;

//                    default:
//                        Console.WriteLine("Invalid choice! ");
//                        break;
//                }
//            }
//        }
//    }
//}
