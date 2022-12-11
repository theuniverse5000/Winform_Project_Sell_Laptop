using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
