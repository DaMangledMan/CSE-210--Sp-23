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
    public override int addContinue()
    {
        _continuePoints ++;
        return 2;
    }

    public override int getContinuePoints()
    {
        return _continuePoints;
    }

    public override int getCompletePoints()
    {
        throw new NotImplementedException();
    }

    public override string stringifyInformation()
    {
        return $"Et,{_name},{_description},{_continuePoints},{_numberOfContinues}";
    }

    public override bool getFinished()
    {
        throw new NotImplementedException();
    }

    public override int getNumberContinues()
    {
        return _numberOfContinues;
    }

    public override void printInformation()
    {
        Console.WriteLine($"Et, {_name}, {_description}, {_continuePoints}, {_numberOfContinues}\n");
    }
}