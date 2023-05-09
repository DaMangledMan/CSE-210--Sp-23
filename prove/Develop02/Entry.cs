public class Entry
{
    // attributes
    private string _prompt;
    private string _entry;
    private string _date;

    // constructor
    public Entry(string prompt, string entry, string date)
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

    // returns the prompt as a string
    public string getPrompt()
    {
        return _prompt;
    }

    // returns the entry as a string
    public string getEntry()
    {
        return _entry;
    }

    // returns the date as a string
    public string getDate()
    {
        return _date;
    }
}