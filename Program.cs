using Assignment_2;
using FunnyProject.Repository;

var characterRepo = new CharacterRepository<Сharacter>();

var mage = new Mage("Mage1", 5, 100, 50, 10);
var soldier = new Soldier("Soldier1", 12, 120, 15);

var team = new Team(characterRepo);
team.AddCharacter(mage);
team.AddCharacter(soldier);

var artifact = new Artifact("Artifactik", 15);

foreach (var character in team.GetAllActiveCharacters())
{
    artifact.ApplyTo(character);
}

var mageFromRepo = characterRepo.GetById(mage.Id);
Console.WriteLine($"Retrieved from repo before update: {mageFromRepo?.Name}");

if (mageFromRepo is not null)
{
    mageFromRepo.Name = "UpdatedMage1";
    characterRepo.Update(mageFromRepo);
}

var updatedMageFromRepo = characterRepo.GetById(mage.Id);
Console.WriteLine($"Retrieved from repo after update: {updatedMageFromRepo?.Name}");

Console.WriteLine("Team characters after update:");
foreach (var character in team.GetAllActiveCharacters())
{
    Console.WriteLine($"{character.Name} - Health: {character.Health}");
}