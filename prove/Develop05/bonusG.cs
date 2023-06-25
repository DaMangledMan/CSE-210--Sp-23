public class Bonus : Goal
{
    // attributes
    private int _continuePoints;
    private int _completePoints;
    private int _numberOfContinues;
    private int _continuesGoal;
    private bool _finished;

    // constructor
    public Bonus(string name, string description, int continuePoints, int completePoints, int continuesGoal, int numberOfContinues = 0, bool finished = false) : base(name, description)
    {
        _continuePoints = continuePoints;
        _completePoints = completePoints;
        _continuesGoal = continuesGoal;
        _numberOfContinues = numberOfContinues;
        _finished = finished;
    }

    // methods
    public void addContinue()
    {
        _numberOfContinues ++;
        if (_numberOfContinues >= _continuesGoal)
        {
            _finished = true;
        }
    }

    public int getContinuePoints()
    {
        return _continuePoints;
    }

    public int getCompletePoints()
    {
        return _completePoints;
    }

    public override string stringifyInformation()
    {
        return $"Bo,{_name},{_description},{_continuePoints},{_completePoints},{_continuesGoal},{_numberOfContinues},{_finished}";
    }
}