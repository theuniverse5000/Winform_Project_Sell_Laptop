using _1.DAL.IRepositories;
using _1.DAL.Models;

namespace _1.DAL.Repositories
{
    public class ImeiRepositories : IImeiRepositories
    {
        BanHangDbContext context = new BanHangDbContext();
        public bool Add(Imei imei)
        {
            if (imei == null) return false;
            context.Imeis.Add(imei);
            context.SaveChanges();
            return true;
        }

        public bool Delete(Imei imei)
        {
            if (imei == null) return false;
            var lan = context.Imeis.FirstOrDefault(a => a.ID == imei.ID);
            context.Remove(lan);
            context.SaveChanges();
            return true;
        }

        public List<Imei> GetImei()
        {
            return context.Imeis.ToList();
        }

        public bool UpdateTrangThai(Imei imei)
        {
            if (imei == null) return false;
            var lan = context.Imeis.FirstOrDefault(a => a.ID == imei.ID);
            lan.TrangThai = imei.TrangThai;
            context.Update(lan);
            context.SaveChanges();
            return true;
        }
    }
}
