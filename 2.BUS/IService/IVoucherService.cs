using _2.BUS.ViewModels;

namespace _2.BUS.IService
{
    public interface IVoucherService
    {
        string Add(VoucherView vv);
        string Update(VoucherView vv);
        string UpdateSoLuong(string ma);
        string Delete(VoucherView vv);
        bool CheckMa(string ma);
        List<VoucherView> GetVoucher();
    }
}
