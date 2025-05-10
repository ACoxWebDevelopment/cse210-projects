public class Resume
{
    public string _name;
    public List<Job> myJobs = new List<Job>();

    public void DisplayResume()
    {
        Console.WriteLine(_name);
        Console.WriteLine("Jobs:");
        foreach (Job i in myJobs)
        {
            i.DisplayJob(); //because i is a datatype Job it has access to the DisplayJob method
        }
    }   
}