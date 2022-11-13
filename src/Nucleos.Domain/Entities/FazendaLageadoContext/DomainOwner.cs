using Nucleos.Domain.Validations;
using Nucleos.Domain.ValueObjects;

namespace Nucleos.Domain.Entities.FazendaLageadoContext;
public class DomainOwner : Entity
{
    public DomainOwner(SocialName socialName, string email, Document document)
    : base(socialName)
    {
        Email = email;
        Document = document;
    }
    public string Email { get; private set; }
    public Document Document { get; private set; }
    public void SetEmail(string email)
    {
        Email = email;
    }


    public override bool Validation()
    {
        if (string.IsNullOrEmpty(this.SocialName.CompanyName))
            return false;
        if (string.IsNullOrEmpty(this.SocialName.TradingName))
            return false;
        
        return true;
    }
}