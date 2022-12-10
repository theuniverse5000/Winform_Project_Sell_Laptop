using _1.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _1.DAL.Configurations
{
    internal class ImeiDaBanConfigurations : IEntityTypeConfiguration<ImeiDaBan>
    {
        public void Configure(EntityTypeBuilder<ImeiDaBan> builder)
        {
            builder.ToTable("ImeiDaBan");
            builder.HasKey(p => p.ID);
            builder.Property(a => a.IDHoaDonChiTiet).IsRequired();
            builder.Property(a => a.SoEmei).HasColumnName("SoImei").HasColumnType("varchar(70)").IsRequired();
            builder.HasOne(x => x.HoaDonChiTiet).WithMany().HasForeignKey(a => a.IDHoaDonChiTiet);
        }
    }
}
