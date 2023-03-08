using _1.DAL.Models;

namespace _1.DAL.IRepositories
{
    public interface IHinhAnhResponsitories
    {
        bool add(HinhAnh image);
        bool remove(HinhAnh image);
        List<HinhAnh> getAll();

        bool update(HinhAnh image);
    }
}
