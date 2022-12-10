using _1.DAL.Models;

namespace _2.BUS.ViewModels
{
    public class ImeiView
    {
        public Guid ID { get; set; }
        public Guid IDChiTietLaptop { get; set; }
        public string SoEmei { get; set; }
        public virtual ChiTietLaptop ChiTietLaptop { get; set; }
        public string MaCTLT { get; set; }
        public int TrangThai { get; set; }
    }
}
