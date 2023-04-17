using System;

class Program
{
    static void Main(string[] args)
    {
        int grade_percent = int.Parse("0");

        while (true)
        {
            try
            { 
                Console.Write("What is the percentage score for your class ( 0 - 100 )? ");
                grade_percent = int.Parse(Console.ReadLine());

                if (grade_percent >= 0 && grade_percent <= 100)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Your Input was not in the expected range.");
                }
            }
            catch ()
            {
                Console.WriteLine("the input was not in the correct format. Integers only.");
            }
        }

        string grade_letter = "o";

        if (grade_percent >= 90)
        {
            grade_letter = "A";
        }   else if (grade_percent >= 80)
        {
            grade_letter = "B";
        }   else if (grade_percent >= 70)
        {
            grade_letter = "C";
        }   else
        {
            grade_letter = "F";
        }
        
        Console.WriteLine($"Your letter grade is {grade_letter}");

        if (grade_letter == "F")
        {
            Console.WriteLine("Better luck next time.");
        }   else
        {
            Console.WriteLine("Congratulations on passing.");
        }
    }
}