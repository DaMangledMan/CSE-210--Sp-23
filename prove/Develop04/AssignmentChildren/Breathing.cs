public class Breathing : Assignments
{
    // Attributes

    // Constructor

    // Methods

    public void breathWithTimer(int duration)
    {
        Animations animations = new Animations();
        
        int breathCount = (duration / 8) + 1;
        for (int i = breathCount; i > 0; i--)
        {
            Console.Clear();
            Console.Write("Breath In ");
            animations.countdown(5);

            Console.Clear();
            Console.Write("Breath Out ");
            animations.countdown(3);
        }
    }
}
