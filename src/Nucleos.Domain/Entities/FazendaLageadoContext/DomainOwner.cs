namespace Nucleos.Domain.Entities.FazendaLageadoContext;

public class DomainOwner : BaseEntity
{
    public DomainOwner(string tradingName, string socialName, string email, string documentNumber, int documentType)
    : base(tradingName, socialName)
    {
        Email = email;
        DocumentNumber = documentNumber;
        DocumentType = documentType;
    }
    public string Email { get; private set; }

    public string DocumentNumber { get; private set; }

    public int DocumentType { get; private set; }
    
    public void SetEmail(string email)
    {
        Email = email;
    }
}