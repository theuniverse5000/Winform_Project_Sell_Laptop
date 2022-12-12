using _1.DAL.IRepositories;
using _1.DAL.Models;
using _1.DAL.Repositories;
using _2.BUS.IService;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Service
{
    public class HinhAnhService : IHinhAnhService
    {
        IHinhAnhResponsitories hinhanhRepositiories = new HinhAnhResponsitories();
        public bool add(hinhanhview img)
        {
            HinhAnh image = new HinhAnh();
            image.Ten = img.Ten;
            image.Id = img.Id;
            image.LinkAnh = img.LinkAnh;
            image.Ma = img.Ma;
            if (hinhanhRepositiories.add(image))
                return true;
            return false;
        }

        public bool CheckMa(string ma)
        {
            var linh = hinhanhRepositiories.getAll();
            var ngoc = linh.FirstOrDefault(a=>a.Ma== ma);
            if (ngoc != null)
            {
                return true;
            }
            else return false;
        }

        public List<hinhanhview> GetAnh()
        {
            return (from a in hinhanhRepositiories.getAll()
                    select new hinhanhview
                    {
                        Id = a.Id,
                        Ten = a.Ten,
                        LinkAnh = a.LinkAnh,
                        Ma = a.Ma,
                    }).ToList();
        }
        public bool remove(hinhanhview img)
        {
            var idImg = hinhanhRepositiories.getAll().FirstOrDefault(p => p.Id == img.Id);
            if (hinhanhRepositiories.remove(idImg)) return true;
            return false;
        }
        public bool update(hinhanhview img)
        {
            HinhAnh image = hinhanhRepositiories.getAll().FirstOrDefault(p => p.Id == img.Id);
            image.Ten = img.Ten;
            image.LinkAnh = img.LinkAnh;

            if (hinhanhRepositiories.update(image))
                return true;
            return false;
        }
        //public Guid Id(hinhanhview img)
        //{
        //    HinhAnh image = new HinhAnh();
        //    image.Ten = img.Ten;
        //    image.Id = img.Id;
        //    image.LinkAnh = img.LinkAnh;
        //    image.Ma = img.Ma;
        //    if (hinhanhRepositiories.add(image))
        //        return image.Id;
        //    return Guid.Empty;
      //  }
    }
}
