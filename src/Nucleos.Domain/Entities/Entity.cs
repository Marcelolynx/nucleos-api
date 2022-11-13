using Nucleos.Domain.ValueObjects;

namespace Nucleos.Domain.Entities;

public abstract class Entity 
{
    protected Entity(Name name, SocialName socialName, string Email)
    {
        Id = Guid.NewGuid();
        CreatedAt = DateTime.UtcNow;
        Name = name;
        SocialName = socialName;
        Email = email;
    }
    
    protected Entity(Name name, SocialName socialName)
    {
        Id = Guid.NewGuid();
        CreatedAt = DateTime.UtcNow;
        Name = name;
        SocialName = socialName; 
    }
    
    protected Entity(Name name)
    {
        Id = Guid.NewGuid();
        CreatedAt = DateTime.UtcNow;
        Name = name; 
    }
    public Guid Id { get; private set; }
    public DateTime CreatedAt { get; private set; }
    
    public DateTime? UpdatedAt { get; private set; }
    public Name? Name { get; private set; }
    public SocialName SocialName { get; private set; }
    public string? email { get; private set; }
    public abstract bool Validation();
    
    internal List<string> _errors = new List<string>();

    private IReadOnlyCollection<string> Error => _errors;


}