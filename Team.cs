using System.Collections;

public class Team : IEnumerable<Ñharacter>
{
    private List<Ñharacter> characters;

    public Team() => characters = new List<Ñharacter> { };

    public void AddCharacter(Ñharacter ñharacter) => characters.Add(ñharacter);

    public void DeleteCharacter(Ñharacter ñharacter) => characters.Remove(ñharacter);

    public IEnumerator<Ñharacter> GetEnumerator()
    {
        foreach (var character in characters)
        {
            if (character.Health > 0)
                yield return character;
        }
    }
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}