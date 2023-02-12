using Nucleos.Domain.Enums;
using Nucleos.Domain.ValueObjects;

namespace Nucleos.Domain.Entities;

public class Owner : Profile
{
    public TypeEntity TypeEntity { get; set; }
    
    public string Cpf { get; set; }
    
    public string Cnpj { get; set; }
    
    public string Rg { get; set; }
    
    public string issuer { get; set; }

    public Address Address { get; set; }
    

    public override bool Validate()
    {
        throw new NotImplementedException();
    }
    protected Owner(){}
}