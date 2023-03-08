using _1.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _1.DAL.Configurations
{
    public class HinhAnhConfigurations : IEntityTypeConfiguration<HinhAnh>
    {
        public void Configure(EntityTypeBuilder<HinhAnh> builder)
        {
            builder.ToTable("HinhAnh");
            // builder.HasKey(x => new { x.IDHoaDon, x.IDChiTietLapTop });
            builder.HasKey(x => x.Id);
            builder.Property(a => a.Ma).HasColumnName("Ma").HasColumnType("varchar(30)").IsRequired();
            builder.Property(p => p.Ten).HasColumnName("Ten").HasColumnType("nvarchar(100)").HasDefaultValue(null);
            builder.Property(p => p.HAnh).HasColumnName("Anh").HasColumnType("image").IsRequired();

        }
    }
}
