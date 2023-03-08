namespace _2.BUS.ViewModels
{
    public class HinhAnhView
    {
        public Guid Id { get; set; }
        public string Ma { get; set; }
        public string? Ten { get; set; }
        public byte[] HAnh { get; set; } = null!;
    }
}
