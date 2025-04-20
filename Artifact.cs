namespace Assignment_2
{
    public class Artifact
    {
        public const int MinRequiredLevel = 5;

        public string Name { get; init; }
        public int PowerBoost { get; set; }
        public Artifact(string name, int powerBoost = 10)
        {
            Name = name;
            PowerBoost = powerBoost;
        }
            
        public void ApplyTo(Сharacter target)
        {
            if (target.Level < MinRequiredLevel)
            {
                Console.WriteLine($"{target.Name} is not experienced enough to use {Name}");
                return;
            }

            if (target is Soldier soldier)
            {
                soldier.Strength += PowerBoost;
                Console.WriteLine($"{Name} has increased {soldier.Name}'s strength by {PowerBoost}");
                return;
            }

            else if (target is Mage mage)
            {
                mage.Mana += PowerBoost;
                Console.WriteLine($"{Name} has boosted {mage.Name}'s mana by {PowerBoost * 2}");
            }

            else
                Console.WriteLine($"{Name} has no effect on {target.Name}.");
        }

        public void ApplyTo(Сharacter target, int bonusBoost)
        {
            ApplyTo(target);
            Console.WriteLine($"{Name} gave an additional bonus of {bonusBoost} to {target.Name}.");
            target.Heal(bonusBoost);
        }
    }
}
