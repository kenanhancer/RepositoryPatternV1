using System.Threading.Tasks;

public abstract class DatabaseRepositoryBase<TEntity> : IRepository<TEntity> where TEntity : class, IEntity, new()
{
  private readonly IOrm _orm;
  private readonly string _tableName;
  private readonly string _primaryKey;

  public IOrm Orm => _orm;

  public DatabaseRepositoryBase(IOrm orm, string tableName, string primaryKey)
  {
      _orm = orm;
      _tableName = tableName;
      _primaryKey = primaryKey;
  }

  public void Create(TEntity entity)
  {
      // _orm.dyno.Insert(table: _tableName, pkField: _primaryKey, args: entity);
  }

  public void Delete(TEntity entity)
  {
      // _orm.dyno.Delete(table: _tableName, args: entity);
  }

  public TEntity GetById(object id)
  {
      return new TEntity();
  }

  public void Update(TEntity entity)
  {
      // _orm.dyno.Update(table: _tableName, pkField: _primaryKey, args: entity);
  }
}