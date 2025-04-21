namespace FunnyProject.Repository
{
    public interface IRepository<T> where T : Сharacter
    {
         T? GetById(Guid id);
         IEnumerable<T> GetAll();
         T Add(T entity);
         void Delete(T entity);
         void Update(T entity);         
    }
}
    