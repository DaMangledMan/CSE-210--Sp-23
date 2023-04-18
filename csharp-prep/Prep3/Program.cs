using System;

class Program
{
    static void Main(string[] args)
    {
        int magic_number;
        int guess_number;

        while (true)
        {
            while (true)
            {
                try
                {
                    Console.Write("What is the magic number? ");
                    magic_number = int.Parse(Console.ReadLine());

                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("the input was not in the correct format. Integers only.");
                }
            }
            
            int count = 0;
            while (true)
            {
                try
                {
                    Console.Write("What is your guess? ");
                    guess_number = int.Parse(Console.ReadLine());

                } catch (FormatException)
                {
                    Console.WriteLine("the input was not in the correct format. Integers only.");
                    continue;
                }
                count += 1;
                if (guess_number > magic_number)
                {
                    Console.WriteLine("Lower!");
                } else if (guess_number < magic_number)
                {
                    Console.WriteLine("Higher!");
                } else
                {
                    Console.WriteLine($"Correct! You took {count} guesses");
                    break;
                }
            }

            string play_again = "t";
            string play_again_lower = "t";
            while (true)
            {
                Console.Write("Would you like to play again (yes/no)? ");
                play_again = Console.ReadLine();
                play_again_lower = play_again.ToLower();

                if ((play_again_lower == "yes") || (play_again_lower == "no"))
                {
                    break;
                } else
                {
                    Console.WriteLine("That was not a valid input.");
                    continue;
                }
            }
            
            if (play_again_lower == "yes")
            {
                continue;
            } else
            {
                break;
            }
        }
    }
}