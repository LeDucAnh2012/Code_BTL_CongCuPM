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
    public partial class fMuonSach_User : Form
    {
        BLL_MuonSach_User bll = new BLL_MuonSach_User();
        public fMuonSach_User()
        {
            InitializeComponent();
        }
        public fMuonSach_User(object sender, EventArgs e) : this()
        {
            fMuonSach_User_Load(sender, e);
            InitializeComponent();
        }
        int maph = 1;
        private void fMuonSach_User_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            txtMaPhieu1.Text = random.Next(1, 99999).ToString();
            
            
            
            DataTable dt = bll.getDataTmpLogin();
            foreach (DataRow row in dt.Rows)
            {
                labMaDocGia.Text = row["MaDocGia"].ToString();
                labTenDocGia.Text = row["TenDocGia"].ToString();
                labSDT.Text = row["SDT"].ToString();

            }

            dgvTTSachMuon.DataSource = bll.PhieuMuon();
            dgvTTSachMuon.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            bll.XoaPhieuMuonTam();
            fMainForUser f = new fMainForUser();
            f.FormClosed += new FormClosedEventHandler(fMainForUser);
            f.Show();
            this.Hide();
        }
        private void fMainForUser(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMuon_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = bll.getDataTmpSachMuon();
                bll.themThieuMuon(txtMaPhieu1.Text, labMaDocGia.Text, labTenDocGia.Text, labSDT.Text, dtpNgayMuon.Value);
                foreach (DataRow row in dt.Rows)
                {
                    bll.themListBooksPhieuMuon(txtMaPhieu1.Text, row["MaSach1"].ToString(), row["TenSach1"].ToString(), row["TenTheLoai"].ToString());
                }
                MessageBox.Show("In Thanh Cong");
                bll.XoaPhieuMuonTam();
                fMainForUser f = new fMainForUser();
                f.FormClosed += new FormClosedEventHandler(fMainForUser);
                f.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("In That Bai.", "Error");
            }
        }
    }
}
