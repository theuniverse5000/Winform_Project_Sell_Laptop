﻿namespace _1.DAL.Models
{
    public class HoaDonChiTiet
    {
        public Guid ID { get; set; }
        public string Ma { get; set; }
        public Guid IDHoaDon { get; set; }
        public Guid IDChiTietLapTop { get; set; }
        public int SoLuong { get; set; }
        public decimal GiaTruoc { get; set; }
        public DateTime NgayTao { get; set; }
        public virtual HoaDon HoaDon { get; set; }
        public virtual ChiTietLaptop ChiTietLaptop { get; set; }
    }
}
