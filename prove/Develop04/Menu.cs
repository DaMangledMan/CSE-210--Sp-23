public class menu
{
    // Attributes

    // Constructor

    // Methods

    public void Menu()
    {
        while (true)
        {        
            Console.Clear();

            int option;
            while (true)
            {
                try
                {
                    Console.Write("\nWhich option would you like to choose ( 1 - 4 )?\n");
                    Console.WriteLine(" 1. Breathing exercise\n 2. Reflection exercise\n 3. Listing exercise\n 4. Quit\n");
                    option = int.Parse(Console.ReadLine());
    
                    if (option >= 1 && option <= 4)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\nYour Input was not one of the options.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nThe input was not in the correct format. Integers only.");
                }
            }

            if (option == 1)
            {
                breathing();
            }
            else if (option == 2)
            {
                reflection();
            }
            else if (option == 3)
            {
                listing();
            }
            else if (option == 4)
            {
                quit();
            }
        }
    }

    public void breathing()
    {
        Animations animations = new Animations();
        Breathing breathing = new Breathing();

        Console.Clear();

        breathing.startMessage(1);

        int duration;
        while (true)
        {
            try
            {
                Console.Write("\nHow long do you want to do the breathing exercise for (in seconds)?\n");
                duration = int.Parse(Console.ReadLine());
                break;
            }
            catch (FormatException)
            {
                Console.WriteLine("\nThe input was not in the correct format. Integers only.");
            }
        }

        Console.Write("\nGet ready to start  ");
        animations.spinning(3);

        Console.Clear();

        breathing.breathWithTimer(duration);

        Console.Clear();

        breathing.endMessage(1);
    }

    public void reflection()
    {
        Animations animations = new Animations();
        Reflection reflection = new Reflection();

        reflection.startMessage(2);

        Console.Clear();

        int duration;
        while (true)
        {
            try
            {
                Console.Write("\nHow long do you want to do the reflection exercise for (in seconds)?\n");
                duration = int.Parse(Console.ReadLine());
                break;
            }
            catch (FormatException)
            {
                Console.WriteLine("\nThe input was not in the correct format. Integers only.");
            }
        }

        Console.Write("\nGet ready to start  ");
        animations.spinning(3);

        Console.Clear();

        reflection.question();

        Console.Clear();

        reflection.promptsWithTimer(duration);

        Console.Clear();

        reflection.endMessage(2);
    }

    public void listing()
    {
        Animations animations = new Animations();
        Listing listing = new Listing();

        Console.Clear();

        listing.startMessage(3);

        Console.Clear();

        int duration;
        while (true)
        {
            try
            {
                Console.Write("\nHow long do you want to do the listing exercise for (in seconds)?\n");
                duration = int.Parse(Console.ReadLine());
                break;
            }
            catch (FormatException)
            {
                Console.WriteLine("\nThe input was not in the correct format. Integers only.");
            }
        }

        Console.Write("\nGet ready to start  ");
        animations.spinning(3);

        Console.Clear();

        listing.listingWithTimerWithCounter(duration);

        Console.Clear();

        listing.endMessage(3);
    }

    public void quit()
    {
        Environment.Exit(1);
    }
}