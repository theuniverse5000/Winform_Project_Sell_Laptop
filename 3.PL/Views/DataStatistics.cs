using _2.BUS.IService;
using _2.BUS.Service;
using _2.BUS.ViewModels;
using excel = Microsoft.Office.Interop.Excel;
namespace _3.PL.Views
{

    public partial class DataStatistics : Form
    {
        IHoaDonChiTietService hoaDonChiTietService;
        IHoaDonService hoaDonService;
        public DataStatistics()
        {
            InitializeComponent();
            hoaDonChiTietService = new HoaDonChiTietService();
            hoaDonService = new HoaDonService();
        }
        void LoadDataHoaDonChiTiet(List<HoaDonChiTietView> listhdctv)
        {
            dtg_hoadonchitiet.Rows.Clear();
            dtg_hoadonchitiet.ColumnCount = 15;
            dtg_hoadonchitiet.Columns[0].Name = "ID";
            dtg_hoadonchitiet.Columns[0].Visible = false;
            dtg_hoadonchitiet.Columns[1].Name = "Mã";
            dtg_hoadonchitiet.Columns[2].Name = "Mã hóa đơn";
            dtg_hoadonchitiet.Columns[3].Name = "Mã chi tiết laptop";
            dtg_hoadonchitiet.Columns[4].Name = "Tên sản phẩm";
            dtg_hoadonchitiet.Columns[5].Name = "SĐT khách hàng";
            dtg_hoadonchitiet.Columns[6].Name = "Tên khách hàng";
            dtg_hoadonchitiet.Columns[7].Name = "SĐT nhân viên";
            dtg_hoadonchitiet.Columns[8].Name = "Tên nhân viên";
            dtg_hoadonchitiet.Columns[9].Name = "Số Imei";
            dtg_hoadonchitiet.Columns[10].Name = "Số lượng";
            dtg_hoadonchitiet.Columns[11].Name = "Giá gốc";
            dtg_hoadonchitiet.Columns[12].Name = "Giảm giá";
            dtg_hoadonchitiet.Columns[13].Name = "Thành tiền";
            dtg_hoadonchitiet.Columns[14].Name = "Ngày tạo";
            dtg_hoadonchitiet.Columns[1].Visible = false;
            dtg_hoadonchitiet.Columns[2].Visible = false; dtg_hoadonchitiet.Columns[14].Visible = false;

            foreach (var t in listhdctv)
            {


                dtg_hoadonchitiet.Rows.Add(t.ID, t.Ma, t.MaHoaDon, t.MaChiTietLaptop, t.TenLaptop, t.SdtKhachHang, t.TenKhachHang, t.SdtNhanVien, t.TenNhanVien, t.SoLuong, t.GiaTruoc, t.GiamGia, t.GiaTruoc, t.NgayTao);
            }
        }

        private void DataStatistics_Load(object sender, EventArgs e)
        {
            cbb_12thang.Text = Convert.ToString(DateTime.Now.Month);
            cbb_timtheonam.Text = Convert.ToString(DateTime.Now.Year);
            //   LoadDataHoaDonChiTiet(hoaDonChiTietService.GetHoaDonChiTiet());
            LoadDataHoaDonChiTiet(hoaDonChiTietService.GetHoaDonChiTietAllData());
            HelloBaBy();


        }
        void HelloBaBy()
        {
            //decimal doanhthu = 0;
            //int soluongdaban = 0;
            //foreach (var a in hoaDonChiTietService.GetHoaDonChiTiet().Where(h=>h.TinhTrang==1&&h.NgayTao.Day==DateTime.Now.Day))
            //{
            //    doanhthu += a.GiaSauKhiGiam;
            //    soluongdaban += a.SoLuong;
            //}
            //tbx_tongdoanhthu.Text = Convert.ToString(doanhthu);
            //tbx_soluongdaban.Text = Convert.ToString(soluongdaban);
        }

        private void btn_doanhthuhomnay_Click(object sender, EventArgs e)
        {
            try
            {
                decimal doanhthu = 0;
                int soluongdaban = 0;
                decimal gianhap = 0;
                foreach (var a in hoaDonChiTietService.GetHoaDonChiTiet().Where(h => h.NgayTao.Day == DateTime.Now.Day))
                {
                   // doanhthu += a.GiaSauKhiGiam;
                    soluongdaban += a.SoLuong;
                    gianhap += a.GiaNhap;
                }
                tbx_tongdoanhthu.Text = Convert.ToString(doanhthu);
                tbx_soluongdaban.Text = Convert.ToString(soluongdaban);
                decimal tienlai = doanhthu - gianhap;
                tbx_tongtienlai.Text = Convert.ToString(tienlai);
                var linh = hoaDonChiTietService.GetHoaDonChiTietJoinNhanVien().Where(h => h.NgayTao.Day == DateTime.Now.Day).OrderBy(x => x.MaHoaDon).First();
                tbx_manhanvien.Text = linh.MaNhanVien;
                tbx_hotennhanvien.Text = linh.TenNhanVien;
                tbx_sdtkhachhang.Text = linh.SdtKhachHang;
                tbx_tenkh.Text = linh.TenKhachHang;
            }
            catch (Exception)
            {
                tbx_manhanvien.Text = "";
                tbx_hotennhanvien.Text = "";
                tbx_sdtkhachhang.Text = "";
                tbx_tenkh.Text = "";
                MessageBox.Show("Không có dữ liệu", "Warrning !!!", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }

        }

        private void btn_doanhthuthang_Click(object sender, EventArgs e)
        {
            decimal doanhthu = 0;
            int soluongdaban = 0;
            decimal gianhap = 0;

            if (cbb_12thang.Text == "1" || cbb_12thang.Text == "2" || cbb_12thang.Text == "3" || cbb_12thang.Text == "4" || cbb_12thang.Text == "5" || cbb_12thang.Text == "6" || cbb_12thang.Text == "7" || cbb_12thang.Text == "8" || cbb_12thang.Text == "9" || cbb_12thang.Text == "10" || cbb_12thang.Text == "11" || cbb_12thang.Text == "12")
            {
                int thang = Convert.ToInt32(cbb_12thang.Text);
                foreach (var a in hoaDonChiTietService.GetHoaDonChiTiet().Where(h => h.NgayTao.Month == thang))
                {
                    doanhthu += a.GiaTruoc;
                    soluongdaban += a.SoLuong;
                    gianhap += a.GiaNhap;
                }
                tbx_tongdoanhthu.Text = Convert.ToString(doanhthu);
                tbx_soluongdaban.Text = Convert.ToString(soluongdaban);
                decimal tienlai = doanhthu - gianhap;
                tbx_tongtienlai.Text = Convert.ToString(tienlai);
                try
                {
                    var khanhlinh = hoaDonChiTietService.GetHoaDonChiTietJoinNhanVien();
                    var linh = khanhlinh.Where(h => h.NgayTao.Month == thang).OrderBy(x => x.MaHoaDon).First();
                    tbx_manhanvien.Text = linh.MaNhanVien;
                    tbx_hotennhanvien.Text = linh.TenNhanVien;
                    tbx_sdtkhachhang.Text = linh.SdtKhachHang;
                    tbx_tenkh.Text = linh.TenKhachHang;
                }

                catch (Exception)
                {
                    tbx_manhanvien.Text = "";
                    tbx_hotennhanvien.Text = "";
                    tbx_sdtkhachhang.Text = "";
                    tbx_tenkh.Text = "";
                    MessageBox.Show("Không có dữ liệu", "Warrning !!!", MessageBoxButtons.OK, MessageBoxIcon.Question);

                }


            }
            else
            {
                MessageBox.Show("Hãy chọn tháng hợp lệ", "Warrning !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void btn_theonam_Click(object sender, EventArgs e)
        {
            try
            {
                int nam = Convert.ToInt32(cbb_timtheonam.Text);
                decimal doanhthu = 0;
                int soluongdaban = 0;
                decimal gianhap = 0;
                foreach (var a in hoaDonChiTietService.GetHoaDonChiTiet().Where(h => h.NgayTao.Year == nam))
                {
                    doanhthu += a.GiaTruoc;
                    soluongdaban += a.SoLuong;
                    gianhap += a.GiaNhap;
                }
                tbx_tongdoanhthu.Text = Convert.ToString(doanhthu);
                tbx_soluongdaban.Text = Convert.ToString(soluongdaban);
                decimal tienlai = doanhthu - gianhap;
                tbx_tongtienlai.Text = Convert.ToString(tienlai);
                var linh = hoaDonChiTietService.GetHoaDonChiTietJoinNhanVien().Where(h => h.NgayTao.Year == nam).OrderBy(x => x.MaHoaDon).First();
                tbx_manhanvien.Text = linh.MaNhanVien;
                tbx_hotennhanvien.Text = linh.TenNhanVien;
                tbx_sdtkhachhang.Text = linh.SdtKhachHang;
                tbx_tenkh.Text = linh.TenKhachHang;
            }
            catch (Exception)
            {
                tbx_manhanvien.Text = "";
                tbx_hotennhanvien.Text = "";
                tbx_sdtkhachhang.Text = "";
                tbx_tenkh.Text = "";
                MessageBox.Show("Không có dữ liệu", "Warrning !!!", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }

        }
        private void dtp_loctheongay_ValueChanged(object sender, EventArgs e)
        {
            LoadDataHoaDonChiTiet(hoaDonChiTietService.GetHoaDonChiTietAllData().Where(a => a.NgayTao.Day == dtp_loctheongay.Value.Day).ToList());
        }

        private void dtg_hoadonchitiet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tbx_macthoadon.Text = dtg_hoadonchitiet.CurrentRow.Cells[1].Value.ToString();
                tbx_mahoadon.Text = dtg_hoadonchitiet.CurrentRow.Cells[2].Value.ToString();
                tbx_ngaytaohdct.Text = dtg_hoadonchitiet.CurrentRow.Cells[14].Value.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void tbx_timsdtkh_TextChanged(object sender, EventArgs e)
        {
            try
            {
                LoadDataHoaDonChiTiet(hoaDonChiTietService.GetHoaDonChiTietAllData().Where(a => a.SdtKhachHang.Contains(tbx_timsdtkh.Text)).ToList());
            }
            catch (Exception)
            {
                MessageBox.Show("Không có dữ liệu", "Warrning !!!", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }

        }

        private void tbx_timsdtnv_TextChanged(object sender, EventArgs e)
        {
            try
            {
                LoadDataHoaDonChiTiet(hoaDonChiTietService.GetHoaDonChiTietAllData().Where(a => a.SdtNhanVien.Contains(tbx_timsdtnv.Text)).ToList());
            }
            catch (Exception)
            {
                MessageBox.Show("Không có dữ liệu", "Warrning !!!", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }

        }

        private void btn_exportExcel_Click(object sender, EventArgs e)
        {
            try
            {
                excel.Application app = new excel.Application();
                excel.Workbook workbook = app.Workbooks.Add();
                excel.Worksheet worksheet = null;
                app.Visible = true;


                worksheet = workbook.ActiveSheet;

                for (int i = 0; i < dtg_hoadonchitiet.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1] = dtg_hoadonchitiet.Columns[i].HeaderText;
                }

                for (int j = 0; j < dtg_hoadonchitiet.Rows.Count; j++)
                {
                    for (int i = 0; i < dtg_hoadonchitiet.Columns.Count - 1; i++)
                    {
                        worksheet.Cells[j + 2, i + 1] = dtg_hoadonchitiet.Rows[j].Cells[i].Value.ToString();
                    }
                }
            }
            catch (Exception)
            {

                //  MessageBox.Show("Đã xuất ra excel");
            }
        }
    }
}
