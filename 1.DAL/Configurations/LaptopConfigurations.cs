using _1.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _1.DAL.Configurations
{
    internal class LaptopConfigurations : IEntityTypeConfiguration<Laptop>
    {
        public void Configure(EntityTypeBuilder<Laptop> builder)
        {
            builder.ToTable("Laptop");
            builder.HasKey(p => p.ID);
            builder.Property(a => a.Ten).HasColumnName("Ten").HasColumnType("nvarchar(50)").HasDefaultValue(null);
            builder.HasOne(p => p.HinhAnh).WithMany().HasForeignKey(p => p.IDHinhAnh); ;
        }
    }
}
