using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nucleos.Domain.Entities;

namespace Nucleos.Infrastructure.Mappings;

public class ClientMap : IEntityTypeConfiguration<Client>
{
    public void Configure(EntityTypeBuilder<Client> builder)
    {
        builder.ToTable("tbl_client");
        
        builder.HasKey(x => x.Id);
        
        builder.OwnsOne(x => x.NameProfile, nameprofile =>
        {
            nameprofile.Property(x => x.FirstName)
                .HasColumnName("first_name")
                .HasColumnType("VARCHAR(100)")
                .HasMaxLength(100)
                .IsRequired();

            nameprofile.Property(x => x.LastName)
                .HasColumnName("last_name")
                .HasColumnType("VARCHAR(100)")
                .HasMaxLength(100)
                .IsRequired();
        });
    }
}