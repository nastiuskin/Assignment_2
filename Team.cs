using FunnyProject.Repository;
using System.Collections;

public class Team : IEnumerable<Ñharacter>
{
    private IRepository<Ñharacter> _repository;

    public Team(IRepository<Ñharacter> repository) => _repository = repository;

    public void AddCharacter(Ñharacter ñharacter) => _repository.Add(ñharacter);

    public IEnumerable<Ñharacter> GetAllActiveCharacters() => _repository.GetAll().Where(character => character.Health > 0);

    public IEnumerator<Ñharacter> GetEnumerator()
    {
        foreach (var character in _repository.GetAll())
        {
            if (character.Health > 0)
                yield return character;
        }
    }
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}