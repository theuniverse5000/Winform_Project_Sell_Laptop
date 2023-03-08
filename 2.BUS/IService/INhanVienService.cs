using _2.BUS.ViewModels;

namespace _2.BUS.IService
{
    public interface INhanVienService
    {
        string AddNhanVien(NhanVienView nvv);
        string UpdateNhanVien(NhanVienView nvv);
        string DeleteNhanVien(NhanVienView nvv);
        string ChangePassWord(NhanVienView nvv);
        bool CheckSdt(string ma);
        bool CheckGmail(string Gmail);
        List<NhanVienView> GetAllNhanVien();
        bool CheckSdtMkNhanVien(string taikhoan, string matkhau);

        bool CheckQuanLy(string taikhoan, string matkhau, string cv);

    }
}
