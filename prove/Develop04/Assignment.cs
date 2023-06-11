public class Assignments
{
    // Attributes

    // Constructor

    // Methods

    public void startMessage(int option)
    {
        Animations animations = new Animations();

        Console.Clear();

        if (option == 1)
        {
            Console.WriteLine("Welcome to the Breathing exercise.");
            Console.WriteLine("\nIn this exercise you will watch your breathing to ensure that it is steady.");
        }
        else if (option == 2)
        {
            Console.WriteLine("Welcome to the Reflection exercise.");
            Console.WriteLine("\nIn this exercise you will reflect on events from your life.");
        }
        else if (option == 3)
        {
            Console.WriteLine("Welcome to the Listing exercise.");
            Console.WriteLine("\nIn this exercise you will list times that something has happened to you.");
        }
        
        Console.Write("\n    ");
        animations.spinning(6);
    }

    public void endMessage(int option)
    {
        Animations animations = new Animations();

        Console.Clear();

        if (option == 1)
        {
            Console.WriteLine("Thank you for enjoying the Breathing exercise.");
        }
        else if (option == 2)
        {
            Console.WriteLine("Thank you for enjoying the Reflection exercise.");
        }
        else if (option == 3)
        {
            Console.WriteLine("Thank you for enjoying the Listing exercise.");
        }

        Console.Write("\nSee you next time ");
        animations.spinning(5);
    }
}