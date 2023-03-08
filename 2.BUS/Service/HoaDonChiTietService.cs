using _1.DAL.IRepositories;
using _1.DAL.Models;
using _1.DAL.Repositories;
using _2.BUS.IService;
using _2.BUS.ViewModels;

namespace _2.BUS.Service
{
    public class HoaDonChiTietService : IHoaDonChiTietService
    {
        IHoaDonChiTietRepositories hoaDonChiTietRepositories = new HoaDonChiTietRepositories();
        IChiTietLaptopRepositories chiTietLaptopRepositories = new ChiTietLaptopRepositories();
        IHoaDonRepositories hoaDonRepositories = new HoaDonRepositories();
        IImeiDaBanRepositories imeiDaBanRepositories = new ImeiDaBanRepositories();
        INhanVienRepositories nhanVienRepositories = new NhanVienRepositories();
        IKhachHangRepositories khachHangRepositories = new KhachHangRepositories();
        ILaptopService laptopService = new LaptopService();
        public string Add(HoaDonChiTietView hdctview)
        {
            if (hdctview == null) return "Thất bại";
            HoaDonChiTiet hct = new HoaDonChiTiet();
            hct.ID = hdctview.ID;
            hct.Ma = hdctview.Ma;
            hct.IDChiTietLapTop = hdctview.IDChiTietLapTop;
            hct.IDHoaDon = hdctview.IDHoaDon;
            hct.NgayTao = hdctview.NgayTao;
            hct.SoLuong = hdctview.SoLuong;
            hct.GiaTruoc = hdctview.GiaTruoc;
            if (hoaDonChiTietRepositories.Add(hct)) return "Thành công";
            else return "Thất bại";
        }

        public bool CheckMa(string mahdct)
        {
            var a = hoaDonChiTietRepositories.GetHoaDonChiTiet();
            var linh = a.FirstOrDefault(a => a.Ma == mahdct);
            if (a != null)
                return true;
            else return false;

        }

        public bool CheckMaCTLT(string mactlt)
        {
            var huyen = chiTietLaptopRepositories.GetChiTietLaptop();
            var linh = huyen.FirstOrDefault(a => a.Ma == mactlt);
            if (linh != null) return true;
            else return false;
        }

        public bool CheckProductInOneBill(string mahoadon, string mactsp)
        {
            var list = GetHoaDonChiTiet().Where(a => a.MaHoaDon == mahoadon).ToList();
            var th = list.FirstOrDefault(a => a.MaChiTietLaptop == mactsp);
            if (th != null) return true;
            else return false;
        }

        public string Delete(HoaDonChiTietView hdctview)
        {
            if (hdctview == null) return "Thất bại";
            HoaDonChiTiet hct = new HoaDonChiTiet();
            hct.ID = hdctview.ID;
            if (hoaDonChiTietRepositories.Delete(hct)) return "Thành công";
            else return "Thất bại";
        }

        public List<HoaDonChiTietView> GetHoaDonChiTiet()
        {
            List<HoaDonChiTietView> listssd = new List<HoaDonChiTietView>();
            listssd = (
                          from a in hoaDonChiTietRepositories.GetHoaDonChiTiet()
                          join b in chiTietLaptopRepositories.GetChiTietLaptop() on a.IDChiTietLapTop equals b.ID
                          join c in hoaDonRepositories.GetHoaDon() on a.IDHoaDon equals c.ID
                          join e in laptopService.GetLaptop() on b.IDLaptop equals e.ID
                          // join d in imeiDaBanRepositories.GetImeiDB() on a.ID equals d.IDHoaDonChiTiet
                          select new HoaDonChiTietView
                          {
                              ID = a.ID,
                              Ma = a.Ma,
                              MaChiTietLaptop = b.Ma,
                              TenLaptop= e.Ten,
                              MaHoaDon = c.Ma,
                              SoLuong = a.SoLuong,
                              GiaTruoc = a.GiaTruoc,
                              NgayTao = a.NgayTao,
                              GiaNhap = b.GiaNhap,
                              ThanhTien = a.SoLuong * a.GiaTruoc

                          }
                ).ToList();
            return listssd;
        }

        public List<HoaDonChiTietView> GetHoaDonChiTietAllData()
        {
            List<HoaDonChiTietView> listall = new List<HoaDonChiTietView>();
            listall = (
                          from a in hoaDonChiTietRepositories.GetHoaDonChiTiet()
                          join b in chiTietLaptopRepositories.GetChiTietLaptop() on a.IDChiTietLapTop equals b.ID
                          join c in hoaDonRepositories.GetHoaDon() on a.IDHoaDon equals c.ID
                          //   join d in imeiDaBanRepositories.GetImeiDB() on a.ID equals d.IDHoaDonChiTiet
                          join e in nhanVienRepositories.GetNhanVien() on c.IdNhanVien equals e.ID
                          join f in khachHangRepositories.GetKhachHang() on c.IdKhachHang equals f.ID
                          join g in laptopService.GetLaptop() on b.IDLaptop equals g.ID
                          select new HoaDonChiTietView
                          {
                              ID = a.ID,
                              Ma = a.Ma,
                              MaChiTietLaptop = b.Ma,
                              MaHoaDon = c.Ma,
                              SoLuong = a.SoLuong,
                              GiaTruoc = a.GiaTruoc,
                              NgayTao = a.NgayTao,
                              GiaNhap = b.GiaNhap,
                              TenNhanVien = e.HoTen,
                              SdtKhachHang = f.SDT,
                              TenKhachHang = f.HoTen,
                              TenLaptop = g.Ten,
                              SdtNhanVien = e.SDT

                          }
                ).ToList();
            return listall;
        }

        public List<HoaDonChiTietView> GetHoaDonChiTietJoinNhanVien()
        {
            List<HoaDonChiTietView> listssd = new List<HoaDonChiTietView>();
            listssd = (
                          from a in hoaDonChiTietRepositories.GetHoaDonChiTiet()
                              // join b in chiTietLaptopRepositories.GetChiTietLaptop() on a.IDChiTietLapTop equals b.ID
                          join c in hoaDonRepositories.GetHoaDon() on a.IDHoaDon equals c.ID
                          //   join d in imeiDaBanRepositories.GetImeiDB() on a.ID equals d.IDHoaDonChiTiet
                          join e in nhanVienRepositories.GetNhanVien() on c.IdNhanVien equals e.ID
                          join f in khachHangRepositories.GetKhachHang() on c.IdKhachHang equals f.ID
                          select new HoaDonChiTietView
                          {
                              ID = a.ID,
                              Ma = a.Ma,
                              //    MaChiTietLaptop = b.Ma,
                              MaHoaDon = c.Ma,
                              SoLuong = a.SoLuong,
                              GiaTruoc = a.GiaTruoc,
                              NgayTao = a.NgayTao,
                              TenNhanVien = e.HoTen,
                              SdtKhachHang = f.SDT,
                              TenKhachHang = f.HoTen

                          }
                ).ToList();
            return listssd;
        }

        public List<HoaDonChiTietView> GetHoaDonChiTietNoJoin()
        {
            List<HoaDonChiTietView> listssd = new List<HoaDonChiTietView>();
            listssd = (
                          from a in hoaDonChiTietRepositories.GetHoaDonChiTiet()
                          join b in chiTietLaptopRepositories.GetChiTietLaptop() on a.IDChiTietLapTop equals b.ID
                          join c in hoaDonRepositories.GetHoaDon() on a.IDHoaDon equals c.ID

                          select new HoaDonChiTietView
                          {
                              ID = a.ID,
                              Ma = a.Ma,
                              MaChiTietLaptop = b.Ma,
                              MaHoaDon = c.Ma,
                              SoLuong = a.SoLuong,
                              GiaTruoc = a.GiaTruoc,
                              NgayTao = a.NgayTao,

                          }
                ).ToList();
            return listssd;
        }

        public string Update(HoaDonChiTietView hdctview)
        {

            if (hdctview == null) return "Thất bại";
            HoaDonChiTiet hct = new HoaDonChiTiet();
            hct.ID = hdctview.ID;
            hct.SoLuong = hdctview.SoLuong;
            //   hct.GiaTruoc = hdctview.GiaTruoc;
            if (hoaDonChiTietRepositories.Update(hct)) return "Thành công";
            else return "Thất bại";
        }
        //public string UpdateTrangThai(HoaDonChiTietView hdctview)
        //{
        //    if (hdctview == null) return "Thất bại";
        //    HoaDonChiTiet hct = new HoaDonChiTiet();
        //    hct.ID = hdctview.ID;
        //    hct.TinhTrang = hdctview.TinhTrang;
        //    if (hoaDonChiTietRepositories.UpdateTrangThai(hct)) return "Thành công";
        //    else return "Thất bại";
        //}
    }
}
