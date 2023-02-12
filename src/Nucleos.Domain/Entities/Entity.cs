using Nucleos.Domain.ValueObjects;

namespace Nucleos.Domain.Entities;

public abstract class Entity 
{
    public Guid Id { get; private set; }
    
    public DateTime CreatedAt { get; private set; }
    
    public DateTime? UpdatedAt { get; private set; }
    
    internal List<string> _errors = new List<string>();
    public abstract bool Validate();

    private IReadOnlyCollection<string> Error => _errors;

    //EF
    protected Entity(){}

}