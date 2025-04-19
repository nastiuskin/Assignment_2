using System.Collections;

public class Team : IEnumerable<�haracter>
{
    private List<�haracter> characters;

    public Team() => characters = new List<�haracter> { };

    public void AddCharacter(�haracter �haracter) => characters.Add(�haracter);

    public void DeleteCharacter(�haracter �haracter) => characters.Remove(�haracter);

    public IEnumerator<�haracter> GetEnumerator()
    {
        foreach (var character in characters)
        {
            if (character.Health > 0)
                yield return character;
        }
    }
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}