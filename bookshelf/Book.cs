public class Book
{
    private string _author;
    private string _name;
    private int _times_read = 0;
    private bool _available = true;

    public Book(string name, string author)
    {
        _author = author;
        _name = name;
    }

    public void Display()
    {
        Console.WriteLine($"{_name} by {_author}");
    }

    public bool is_available()
    {
        return _available;
    }

    public int times_read()
    {
        return _times_read;
    }
}