public class ProductDynamodbRepository : DynamodbRepositoryBase<Product>, IProductRepository
{
  public ProductDynamodbRepository(IDynamodbClient dynamodbClient):base(dynamodbClient, "Product", "id")
  {}
}