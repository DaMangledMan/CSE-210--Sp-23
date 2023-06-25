public class Menu
{
    Points points = new Points();
    csvEditor CSV = new csvEditor();
    
    // attributes
    private List<Goal> goalsList = new List<Goal> ();

    // constructor
    // n/a

    // methods
    public void menu()
    {

    }

    private void displayPoints()
    {
        Console.WriteLine($"You are currently at {points.getPointTotal()} points.\n\n   Good Job!!!");
    }

    private void create()
    {

    }
    
    private void list()
    {

    }

    private void save()
    {

    }

    private void load()
    {

    }

    private void record()
    {

    }

    private void quit()
    {
        Environment.Exit(1);
    }
}