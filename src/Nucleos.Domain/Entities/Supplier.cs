using Nucleos.Domain.ValueObjects;

namespace Nucleos.Domain.Entities;

public class Supplier : Profile
{
    public string Cnpj { get; private set; }
    
    public override bool Validate()
    {
        throw new NotImplementedException();
    }
    //EF
    protected Supplier(){}
    
    
    
}