public struct Jobs
{
    public int Salary;
    public string JobName;
    public educationLevel EducationRequired;

    public Jobs(string jobname, int salary, educationLevel educationRequired)
    {
        JobName = jobname;
        Salary = salary;
        EducationRequired = educationRequired;
    }
}


public class JobsList
{

    public List<Jobs> ListofJobs = new List<Jobs>();
    public void SetJobList()
    {
        ListofJobs.Add(new Jobs("Janitor", 15000, educationLevel.HighSchool));
        ListofJobs.Add(new Jobs("Software Engineer", 150000, educationLevel.University));
    }

    public void PrintJobsList()
    {
        Console.Clear();
        for (int i = 0; i < ListofJobs.Count; i++)
        {
            System.Console.WriteLine($"{i}) {ListofJobs[i].JobName} ${ListofJobs[i].Salary} Requires: {ListofJobs[i].EducationRequired}");
        }
        System.Console.WriteLine("E) Go Back");

    }
}