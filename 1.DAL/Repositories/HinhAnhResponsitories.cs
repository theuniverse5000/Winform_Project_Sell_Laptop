using _1.DAL.IRepositories;
using _1.DAL.Models;

namespace _1.DAL.Repositories
{
    public class HinhAnhResponsitories : IHinhAnhResponsitories
    {
        BanHangDbContext _DBcontext = new BanHangDbContext();
        public bool add(HinhAnh image)
        {
            try
            {
                _DBcontext.HinhAnhs.Add(image);
                _DBcontext.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<HinhAnh> getAll()
        {
            return _DBcontext.HinhAnhs.ToList();
        }

        public bool remove(HinhAnh image)
        {
            try
            {
                var x = _DBcontext.HinhAnhs.FirstOrDefault(p => p.Id == image.Id);
                _DBcontext.HinhAnhs.Remove(x);
                _DBcontext.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool update(HinhAnh image)
        {
            try
            {
                var lan = _DBcontext.HinhAnhs.Find(image.Id);
                lan.Ten = image.Ten;
                lan.HAnh = image.HAnh;
                _DBcontext.Update(lan);
                _DBcontext.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
