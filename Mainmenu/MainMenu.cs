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
                        Enemies enemyManager = new Enemies();
                        string enemyName = enemyManager.GetRandomEnemy();
                        Console.WriteLine("Enemy: " + enemyName);
                        Console.WriteLine("HP: " + enemyManager.currentHp);
                        FightSystem.Fight(enemyManager, player);
                        break;
                    case "2":
                        Console.WriteLine("Resting");
                        if (player.hp >= player.maxHp)
                        {
                            Console.WriteLine("You don't need to rest");
                        }
                        else
                        {
                            player.hp += 15;
                            player.hp = Math.Min(player.hp, player.maxHp);
                            Console.Write($"You rested and healed 15 hit points your health is now {player.hp}/{player.maxHp}");
                        }
                        break;
                    case "3":
                        Console.WriteLine("Checking Status");
                        Console.WriteLine($"You have {player.hp}/{player.maxHp} hit points and you have {player.gold} gold");
                        break;
                    case "4":
                        Console.WriteLine("Exiting game");
                        keepPlaying = false;
                        Environment.Exit(1);
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
            Console.WriteLine("1. Fight");
            Console.WriteLine("2. Rest");
            Console.WriteLine("3. Status");
            Console.WriteLine("4. Exit");
        }
    }
}
