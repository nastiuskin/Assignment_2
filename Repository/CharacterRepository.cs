namespace FunnyProject.Repository
{
    public class CharacterRepository<T> : IRepository<T> where T : Сharacter
    {
        private readonly List<T> _characters = new();

        public T Add(T entity)
        {
            _characters.Add(entity);
            return entity;
        }

        public void Delete(T entity) => _characters.Remove(entity);

        public IEnumerable<T> GetAll() => _characters;

        public T? GetById(Guid id) => _characters.FirstOrDefault(c => c.Id == id);

        public void Update(T entity)
        {
            var index = _characters.FindIndex(x => x.Id == entity.Id);
            if (index < 0) return;
            _characters[index] = entity;
        }
    }
}