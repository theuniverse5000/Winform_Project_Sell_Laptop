using _2.BUS.IService;
using _2.BUS.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2.BUS.ViewModels;

namespace _3.PL.Views
{
    public partial class SendEmailResetPassWord : Form
    {
        INhanVienService nhanVienService;
        public SendEmailResetPassWord()
        {
            InitializeComponent();
            nhanVienService = new NhanVienService();
        }
        string rand_num = Convert.ToString(new Random().Next(1000, 9999));
        private void btn_GuiMA_Click(object sender, EventArgs e)
        {

            if (tb_EmailNguoiNhan.Text == "")
            {
                MessageBox.Show("Mời bạn nhập email nhân viên quán ");
            }
            else
            {
                if (nhanVienService.CheckGmail(tb_EmailNguoiNhan.Text))
                {
                    string from, to, pass, content;
                    //from = "thiennguvl2@gmail.com";
                    //to = tb_EmailNguoiNhan.Text.Trim();
                    //pass = "thien1402";
                    from = "thiendvph28231@fpt.edu.vn";
                    to = tb_EmailNguoiNhan.Text.Trim();
                    pass = "conpig49kg";
                    content = "Mã xác nhận của bạn là " + rand_num;
                    MailMessage mail = new MailMessage();
                    mail.To.Add(to);
                    mail.From = new MailAddress(from);
                    mail.Subject = "Mã xác nhận đăng nhập";
                    mail.Body = content;
                    SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                    smtp.EnableSsl = true;
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Credentials = new NetworkCredential(from, pass);
                    try
                    {
                        smtp.Send(mail);
                        MessageBox.Show("email đã gửi thành công ", "Email", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tb_MaXacNhan.Enabled = true;
                        btn_XacnhanMa.Enabled = true;
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message, "Email", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {

                    MessageBox.Show("Email ban Khong phai la nhan vien cua quan ");
                    tb_EmailNguoiNhan.Text = "";
                }
            }
        }

        private void btn_XacnhanMa_Click(object sender, EventArgs e)
        {
            if (tb_MaXacNhan.Text == rand_num)
            {
                MessageBox.Show("Nhập mật khẩu mới");
                tb_NhapLaiMatKhau.Enabled = true;
                tb_NhapMatKhauMoi.Enabled = true;

            }
            else
            {
                tb_MaXacNhan.Text = "";
                MessageBox.Show("Nhập lại mã");
            }
        }

        static bool CheckPassword(string psw)
        {
            
            if (psw.Length < 8)
                return false;
            bool hasLower = false;
            bool hasUpper = false;
            bool hasDigit = false;
            for(int i = 0; i < psw.Length; i++)
            {
                if(psw[i] >= 'a' && psw[i] < 'z')
                    hasLower = true;
                if (psw[i] >= 'A' && psw[i] < 'Z')
                    hasUpper = true;
                if (psw[i] >= '0' && psw[i] < '9')
                    hasDigit = true;
                if(hasLower && hasUpper && hasDigit)
                    return true;
            }
            return false;
        }
        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            NhanVienView cc = new NhanVienView();
            Guid GetIdnvtoDMK = nhanVienService.GetAllNhanVien().FirstOrDefault(c => c.Gmail == tb_EmailNguoiNhan.Text).ID;
            cc.ID = GetIdnvtoDMK;
            cc.MatKhau = tb_NhapLaiMatKhau.Text;
            bool check = CheckPassword(tb_NhapMatKhauMoi.Text);
            if(check == true)
            {
                if(tb_NhapMatKhauMoi.Text == "" && tb_NhapLaiMatKhau.Text == "")
                {
                    if(tb_NhapMatKhauMoi.Text != tb_NhapMatKhauMoi.Text)
                    {
                        MessageBox.Show("Doi Mat khau thanh cong moi ban dang nhap");
                        this.Hide();
                        FormLogin laf = new FormLogin();
                        laf.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu không trùng nhau");
                    }
                }else
                {
                    MessageBox.Show("Mời bạn nhập mật khẩu ");
                }
                MessageBox.Show("");
            }
            else
            {
                MessageBox.Show("Mời bạn nhập mật khẩu đầy đủ");
            }

        }
    }
}
