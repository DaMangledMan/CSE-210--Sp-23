public class Journal
{
    csvEditor1 CSVE = new csvEditor1();
    
    // attributes
    private List<Entry> _oldJournal = new List<Entry> {};
    private List<Entry> _newJournal = new List<Entry> {};

    //constructor
    public Journal()
    {}

    // methods
    // Loads a file as the "old journal"
    public void loadOldJournal(string fileName)
    {
        List<Entry> csv = CSVE.Load(fileName);
        _oldJournal = csv;
    }

    // OverWrites an existing/Creates a new file with the contents of the old and new journal entries
    public void OverWrite(string fileName)
    {
        CSVE.OverWrite(fileName, _oldJournal, _newJournal);
    }

    // Appends to the end of an existing file with the contents of the new journal entries only
    public void Append(string fileName)
    {
        CSVE.Append(fileName, _newJournal);
    }

    // Displays information to terminal
    public void display()
    {
        foreach(Entry i in _oldJournal)
        {
            i.display();
        }

        foreach(Entry i in _newJournal)
        {
            i.display();
        }
    }

    // Adds an entry to the journal
    public void addEntry(string prompt, string entry)
    {
        Entry i = new Entry(prompt, entry, DateTime.Now.ToString());
        _newJournal.Add(i);
    }

    // returns the oldJournal as a list
    public List<Entry> getOldJournal()
    {
        return _oldJournal;
    }

    // returns the newJournal as a list
    public List<Entry> getNewJournal()
    {
        return _newJournal;
    }
}