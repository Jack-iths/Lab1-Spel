namespace Lab1_Spel;

public class Enemies
{
    public string currentEnemyName;
    public int currentHp;
    public int currentDamage;
    public int currentGold;

    public string[] enemies = new[]
    {
            "Shadow wraith", "Iron Golem", "Venomfang Spider", "Bone Reaper", "Fire Drake"
        };

    public Random random = new Random();

    public string GetRandomEnemy()
    {
        int randomIndex = random.Next(enemies.Length);
        currentEnemyName = enemies[randomIndex];
        currentHp = random.Next(30, 71);
        currentDamage = random.Next(4, 16);
        currentGold = random.Next(10, 21);
        return enemies[randomIndex];

    }
}


