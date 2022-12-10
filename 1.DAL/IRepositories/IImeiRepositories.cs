using _1.DAL.Models;

namespace _1.DAL.IRepositories
{
    public interface IImeiRepositories
    {
        bool Add(Imei imei);
        bool UpdateTrangThai(Imei imei);
        bool Delete(Imei imei);
        List<Imei> GetImei();
    }
}
