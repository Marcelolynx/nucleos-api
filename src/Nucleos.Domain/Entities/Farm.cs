using Nucleos.Domain.ValueObjects;

namespace Nucleos.Domain.Entities;

public class Farm : Entity
{
    public Farm(Name name, SocialName socialName, string email) : base(name, socialName, email)
    {
    }

    public override bool Validation()
    {
        throw new NotImplementedException();
    }
}