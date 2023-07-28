public record Property(string name, int price, int revenue);


public class Assets
{
    public List<Property> ListofProperties = new List<Property>();
    public List<Property> OwnedProperties = new List<Property>();
    public void AssetsMenu()
    {
        System.Console.WriteLine(
$@"
1) Owned Properties
2) Properties For Sale
E) Go Back
"
        );
        switch (Console.ReadKey(true).Key)
        {
            case ConsoleKey.D1:
            case ConsoleKey.NumPad1:
            OwnedPropertiesMenu();
            break;

            case ConsoleKey.D2:
            case ConsoleKey.NumPad2:
            PurchaseablePropertiesMenu();
            break;

            case ConsoleKey.E:
            break;

            default:
            AssetsMenu();
            break;
        }

    }

    void PurchaseablePropertiesMenu()
    {
        PrintHouseList();
        switch (Console.ReadKey(true).Key)
        {
            case ConsoleKey.D0:
            case ConsoleKey.NumPad0:
            PurchaseProperty(0);
            break;

            case ConsoleKey.E:
            break;

            default:
            PurchaseablePropertiesMenu();
            break;
        }
    }

    public void SetProperties()
    {
        ListofProperties.Add(new Property("trailer", 10000, 2000));
    }

    void PrintHouseList()
    {
        for(int i = 0; i < ListofProperties.Count(); i++)
            System.Console.WriteLine($"{i}) {ListofProperties[i].name} ${ListofProperties[i].price}");;
        System.Console.WriteLine("E) Go Back");
    }

    void PurchaseProperty(int index)
    {
        OwnedProperties.Add(ListofProperties[index]);
        ListofProperties.RemoveAt(index);
    }

    void OwnedPropertiesMenu()
    {
        PrintPurchasedHouses();
        switch (Console.ReadKey(true).Key)
        {
            case ConsoleKey.E:
            break;

            default:
            AssetsMenu();
            break;
        }

    }

    void PrintPurchasedHouses()
    {
        for(int i = 0; i < OwnedProperties.Count(); i++)
            System.Console.WriteLine($"{i}) {OwnedProperties[i].name} ${OwnedProperties[i].price}");;
        System.Console.WriteLine("E) Go Back");
    }

}