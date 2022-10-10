namespace Nucleos.Domain.Entities;

public abstract class BaseEntity
{
    protected BaseEntity()
    {
        Id = Guid.NewGuid();
        CreatedAt =DateTime.UtcNow;
    }
    public Guid Id { get; private set; }

    public DateTime CreatedAt { get; private set; }
    
}