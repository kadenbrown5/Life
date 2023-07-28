public class Relationships
{
    public int relationshipBar = 0;
    public int relationshipLevel = 1;
    public int nextLevelRequirement = 100;
    public int moneyToAward = 100;

    public void RelationshipsMenu()
    {
        System.Console.WriteLine(
$@"
Relationship Level {relationshipLevel}: [{relationshipBar}/{nextLevelRequirement}]

Next Reward [${moneyToAward}]

Father Gives 5 Points per Year
Mother Gives 5 Points per Year
Brother Gives 3 Points per Year
Sister Gives 3 Points per Year
Significant Other gives 4 Points per Year

E) Go Back
"
        );
    }

    public void IncreaseBar()
    {
        relationshipBar += 20;
    }

    public void AfterIncrease()
    {
        if (relationshipBar >= nextLevelRequirement)
        {
            relationshipBar = 0;
            nextLevelRequirement *= 2;
            moneyToAward *= 2;
            relationshipLevel++;
        }
    }
}





