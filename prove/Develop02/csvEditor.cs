public class csvEditor
{

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
    public void OverWrite(string fileName, List<Entry> oldJournal, List<Entry> newJournal)
    {
        List<Entry> fullJournal = new List<Entry> {};

        foreach (Entry i in oldJournal)
        {
            fullJournal.Add(i);
        }
        foreach (Entry i in newJournal)
        {
            fullJournal.Add(i);
        }

        using (StreamWriter output = new StreamWriter(fileName))
        {
            foreach (Entry i in fullJournal)
            {
                output.WriteLine($"{i.getPrompt()},{i.getEntry()},{i.getDate()}");
            }
        }
    }

    // Appends the newJournal to the end of the csv file
    public void Append(string fileName, List<Entry> newJournal)
    {
        List<Entry> fullJournal = new List<Entry> {};
        
        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach(string line in lines)
        {
            string[] columns = line.Split(',');
            Entry i = new Entry(columns[0], columns[1], columns[2]);
            fullJournal.Add(i);
        }

        foreach (Entry i in newJournal)
        {
            fullJournal.Add(i);
        }


        using (StreamWriter output = new StreamWriter(fileName))
        {
            foreach (Entry i in fullJournal)
            {
                output.WriteLine($"{i.getPrompt()},{i.getEntry()},{i.getDate()}");
            }
        }
    }
}