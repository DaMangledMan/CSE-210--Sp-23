using System;

class Program
{
    static void Main(string[] args)
    {
        int magic_number;
        int guess_number;

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
            
            if (guess_number > magic_number)
            {
                Console.WriteLine("Lower!");
            } else if (guess_number < magic_number)
            {
                Console.WriteLine("Higher!");
            } else
            {
                Console.WriteLine("Correct!");
                break;
            }
        }
    }
}