//using System;

//class TaskNode
//{
//    public int TaskID;
//    public string TaskName;
//    public int Priority;
//    public DateTime DueDate;
//    public TaskNode Next;

//    public TaskNode(int taskId, string taskName, int priority, DateTime dueDate)
//    {
//        TaskID = taskId;
//        TaskName = taskName;
//        Priority = priority;
//        DueDate = dueDate;
//        Next = null;
//    }
//}

//class TaskScheduler
//{
//    private TaskNode head = null;
//    private TaskNode currentTask = null;

//    public void AddTaskAtEnd(int taskId, string taskName, int priority, DateTime dueDate)
//    {
//        TaskNode newTask = new TaskNode(taskId, taskName, priority, dueDate);
//        if (head == null)
//        {
//            head = newTask;
//            head.Next = head; 
//        }
//        else
//        {
//            TaskNode temp = head;
//            while (temp.Next != head)
//            {
//                temp = temp.Next;
//            }
//            temp.Next = newTask;
//            newTask.Next = head;
//        }
//    }

  
//    public void AddTaskAtBeginning(int taskId, string taskName, int priority, DateTime dueDate)
//    {
//        TaskNode newTask = new TaskNode(taskId, taskName, priority, dueDate);
//        if (head == null)
//        {
//            head = newTask;
//            head.Next = head; 
//        }
//        else
//        {
//            TaskNode temp = head;
//            while (temp.Next != head)
//            {
//                temp = temp.Next;
//            }
//            newTask.Next = head;
//            temp.Next = newTask;
//            head = newTask;
//        }
//    }


//    public void RemoveTask(int taskId)
//    {
//        if (head == null)
//        {
//            Console.WriteLine("Task list is empty.");
//            return;
//        }

//        TaskNode temp = head, prev = null;

      
//        if (head.TaskID == taskId)
//        {
//            if (head.Next == head)
//            {
//                head = null;
//            }
//            else
//            {
//                TaskNode last = head;
//                while (last.Next != head)
//                {
//                    last = last.Next;
//                }
//                head = head.Next;
//                last.Next = head;
//            }
//            Console.WriteLine($"Task {taskId} removed.");
//            return;
//        }

       
//        do
//        {
//            prev = temp;
//            temp = temp.Next;
//        } while (temp != head && temp.TaskID != taskId);

//        if (temp == head)
//        {
//            Console.WriteLine("Task not found.");
//            return;
//        }

//        prev.Next = temp.Next;
//        Console.WriteLine($"Task {taskId} removed.");
//    }

 
//    public void ViewCurrentTask()
//    {
//        if (head == null)
//        {
//            Console.WriteLine("No tasks available.");
//            return;
//        }

//        if (currentTask == null)
//        {
//            currentTask = head;
//        }

//        Console.WriteLine($"Current Task -> ID: {currentTask.TaskID}, Name: {currentTask.TaskName}, Priority: {currentTask.Priority}, Due: {currentTask.DueDate}");
//        currentTask = currentTask.Next;
//    }

//    public void DisplayTasks()
//    {
//        if (head == null)
//        {
//            Console.WriteLine("No tasks in the scheduler.");
//            return;
//        }

//        TaskNode temp = head;
//        do
//        {
//            Console.WriteLine($"Task ID: {temp.TaskID}, Name: {temp.TaskName}, Priority: {temp.Priority}, Due Date: {temp.DueDate}");
//            temp = temp.Next;
//        } while (temp != head);
//    }


//    public void SearchByPriority(int priority)
//    {
//        if (head == null)
//        {
//            Console.WriteLine("No tasks available.");
//            return;
//        }

//        TaskNode temp = head;
//        bool found = false;
//        do
//        {
//            if (temp.Priority == priority)
//            {
//                Console.WriteLine($"Task ID: {temp.TaskID}, Name: {temp.TaskName}, Priority: {temp.Priority}, Due Date: {temp.DueDate}");
//                found = true;
//            }
//            temp = temp.Next;
//        } while (temp != head);

//        if (!found)
//        {
//            Console.WriteLine("No tasks found with the given priority.");
//        }
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        TaskScheduler scheduler = new TaskScheduler();

//        while (true)
//        {
//            Console.WriteLine("\n1. Add Task at End\n2. Add Task at Beginning\n3. Remove Task\n4. View Current Task\n5. Display All Tasks\n6. Search Task by Priority\n7. Exit");
//            Console.Write("Enter your choice: ");

//            if (!int.TryParse(Console.ReadLine(), out int choice))
//            {
//                Console.WriteLine("Invalid input. Please enter a number.");
//                continue;
//            }

//            switch (choice)
//            {
//                case 1:
//                    Console.Write("Enter Task ID: ");
//                    int taskId = int.Parse(Console.ReadLine());
//                    Console.Write("Enter Task Name: ");
//                    string taskName = Console.ReadLine();
//                    Console.Write("Enter Priority: ");
//                    int priority = int.Parse(Console.ReadLine());
//                    Console.Write("Enter Due Date (yyyy-MM-dd): ");
//                    DateTime dueDate = DateTime.Parse(Console.ReadLine());
//                    scheduler.AddTaskAtEnd(taskId, taskName, priority, dueDate);
//                    break;

//                case 2:
//                    Console.Write("Enter Task ID: ");
//                    int taskIdB = int.Parse(Console.ReadLine());
//                    Console.Write("Enter Task Name: ");
//                    string taskNameB = Console.ReadLine();
//                    Console.Write("Enter Priority: ");
//                    int priorityB = int.Parse(Console.ReadLine());
//                    Console.Write("Enter Due Date (yyyy-MM-dd): ");
//                    DateTime dueDateB = DateTime.Parse(Console.ReadLine());
//                    scheduler.AddTaskAtBeginning(taskIdB, taskNameB, priorityB, dueDateB);
//                    break;

//                case 3:
//                    Console.Write("Enter Task ID to remove: ");
//                    int removeId = int.Parse(Console.ReadLine());
//                    scheduler.RemoveTask(removeId);
//                    break;

//                case 4:
//                    scheduler.ViewCurrentTask();
//                    break;

//                case 5:
//                    scheduler.DisplayTasks();
//                    break;

//                case 6:
//                    Console.Write("Enter Priority to search: ");
//                    int searchPriority = int.Parse(Console.ReadLine());
//                    scheduler.SearchByPriority(searchPriority);
//                    break;

//                case 7:
//                    return;

//                default:
//                    Console.WriteLine("Invalid choice.");
//                    break;
//            }
//        }
//    }
//}

