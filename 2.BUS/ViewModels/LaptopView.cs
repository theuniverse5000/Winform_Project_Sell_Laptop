namespace _2.BUS.ViewModels
{
    public class LaptopView
    {
        public Guid ID { get; set; }
        public string Ten { get; set; }
        public Guid IDHinhAnh { get; set; }
        public byte[] HAnh { get; set; } = null!;
    }
}
