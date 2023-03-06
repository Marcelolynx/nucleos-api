namespace Nucleos.Domain.Entities;

public class Category : Entity
{
    public string Name { get; private set; }
    public override bool Validate()
    {
        throw new NotImplementedException();
    }
}