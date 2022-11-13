using Nucleos.Domain.ValueObjects;

namespace Nucleos.Domain.Entities;

public class Employe : Entity
{

    public override bool Validation()
    {
        throw new NotImplementedException();
    }

    public Employe(Name name, SocialName socialName, string email) : base(name, socialName, email)
    {
    }
}