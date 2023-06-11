public class Listing : Assignments
{
    // Attributes
    private int _count = 0;
    private List<string> prompts = new List<string> {
        "When have you felt the Holy Ghost this month?",
        "What interesting thoughts came to mind today?",
        "What did you do to better yourself this week?",
        "this is an easter egg"
        };

    // Constructor

    // Methods

    public void listingWithTimerWithCounter(int duration)
    {
        Animations animations = new Animations();
        Random rnd = new Random();

        Console.Clear();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($"\n--- {prompts[rnd.Next(prompts.Count() - 1)]} ---");
        Console.Write("\nYou may begin in: ");
        animations.countdown(10);

        Console.WriteLine("\n\nStart Typing.");

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);

        DateTime currentTime = DateTime.Now;
        while(currentTime < futureTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            _count += 1;
            currentTime = DateTime.Now;
        }

        Console.WriteLine($"\nYou listed {_count} items!");
        Console.Write("\nWell done!! ");
        animations.spinning(7);
    }
}