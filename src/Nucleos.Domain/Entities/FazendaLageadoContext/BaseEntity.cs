namespace Nucleos.Domain.Entities.FazendaLageadoContext;

public abstract class BaseEntity
{
    protected BaseEntity(string tradingName, string socialName)
    {
        Id = Guid.NewGuid();
        CreatedAt = DateTime.UtcNow;
        TradingName = tradingName;
        SocialName = socialName; 
    }
    public Guid Id { get; private set; }
    public DateTime CreatedAt { get; private set; }
    
    public DateTime? UpdatedAt { get; private set; }
    public string TradingName { get; private set; }
    public string SocialName { get; private set; }
}