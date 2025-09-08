namespace Lab1_Spel
{
    public class Warrior : Character
    {
        public Warrior(string name)
        {
            hp = 100;
            maxHp = 100;
            dmg = 5;
            gold = 20;
            characterClass = "Warrior";
            this.name = name;
        }
    }
}