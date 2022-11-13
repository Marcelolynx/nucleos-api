using Nucleos.Domain.ValueObjects;

namespace Nucleos.Domain.Entities;

public class Fornecedor : Entity
{
    public string Name { get; set; } 
    public Document Document { get; private set; }
    public bool Active { get; set; }
    public Address Address { get; set; }
    public IEnumerable<Product> Products { get; set; }
}
