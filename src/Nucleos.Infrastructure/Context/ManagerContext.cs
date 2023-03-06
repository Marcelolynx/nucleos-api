using Microsoft.EntityFrameworkCore;
using Nucleos.Domain.Entities;
using Nucleos.Infrastructure.Mappings;

namespace Nucleos.Infrastructure.Context;

public class ManagerContext : DbContext
{
    public ManagerContext()
    {
        
    }
    public ManagerContext(DbContextOptions<ManagerContext> options) : base(options)
    {
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source=localhost;Database=nucleos_db;User Id=sa;Password=Mco02Jgp!;TrustServerCertificate=True;Encrypt=false");
    } 
    public DbSet<Employe> Employes { get; set; }
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfiguration(new EmployeMap());
    }
}