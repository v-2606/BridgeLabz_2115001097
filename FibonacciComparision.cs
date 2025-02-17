//using System;
//using System.Diagnostics;

//class FibonacciComparison
//{
//    static void Main(string[] args)
//    {
//        int n = 40;

//        MeasureTime("Recursive Fibonacci", () => FibonacciRecursive(n));
//        MeasureTime("Iterative Fibonacci", () => FibonacciIterative(n));
//    }

//    static int FibonacciRecursive(int n)
//    {
//        if (n <= 1) return n;
//        return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
//    }

//    static int FibonacciIterative(int n)
//    {
//        if (n <= 1) return n;
//        int a = 0, b = 1, sum;
//        for (int i = 2; i <= n; i++)
//        {
//            sum = a + b;
//            a = b;
//            b = sum;
//        }
//        return b;
//    }

//    static void MeasureTime(string method, Func<int> operation)
//    {
//        Stopwatch stopwatch = Stopwatch.StartNew();
//        int result = operation();
//        stopwatch.Stop();
//        Console.WriteLine($"{method} Result: {result}, Time: {stopwatch.ElapsedMilliseconds} ms");
//    }
//}
