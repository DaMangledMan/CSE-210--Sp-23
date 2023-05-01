public class Resume
{
    string _name;
    List<Job> _jobs;


    public Resume (string name, List<Job> jobs)
    {
        _name = name;
        _jobs = jobs;
    }


    public void display()
    {
        Console.WriteLine($"\n\n{_name}\njobs:");
        foreach (Job i in _jobs)
        {
            i.display();
        }
        Console.WriteLine("\n\n");
    }
}