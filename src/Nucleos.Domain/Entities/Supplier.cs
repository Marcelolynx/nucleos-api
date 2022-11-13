using Nucleos.Domain.ValueObjects;

namespace Nucleos.Domain.Entities;

public class Supplier : Entity
{
    public override bool Validation()
    {
        throw new NotImplementedException();
    }
    
    public Supplier(Name name, SocialName socialName) : base(name, socialName)
    {
    }
}