public class Animations
{
    // Attributes

    // Constructor

    // Methods

    public void spinning(int duration)
    {
        for (int i = duration; i > 0; i--)
        {
            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b \b\\");
            Thread.Sleep(250);
            Console.Write("\b \b|");
            Thread.Sleep(250);
            Console.Write("\b \b/");
            Thread.Sleep(250);
            Console.Write("\b \b");
        }
    }

    public void countdown(int duration)
    {
        for (int i = duration; i > 0; i--)
        {
            Console.Write($"{i}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}