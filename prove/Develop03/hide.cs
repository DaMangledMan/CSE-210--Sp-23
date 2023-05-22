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
            int attempts = 0;
            while (true)
            {
                int index = rnd.Next(_scriptureLength);

                if (!_hiddenWords.Contains(index))
                {
                    _hiddenWords.Add(index);
                    break;
                }
                else if (attempts > _scriptureLength)
                {
                    break;
                }
                else
                {
                    continue;
                }
            }
        }
    }

    public string stringify()
    {
        List<string> listStringedScripture = new List<string>();
        int index = 0;
        foreach (string word in _scripture)
        {
            if (_hiddenWords.Contains(index))
            {
                string hiddenWord = new string('-', word.Length);
                listStringedScripture.Add(hiddenWord);
            }
            else 
            {
                listStringedScripture.Add(word);
            }
            index ++;
        }
        string stringedSripture = string.Join(" ", listStringedScripture);
        return stringedSripture;
    }

    public bool completelyHidden()
    {
        if (_hiddenWords.Count() - 1 >= _scriptureLength)
        {
            return true;
        }
        else 
        {
            return false;
        }
    }
}