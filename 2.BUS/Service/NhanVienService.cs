﻿using _1.DAL.IRepositories;
using _1.DAL.Models;
using _1.DAL.Repositories;
using _2.BUS.IService;
using _2.BUS.ViewModels;

namespace _2.BUS.Service
{
    public class NhanVienService : INhanVienService
    {
        INhanVienRepositories nhanVienRepositories;
        ICuaHangRepositories cuaHangRepositories;
        IChucVuRepositories chucVuRepositories;
        public NhanVienService()
        {
            nhanVienRepositories = new NhanVienRepositories();
            cuaHangRepositories = new CuaHangRepositories();
            chucVuRepositories = new ChucVuRepositories();
        }
        public string AddNhanVien(NhanVienView nvv)
        {
            if (nvv == null) return "Thất bại";
            NhanVien t = new NhanVien();
            t.ID = nvv.ID;
            t.HoTen = nvv.HoTen;
            t.DiaChi = nvv.DiaChi;
            t.SDT = nvv.SDT;
            t.MatKhau = nvv.MatKhau;
            t.TrangThai = nvv.TrangThai;
            t.Gmail = nvv.Gmail;
            t.IdChucVu = nvv.IdChucVu;
            t.IdCuaHang = nvv.IdCuaHang;
            if (nhanVienRepositories.Add(t))
                return "Thành Công";
            else return "Thất bại";
        }

        public bool CheckSdt(string sdt)
        {
            var thao = nhanVienRepositories.GetNhanVien().FirstOrDefault(a => a.SDT == sdt);
            if (thao != null) return true;
            else return false;
        }

        public bool CheckQuanLy(string taikhoan, string matkhau, string cv)
        {
            var s = GetAllNhanVien().FirstOrDefault(a => a.SDT == taikhoan && a.MatKhau == matkhau && a.MaChucVu == cv);
            if (s != null) return true;
            else return false;
        }

        public bool CheckSdtMkNhanVien(string taikhoan, string matkhau)
        {
            var listnv = nhanVienRepositories.GetNhanVien();// lấy dữ liệu trong database ra rồi tìm  check dc hoa thường
            var t = listnv.FirstOrDefault(a => a.SDT == taikhoan && a.MatKhau == matkhau);
            if (t != null) return true;
            else return false;
        }

        public string DeleteNhanVien(NhanVienView nvv)
        {
            if (nvv == null) return "Thất bại";
            NhanVien t = new NhanVien();
            t.ID = nvv.ID;
            if (nhanVienRepositories.Delete(t))
                return "Thành Công";
            else return "Thất bại";
        }

        public List<NhanVienView> GetAllNhanVien()
        {
            List<NhanVienView> listnv = new List<NhanVienView>();
            listnv = (
                from a in nhanVienRepositories.GetNhanVien()
                join b in cuaHangRepositories.GetCuaHang() on a.IdCuaHang equals b.ID
                join c in chucVuRepositories.GetChucVu() on a.IdChucVu equals c.ID
                select new NhanVienView
                {
                    ID = a.ID,
                    HoTen = a.HoTen,
                    DiaChi = a.DiaChi,
                    SDT = a.SDT,
                    MatKhau = a.MatKhau,

                    TrangThai = a.TrangThai,
                    IdChucVu = a.IdChucVu,
                    IdCuaHang = a.IdCuaHang,
                    MaChucVu = c.Ma,
                    MaCuaHang = b.Ma,
                    Gmail = a.Gmail
                }
                ).ToList();
            return listnv;
        }

        public string UpdateNhanVien(NhanVienView nvv)
        {
            if (nvv == null) return "Thất bại";
            NhanVien t = new NhanVien();
            t.ID = nvv.ID;
            //t.Ma = nvv.Ma;
            t.HoTen = nvv.HoTen;
            t.DiaChi = nvv.DiaChi;
            t.SDT = nvv.SDT;
            t.MatKhau = nvv.MatKhau;
            t.Gmail = nvv.Gmail;
            t.TrangThai = nvv.TrangThai;

            if (nhanVienRepositories.Update(t))
                return "Thành Công";
            else return "Thất bại";
        }
        public string ChangePassWord(NhanVienView nvv)
        {
            if (nvv == null) return "Thất bại";
            NhanVien t = new NhanVien();
            t.ID = nvv.ID;
            t.MatKhau = nvv.MatKhau;
            if (nhanVienRepositories.ChangePassWord(t))
                return "Thành Công";
            else return "Thất bại";
        }
        public bool CheckGmail(string Gmail)
        {
            var thao = nhanVienRepositories.GetNhanVien().FirstOrDefault(a => a.Gmail == Gmail);
            if (thao != null) return true;
            else return false;
        }
    }
}
