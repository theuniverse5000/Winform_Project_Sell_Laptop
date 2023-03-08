﻿using _1.DAL.IRepositories;
using _1.DAL.Models;
using _1.DAL.Repositories;
using _2.BUS.IService;
using _2.BUS.ViewModels;

namespace _2.BUS.Service
{
    public class ChiTietLaptopService : IChiTietLaptopService
    {
        IChiTietLaptopRepositories chiTietLaptopRepositories = new ChiTietLaptopRepositories();
        ILaptopRepositories laptopRepositories = new LaptopRepositories();
        IMauSacRepositories mauSacRepositories = new MauSacRepositories();
        INsxRepositories nsxRepositories = new NsxRepositories();
        IThuocTinhRepositories thuocTinhRepositories = new ThuocTinhRepositories();
        IGiaTriRepositories giaTriRepositories = new GiaTriRepositories();
        IHinhAnhResponsitories hinhAnhResponsitories = new HinhAnhResponsitories();
        //   ILaptopService laptopService = new LaptopService();
        public string Add(ChiTietLaptopView ctltview)
        {
            if (ctltview == null) return "Thất bại";
            ChiTietLaptop t = new ChiTietLaptop();
            t.ID = ctltview.ID;
            t.Ma = ctltview.Ma;
            t.IDMauSac = ctltview.IDMauSac;
            t.IDLaptop = ctltview.IDLaptop;
            t.IDNsx = ctltview.IDNsx;
            t.MoTa = ctltview.MoTa;
            t.SoLuong = ctltview.SoLuong;
            t.GiaNhap = ctltview.GiaNhap;
            t.Giaban = ctltview.Giaban;
            if (chiTietLaptopRepositories.Add(t)) return "Thành công";
            else return "Thất bại";
        }
        public string Delete(ChiTietLaptopView ctltview)
        {
            if (ctltview == null) return "Thất bại";
            ChiTietLaptop t = new ChiTietLaptop();
            t.ID = ctltview.ID;
            if (chiTietLaptopRepositories.Delete(t)) return "Thành công";
            else return "Thất bại";
        }

        public List<ChiTietLaptopView> GetChiTietLaptop()
        {
            List<ChiTietLaptopView> listview = new List<ChiTietLaptopView>();
            listview = (
                         from a in chiTietLaptopRepositories.GetChiTietLaptop()
                         join c in mauSacRepositories.GetMauSac() on a.IDMauSac equals c.ID
                         join d in nsxRepositories.GetNsx() on a.IDNsx equals d.ID
                         join g in laptopRepositories.GetLaptop() on a.IDLaptop equals g.ID
                         join e in thuocTinhRepositories.GetThuocTinh() on g.ID equals e.IDLaptop
                         join f in giaTriRepositories.GetGiaTri() on e.ID equals f.IDThuocTinh
                         join i in hinhAnhResponsitories.getAll() on g.IDHinhAnh equals i.Id
                         select new ChiTietLaptopView
                         {
                             ID = a.ID,
                             Ma = a.Ma,
                             MoTa = a.MoTa,
                             SoLuong = a.SoLuong,
                             GiaNhap = a.GiaNhap,
                             Giaban = a.Giaban,
                             MaMauSac = c.Ma,
                             TenLaptop = g.Ten,
                             TenThuocTinh = e.Ten,
                             ThongSoGiaTri = f.ThongSo,
                             TenMauSac = c.Ten,
                             TenNsx = d.Ten,
                             HAnh = i.HAnh
                         }

                ).ToList();
            return listview;
        }

        public string Update(ChiTietLaptopView ctltview)
        {
            if (ctltview == null) return "Thất bại";
            ChiTietLaptop t = new ChiTietLaptop();
            t.ID = ctltview.ID;
            t.MoTa = ctltview.MoTa;
            t.SoLuong = ctltview.SoLuong;
            t.GiaNhap = ctltview.GiaNhap;
            t.Giaban = ctltview.Giaban;
            if (chiTietLaptopRepositories.Update(t)) return "Thành công";
            else return "Thất bại";
        }
        public List<ChiTietLaptopView> GetChiTietLaptopNoJoin()
        {
            List<ChiTietLaptopView> listview = new List<ChiTietLaptopView>();
            listview = (
                         from a in chiTietLaptopRepositories.GetChiTietLaptop()
                         join c in mauSacRepositories.GetMauSac() on a.IDMauSac equals c.ID
                         join d in nsxRepositories.GetNsx() on a.IDNsx equals d.ID
                         join g in laptopRepositories.GetLaptop() on a.IDLaptop equals g.ID
                         join e in thuocTinhRepositories.GetThuocTinh() on g.ID equals e.IDLaptop
                         join f in giaTriRepositories.GetGiaTri() on e.ID equals f.IDThuocTinh
                         //  join h in imeiRepositories.GetImei() on a.ID equals h.IDChiTietLaptop
                         select new ChiTietLaptopView
                         {
                             ID = a.ID,
                             Ma = a.Ma,
                             MoTa = a.MoTa,
                             SoLuong = a.SoLuong,
                             GiaNhap = a.GiaNhap,
                             Giaban = a.Giaban,
                             MaMauSac = c.Ma,
                             TenLaptop = g.Ten,
                             TenThuocTinh = e.Ten,
                             ThongSoGiaTri = f.ThongSo,
                             TenMauSac = c.Ten,
                             TenNsx = d.Ten,

                         }

                ).ToList();
            return listview;
        }

        public bool CheckMa(string ma)
        {
            var th = chiTietLaptopRepositories.GetChiTietLaptop();
            var linh = th.FirstOrDefault(a => a.Ma == ma);
            if (linh != null)
            {
                return true;
            }
            else return false;
        }

        public string UpdateSoLuong(ChiTietLaptopView ctltview)
        {
            if (ctltview == null) return "Thất bại";
            ChiTietLaptop t = new ChiTietLaptop();
            t.ID = ctltview.ID;
            t.SoLuong = ctltview.SoLuong;
            if (chiTietLaptopRepositories.UpdateSoLuong(t)) return "Thành công";
            else return "Thất bại";
        }

        public List<ChiTietLaptopView> GetChiTietLaptopNo()
        {
            List<ChiTietLaptopView> listview = new List<ChiTietLaptopView>();
            listview = (
                         from a in chiTietLaptopRepositories.GetChiTietLaptop()

                         select new ChiTietLaptopView
                         {
                             ID = a.ID,
                             Ma = a.Ma,
                             MoTa = a.MoTa,
                             SoLuong = a.SoLuong,
                             GiaNhap = a.GiaNhap,
                             Giaban = a.Giaban
                         }

                ).ToList();
            return listview;
        }
    }
}
