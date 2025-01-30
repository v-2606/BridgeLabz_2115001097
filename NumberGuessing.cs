using System;

class NumberGuessing
{
   static Random random = new Random();

    static int GenerateGuess(int low, int high)
    {
        return random.Next(low, high + 1);
    }

    static char GetFeedback()
    {
        while (true)
        {
            Console.Write(" guess high (H), too low (L), or correct (C)? ");
            char feedback = Char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();
            if (feedback == 'H' || feedback == 'L' || feedback == 'C')
            {
                return feedback;
            }
            Console.WriteLine("Invalid input.enter H, L, or C.");
        }
    }

    static void NumberGuessingGame(string[] args)
    {
        Console.WriteLine("enter number between 1 and 100 to guess ");
        Console.WriteLine("Press Enter ");
        Console.ReadLine();

        int low = 1, high = 100, attempts = 0;
        int guess = GenerateGuess(low, high);

        while (true)
        {
            Console.WriteLine(" guess : "+guess);
            attempts++;
            char feedback = GetFeedback();

            if (feedback == 'C')
            {
                Console.WriteLine(" number guessed  " +attempts +"attempts.");
                break;
            }
            else if (feedback == 'H')
            {
                high = guess - 1;
            }
            else if (feedback == 'L')
            {
                low = guess + 1;
            }

            if (low > high)
            {
                Console.WriteLine("number changge?");
                break;
            }

            guess = GenerateGuess(low, high);
        }
    }

  static void Main(string [] args)
 {
    NumberGuessingGame();
    Console.ReadKey();
 }
 }