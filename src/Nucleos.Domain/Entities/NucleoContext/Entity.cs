namespace Nucleos.Domain.Entities;

public abstract class Entity
{
    protected Entity(Guid id, DateTime createdAt, DateTime updateddAt)
    {
        Id = id;
        CreatedAt = createdAt;
        UpdateddAt = updateddAt;
    }

    protected Entity()
    {
        
    }
    protected Entity(Guid id)
    {
        Id = id; 
    }
    public Guid Id { get; protected set; }
    
    public DateTime CreatedAt { get; protected set; }
    
    public DateTime UpdateddAt { get; protected set; }
    
}