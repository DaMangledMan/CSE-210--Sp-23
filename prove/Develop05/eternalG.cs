public class Eternal : Goal
{
    // attributes
    private int _continuePoints;
    private int _numberOfContinues;

    // constructor
    public Eternal(string name, string description, int continuePoints, int numberOfContinues = 0) : base(name, description)
    {
        _continuePoints = continuePoints;
        _numberOfContinues = numberOfContinues;
    }

    // methods
    public void addContinue()
    {
        _continuePoints ++;
    }

    public int getContinuePoints()
    {
        return _continuePoints;
    }

    public override string stringifyInformation()
    {
        return $"Et,{_name},{_description},{_continuePoints},{_numberOfContinues}";
    }
}