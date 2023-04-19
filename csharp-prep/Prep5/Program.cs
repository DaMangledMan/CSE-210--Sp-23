using System;

class Program
{
    static void Main(string[] args)
    {
        static int square_number(int input)
        {
            return input * input;
        }

        string name;
        int number;
        
        
        Console.WriteLine("Welcome to the program!");

        Console.Write("Please enter your name: ");
        name = Console.ReadLine();


        while (true)
        {
            try
            {
                Console.Write("Please enter your favorite number: ");
                number = int.Parse(Console.ReadLine());

                break;
            }
            catch (FormatException)
            {
                Console.WriteLine("the input was not in the correct format. Integers only.");
            }
        }
        
        Console.WriteLine($"{name}, the square of your number is {square_number(number)}");
    }
}