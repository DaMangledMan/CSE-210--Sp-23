public class Journal
{
    csvEditor CSVE = new csvEditor();
    
    // attributes
    private List<Entry> _oldJournal;
    private List<Entry> _newJournal;


    // methods
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
        Entry i = new Entry(prompt, entry, DateTime.Now);
        _newJournal.Add(i);
    }
}