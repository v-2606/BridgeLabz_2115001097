﻿//using System;

//class HeapSort
//{
//    static void Heapify(int[] arr, int n, int i)
//    {
//        int largest = i;
//        int left = 2 * i + 1;
//        int right = 2 * i + 2;

//        if (left < n && arr[left] > arr[largest])
//            largest = left;

//        if (right < n && arr[right] > arr[largest])
//            largest = right;

//        if (largest != i)
//        {
//            (arr[i], arr[largest]) = (arr[largest], arr[i]);
//            Heapify(arr, n, largest);
//        }
//    }

//    static void Sort(int[] arr)
//    {
//        int n = arr.Length;

//        for (int i = n / 2 - 1; i >= 0; i--)
//            Heapify(arr, n, i);

//        for (int i = n - 1; i > 0; i--)
//        {
//            (arr[0], arr[i]) = (arr[i], arr[0]);
//            Heapify(arr, i, 0);
//        }
//    }

//    static void Main(string[]args)
//    {
//        int[] salaries = { 500, 700, 600, 800, 400 };

//        Sort(salaries);

//        Console.WriteLine("Sorted Salaries:");
//        foreach (int salary in salaries)
//            Console.Write(salary + " ");
//    }
//}
