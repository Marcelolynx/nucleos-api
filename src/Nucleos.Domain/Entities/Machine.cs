using Nucleos.Domain.Enums;
using Nucleos.Domain.ValueObjects;

namespace Nucleos.Domain.Entities;

public class Machine : Entity
{
    public string Brand { get; set; }
    
    public string model { get; set; }
    
    public DateTime YearModel { get; set; }
    
    public TypeFuel TypeFuel { get; set; } 
    
    public int Kilometer { get; set; }
    
    public override bool Validate()
    {
        throw new NotImplementedException();
    }
}