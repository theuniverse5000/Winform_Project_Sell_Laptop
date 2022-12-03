using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
