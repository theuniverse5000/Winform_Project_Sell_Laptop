using _1.DAL.Models;

namespace _1.DAL.IRepositories
{
    public interface IImeiDaBanRepositories
    {
        bool Add(ImeiDaBan imeiDaBan);
        List<ImeiDaBan> GetImeiDB();
    }
}
