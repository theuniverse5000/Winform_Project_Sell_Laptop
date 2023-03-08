using _1.DAL.IRepositories;
using _1.DAL.Models;
using _1.DAL.Repositories;
using _2.BUS.IService;
using _2.BUS.ViewModels;

namespace _2.BUS.Service
{
    public class HinhAnhService : IHinhAnhService
    {
        IHinhAnhResponsitories hinhanhRepositiories = new HinhAnhResponsitories();

        public string Add(HinhAnhView hav)
        {
            if (hav == null)
            {
                return "Thất bại";

            }
            HinhAnh ha = new HinhAnh();
            ha.Id = hav.Id;
            ha.Ma = hav.Ma;
            ha.Ten = hav.Ten;
            ha.HAnh = hav.HAnh;
            if (hinhanhRepositiories.add(ha))
            {
                return "Thành công";
            }
            else return "Thất bại";
        }

        public bool CheckMa(string ma)
        {
            var linh = hinhanhRepositiories.getAll();
            var ngoc = linh.FirstOrDefault(a => a.Ma == ma);
            if (ngoc != null)
            {
                return true;
            }
            else return false;
        }

        public string Delete(HinhAnhView hav)
        {
            if (hav == null)
            {
                return "Thất bại";

            }
            HinhAnh ha = new HinhAnh();
            ha.Id = hav.Id;
            if (hinhanhRepositiories.remove(ha))
            {
                return "Thành công";
            }
            else return "Thất bại";
        }

        public List<HinhAnhView> GetHinhAnh()
        {
            List<HinhAnhView> listha = new List<HinhAnhView>();
            listha = (
                 from a in hinhanhRepositiories.getAll()
                 select new HinhAnhView
                 {
                     Id = a.Id,
                     Ma = a.Ma,
                     Ten = a.Ten,
                     HAnh = a.HAnh
                 }
                ).ToList();
            return listha;
        }

        public string Update(HinhAnhView hav)
        {
            if (hav == null)
            {
                return "Thất bại";

            }
            HinhAnh ha = new HinhAnh();
            ha.Id = hav.Id;
            ha.Ten = hav.Ten;
            ha.HAnh = hav.HAnh;
            if (hinhanhRepositiories.update(ha))
            {
                return "Thành công";
            }
            else return "Thất bại";
        }
    }
}
