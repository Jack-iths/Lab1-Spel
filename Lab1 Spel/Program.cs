namespace Lab1_Spel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my mini adventure!");
            
            Console.WriteLine("Enter your Character's name:");
            string playerName = Console.ReadLine();

            Console.WriteLine("Choose your class (Warrior/Mage):");
            string chosenClass = Console.ReadLine();

            Character player;
            switch (chosenClass.ToLower())
            {
                case "Warrior":
                    player = new Warrior(playerName);
                    break;
                case "Mage":
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
}
