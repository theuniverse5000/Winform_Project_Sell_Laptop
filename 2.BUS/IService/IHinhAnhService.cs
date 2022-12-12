using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IService
{
    public interface IHinhAnhService
    {
        bool add(hinhanhview img);
        bool remove(hinhanhview img);
        bool update(hinhanhview img);
      //  public Guid Id(hinhanhview img);
        List<hinhanhview> GetAnh();
        bool CheckMa(string ma);
    }
}
