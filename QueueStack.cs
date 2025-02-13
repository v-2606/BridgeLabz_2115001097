using System;
using System.Collections.Generic;

class QueueStack
{
    private Stack<int> stack1;
    private Stack<int> stack2;

    public QueueStack()
    {
        stack1 = new Stack<int>();
        stack2 = new Stack<int>();
    }

    public void Enqueue(int value)
    {
        stack1.Push(value);
    }

    public int Dequeue()
    {
        if (stack2.Count == 0)
        {
            if (stack1.Count == 0)
            {
                Console.WriteLine("Queue is empty!");
                return -1;
            }
            while (stack1.Count > 0)
            {
                stack2.Push(stack1.Pop());
            }
        }
        return stack2.Pop();
    }

    public int Peek()
    {
        if (stack2.Count == 0)
        {
            if (stack1.Count == 0)
            {
                Console.WriteLine("Queue is empty!");
                return -1;
            }
            while (stack1.Count > 0)
            {
                stack2.Push(stack1.Pop());
            }
        }
        return stack2.Peek();
    }

    public bool IsEmpty()
    {
        return stack1.Count == 0 && stack2.Count == 0;
    }

    public static void Main(string[] args)
    {
        QueueStack queue = new QueueStack();

        Console.Write("Enter number of elements to enqueue: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter elements:");
        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            queue.Enqueue(num);
        }

        Console.WriteLine("Dequeued Element: " + queue.Dequeue());
        Console.WriteLine("Front Element: " + queue.Peek());
        Console.WriteLine("Is Queue Empty? " + queue.IsEmpty());
    }
}
