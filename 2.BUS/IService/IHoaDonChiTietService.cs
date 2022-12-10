using _2.BUS.ViewModels;

namespace _2.BUS.IService
{
    public interface IHoaDonChiTietService
    {
        string Add(HoaDonChiTietView hdctview);
        string Update(HoaDonChiTietView hdctview);
        string Delete(HoaDonChiTietView hdctview);
        //bool CheckMa(string ma);
        string UpdateTrangThai(HoaDonChiTietView hdctview);
        List<HoaDonChiTietView> GetHoaDonChiTiet();
        public List<HoaDonChiTietView> GetHoaDonChiTietNoJoin();
        bool CheckMa(string mahdct);
        bool CheckMaCTLT(string mactlt);
        List<HoaDonChiTietView> GetHoaDonChiTietJoinNhanVien();
        List<HoaDonChiTietView> GetHoaDonChiTietAllData();
    }
}
