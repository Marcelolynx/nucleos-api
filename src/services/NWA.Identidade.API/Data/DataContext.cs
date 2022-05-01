using Microsoft.EntityFrameworkCore;

namespace NWA.Identidade.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
    }
}
