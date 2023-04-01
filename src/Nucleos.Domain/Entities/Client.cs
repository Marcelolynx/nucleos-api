using Nucleos.Domain.ValueObjects;
using Nucleos.Entities;

namespace Nucleos.Domain.Entities;

public class Client : Profile
{
    protected Client(){}

    public override bool Validate()
    {
        throw new NotImplementedException();
    }
}