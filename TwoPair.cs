//using System;
//using System.Collections.Generic;

//class TwoPair
//{
//    public static int[] TwoSum(int[] nums, int target)
//    {
//        Dictionary<int, int> map = new Dictionary<int, int>();

//        for (int i = 0; i < nums.Length; i++)
//        {
//            int complement = target - nums[i];

//            if (map.ContainsKey(complement))
//            {
//                return new int[] { map[complement], i };
//            }

//            map[nums[i]] = i;
//        }

//        return new int[] { -1, -1 };
//    }

//    public static void Main(string[] args)
//    {
//        Console.WriteLine("Enter array size:");
//        int size = int.Parse(Console.ReadLine());
//        int[] nums = new int[size];

//        Console.WriteLine("Enter array elements:");
//        for (int i = 0; i < size; i++)
//        {
//            nums[i] = int.Parse(Console.ReadLine());
//        }

//        Console.WriteLine("Enter target sum:");
//        int target = int.Parse(Console.ReadLine());

//        int[] result = TwoSum(nums, target);

//        if (result[0] == -1)
//        {
//            Console.WriteLine("No two numbers found.");
//        }
//        else
//        {
//            Console.WriteLine($"Indices: {result[0]}, {result[1]}");
//        }
//    }
//}

