public class Reflection : Assignments
{
    // Attributes
    private List<string> prompts = new List<string> {
        "How did you feel when you complete it?",
        "What was the best part of this experience?",
        "what was the worst part of this experience?",
        "this is an easter egg"
        };

    // Constructor

    // Methods

    public void question()
    {
        Animations animations = new Animations();

        Console.Clear();
        Console.WriteLine("Consider the following");
        Console.WriteLine("\n--- think of a time when you did something difficult ---");
        Console.WriteLine("\nWhen ready to continue, press enter");
        Console.ReadLine();
        Console.WriteLine("Now consider the folloing in the context of the answer you just gave.\n");
        animations.spinning(5);
    }

    public void promptsWithTimer(int duration)
    {
        Animations animations = new Animations();
        Random rnd = new Random();
        
        int promptsCount = (duration / 8) + 1;

        for (int i = promptsCount; i > 0; i--)
        {
            Console.Clear();
            Console.Write($"{prompts[rnd.Next(prompts.Count() - 1)]} ");
            animations.spinning(8);
        }
    }
}