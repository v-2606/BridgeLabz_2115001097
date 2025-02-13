//using System;



   
//    class Node
//    {
//        public int Data; 
//        public Node Next;

//        public Node(int data)
//        {
//            Data = data;
//            Next = null;
//        }
//    }


//    class CustomStack
//    {
//        private Node top; 

//        public CustomStack()
//        {
//            top = null;
//        }

//        public void Push(int value)
//        {
//            Node newNode = new Node(value);
//            newNode.Next = top;
//            top = newNode;
//        }

//        public int Pop()
//        {
//            if (top == null)
//                return -1;

//            int value = top.Data;
//            top = top.Next;
//            return value;
//        }

      
//        public int Peek()
//        {
//            return top == null ? -1 : top.Data;
//        }

//        public bool IsEmpty()
//        {
//            return top == null;
//        }
//    }

//    class StockSpan
//    {
      
//        public static int[] CalculateSpan(int[] prices)
//        {
//            int n = prices.Length;
//            int[] span = new int[n];
//            CustomStack stack = new CustomStack(); 

//            for (int i = 0; i < n; i++)
//            {
              
//                while (!stack.IsEmpty() && prices[stack.Peek()] <= prices[i])
//                {
//                    stack.Pop();
//                }

                
//                span[i] = stack.IsEmpty() ? (i + 1) : (i - stack.Peek());

                
//                stack.Push(i);
//            }
//            return span;
//        }

//        public static void Main()
//        {
//            int[] prices = { 100, 80, 60, 70, 60, 75, 85 };
//            int[] span = CalculateSpan(prices);

//            Console.WriteLine("Stock Prices: " + string.Join(", ", prices));
//            Console.WriteLine("Stock Span  : " + string.Join(", ", span));
//        }
//    }

