using _1.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _1.DAL.Configurations
{
    internal class HoaDonConfigurations : IEntityTypeConfiguration<HoaDon>
    {
        public void Configure(EntityTypeBuilder<HoaDon> builder)
        {
            builder.ToTable("HoaDon");
            builder.HasKey(a => a.ID);
            builder.Property(a => a.IdKhachHang).HasDefaultValue(null);
            builder.Property(a => a.IdNhanVien).IsRequired();
            builder.Property(a => a.IdVoucher).HasDefaultValue(null);
            builder.Property(a => a.Ma).HasColumnName("Ma").HasColumnType("varchar(30)").IsRequired();
            builder.Property(a => a.NgayTao).HasColumnName("NgayTao").HasColumnType("datetime").IsRequired();
            builder.Property(a => a.TenNguoiNhan).HasColumnName("TenNguoiNhan").HasColumnType("nvarchar(50)").HasDefaultValue(null);
            builder.Property(a => a.SdtNguoiNhan).HasColumnName("SdtNguoiNhan").HasColumnType("varchar(20)").HasDefaultValue(null);
            builder.Property(a => a.TinhTrang).HasColumnName("TinhTrang").HasColumnType("int").HasDefaultValue(0);
            builder.HasOne(x => x.KhachHang).WithMany().HasForeignKey(a => a.IdKhachHang);
            builder.HasOne(x => x.NhanVien).WithMany().HasForeignKey(a => a.IdNhanVien);
            builder.HasOne(x => x.Voucher).WithMany().HasForeignKey(a => a.IdVoucher);
        }
    }
}
