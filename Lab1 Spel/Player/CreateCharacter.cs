using Lab1_Spel;

public class CreateCharacter
{
    public Character player;
    public string playerName;

    public void RunCreation()
    {
        Console.WriteLine("Enter your Character's name:");
        playerName = Console.ReadLine();
        Console.WriteLine("Choose your class (Warrior/Mage):");
        string chosenClass = Console.ReadLine();
        chosenClass = chosenClass.ToLower();

        switch (chosenClass)
        {
            case "warrior":
                player = new Warrior(playerName);
                break;
            case "mage":
                player = new Mage(playerName);
                break;
            default:
                Console.WriteLine("No class selected, you will start as the Hobo");
                player = new Hobo(playerName);
                break;
        }
        Console.WriteLine($"Welcomme, {playerName} the {player.characterClass}!");
    }
}
