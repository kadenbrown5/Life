public interface IActivity
{
    public void DoSomething();
}

public class Activites
{
    Bike bike = new Bike();
    Chair chair = new Chair();
    public void ActivityMenu()
    {
        System.Console.WriteLine(
$@"
!) Ride a Bike
2) Sit on a Chair
E) Go Back
"
        );

        switch (Console.ReadKey(true).Key)
        {
            case ConsoleKey.D1:
            case ConsoleKey.NumPad1:
                bike.DoSomething();
                break;
            
            case ConsoleKey.NumPad2:
            case ConsoleKey.D2:
                chair.DoSomething();
                break;

            case ConsoleKey.E:
                break;

            default:
                ActivityMenu();
                break;
        }
    }

}

public class Bike : IActivity
{
    public void DoSomething()
    {
        System.Console.WriteLine("You rode a bike");
    }
}

public class Chair : IActivity
{
    public void DoSomething()
    {
        System.Console.WriteLine("You Sat in a Chair");
    }
}

