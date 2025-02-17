//using System;
//using System.Diagnostics;

//class SortingComparison
//{
//    static void Main(string[] args)
//    {
//        int[] dataset = GenerateDataset(100000);

//        MeasureTime("Bubble Sort", () => BubbleSort((int[])dataset.Clone()));

//        MeasureTime("Merge Sort", () => MergeSort((int[])dataset.Clone(), 0, dataset.Length - 1));

//        MeasureTime("Quick Sort", () => QuickSort((int[])dataset.Clone(), 0, dataset.Length - 1));
//    }

//    static void BubbleSort(int[] arr)
//    {
//        int n = arr.Length;
//        for (int i = 0; i < n - 1; i++)
//        {
//            for (int j = 0; j < n - i - 1; j++)
//            {
//                if (arr[j] > arr[j + 1])
//                {
//                    int temp = arr[j];
//                    arr[j] = arr[j + 1];
//                    arr[j + 1] = temp;
//                }
//            }
//        }
//    }

//    static void MergeSort(int[] arr, int left, int right)
//    {
//        if (left < right)
//        {
//            int mid = left + (right - left) / 2;

//            MergeSort(arr, left, mid);
//            MergeSort(arr, mid + 1, right);

//            Merge(arr, left, mid, right);
//        }
//    }

//    static void Merge(int[] arr, int left, int mid, int right)
//    {
//        int n1 = mid - left + 1;
//        int n2 = right - mid;

//        int[] leftArr = new int[n1];
//        int[] rightArr = new int[n2];

//        Array.Copy(arr, left, leftArr, 0, n1);
//        Array.Copy(arr, mid + 1, rightArr, 0, n2);

//        int i = 0, j = 0, k = left;

//        while (i < n1 && j < n2)
//        {
//            if (leftArr[i] <= rightArr[j])
//            {
//                arr[k++] = leftArr[i++];
//            }
//            else
//            {
//                arr[k++] = rightArr[j++];
//            }
//        }

//        while (i < n1) arr[k++] = leftArr[i++];
//        while (j < n2) arr[k++] = rightArr[j++];
//    }

//    static void QuickSort(int[] arr, int low, int high)
//    {
//        if (low < high)
//        {
//            int pivot = Partition(arr, low, high);

//            QuickSort(arr, low, pivot - 1);
//            QuickSort(arr, pivot + 1, high);
//        }
//    }

//    static int Partition(int[] arr, int low, int high)
//    {
//        int pivot = arr[high];
//        int i = low - 1;

//        for (int j = low; j < high; j++)
//        {
//            if (arr[j] <= pivot)
//            {
//                i++;
//                (arr[i], arr[j]) = (arr[j], arr[i]);
//            }
//        }

//        (arr[i + 1], arr[high]) = (arr[high], arr[i + 1]);
//        return i + 1;
//    }

//    static void MeasureTime(string method, Action sortingMethod)
//    {
//        Stopwatch stopwatch = Stopwatch.StartNew();
//        sortingMethod();
//        stopwatch.Stop();
//        Console.WriteLine($"{method} Time: {stopwatch.ElapsedMilliseconds} ms");
//    }

//    static int[] GenerateDataset(int size)
//    {
//        Random rand = new Random();
//        int[] arr = new int[size];
//        for (int i = 0; i < size; i++)
//        {
//            arr[i] = rand.Next(0, 100000);
//        }
//        return arr;
//    }
//}
