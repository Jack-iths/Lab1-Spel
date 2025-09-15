
namespace Lab1_Spel
{
    public class Turns
    {
        public static void PlayerTurn(Enemies enemy, Character character)
        {
            int dmg = character.dmg;
            enemy.currentHp = Math.Max(0, enemy.currentHp - dmg);
            Console.WriteLine($"You hit {enemy.currentEnemyName} for {dmg}. Enemy HP: {enemy.currentHp}");
        }

        public static void EnemyTurn(Enemies enemy, Character character)
        {
            int enemyDmg = enemy.currentDamage;
            character.hp -= enemyDmg;
            Console.WriteLine($"{enemy.currentEnemyName} hits you for {enemyDmg}. Your HP: {character.hp}/{character.maxHp}");
        }
        public static void PlayerBlock(Enemies enemy, Character character)
        {
            int enemyDmg = enemy.currentDamage - 5;
            character.hp -= enemyDmg;
            Console.WriteLine($"You raise your shield and {enemy.currentEnemyName} hits you for {enemyDmg}. Your HP: {character.hp}/{character.maxHp}");
        }
    }
}
