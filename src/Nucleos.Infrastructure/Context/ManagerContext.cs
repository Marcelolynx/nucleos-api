using Microsoft.EntityFrameworkCore;
using Nucleos.Domain.Entities;
using Nucleos.Infrastructure.Mappings;

namespace Nucleos.Infrastructure.Context;

public class ManagerContext : DbContext
{
    public ManagerContext(DbContextOptions<ManagerContext> options) : base(options)
    {
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(
            "Provider=PostgreSQL OLE DB Provider;Data Source=docker-ps;location=nucleos_db;User ID=postgres;password=mco02jgp");
    }
    public DbSet<Employe> Employes { get; set; }
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfiguration(new EmployeMap());
    }
}