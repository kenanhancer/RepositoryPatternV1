public class ProductDatabaseRepository : DatabaseRepositoryBase<Product>, IProductRepository
{
  public ProductDatabaseRepository(IOrm orm) : base(orm, "product", "id")
  {
  }
}