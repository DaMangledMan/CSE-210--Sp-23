public class Journal
{
    csvEditor CSVE = new csvEditor();
    
    // attributes
    private List<Entry> _oldJournal;
    private List<Entry> _newJournal;


    // methods
    // Loads a file as the "old journal"
    public void loadOldJournal(string fileName)
    {
        List<Entry> csv = CSVE.Load(fileName);
        _oldJournal = csv;
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