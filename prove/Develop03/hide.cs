public class Hide
{
    Random rnd = new Random ();

    // attributes
    private List<string> _scripture = new List<string>();
    private int _scriptureLength;
    private List<int> _hiddenWords = new List<int>();

    // constructor
    public Hide(List<string> scripture)
    {
        _scripture = scripture;
        _scriptureLength = _scripture.Count() - 1;
    }

    // methods
    public void hideThreeWords()
    {
        for (int i = 1; i >= 3; i++)
        {
            while (true)
            {
                int index = rnd.Next(_scriptureLength);

                if (!_hiddenWords.Contains(index))
                {
                    _hiddenWords.Add(index);
                    break;
                }
                else
                {
                    continue;
                }
            }
        }
    }
}