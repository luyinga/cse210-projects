using System;

public class Resume
{
    public string _name;
    //Make sure to initialize you list to a new list before you use it.
    public List<Job> _jobs = new List<Job>();
}
public void Display()
{
    Console.WriteLine($"Name: {_name}");
    Console.WriteLine($"Jobs: ");

    //Notice The use of costom data type "Job" in this loop.
    foreach (Job job in jobs)
    {
        //This calls the display methode on each job
        job.Display();
    }
}