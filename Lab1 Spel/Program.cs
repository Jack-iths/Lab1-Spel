namespace Lab1_Spel
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Realm of shadows!");
            
            Console.WriteLine("Enter your Character's name:");
            string playerName = Console.ReadLine();

            Console.WriteLine("Choose your class (Warrior/Mage):");
            string chosenClass = Console.ReadLine();

            Character player;
            switch (chosenClass.ToLower())
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
            MainMenu menu = new MainMenu(player);
            menu.Run();
        }
    }
}
