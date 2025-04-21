public abstract class Сharacter : ICloneable
{
    public Guid Id { get; init; }

    private string _name;
    private int _level;
    private int _health;

    public string Name
    {
        get => _name;
        set => _name = string.IsNullOrEmpty(value) ? "Unknown" : value;
    }

    public int Level
    {
        get => _level;
        set => _level = value > 0 ? value : 1;
    }

    public int Health
    {
        get => _health;
        set => _health = value < 0 ? 0 : value;
    }

    public Сharacter(string name, int level, int health)
    {
        _name = name;
        _level = level;
        _health = health;

    }

    public void Heal(int amount) => Health += amount;

    public void TakeDamage(int amount) => Health -= amount;

    public abstract void Attack(Сharacter target);
    public abstract object Clone();
}
