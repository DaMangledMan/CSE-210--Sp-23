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
    public void setFinished()
    {
        _finished = true;
    }

    public int getCompletePoints()
    {
        return _completePoints;
    }

    public override string stringifyInformation()
    {
        return $"Ba,{_name},{_description},{_completePoints},{_finished}";
    }
}