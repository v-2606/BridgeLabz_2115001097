using System;
class AmarAkbarAnthony
{
    static void Main()
    {
        Console.Write("Enter the age of Amar: ");
        int amarAge = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the height of Amar: ");
        int amarHeight = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the age of Akbar: ");
        int akbarAge = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the height of Akbar: ");
        int akbarHeight = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the age of Anthony: ");
        int anthonyAge = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the height of Anthony: ");
        int anthonyHeight = Convert.ToInt32(Console.ReadLine());

        FindYoungestAndTallest(amarAge, akbarAge, anthonyAge, amarHeight, akbarHeight, anthonyHeight);
    }

    static void FindYoungestAndTallest(int amarAge, int akbarAge, int anthonyAge, int amarHeight, int akbarHeight, int anthonyHeight)
    {
        int youngestAge = Math.Min(Math.Min(amarAge, akbarAge), anthonyAge);
        string youngestFriend = (youngestAge == amarAge) ? "Amar" : (youngestAge == akbarAge) ? "Akbar" : "Anthony";

        int tallestHeight = Math.Max(Math.Max(amarHeight, akbarHeight), anthonyHeight);
        string tallestFriend = (tallestHeight == amarHeight) ? "Amar" : (tallestHeight == akbarHeight) ? "Akbar" : "Anthony";

        Console.WriteLine("The youngest friend is: " + youngestFriend);
        Console.WriteLine("The tallest friend is: " + tallestFriend);
    }
}
