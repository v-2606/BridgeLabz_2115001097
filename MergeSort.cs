//using System;

// class MergeSort
//    {


//    static void Merge(double[] prices, int left, int right)
//    {
//        if (left < right)
//        {
//            int mid = (left + right) / 2;
//            Merge(prices, left, mid);
//            Merge(prices, mid + 1, right);
//            Merge(prices, left, mid, right);
//        }
//    }

//    static void Merge(double[] prices, int left, int mid, int right)
//    {
//        int n1 = mid - left + 1, n2 = right - mid;
//        double[] leftArray = new double[n1], rightArray = new double[n2];

//        for (int i = 0; i < n1; i++)
//            leftArray[i] = prices[left + i];
//        for (int j = 0; j < n2; j++)
//            rightArray[j] = prices[mid + 1 + j];

//        int iIndex = 0, jIndex = 0, kIndex = left;
//        while (iIndex < n1 && jIndex < n2)
//        {
//            if (leftArray[iIndex] <= rightArray[jIndex])
//                prices[kIndex++] = leftArray[iIndex++];
//            else
//                prices[kIndex++] = rightArray[jIndex++];
//        }

//        while (iIndex < n1)
//            prices[kIndex++] = leftArray[iIndex++];
//        while (jIndex < n2)
//            prices[kIndex++] = rightArray[jIndex++];
//    }

//    static void PrintArray(double[] prices)
//    {
//        foreach (double price in prices)
//            Console.Write(price + " ");
//        Console.WriteLine();
//    }

//    static void Main(string[] args)
//    {
//        Console.Write("Enter number of books: ");
//        int n = int.Parse(Console.ReadLine());

//        double[] bookPrices = new double[n];
//        Console.WriteLine("Enter book prices:");
//        for (int i = 0; i < n; i++)
//        {
//            Console.Write("Book " + (i + 1) + " Price: ");
//            bookPrices[i] = double.Parse(Console.ReadLine());
//        }

//        Console.WriteLine("\nOriginal Book Prices:");
//        PrintArray(bookPrices);

//        Merge(bookPrices, 0, n - 1);

//        Console.WriteLine("Sorted Book Prices:");
//        PrintArray(bookPrices);
//    }
//}

    

