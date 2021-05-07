using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QLThuVien
{
    public partial class fResistration : Form
    {
        BUL_MainAdmin bul = new BUL_MainAdmin();
        public fResistration()
        {
            InitializeComponent();
        }

        private void btnCancelBorrow_Click(object sender, EventArgs e)
        {
            fLogin f = new fLogin();
            f.FormClosed += new FormClosedEventHandler(fLogin);
            f.Show();
            this.Hide();
        }
        private void fLogin(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void btnDangKy_Click(object sender, EventArgs e)
        {
            try
            {
                if (bul.InsertUser(MappingCode()) && CheckTextBoxEmptyOfUser() && bul.InsertAccountLogin(MappingCodeOfUserAccount()))
                {
                    MessageBox.Show("Đăng ký thành công");

                    CleanForm();
                }
                else
                {
                    MessageBox.Show("Đăng ký thất bại. Xem lại dữ liệu");
                }
            }
            catch (Exception ex)
            {

            }
        }

        //Anh Xa Code
        private User MappingCode()
        {
            User u = new User();
            u.NameLogin = txtTenDangNhap.Text;
            u.UserCode = txtMaDocGia.Text;
            u.UserName = txtTenDocGia.Text;
            u.DateOfBirth = dateTimePickerNgaySinh.Value;
            u.Address = txtDiaChi.Text;
            u.SDT = txtSDT.Text;
            u.DateResistration = dateTimePickerNgayDangKy.Value;
            u.CCCD = txtCCCD.Text;
            return u;

        }

        private bool CheckTextBoxEmptyOfUser()
        {
            if (txtTenDangNhap.Text == "") return false;
            if (txtMatKhau.Text == "") return false;
            if (txtTenDocGia.Text == "") return false;
            if (txtMaDocGia.Text == "") return false;
            if (dateTimePickerNgayDangKy.Text == "") return false;
            if (dateTimePickerNgaySinh.Text == "") return false;
            if (txtSDT.Text == "") return false;
            if (txtCCCD.Text == "") return false;
            if (txtDiaChi.Text == "") return false;
            return true;
        }
        private AccountLogin MappingCodeOfUserAccount()
        {
            AccountLogin ac = new AccountLogin();
            ac.NameLogin = txtTenDangNhap.Text;
            ac.PassWord = txtMatKhau.Text;
            ac.PhanQuyen = false;
            return ac;
        }
        // clear textbox
        private void CleanForm()
        {
            txtTenDangNhap.Clear();
            txtMaDocGia.Clear();
            txtTenDocGia.Clear();
            txtMatKhau.Clear();
            txtDiaChi.Clear();
            txtSDT.Clear();
            txtCCCD.Clear();
            txtTenDangNhap.Focus();
        }

        private void fResistration_Load(object sender, EventArgs e)
        {

        }
    }
}
