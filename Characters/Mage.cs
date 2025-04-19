using System;

public class Mage : Сharacter
{
    public int Mana { get; set; }
    public int ManaCostPerAttack { get; set; }
    public Mage(string name, int level,int health, int mana, int manaCostPerAttack)
		: base (name, level, health)
	{
        Mana = mana;
        ManaCostPerAttack = manaCostPerAttack;
	}

    public override void Attack(Сharacter target)
    {
        if (target == null || target == this || target.Health <= 0)
            return;

        if (Mana < ManaCostPerAttack)
        {
            Console.WriteLine($"{Name} does not have enough mana to attack");
            return;
        }

        int magicDamage = (Level * 3);
        Mana -= ManaCostPerAttack;
        target.TakeDamage(magicDamage);
    }

    public override object Clone() => 
        new Mage(this.Name, this.Level, this.Health, this.Mana, this.ManaCostPerAttack);  
}
