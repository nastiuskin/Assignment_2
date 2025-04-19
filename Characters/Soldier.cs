public class Soldier : Сharacter
{
    public int Strength { get; set; }
    public Soldier(string name, int level, int health, int strength)
        : base(name, level, health)
    {
        Strength = strength > 0 ? strength : 5;
    }

    public override void Attack(Сharacter target)
    {
        if (target == null || target == this || target.Health <= 0)
            return;

        int damage = Strength + (Level * 2);
        target.TakeDamage(damage);
    }

    public override object Clone() =>
         new Soldier(this.Name, this.Level, this.Health, this.Strength);
}
