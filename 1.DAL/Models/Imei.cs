namespace _1.DAL.Models
{
    public class Imei
    {
        public Guid ID { get; set; }
        public Guid IDChiTietLaptop { get; set; }
        public string SoEmei { get; set; }
        public virtual ChiTietLaptop ChiTietLaptop { get; set; }
        public int TrangThai { get; set; }
    }
}
