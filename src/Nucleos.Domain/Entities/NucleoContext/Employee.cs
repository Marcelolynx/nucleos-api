using Nucleos.Domain.Enums;

namespace Nucleos.Domain.Entities;

public class Employee : Entity
{
    public EGender Gender { get; private set; }
    public string Name { get; private set; }
    public string LastName { get; private set; }
}