using _1.DAL.Models;

namespace _2.BUS.ViewModels
{
    public class HoaDonChiTietView
    {
        public Guid ID { get; set; }
        public string Ma { get; set; }
        public Guid IDHoaDon { get; set; }
        public Guid IDChiTietLapTop { get; set; }
        public int SoLuong { get; set; }
        public decimal GiaTruoc { get; set; }
        public DateTime NgayTao { get; set; }
        public decimal GiaSauKhiGiam { get; set; }
        public int TinhTrang { get; set; }
        public virtual HoaDon HoaDon { get; set; }
        public virtual ChiTietLaptop ChiTietLaptop { get; set; }
        public string SoImei { get; set; }
        public string MaHoaDon { get; set; }
        public string MaChiTietLaptop { get; set; }
        public decimal GiamGia { get; set; }
        public decimal GiaNhap { get; set; }
        public string MaNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public string SdtNhanVien { get; set; }
        public string SdtKhachHang { get; set; }
        public string TenKhachHang { get; set; }
        public string TenLaptop { get; set; }
        //     public string TenKhachHang{ get; set; }

    }
}
