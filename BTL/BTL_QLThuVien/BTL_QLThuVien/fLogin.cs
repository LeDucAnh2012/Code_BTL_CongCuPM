using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace BTL_QLThuVien
{
    public partial class fLogin : Form
    {
        
        public fLogin()
        {
            InitializeComponent();
        }

        public static fLogin f;
        public static bool check = true;
        BULs bul = new BULs();

       
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            check = true;
            string userName = txtTenDangNhap.Text;
            string pass = txtMatKhau.Text;
            bool Pk = true;
            if (radioAdmin.Checked)
            {
                Pk = true;
            }
            else if (radioUser.Checked)
                Pk = false;
            else
            {
                MessageBox.Show("Hãy chọn quyền đăng nhập.");
                check = false;
            }
            if (check)
            {

                if (bul.GetTableInforLogin(userName, pass, Pk).Rows.Count > 0 && Pk == true)
                {
                    bul.InsertInforLoginTo_TMP_TABLE(userName, pass, Pk);
                    fMainForAdmin f = new fMainForAdmin();
                    f.FormClosed += new FormClosedEventHandler(ShowForm);
                    txtMatKhau.Clear();
                    txtTenDangNhap.Clear();
                    radioAdmin.Checked = false;
                    radioUser.Checked = false;
                    f.Show();
                    this.Hide();

                }
                else if(bul.GetTableInforLogin(userName,pass,Pk).Rows.Count > 0 && Pk == false)
                {
                    bul.InsertInforLoginTo_TMP_TABLE(userName, pass, Pk);
                    fMainForUser f = new fMainForUser();
                    f.FormClosed += new FormClosedEventHandler(ShowForm);
                    txtMatKhau.Clear();
                    txtTenDangNhap.Clear();
                    radioAdmin.Checked = false;
                    radioUser.Checked = false;
                    f.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Đăng Nhập không thành công\nXem lại thông tin tài khoản");
                    txtMatKhau.Clear();
                    txtTenDangNhap.Clear();
                    radioAdmin.Checked = false;
                    radioUser.Checked = false;
                } 
                    
            }
        }
        private void ShowForm(object sender, EventArgs e)
        {
            this.Show();
        }
        private void fLogin_Load(object sender, EventArgs e)
        {
          
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát không?","Thông Báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            Application.Exit();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            fResistration f = new fResistration();
            f.FormClosed += new FormClosedEventHandler(ShowForm);
            f.Show();
            this.Hide();
        }
        
    }
}
