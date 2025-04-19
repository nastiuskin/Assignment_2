Сharacter mage = new Mage("Magecik1", 3, 100, 50, 10);
Сharacter soldier = new Soldier("Soldiercik1", 12, 120, 15);
Сharacter mage2 = new Mage("Magecik2", 10, 0, 50, 10);
Сharacter soldier2 = new Soldier("Soldiercik2", 12, 0, 15);

Console.WriteLine("Before Attack:");
Console.WriteLine($"{mage.Name} health: {mage.Health}");
Console.WriteLine($"{soldier.Name} health: {soldier.Health}");

mage.Attack(soldier);

Console.WriteLine("\nAfter Attack:");
Console.WriteLine($"{mage.Name} health: {mage.Health}");
Console.WriteLine($"{soldier.Name} health: {soldier.Health}");

var soldier3 = (Soldier)soldier.Clone();
var mage3 = (Mage)mage.Clone();

Team team = new Team();
team.AddCharacter(mage);
team.AddCharacter(mage2);
team.AddCharacter(soldier);
team.AddCharacter(soldier2);

Console.WriteLine("\nListik:");

foreach (var character in team)
{
    Console.WriteLine($"{character.Name} - Health: {character.Health}");
}