using _2.BUS.ViewModels;

namespace _2.BUS.IService
{
    public interface IImeiService
    {
        string Add(ImeiView imv);
        string UpdateTrangThai(ImeiView imv);
        string Delete(ImeiView imv);
        List<ImeiView> GetImei();
        bool CheckSoImeil(string soimei);
    }
}
