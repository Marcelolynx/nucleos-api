using Nucleos.Domain.ValueObjects;

namespace Nucleos.Domain.Entities;

public class Client : Entity
{
    public Address Address { get; private set; }

    protected Client(){}

    public override bool Validate()
    {
        throw new NotImplementedException();
    }
}