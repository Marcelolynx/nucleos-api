using Nucleos.Domain.Entities;

namespace Nucleos.Infrastructure.Interfaces;

public interface IClientRepository : IEntityRepository<Client>
{
    Task<Employe> GetByEmail(string email);
    
    Task<List<Employe>> SearchByEmail(string email);
    
    Task<List<Employe>> SearchByName(string name);
}