namespace Lab1_Spel
{
    public class MainMenu
    {
        public bool keepPlaying = true;
        public Character player; 
        

        public MainMenu(Character character)
        {
            player = character;
        }

        public void Run()
        {
            while (keepPlaying)
            {
                ShowMenu();
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Starting Adventure");
                        Adventure adventure = new Adventure(player);
                        adventure.Run();
                        break;
                    case "2":
                        Console.WriteLine("Resting");
                        break;
                    case "3":
                        Console.WriteLine("Checking Status");
                        Console.WriteLine($"HP: {player.hp}/{player.maxHp}");
                        break;
                    case "4":
                        Console.WriteLine("Exiting game");
                        keepPlaying = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice, try again.");
                        break;
                }
            }
        }

        public void ShowMenu()
        {
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1. Adventure");
            Console.WriteLine("2. Rest");
            Console.WriteLine("3. Status");
            Console.WriteLine("4. Exit");
        }
    }
}
