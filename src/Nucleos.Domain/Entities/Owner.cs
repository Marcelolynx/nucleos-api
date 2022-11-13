using Nucleos.Domain.Enums;
using Nucleos.Domain.ValueObjects;

namespace Nucleos.Domain.Entities;

public class Owner : Entity
{
    public Owner(Name name, SocialName socialName, string email) : base(name, socialName, email)
    {
    }

    public override bool Validation()
    {
        throw new NotImplementedException();
    }
    
    public TypeEntity TipoPessoa { get; set; }
    
    public string Cpf { get; set; }
    
    public string Cnpj { get; set; }
    
    
}