namespace Lab1_Spel
{
    public static class Screens
    {
        public static void ShowGameOver(Character character, int goldEarned = 0)
        {
            Console.Clear();
            Console.WriteLine("=== GAME OVER ===");
            Console.WriteLine($"Final HP: {Math.Max(0, character.hp)}/{character.maxHp}");
            Console.WriteLine($"Gold: {character.gold} (+{goldEarned})");
            Console.WriteLine();
            Console.WriteLine("Press Enter to return to exit...");
            Console.ReadLine();
            Environment.Exit(1);
        }
    }
}
