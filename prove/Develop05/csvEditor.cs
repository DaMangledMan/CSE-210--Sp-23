public class csvEditor
{

    // methods
    // Loads the csv file as List<List<string>> 
    public List<List<string>> Load(string fileName)
    {
        List<List<string>> fullList = new List<List<string>>();

        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach(string line in lines)
        {
            string[] columns = line.Split(',');
            List<string> columnList = new List<string>();
            foreach (string column in columns)
            {
                columnList.Add(column);
            }
            fullList.Add(columnList);
        }

        return fullList;
    }

    // Overwrites any file of the same name with a List<string> input
    public void OverWrite(string fileName, List<string> fullList)
    {
        using (StreamWriter output = new StreamWriter(fileName))
        {
            foreach (string i in fullList)
            {
                output.WriteLine(i);
            }
        }
    }
}