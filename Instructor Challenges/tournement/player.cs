public class Player 
{
    // attributes
    private string _name;
    private string _position;
    private int _jerseyNumber;

    // constructor
    public Player(string name, int jerseyNumber, string position = "")
    {
        _name = name;
        _position = position;
        _jerseyNumber = jerseyNumber;
    }

    // methods
    public void setPosition(string position)
    {
        _position = position;
    }

    public void display()
    {
        Console.WriteLine($"{_name}, {_jerseyNumber}, {_position}");
    }
}