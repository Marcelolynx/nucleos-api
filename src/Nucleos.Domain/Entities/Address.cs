namespace Nucleos.Entities;

public class Address
{
    public Guid Id { get; private set; }
    public string Streat { get; private set; }
    public int Number { get; private set; }
    public string Complement { get; private set; }
    public string Neighborhood { get; private set; }
    public string City { get; private set; }
    public string State { get; private set; }
    public string ZipCode { get; private set; }

    public string latitude { get; private set; }
    
    public string longitude { get; private set; }
    
}