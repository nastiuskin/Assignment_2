using FunnyProject.Repository;
using System.Collections;

public class Team : IEnumerable<�haracter>
{
    private IRepository<�haracter> _repository;

    public Team(IRepository<�haracter> repository) => _repository = repository;

    public void AddCharacter(�haracter �haracter) => _repository.Add(�haracter);

    public IEnumerable<�haracter> GetAllActiveCharacters() => _repository.GetAll().Where(character => character.Health > 0);

    public IEnumerator<�haracter> GetEnumerator()
    {
        foreach (var character in _repository.GetAll())
        {
            if (character.Health > 0)
                yield return character;
        }
    }
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}