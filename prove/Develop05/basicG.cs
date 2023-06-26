public class Basic : Goal
{
    // attributes
    private int _completePoints;
    private bool _finished;


    // constructor
    public Basic(string name, string description, int completePoints, bool finished = false) : base(name, description)
    {
        _completePoints = completePoints;
        _finished = finished;
    }

    // methods
    public override int addContinue()
    {
        _finished = true;
        return 1;
    }

    public override int getContinuePoints()
    {
        throw new NotImplementedException();
    }

    public override int getCompletePoints()
    {
        return _completePoints;
    }

    public override string stringifyInformation()
    {
        return $"Ba,{_name},{_description},{_completePoints},{_finished}";
    }

    public override bool getFinished()
    {
        return _finished;
    }

    public override int getNumberContinues()
    {
        throw new NotImplementedException();
    }
}