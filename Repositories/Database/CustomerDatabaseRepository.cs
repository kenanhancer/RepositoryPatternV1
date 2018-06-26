using System.Threading.Tasks;

public class CustomerDatabaseRepository : DatabaseRepositoryBase<Customer>, ICustomerRepository
{
  public CustomerDatabaseRepository(IOrm orm) : base(orm, "customer", "id")
  {
  }
}