//using System;

//namespace TextEditorApp
//{
//    class TextState
//    {
//        public string Content { get; set; }
//        public TextState Prev { get; set; }
//        public TextState Next { get; set; }

//        public TextState(string content)
//        {
//            Content = content;
//            Prev = null;
//            Next = null;
//        }
//    }

//    class TextEditor
//    {
//        private TextState current;
//        private int historyLimit;
//        private int historyCount;

//        public TextEditor(int limit = 10)
//        {
//            current = null;
//            historyLimit = limit;
//            historyCount = 0;
//        }

//        public void AddState(string content)
//        {
//            TextState newState = new TextState(content);
//            if (current != null)
//            {
//                newState.Prev = current;
//                current.Next = newState;
//            }
//            current = newState;
//            historyCount++;

//            if (historyCount > historyLimit)
//            {
//                RemoveOldestState();
//            }
//            Console.WriteLine("Text Saved!");
//        }

//        private void RemoveOldestState()
//        {
//            TextState temp = current;
//            while (temp.Prev != null)
//            {
//                temp = temp.Prev;
//            }
//            if (temp.Next != null)
//            {
//                temp.Next.Prev = null;
//            }
//            historyCount--;
//        }

//        public void Undo()
//        {
//            if (current != null && current.Prev != null)
//            {
//                current = current.Prev;
//                Console.WriteLine("Undo Successful!");
//            }
//            else
//            {
//                Console.WriteLine("No more Undo available.");
//            }
//        }

//        public void Redo()
//        {
//            if (current != null && current.Next != null)
//            {
//                current = current.Next;
//                Console.WriteLine("Redo Successful!");
//            }
//            else
//            {
//                Console.WriteLine("No more Redo available.");
//            }
//        }

//        public void DisplayCurrentState()
//        {
//            if (current != null)
//            {
//                Console.WriteLine("Current Text: " + current.Content);
//            }
//            else
//            {
//                Console.WriteLine("No text available.");
//            }
//        }
//    }

//    class UndoRedo
//    {
//        static void Main(string[] args)
//        {
//            TextEditor editor = new TextEditor();

//            while (true)
//            {
//                Console.WriteLine("\nText Editor - Undo/Redo System");
//                Console.WriteLine("1. Enter New Text");
//                Console.WriteLine("2. Undo");
//                Console.WriteLine("3. Redo");
//                Console.WriteLine("4. Show Current Text");
//                Console.WriteLine("5. Exit");
//                Console.Write("Choose an option: ");

//                int choice;
//                if (!int.TryParse(Console.ReadLine(), out choice))
//                {
//                    Console.WriteLine("Invalid input! Please enter a number.");
//                    continue;
//                }

//                switch (choice)
//                {
//                    case 1:
//                        Console.Write("Enter new text: ");
//                        string newText = Console.ReadLine();
//                        editor.AddState(newText);
//                        break;

//                    case 2:
//                        editor.Undo();
//                        break;

//                    case 3:
//                        editor.Redo();
//                        break;

//                    case 4:
//                        editor.DisplayCurrentState();
//                        break;

//                    case 5:
//                        Console.WriteLine("Exiting the program...");
//                        return;

//                    default:
//                        Console.WriteLine("Invalid choice! Please try again.");
//                        break;
//                }
//            }
//        }
//    }
//}
