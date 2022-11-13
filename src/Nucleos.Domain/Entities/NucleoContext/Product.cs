namespace Nucleos.Domain.Entities;

public class Product : Entity
{
    public int Id { get; private set; }
    public string Name { get; private set; }
    public string Description { get; private set; }
    public decimal Price { get; private set; }

}