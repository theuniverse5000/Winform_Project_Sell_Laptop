using _1.DAL.IRepositories;
using _1.DAL.Models;
using _1.DAL.Repositories;
using _2.BUS.IService;
using _2.BUS.ViewModels;

namespace _2.BUS.Service
{
    public class ImeiService : IImeiService
    {
        IImeiRepositories imeiRepositories = new ImeiRepositories();
        IChiTietLaptopRepositories chiTietLaptopRepositories = new ChiTietLaptopRepositories();
        public string Add(ImeiView imv)
        {
            if (imv == null) return "Thất Bại";
            Imei i = new Imei();
            i.ID = imv.ID;
            i.SoEmei = imv.SoEmei;
            i.IDChiTietLaptop = imv.IDChiTietLaptop;
            i.TrangThai = imv.TrangThai;
            if (imeiRepositories.Add(i)) return "Thành Công";
            else return "Thất Bại";
        }

        public bool CheckSoImeil(string soimei)
        {
            var ngoc = imeiRepositories.GetImei();
            var linh = ngoc.FirstOrDefault(a => a.SoEmei == soimei);
            if (linh != null) return true;
            else return false;
        }

        public string Delete(ImeiView imv)
        {
            if (imv == null) return "Thất Bại";
            Imei i = new Imei();
            i.ID = imv.ID;
            if (imeiRepositories.Delete(i)) return "Thành Công";
            else return "Thất Bại";
        }

        public List<ImeiView> GetImei()
        {
            List<ImeiView> listimv = new List<ImeiView>();
            listimv = (from a in imeiRepositories.GetImei()
                       join b in chiTietLaptopRepositories.GetChiTietLaptop() on a.IDChiTietLaptop equals b.ID
                       select new ImeiView()
                       {
                           ID = a.ID,
                           SoEmei = a.SoEmei,
                           TrangThai = a.TrangThai,
                           MaCTLT = b.Ma
                       }
                ).ToList();
            return listimv;
        }

        public string UpdateTrangThai(ImeiView imv)
        {
            if (imv == null) return "Thất Bại";
            Imei i = new Imei();
            i.ID = imv.ID;
            i.TrangThai = imv.TrangThai;
            if (imeiRepositories.UpdateTrangThai(i)) return "Thành Công";
            else return "Thất Bại";
        }
    }
}
