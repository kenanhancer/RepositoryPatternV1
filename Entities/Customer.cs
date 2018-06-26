public class Customer : IEntity
{
  public object Id { get; set; }
  
  public string Name { get; set; }
  
  public string Type { get; set; }
  
  public string Country { get; set; }
}