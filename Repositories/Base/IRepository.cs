public interface IRepository<TEntity> where TEntity : class, IEntity, new()
{
  TEntity GetById(object id);
  void Create(TEntity entity);
  void Update(TEntity entity);
  void Delete(TEntity entity);
}