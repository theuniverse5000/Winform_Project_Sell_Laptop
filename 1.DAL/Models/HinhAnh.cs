namespace _1.DAL.Models
{
    public class HinhAnh
    {
        public Guid Id { get; set; }
        public string Ma { get; set; }
        public string? Ten { get; set; }
        public byte[] HAnh { get; set; } = null!;
    }
}
