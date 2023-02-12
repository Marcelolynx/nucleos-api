using Nucleos.Domain.ValueObjects;

namespace Nucleos.Domain.Entities;

public class Farm : Profile
{
    public string FarmName { get; private set; }
    
    public string Ie { get; private set; }
    
    public string Cnpj { get; private set; }
    
    public Address Address { get; private set; }
    
    protected Farm(){}
   
    public override bool Validate()
    {
        throw new NotImplementedException();
    }
   
}