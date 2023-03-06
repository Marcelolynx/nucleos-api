using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders; 
using Nucleos.Entities;

namespace Nucleos.Infrastructure.Mappings;

public class AddressMap : IEntityTypeConfiguration<Address>
{
    public void Configure(EntityTypeBuilder<Address> builder)
    {
        builder.ToTable("tbl_address");

        builder.HasKey(x => x.Id);
        
        builder.Property(x => x.ZipCode)
                        .HasColumnName("zipcode")
                        .HasColumnType("VARCHAR(100)")
                        .HasMaxLength(100)
                        .IsRequired();
        
        builder.Property(x => x.Streat)
                        .HasColumnName("streat")
                        .HasColumnType("VARCHAR(255)")
                        .HasMaxLength(255)
                        .IsRequired();
        
        builder.Property(x => x.Number)
                        .HasColumnName("number")
                        .HasColumnType("VARCHAR(5)")
                        .HasMaxLength(5)
                        .IsRequired();
        
        builder.Property(x => x.Complement)
                        .HasColumnName("complement")
                        .HasColumnType("VARCHAR(150)")
                        .HasMaxLength(150)
                        .IsRequired();
        
        builder.Property(x => x.Neighborhood)
                        .HasColumnName("neighborhood")
                        .HasColumnType("VARCHAR(150)")
                        .HasMaxLength(150)
                        .IsRequired();
        
        builder.Property(x => x.City)
                        .HasColumnName("city")
                        .HasColumnType("VARCHAR(150)")
                        .HasMaxLength(150)
                        .IsRequired();
        
        builder.Property(x => x.State)
                        .HasColumnName("state")
                        .HasColumnType("VARCHAR(150)")
                        .HasMaxLength(150)
                        .IsRequired();
    }
    
}