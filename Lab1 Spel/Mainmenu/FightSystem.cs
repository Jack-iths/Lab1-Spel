namespace Lab1_Spel
{
    internal class FightSystem
    {
        public static void Fight(Enemies enemyManager, Character character)
        {
            bool isFighting = true;
            Console.WriteLine($"Time to fight {enemyManager.currentEnemyName}");
            while (character.hp > 0 && enemyManager.currentHp > 0 && isFighting)
            {
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("1. Fight");
                Console.WriteLine("2. Defend");
                Console.WriteLine("3. Run Away");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Turns.PlayerTurn(enemyManager, character);
                        if (enemyManager.currentHp <= 0)
                        {
                            Console.WriteLine($"Congratulations you have won and gained {enemyManager.currentGold} Gold Pieces");
                            character.gold += enemyManager.currentGold;
                            break;
                        }

                        Turns.EnemyTurn(enemyManager, character);
                        if (character.hp <= 0)
                        {
                            Console.WriteLine("You died, Game Over.");
                            Screens.ShowGameOver(character);
                            isFighting = false;
                        }
                        break;

                    case "2":
                        Turns.PlayerBlock(enemyManager, character);
                        break;

                    case "3":
                        Console.WriteLine("You ran away!");
                        isFighting = false;
                        break;
                }
            }
        }





    }
}

