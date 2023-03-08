namespace _1.DAL.Models
{
    public class Laptop
    {
        public Guid ID { get; set; }
        public Guid? IDHinhAnh { get; set; }
        public string? Ten { get; set; }
        public virtual HinhAnh HinhAnh { get; set; }
    }
}
