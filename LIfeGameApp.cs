public class LifeGameApp
{
    Activites activites = new Activites();
    Work work = new Work();
    Assets assets = new Assets();
    Relationships relationships = new Relationships();
    int _age = 18;
    int _money;

    public void Run()
    {
        work.jobsList.SetJobList();
        assets.SetProperties();
        System.Console.WriteLine(
@"
Welcome to the game of life, You start at age 18, Your job is to Learn, Work, and Grow as a person");

        MenuApp();
    }

    void MenuApp()
    {
        System.Console.WriteLine(
$@"
Age: {_age} Years Old
Money: ${_money};
Job: {work.CurrentJobName}
Education: {work.EducationLevelFinished}

1) Age Up
2) Work
3) Assets
4) Relationships
5) Activities
6) Quit
");

        switch (Console.ReadKey(true).Key)
        {
            case ConsoleKey.NumPad1:
            case ConsoleKey.D1:
                AgeUp();
                break;

            case ConsoleKey.NumPad2:
            case ConsoleKey.D2:
                work.WorkMenu();
                MenuApp();
                break;

            case ConsoleKey.NumPad3:
            case ConsoleKey.D3:
                assets.AssetsMenu();
                MenuApp();
                break;

            case ConsoleKey.NumPad4:
            case ConsoleKey.D4:
                relationships.RelationshipsMenu();
                MenuApp();
                break;

            case ConsoleKey.NumPad5:
            case ConsoleKey.D5:
                activites.ActivityMenu();
                MenuApp();
                break;

            case ConsoleKey.NumPad6:
            case ConsoleKey.D6:
                Environment.Exit(0);
                break;

            default:
                MenuApp();
                break;
        }
    }

    void AgeUp()
    {
        Console.Clear();
        _age++;
        MoneyStuff(work.CurrentSalary);
        work.CheckCurrentEducation();
        relationships.IncreaseBar();
        RelationshipMoney(relationships.moneyToAward, relationships.relationshipBar, relationships.nextLevelRequirement);
        relationships.AfterIncrease();
        MenuApp();
    }

    void MoneyStuff(int _salary)
    {
        _salary = _salary * 70 / 100;
        _money += _salary;
    }

    void RelationshipMoney(int moneytoGift, int barFirst, int barLast)
    {
        if (barFirst >= barLast)
        {
            _money += moneytoGift;
        }
    }

}