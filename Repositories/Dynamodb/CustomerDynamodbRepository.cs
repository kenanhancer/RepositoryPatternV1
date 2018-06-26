public class CustomerDynamodbRepository : DynamodbRepositoryBase<Customer>, ICustomerRepository
{
  public CustomerDynamodbRepository(IDynamodbClient dynamodbClient):base(dynamodbClient, "Customer", "id")
  {}
}