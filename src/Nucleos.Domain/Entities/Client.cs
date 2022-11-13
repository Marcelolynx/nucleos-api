using Nucleos.Domain.ValueObjects;

namespace Nucleos.Domain.Entities;

public class Client : Entity
{
    public string Email { get; private set; } 

    public override bool Validation()
    {
        throw new NotImplementedException();
    }
    
    public Client(Name name, SocialName socialName) : base(name, socialName)
    {
        
    }
    
    public Client(Name name, SocialName socialName, string email) : base(name, socialName)
    {
        Email = email;
        _errors = new List<string>();
    }

}