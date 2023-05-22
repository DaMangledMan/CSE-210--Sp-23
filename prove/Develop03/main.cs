public class Main
{
    Display display = new Display();

    public void mainF()
    {
        display.displayFullVerse();
        while (true)
        {
            string choice;
            bool end = false;
            while (!end)
            {
                try
                {
                    Console.WriteLine ("\n\n\njust click Enter to continue : type Quit to quit");
                    choice = Console.ReadLine().ToLower();
                    if (choice == "quit")
                    {
                        Environment.Exit(1);
                    }
                }
                catch (ArgumentException)
                {}
                end = true;
            }

            display.displayHidden();

            if (display.completelyHidden())
            {
                Environment.Exit(1);
            }
        }
        
    }
}