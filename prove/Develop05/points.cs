public class Points
{
    // attributes
    private int _pointTotal = 0;

    // constructor
    // n/a

    // methods
    public void setPointTotal(int points)
    {
        _pointTotal = points;
    }

    public void addPoints(int points)
    {
        _pointTotal += points;
    }

    public int getPointTotal()
    {
        return _pointTotal;
    }
}