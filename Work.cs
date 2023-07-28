public class Work
{
    public JobsList jobsList = new JobsList();
    //Level that the person is learning
    educationLevel CurrentEducation;
    //Level learned
    public educationLevel EducationLevelFinished = educationLevel.HighSchool;
    int yearsInSchool;
    int costOfSchool;
    bool currentEnrolled = false;
    int dept;
    public int CurrentSalary;
    public string CurrentJobName = "none";
    public void WorkMenu()
    {
        System.Console.WriteLine(
$@"
1) Education
2) Work
3) Business
4) Back
");

        switch (Console.ReadKey(true).Key)
        {
            case ConsoleKey.D1:
            case ConsoleKey.NumPad1:
                EducationMenu();
                break;

            case ConsoleKey.D2:
            case ConsoleKey.NumPad2:
                JobMenu();
                break;

            case ConsoleKey.D3:
            case ConsoleKey.NumPad3:
                BusinessMenu();
                break;

            case ConsoleKey.D4:
            case ConsoleKey.NumPad4:
                break;

            default:
                WorkMenu();
                break;
        }
    }

    void EducationMenu()
    {
        System.Console.WriteLine(
$@"
Education Level: {EducationLevelFinished}

1) Community College
2) University
3) Graduate School
4) Back
");
        switch (Console.ReadKey(true).Key)
        {
            case ConsoleKey.D1:
            case ConsoleKey.NumPad1:
                CommunityCollegeMenu();
                break;

            case ConsoleKey.D2:
            case ConsoleKey.NumPad2:
                UniversityMenu();
                break;

            case ConsoleKey.D3:
            case ConsoleKey.NumPad3:
                GradSchoolMenu();
                break;

            case ConsoleKey.D4:
            case ConsoleKey.NumPad4:
                WorkMenu();
                break;

            default:
                EducationMenu();
                break;
        }
    }

    void JobMenu()
    {
        jobsList.PrintJobsList();

        switch (Console.ReadKey(true).Key)
        {
            case ConsoleKey.NumPad0:
            case ConsoleKey.D0:
                SetJob(0);
                break;

            case ConsoleKey.D1:
            case ConsoleKey.NumPad1:
                SetJob(1);
                break;
            case ConsoleKey.E:
                break;

            default:
                JobMenu();
                break;
        }
    }

    void SetJob(int index)
    {
        if (EducationLevelFinished >= jobsList.ListofJobs[index].EducationRequired)
        {
            CurrentSalary = jobsList.ListofJobs[index].Salary;
            CurrentJobName = jobsList.ListofJobs[index].JobName;
        }
        else
        {
            System.Console.WriteLine("You Are Not Qualified For This Job");
            Console.ReadKey();
            JobMenu();
        }
    }

    void BusinessMenu()
    {

    }

    void CommunityCollegeMenu()
    {
        System.Console.WriteLine(
$@"
1) Enroll into Community College
2) Go Back
");

        switch (Console.ReadKey(true).Key)
        {
            case ConsoleKey.D1:
            case ConsoleKey.NumPad1:
                EnrollInCollege(educationLevel.CommunityCollege);
                break;

            case ConsoleKey.D2:
                break;

            default:
                CommunityCollegeMenu();
                break;
        }
    }

    void UniversityMenu()
    {
        System.Console.WriteLine(
$@"
1) Enroll into University
2) Go Back
");
        switch (Console.ReadKey(true).Key)
        {
            case ConsoleKey.D1:
            case ConsoleKey.NumPad1:
                EnrollInCollege(educationLevel.University);
                break;

            case ConsoleKey.D2:
                break;

            default:
                UniversityMenu();
                break;
        }

    }
    void GradSchoolMenu()
    {
        System.Console.WriteLine(
$@"
1) Enroll into Grad School
2) Go Back
");
        switch (Console.ReadKey(true).Key)
        {
            case ConsoleKey.D1:
            case ConsoleKey.NumPad1:
                EnrollInCollege(educationLevel.GradSchool);
                break;

            case ConsoleKey.D2:
                break;

            default:
                GradSchoolMenu();
                break;
        }
    }

    void EnrollInCollege(educationLevel currentEducation)
    {
        CurrentEducation = currentEducation;

        if (CurrentEducation == educationLevel.CommunityCollege)
        {
            if (EducationLevelFinished != educationLevel.CommunityCollege && EducationLevelFinished != educationLevel.University)
            {
                currentEnrolled = true;
                yearsInSchool = 2;
                costOfSchool += 10000;
            }
        }
        else if (CurrentEducation == educationLevel.University)
        {
            if (EducationLevelFinished == educationLevel.CommunityCollege && EducationLevelFinished != educationLevel.University)
            {
                yearsInSchool = 2;
                currentEnrolled = true;
            }
            else if (EducationLevelFinished != educationLevel.University)
            {
                yearsInSchool = 4;
                currentEnrolled = true;
            }

            costOfSchool += 10000 * yearsInSchool;
        }
        else if (CurrentEducation == educationLevel.GradSchool && EducationLevelFinished == educationLevel.University)
        {
            yearsInSchool = 2;
            currentEnrolled = true;
        }
    }

    public void CheckCurrentEducation()
    {
        if (yearsInSchool >= 1 && currentEnrolled)

        {
            yearsInSchool--;
        }
        if (currentEnrolled && yearsInSchool == 0)
        {
            currentEnrolled = false;
            dept += costOfSchool;
            EducationLevelFinished = CurrentEducation;
            CurrentEducation = educationLevel.None;
        }
    }
}

public enum educationLevel { None, HighSchool, CommunityCollege, University, GradSchool }