public class csvEditor
{
    Journal journal = new Journal();



    // methods
    // Loads the csv file as List<Entry> 
    public List<Entry> Load(string fileName)
    {
        List<Entry> oldJournal = new List<Entry>();
        
        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach(string line in lines)
        {
            string[] columns = line.Split(',');
            Entry i = new Entry(columns[0], columns[1], columns[2]);
            oldJournal.Add(i);
        }

        return oldJournal;
    }

    // Overwrites any file of the same name with both oldJournal and newJournal
    public void OverWrite(string fileName)
    {
        List<Entry> oldJournal = journal.getOldJournal();
        List<Entry> newJournal = journal.getNewJournal();

        foreach (Entry i in newJournal)
        {
            oldJournal.Add(i);
        }

        List<Entry> fullJournal = oldJournal;

        using (StreamWriter output = new StreamWriter(fileName))
        {
            foreach (Entry i in fullJournal)
            {
                output.WriteLine($"{i.getPrompt()},{i.getEntry()},{i.getDate()}");
            }
        }
    }

    // Appends the newJournal to the end of the csv file
    public void Append(string fileName)
    {
        List<Entry> oldJournal = new List<Entry>();
        List<Entry> newJournal = journal.getNewJournal();
        
        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach(string line in lines)
        {
            string[] columns = line.Split(',');
            Entry i = new Entry(columns[0], columns[1], columns[2]);
            oldJournal.Add(i);
        }

        foreach (Entry i in newJournal)
        {
            oldJournal.Add(i);
        }

        List<Entry> fullJournal = oldJournal;

        using (StreamWriter output = new StreamWriter(fileName))
        {
            foreach (Entry i in fullJournal)
            {
                output.WriteLine($"{i.getPrompt()},{i.getEntry()},{i.getDate()}");
            }
        }
    }
}