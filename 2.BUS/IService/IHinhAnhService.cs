using _2.BUS.ViewModels;

namespace _2.BUS.IService
{
    public interface IHinhAnhService
    {
        string Add(HinhAnhView hav);
        string Update(HinhAnhView hav);
        string Delete(HinhAnhView hav);
        List<HinhAnhView> GetHinhAnh();
        bool CheckMa(string ma);
    }
}
