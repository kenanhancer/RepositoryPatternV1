using System;

class MainClass {
  public static void Main (string[] args) {
    
    IOrm orm = null;
    
    IDynamodbClient dynamodbClient = null;
    
    IProductRepository productRepo = new ProductDatabaseRepository(orm);
    
    ICustomerRepository customerRepo = new CustomerDatabaseRepository(orm);
    
    Product p1 = productRepo.GetById(3);
    
    Customer c1 = customerRepo.GetById(49);
    
    productRepo = new ProductDynamodbRepository(dynamodbClient);
    
    customerRepo = new CustomerDynamodbRepository(dynamodbClient);
    
    p1 = productRepo.GetById(3);
    
    c1 = customerRepo.GetById(49);
    
    Console.WriteLine ("Hello World");
  }
}