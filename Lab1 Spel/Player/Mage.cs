namespace Lab1_Spel
{
    public class Mage : Character
    {
        public Mage(string name)
        {
            hp = 80;
            maxHp = 80;
            dmg = 10;
            gold = 20;
            characterClass = "Mage";
            this.name = name;
        }
    }
}