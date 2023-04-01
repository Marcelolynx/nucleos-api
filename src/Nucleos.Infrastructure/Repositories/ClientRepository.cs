using Nucleos.Domain.Entities;
using Nucleos.Infrastructure.Context;
using Nucleos.Infrastructure.Interfaces;

namespace Nucleos.Infrastructure.Repositories;

public class ClientRepository : EntityRepository<Client>, IClientRepository
{
    public ClientRepository(ManagerContext context) : base(context)
    {
    }

    public async Task<Employe> GetByEmail(string email)
    {
        throw new NotImplementedException();
    }

    public async Task<List<Employe>> SearchByEmail(string email)
    {
        throw new NotImplementedException();
    }

    public async Task<List<Employe>> SearchByName(string name)
    {
        throw new NotImplementedException();
    }
}