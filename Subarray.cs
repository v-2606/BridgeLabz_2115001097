//using System;
//using System.Collections.Generic;

//namespace DSA
//{
//    public class ZeroSumSubarrays
//    {
//        public static void FindSubarrays(int[] arr)
//        {
//            Dictionary<int, List<int>> map = new Dictionary<int, List<int>>();
//            int sum = 0;

//            for (int i = 0; i < arr.Length; i++)
//            {
//                sum += arr[i];

//                if (sum == 0)
//                {
//                    Console.WriteLine("Subarray from index 0 to " + i);
//                }

//                if (map.ContainsKey(sum))
//                {
//                    foreach (var start in map[sum])
//                    {
//                        Console.WriteLine("Subarray  from index " + (start + 1) + " to " + i);
//                    }
//                }

//                if (!map.ContainsKey(sum))
//                {
//                    map[sum] = new List<int>();
//                }
//                map[sum].Add(i);
//            }
//        }

//        public static void Main()
//        {
//            Console.WriteLine("Enter the number of elements:");
//            int length = int.Parse(Console.ReadLine());
//            int[] arr = new int[length];

//            Console.WriteLine("Enter the elements:");
//            for (int i = 0; i < length; i++)
//            {
//                arr[i] = int.Parse(Console.ReadLine());
//            }

//            FindSubarrays(arr);
//        }
//    }
//}
