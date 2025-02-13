//using System;


//    class Node
//    {
//        public int Data;
//        public Node Next;
//        public Node Prev;

//        public Node(int data)
//        {
//            Data = data;
//            Next = null;
//            Prev = null;
//        }
//    }

//    class CustomDeque
//    {
//        private Node front, rear;

//        public CustomDeque()
//        {
//            front = rear = null;
//        }

//        public void InsertRear(int value)
//        {
//            Node newNode = new Node(value);
//            if (rear == null)
//            {
//                front = rear = newNode;
//            }
//            else
//            {
//                rear.Next = newNode;
//                newNode.Prev = rear;
//                rear = newNode;
//            }
//        }

//        public void RemoveFront()
//        {
//            if (front == null) return;
//            front = front.Next;
//            if (front != null)
//                front.Prev = null;
//            else
//                rear = null;
//        }

//        public void RemoveRear()
//        {
//            if (rear == null) return;
//            rear = rear.Prev;
//            if (rear != null)
//                rear.Next = null;
//            else
//                front = null;
//        }

//        public int GetFront()
//        {
//            return front != null ? front.Data : -1;
//        }

//        public bool IsEmpty()
//        {
//            return front == null;
//        }
//    }

//    class SlidingWindowMaximum
//    {
//        public static int[] FindMaxSlidingWindow(int[] arr, int k)
//        {
//            int n = arr.Length;
//            if (n == 0 || k > n) return new int[0];

//            int[] result = new int[n - k + 1];
//            CustomDeque deque = new CustomDeque();

//            for (int i = 0; i < n; i++)
//            {
//                if (!deque.IsEmpty() && deque.GetFront() <= i - k)
//                    deque.RemoveFront();

//                while (!deque.IsEmpty() && arr[deque.GetFront()] <= arr[i])
//                    deque.RemoveRear();

//                deque.InsertRear(i);

//                if (i >= k - 1)
//                    result[i - k + 1] = arr[deque.GetFront()];
//            }
//            return result;
//        }

//        public static void Main()
//        {
//            int[] arr = { 1, 3, -1, -3, 5, 3, 6, 7 };
//            int k = 3;

//            int[] result = FindMaxSlidingWindow(arr, k);

//            Console.WriteLine("Sliding Window Maximum:");
//            Console.WriteLine(string.Join(", ", result));
//        }
//    }

