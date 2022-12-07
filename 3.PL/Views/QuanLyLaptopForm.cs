using _2.BUS.IService;
using _2.BUS.Service;
using _2.BUS.ViewModels;

namespace _3.PL.Views
{
    public partial class QuanLyLaptopForm : Form
    {
        IMauSacService mauSacService;
        INsxService nsxService;
        ILaptopService laptopService;
        IThuocTinhService thuocTinhService;
        IGiaTriService giaTriService;
        IChiTietLaptopService chiTietLaptopService;
        IImeiService imeiService;
        Guid GetIdMauSac { get; set; }
        Guid GetIdNsx { get; set; }
        Guid GetIdLaptop { get; set; }
        Guid GetIdThuocTinh { get; set; }
        Guid GetIdGiaTri { get; set; }
        Guid GetIdChiTietLaptop { get; set; }
        public QuanLyLaptopForm()
        {
            InitializeComponent();
            mauSacService = new MauSacService();
            nsxService = new NsxService();
            laptopService = new LaptopService();
            thuocTinhService = new ThuocTinhService();
            giaTriService = new GiaTriService();
            chiTietLaptopService = new ChiTietLaptopService();
            imeiService = new ImeiService();
        }
        void LoadDataMauSac(List<MauSacView> listms)
        {
            int sttms = 0;
            dtg_showmausac.Rows.Clear();
            dtg_showmausac.ColumnCount = 4;
            dtg_showmausac.Columns[0].Name = "ID";
            dtg_showmausac.Columns[0].Visible = false;
            dtg_showmausac.Columns[1].Name = "STT";
            dtg_showmausac.Columns[2].Name = "Mã";
            dtg_showmausac.Columns[3].Name = "Tên";
            foreach (var b in listms)
            {
                sttms++;
                dtg_showmausac.Rows.Add(b.ID, sttms, b.Ma, b.Ten);
            }
        }
        void LoadDataNsx(List<NsxView> listnsx)
        {
            int sttnsx = 0;
            dtg_shownsx.Rows.Clear();
            dtg_shownsx.ColumnCount = 4;
            dtg_shownsx.Columns[0].Name = "ID";
            dtg_shownsx.Columns[0].Visible = false;
            dtg_shownsx.Columns[1].Name = "STT";
            dtg_shownsx.Columns[2].Name = "Mã";
            dtg_shownsx.Columns[3].Name = "Tên";
            foreach (var c in listnsx)
            {
                sttnsx++;
                dtg_shownsx.Rows.Add(c.ID, sttnsx, c.Ma, c.Ten);
            }
        }
        void LoadDataLaptop(List<LaptopView> listlt)
        {
            int sttlt = 0;
            dtg_showlaptop.Rows.Clear();
            dtg_showlaptop.ColumnCount = 4;
            dtg_showlaptop.Columns[0].Name = "ID";
            dtg_showlaptop.Columns[0].Visible = false;
            dtg_showlaptop.Columns[1].Name = "STT";
            dtg_showlaptop.Columns[2].Name = "Mã";
            dtg_showlaptop.Columns[3].Name = "Tên";
            foreach (var g in listlt)
            {
                sttlt++;
                dtg_showlaptop.Rows.Add(g.ID, sttlt, g.Ma, g.Ten);
            }
        }
        void LoadDataThuocTinh(List<ThuocTinhView> listtt)
        {
            int stttt = 0;
            dtg_showthuoctinh.Rows.Clear();
            dtg_showthuoctinh.ColumnCount = 5;
            dtg_showthuoctinh.Columns[0].Name = "ID";
            dtg_showthuoctinh.Columns[0].Visible = false;
            dtg_showthuoctinh.Columns[1].Name = "STT";
            dtg_showthuoctinh.Columns[2].Name = "Mã thuộc tính";
            dtg_showthuoctinh.Columns[3].Name = "Mã laptop";
            dtg_showthuoctinh.Columns[4].Name = "Tên thuộc tính";
            foreach (var g in listtt)
            {
                stttt++;
                dtg_showthuoctinh.Rows.Add(g.ID, stttt, g.Ma, g.MaLaptop, g.Ten);
            }
        }
        void LoadDataGiaTri(List<GiaTriView> listgtv)
        {
            int sttgt = 0;
            dtg_showgiatri.Rows.Clear();
            dtg_showgiatri.ColumnCount = 5;
            dtg_showgiatri.Columns[0].Name = "ID";
            dtg_showgiatri.Columns[0].Visible = false;
            dtg_showgiatri.Columns[1].Name = "STT";
            dtg_showgiatri.Columns[2].Name = "Mã";
            dtg_showgiatri.Columns[3].Name = "Mã thuộc tính";
            dtg_showgiatri.Columns[4].Name = "Thông số";
            foreach (var h in listgtv)
            {
                sttgt++;
                dtg_showgiatri.Rows.Add(h.ID, sttgt, h.Ma, h.MaThuocTinh, h.ThongSo);
            }
        }
        void LoadDataChiTietLaptop(List<ChiTietLaptopView> list)
        {
            int sttctlt = 0;
            dtg_showchitietlaptop.Rows.Clear();
            dtg_showchitietlaptop.ColumnCount = 14;
            dtg_showchitietlaptop.Columns[0].Name = "ID";
            dtg_showchitietlaptop.Columns[0].Visible = false;
            dtg_showchitietlaptop.Columns[1].Name = "STT";
            dtg_showchitietlaptop.Columns[2].Name = "Mã";
            dtg_showchitietlaptop.Columns[3].Name = "Mã Laptop ";
            dtg_showchitietlaptop.Columns[4].Name = "TenLaptop";
            dtg_showchitietlaptop.Columns[5].Name = "Tên thuộc tính";
            dtg_showchitietlaptop.Columns[6].Name = "Thông số giá trị";
            dtg_showchitietlaptop.Columns[7].Name = "Mã nhà sản xuất";
            dtg_showchitietlaptop.Columns[8].Name = "Mã màu sắc";
            dtg_showchitietlaptop.Columns[9].Name = "Mô tả";
            dtg_showchitietlaptop.Columns[10].Name = "Số lượng";
            dtg_showchitietlaptop.Columns[11].Name = "Giá nhập";
            dtg_showchitietlaptop.Columns[12].Name = "Giá bán";
            dtg_showchitietlaptop.Columns[13].Name = "Số Imei";
            dtg_showchitietlaptop.Columns[2].Visible = false;
            dtg_showchitietlaptop.Columns[3].Visible = false;
            dtg_showchitietlaptop.Columns[4].Visible = false;
            dtg_showchitietlaptop.Columns[7].Visible = false;
            dtg_showchitietlaptop.Columns[8].Visible = false;
            dtg_showchitietlaptop.Columns[9].Visible = false;
            dtg_showchitietlaptop.Columns[10].Visible = false;
            dtg_showchitietlaptop.Columns[11].Visible = false;
            dtg_showchitietlaptop.Columns[12].Visible = false;
            dtg_showchitietlaptop.Columns[13].Visible = false;
            foreach (var s in list)
            {
                sttctlt++;
                dtg_showchitietlaptop.Rows.Add(s.ID, sttctlt, s.Ma, s.MaLaptop, s.TenLaptop, s.TenThuocTinh, s.ThongSoGiaTri, s.MaNsx, s.MaMauSac, s.MoTa, s.SoLuong, s.GiaNhap, s.Giaban, s.SoImei);
            }
        }
        void LoadCombobox()
        {
            cbb_mams.Items.Clear();
            cbb_mansx.Items.Clear();
            cbb_idlaptoptt.Items.Clear();
            cbb_malaptopctlt.Items.Clear();
            cbb_idthuoctinh.Items.Clear();
            foreach (var d in mauSacService.GetMauSac())
            {
                cbb_mams.Items.Add(d.Ma);
            }
            foreach (var e in nsxService.GetNsx())
            {
                cbb_mansx.Items.Add(e.Ma);
            }
            foreach (var f in laptopService.GetLaptop())
            {
                cbb_idlaptoptt.Items.Add(f.Ma);
                cbb_malaptopctlt.Items.Add(f.Ma);
            }
            foreach (var i in thuocTinhService.GetThuocTinh())
            {
                cbb_idthuoctinh.Items.Add(i.Ma);
            }
        }

        private void QuanLyLaptopForm_Load(object sender, EventArgs e)
        {
            LoadCombobox();
            LoadDataMauSac(mauSacService.GetMauSac());
            LoadDataNsx(nsxService.GetNsx());
            LoadDataLaptop(laptopService.GetLaptop());
            LoadDataThuocTinh(thuocTinhService.GetThuocTinh());
            LoadDataGiaTri(giaTriService.GetGiaTri());
            LoadDataChiTietLaptop(chiTietLaptopService.GetChiTietLaptop());

        }

        private void btn_themms_Click(object sender, EventArgs e)
        {
            if (tbx_mams.Text == "" || tbx_tenms.Text == "")
            {
                MessageBox.Show("Hãy điển đủ thông tin", "Warrning !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MauSacView blue = new MauSacView();
                blue.ID = Guid.NewGuid();
                blue.Ma = tbx_mams.Text;
                blue.Ten = tbx_tenms.Text;
                if (mauSacService.CheckMa(tbx_mams.Text))
                {
                    MessageBox.Show("Mã đã tồn tại", "Warrning !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(mauSacService.Add(blue));
                    LoadDataMauSac(mauSacService.GetMauSac());
                }
            }

        }

        private void btn_suams_Click(object sender, EventArgs e)
        {
            if (tbx_tenms.Text == "")
            {
                MessageBox.Show("Hãy điển đủ thông tin", "Warrning !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    MauSacView blue = new MauSacView();
                    blue.ID = GetIdMauSac;
                    blue.Ten = tbx_tenms.Text;
                    MessageBox.Show(mauSacService.Update(blue));
                    LoadDataMauSac(mauSacService.GetMauSac());
                }
                catch (Exception)
                {
                    MessageBox.Show("Hãy chọn để sửa", "Warrning !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btn_xoams_Click(object sender, EventArgs e)
        {
            try
            {
                MauSacView blue = new MauSacView();
                blue.ID = GetIdMauSac;
                MessageBox.Show(mauSacService.Delete(blue));
                LoadDataMauSac(mauSacService.GetMauSac());
            }
            catch (Exception)
            {

                MessageBox.Show("Hãy chọn để xóa", "Warrning !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void dtg_showmausac_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                GetIdMauSac = Guid.Parse(dtg_showmausac.CurrentRow.Cells[0].Value.ToString());
                tbx_mams.Text = dtg_showmausac.CurrentRow.Cells[2].Value.ToString();
                tbx_tenms.Text = dtg_showmausac.CurrentRow.Cells[3].Value.ToString();
            }
            catch (Exception)
            {

            }

        }

        private void btn_themnsx_Click(object sender, EventArgs e)
        {
            if (tbx_mansx.Text == "" || tbx_tennsx.Text == "")
            {
                MessageBox.Show("Hãy điển đủ thông tin", "Warrning !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                NsxView apple = new NsxView();
                apple.ID = Guid.NewGuid();
                apple.Ma = tbx_mansx.Text;
                apple.Ten = tbx_tennsx.Text;
                if (nsxService.CheckMa(tbx_mansx.Text))
                {
                    MessageBox.Show("Mã đã tồn tại", "Warrning !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(nsxService.Add(apple));
                    LoadDataNsx(nsxService.GetNsx());
                }
            }

        }

        private void btn_suansx_Click(object sender, EventArgs e)
        {
            if (tbx_tennsx.Text == "")
            {
                MessageBox.Show("Hãy điển đủ thông tin", "Warrning !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    NsxView apple = new NsxView();
                    apple.ID = GetIdNsx;
                    apple.Ten = tbx_tennsx.Text;
                    MessageBox.Show(nsxService.Update(apple));
                    LoadDataNsx(nsxService.GetNsx());
                }
                catch (Exception)
                {

                }

            }
        }

        private void btn_xoansx_Click(object sender, EventArgs e)
        {
            try
            {
                NsxView apple = new NsxView();
                apple.ID = GetIdNsx;
                MessageBox.Show(nsxService.Delete(apple));
                LoadDataNsx(nsxService.GetNsx());
            }
            catch (Exception)
            {
            }

        }

        private void dtg_shownsx_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                GetIdNsx = Guid.Parse(dtg_shownsx.CurrentRow.Cells[0].Value.ToString());
                tbx_mansx.Text = dtg_shownsx.CurrentRow.Cells[2].Value.ToString();
                tbx_tennsx.Text = dtg_shownsx.CurrentRow.Cells[3].Value.ToString();
            }
            catch (Exception)
            {

            }

        }

        private void btn_themlt_Click(object sender, EventArgs e)
        {
            if (tbx_malaptop.Text == "" || tbx_tenlaptop.Text == "")
            {
                MessageBox.Show("Hãy điền đủ thông tin", "Warrning !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                LaptopView lv = new LaptopView();
                lv.ID = Guid.NewGuid();
                lv.Ma = tbx_malaptop.Text;
                lv.Ten = tbx_tenlaptop.Text;
                if (laptopService.CheckMa(tbx_malaptop.Text))
                {
                    MessageBox.Show("Mã đã tồn tại", "Warrning !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(laptopService.AddLaptop(lv));
                    LoadDataLaptop(laptopService.GetLaptop());
                }
            }

        }

        private void btn_sualt_Click(object sender, EventArgs e)
        {
            if (tbx_malaptop.Text == "" || tbx_tenlaptop.Text == "")
            {
                MessageBox.Show("Hãy điền đủ thông tin", "Warrning !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    LaptopView lv = new LaptopView();
                    lv.ID = GetIdLaptop;
                    lv.Ten = tbx_tenlaptop.Text;
                    MessageBox.Show(laptopService.UpdateLaptop(lv));
                    LoadDataLaptop(laptopService.GetLaptop());
                }
                catch (Exception)
                {


                }

            }
        }

        private void btn_xoalt_Click(object sender, EventArgs e)
        {
            try
            {
                LaptopView lv = new LaptopView();
                lv.ID = GetIdLaptop;
                MessageBox.Show(laptopService.DeleteLaptop(lv));
                LoadDataLaptop(laptopService.GetLaptop());
            }
            catch (Exception)
            {

            }

        }

        private void dtg_showlaptop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                GetIdLaptop = Guid.Parse(dtg_showlaptop.CurrentRow.Cells[0].Value.ToString());
                tbx_malaptop.Text = dtg_showlaptop.CurrentRow.Cells[2].Value.ToString();
                tbx_tenlaptop.Text = dtg_showlaptop.CurrentRow.Cells[3].Value.ToString();
            }
            catch (Exception)
            {

            }

        }

        private void btn_themthuoctinh_Click(object sender, EventArgs e)
        {
            if (tbx_tenthuoctinh.Text == "" || tbx_mathuoctinh.Text == "" || cbb_idlaptoptt.Text == "")
            {

                MessageBox.Show("Hãy điền đủ thông tin", "Warrning !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    ThuocTinhView xinh = new ThuocTinhView();
                    xinh.ID = Guid.NewGuid();
                    xinh.IDLaptop = laptopService.GetLaptop().FirstOrDefault(a => a.Ma == cbb_idlaptoptt.Text).ID;
                    xinh.Ma = tbx_mathuoctinh.Text;
                    xinh.Ten = tbx_tenthuoctinh.Text;
                    if (thuocTinhService.CheckMaTt(tbx_mathuoctinh.Text))
                    {
                        MessageBox.Show("Mã đã tồn tại", "Warrning !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show(thuocTinhService.AddTt(xinh));
                        LoadDataThuocTinh(thuocTinhService.GetThuocTinh());
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Hãy kiểm tra thông tin", "Warrning !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }


        }

        private void btn_suathuoctinh_Click(object sender, EventArgs e)
        {
            if (tbx_mathuoctinh.Text == "")
            {

                MessageBox.Show("Hãy điền đủ thông tin", "Warrning !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    ThuocTinhView xinh = new ThuocTinhView();
                    xinh.ID = GetIdThuocTinh;
                    xinh.Ten = tbx_tenthuoctinh.Text;
                    MessageBox.Show(thuocTinhService.UpdateTt(xinh));
                    LoadDataThuocTinh(thuocTinhService.GetThuocTinh());
                }
                catch (Exception)
                {
                    MessageBox.Show("Hãy kiểm tra lại", "Warrning !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btn_xoathuoctinh_Click(object sender, EventArgs e)
        {
            try
            {
                ThuocTinhView xinh = new ThuocTinhView();
                xinh.ID = GetIdThuocTinh;
                MessageBox.Show(thuocTinhService.DeleteTt(xinh));
                LoadDataThuocTinh(thuocTinhService.GetThuocTinh());
            }
            catch (Exception)
            {
                MessageBox.Show("Hãy kiểm tra thông tin", "Warrning !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void dtg_showthuoctinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                GetIdThuocTinh = Guid.Parse(dtg_showthuoctinh.CurrentRow.Cells[0].Value.ToString());
                tbx_mathuoctinh.Text = dtg_showthuoctinh.CurrentRow.Cells[2].Value.ToString();
                tbx_tenthuoctinh.Text = dtg_showthuoctinh.CurrentRow.Cells[4].Value.ToString();
                cbb_idlaptoptt.Text = dtg_showthuoctinh.CurrentRow.Cells[3].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Hãy kiểm tra thông tin", "Warrning !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btn_themgiatri_Click(object sender, EventArgs e)
        {
            if (tbx_magiatri.Text == "" || tbx_thongsogt.Text == "" || cbb_idthuoctinh.Text == "")
            {
                MessageBox.Show("Hãy điền đủ thông tin", "Warrning !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    GiaTriView gtv = new GiaTriView();
                    gtv.ID = Guid.NewGuid();
                    gtv.IDThuocTinh = thuocTinhService.GetThuocTinh().FirstOrDefault(a => a.Ma == cbb_idthuoctinh.Text).ID;
                    gtv.Ma = tbx_magiatri.Text;
                    gtv.ThongSo = tbx_thongsogt.Text;
                    if (giaTriService.CheckMaGt(tbx_magiatri.Text))
                    {
                        MessageBox.Show("Mã đã tồn tại", "Warrning !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show(giaTriService.AddGt(gtv));
                        LoadDataGiaTri(giaTriService.GetGiaTri());
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Hãy điền kiểm tra lại", "Warrning !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }


        }

        private void btn_suagiatri_Click(object sender, EventArgs e)
        {
            try
            {
                GiaTriView gtv = new GiaTriView();
                gtv.ID = GetIdGiaTri;
                gtv.ThongSo = tbx_thongsogt.Text;
                MessageBox.Show(giaTriService.UpDateGt(gtv));
                LoadDataGiaTri(giaTriService.GetGiaTri());
            }
            catch (Exception)
            {
                MessageBox.Show("Hãy kiểm tra thông tin", "Warrning !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btn_xoagiatri_Click(object sender, EventArgs e)
        {
            try
            {
                GiaTriView gtv = new GiaTriView();
                gtv.ID = GetIdGiaTri;
                MessageBox.Show(giaTriService.DeleteGt(gtv));
                LoadDataGiaTri(giaTriService.GetGiaTri());
            }
            catch (Exception)
            {
                MessageBox.Show("Hãy kiểm tra thông tin", "Warrning !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void dtg_showgiatri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                GetIdGiaTri = Guid.Parse(dtg_showgiatri.CurrentRow.Cells[0].Value.ToString());
                tbx_magiatri.Text = dtg_showgiatri.CurrentRow.Cells[2].Value.ToString();
                tbx_thongsogt.Text = dtg_showgiatri.CurrentRow.Cells[4].Value.ToString();
                cbb_idthuoctinh.Text = dtg_showgiatri.CurrentRow.Cells[3].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Hãy kiểm tra thông tin", "Warrning !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btn_themctlt_Click(object sender, EventArgs e)
        {
            try
            {
                decimal gianhap = Convert.ToDecimal(tbx_ctltgianhap.Text);
                decimal giaban = Convert.ToDecimal(tbx_ctltgiaban.Text);
                if (tbx_machitietlaptop.Text == "" || cbb_malaptopctlt.Text == "" || cbb_mansx.Text == "" || cbb_mams.Text == "" || tbx_mota.Text == "")
                {
                    MessageBox.Show("Hãy điền đủ thông tin", "Warrning !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (gianhap <= 0 || giaban <= 0 || giaban < gianhap)
                {
                    MessageBox.Show("Kiểm tra lại giá nhập giá bán", "Warrning !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    ChiTietLaptopView thao = new ChiTietLaptopView();
                    thao.ID = Guid.NewGuid();
                    thao.Ma = tbx_machitietlaptop.Text;
                    thao.IDLaptop = laptopService.GetLaptop().FirstOrDefault(a => a.Ma == cbb_malaptopctlt.Text).ID;
                    thao.IDMauSac = mauSacService.GetMauSac().FirstOrDefault(a => a.Ma == cbb_mams.Text).ID;
                    thao.IDNsx = nsxService.GetNsx().FirstOrDefault(a => a.Ma == cbb_mansx.Text).ID;
                    thao.MoTa = tbx_mota.Text;
                    thao.SoLuong = Convert.ToInt32(tbx_soluongctlt.Text);
                    thao.GiaNhap = Convert.ToDecimal(tbx_ctltgianhap.Text);
                    thao.Giaban = Convert.ToDecimal(tbx_ctltgiaban.Text);
                    if (chiTietLaptopService.CheckMa(tbx_machitietlaptop.Text))
                    {
                        MessageBox.Show("Mã đã tồn tại", "Warrning !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show(chiTietLaptopService.Add(thao));
                        LoadDataChiTietLaptop(chiTietLaptopService.GetChiTietLaptop());
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hãy kiểm tra thông tin", "Warrning !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }




        }

        private void btn_suactlt_Click(object sender, EventArgs e)
        {
            decimal gianhap = Convert.ToDecimal(tbx_ctltgianhap.Text);
            decimal giaban = Convert.ToDecimal(tbx_ctltgiaban.Text);
            if (tbx_mota.Text == "")
            {
                MessageBox.Show("Hãy điền đủ thông tin", "Warrning !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (gianhap <= 0 || giaban <= 0 || giaban < gianhap)
            {
                MessageBox.Show("Kiểm tra lại giá nhập giá bán", "Warrning !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    ChiTietLaptopView thao = new ChiTietLaptopView();
                    thao.ID = GetIdChiTietLaptop;
                    thao.MoTa = tbx_mota.Text;
                    thao.SoLuong = Convert.ToInt32(tbx_soluongctlt.Text);
                    thao.GiaNhap = Convert.ToDecimal(tbx_ctltgianhap.Text);
                    thao.Giaban = Convert.ToDecimal(tbx_ctltgiaban.Text);
                    MessageBox.Show(chiTietLaptopService.Update(thao));
                    LoadDataChiTietLaptop(chiTietLaptopService.GetChiTietLaptop());

                }
                catch (Exception)
                {

                    MessageBox.Show("Hãy kiểm tra thông tin", "Warrning !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btn_xoactlt_Click(object sender, EventArgs e)
        {
            try
            {
                ChiTietLaptopView thao = new ChiTietLaptopView();
                thao.ID = GetIdChiTietLaptop;
                MessageBox.Show(chiTietLaptopService.Delete(thao));
                LoadDataChiTietLaptop(chiTietLaptopService.GetChiTietLaptop());
            }
            catch (Exception)
            {

                MessageBox.Show("Hãy kiểm tra thông tin", "Warrning !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void dtg_showchitietlaptop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                GetIdChiTietLaptop = Guid.Parse(dtg_showchitietlaptop.CurrentRow.Cells[0].Value.ToString());
                tbx_machitietlaptop.Text = dtg_showchitietlaptop.CurrentRow.Cells[2].Value.ToString();
                cbb_malaptopctlt.Text = dtg_showchitietlaptop.CurrentRow.Cells[3].Value.ToString();
                cbb_mansx.Text = dtg_showchitietlaptop.CurrentRow.Cells[7].Value.ToString();
                cbb_mams.Text = dtg_showchitietlaptop.CurrentRow.Cells[8].Value.ToString();
                tbx_mota.Text = dtg_showchitietlaptop.CurrentRow.Cells[9].Value.ToString();
                tbx_soluongctlt.Text = Convert.ToString(dtg_showchitietlaptop.CurrentRow.Cells[10].Value.ToString());
                tbx_ctltgianhap.Text = dtg_showchitietlaptop.CurrentRow.Cells[11].Value.ToString();
                tbx_ctltgiaban.Text = dtg_showchitietlaptop.CurrentRow.Cells[12].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Hãy kiểm tra thông tin", "Warrning !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void tbx_ctltgianhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void tbx_ctltgiaban_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void tbx_soluongctlt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btn_themimei_Click(object sender, EventArgs e)
        {
            if (tbx_imei_mactlt.Text == "" || tbx_soimei.Text == "")
            {
                MessageBox.Show("Hãy kiểm tra thông tin", "Warrning !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (rbt_trangthai1.Checked == false && rbt_trangthai0.Checked == false)
            {
                MessageBox.Show("Hãy chọn trạng thái", "Warrning !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (imeiService.CheckSoImeil(tbx_soimei.Text))
            {
                MessageBox.Show("Số Imei đã tồn tại", "Warrning !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    ImeiView th = new ImeiView();
                    th.ID = Guid.NewGuid();
                    th.SoEmei = tbx_soimei.Text;
                    th.IDChiTietLaptop = chiTietLaptopService.GetChiTietLaptopNoJoin().FirstOrDefault(a => a.Ma == tbx_imei_mactlt.Text).ID;
                    if (rbt_trangthai1.Checked)
                    {
                        th.TrangThai = 1;
                    }
                    else
                    {
                        th.TrangThai = 0;
                    }
                    MessageBox.Show(imeiService.Add(th));
                }
                catch (Exception)
                {
                    MessageBox.Show("Hãy kiểm tra thông tin", "Warrning !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }

        }
        private void ShowImei(List<ImeiView> imeiViews)
        {
            dtg_showimei.Rows.Clear();
            dtg_showimei.ColumnCount = 4;
            dtg_showimei.Columns[0].Name = "ID";
            dtg_showimei.Columns[0].Visible = false;
            dtg_showimei.Columns[1].Name = "Mã";
            dtg_showimei.Columns[2].Name = "Tên";
            dtg_showimei.Columns[3].Name = "Trạng thái";
            foreach (var d in imeiViews)
            {
                string trangthai;
                if (d.TrangThai ==  1)
                    trangthai = "chưa bán";
                else
                {
                    trangthai = "đã bán rồi";
                }

                dtg_showimei.Rows.Add(d.ID, d.SoEmei,trangthai);
            }


        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
