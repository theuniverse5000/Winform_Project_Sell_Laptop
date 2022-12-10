namespace _1.DAL.Models
{
    public class ImeiDaBan
    {
        public Guid ID { get; set; }
        public Guid IDHoaDonChiTiet { get; set; }
        public string SoEmei { get; set; }
        public virtual HoaDonChiTiet HoaDonChiTiet { get; set; }
    }
}
