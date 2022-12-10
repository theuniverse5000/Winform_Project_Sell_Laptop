using _2.BUS.ViewModels;

namespace _2.BUS.IService
{
    public interface IImeiDaBanService
    {
        string Add(ImeiDaBanView imdbv);
        List<ImeiDaBanView> GetImeiDaBan();
    }
}
