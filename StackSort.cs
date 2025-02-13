//using System;

//namespace DSA
//{

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
//            {
//                Console.WriteLine("Stack is Empty");
//                return -1;
//            }
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


//        public void Sort()
//        {
//            if (!IsEmpty())
//            {
//                int temp = Pop();
//                Sort();
//                InsertSorted(temp);
//            }
//        }


//        private void InsertSorted(int value)
//        {
//            if (IsEmpty() || Peek() <= value)
//            {
//                Push(value);
//                return;
//            }
//            int temp = Pop();
//            InsertSorted(value);
//            Push(temp);
//        }


//        public void Display()
//        {
//            Node temp = top;
//            while (temp != null)
//            {
//                Console.Write(temp.Data + " ");
//                temp = temp.Next;
//            }
//            Console.WriteLine();
//        }
//    }
//    class StackSort
//    {
//        public static void Main(string[] args)
//        {
//            CustomStack stack = new CustomStack();


//            stack.Push(15);
//            stack.Push(12);
//            stack.Push(44);
//            stack.Push(21);

//            Console.WriteLine("Before Sorting:");
//            stack.Display();


//            stack.Sort();

//            Console.WriteLine("\nAfter Sorting:");
//            stack.Display();
//        }
//    }
//}

