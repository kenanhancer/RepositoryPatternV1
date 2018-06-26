public abstract class DynamodbRepositoryBase<TEntity> : IRepository<TEntity> where TEntity : class, IEntity, new()
{
  private readonly IDynamodbClient _dynamodbClient;
  private readonly string _tableName;
  private readonly string _hashKey;

  public IDynamodbClient DynamodbClient => _dynamodbClient;

  public DynamodbRepositoryBase(IDynamodbClient dynamodbClient, string tableName, string hashKey)
  {
      _dynamodbClient = dynamodbClient;
      _tableName = tableName;
      _hashKey = hashKey;
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