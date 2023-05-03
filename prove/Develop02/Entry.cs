public class Entry
{
    // attributes
    private string _prompt;
    private string _entry;
    private DateTime _date;

    // constructor
    public Entry(string prompt, string entry, DateTime date)
    {
        _prompt = prompt;
        _entry = entry;
        _date = date;
    }

    // methods
    // Displays information to terminal
    public void display()
    {
        Console.WriteLine($"\nPrompt:\n{_prompt}\n");
        Console.WriteLine($"Entry:\n{_entry}\n");
        Console.WriteLine($"{_date}\n");
    }
}