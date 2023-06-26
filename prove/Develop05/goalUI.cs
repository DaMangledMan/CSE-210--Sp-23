public abstract class Goal
{
    // attributes
    protected string _name;
    protected string _description;

    // constructor
    public Goal(string name, string description)
    {
        _name = name;
        _description = description;
    }

    // methods
    public abstract int addContinue();

    public abstract string stringifyInformation();

    public abstract int getContinuePoints();

    public abstract int getCompletePoints();

    public abstract bool getFinished();

    public abstract int getNumberContinues();

    public string getName()
    {
        return _name;
    }

    public string getDescription()
    {
        return _description;
    }
}