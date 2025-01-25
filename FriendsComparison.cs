using System;

class FriendsComparison
{
    static void Main()
    {
        string[] friends = { "Amar", "Akbar", "Anthony" };
        int[] ages = new int[3];
        double[] heights = new double[3];

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Enter age of " + friends[i] + ":");
            ages[i] = Convert.ToInt32(Console.ReadLine());
            while (ages[i] <= 0)
            {
                Console.WriteLine("Invalid input. Enter a positive age:");
                ages[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Enter height of " + friends[i] + " in cm:");
            heights[i] = Convert.ToDouble(Console.ReadLine());
            while (heights[i] <= 0)
            {
                Console.WriteLine("Invalid input. Enter a positive height:");
                heights[i] = Convert.ToDouble(Console.ReadLine());
            }
        }

        int youngestIndex = 0;
        int tallestIndex = 0;

        for (int i = 1; i < 3; i++)
        {
            if (ages[i] < ages[youngestIndex])
            {
                youngestIndex = i;
            }

            if (heights[i] > heights[tallestIndex])
            {
                tallestIndex = i;
            }
        }

        Console.WriteLine("The youngest friend is " + friends[youngestIndex] + " with age " + ages[youngestIndex] + " years.");
        Console.WriteLine("The tallest friend is " + friends[tallestIndex] + " with height " + heights[tallestIndex] + " cm.");
    }
}
