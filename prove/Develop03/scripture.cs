public class Scripture
{
    // attributes
    private string _header;
    private string _scripture;
    private List<string> _scriptureList = new List<string>();

    // constructor
    public Scripture(string header, string scripture)
    {
        _header = header;
        _scripture = scripture;
        _scriptureList = _scripture.Split(" ").ToList();
    }

    // methods
    public string getHeader()
    {
        return _header;
    }

    public string getScripture()
    {
        return _scripture;
    }

    public List<string> getScriptureList()
    {
        return _scriptureList;
    }
}