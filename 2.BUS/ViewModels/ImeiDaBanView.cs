using _1.DAL.Models;

namespace _2.BUS.ViewModels
{
    public class ImeiDaBanView
    {
        public Guid ID { get; set; }
        public Guid IDHoaDonChiTiet { get; set; }
        public string SoEmei { get; set; }
        public virtual HoaDonChiTiet HoaDonChiTiet { get; set; }
        public string MaHDCT { get; set; }

    }
}
