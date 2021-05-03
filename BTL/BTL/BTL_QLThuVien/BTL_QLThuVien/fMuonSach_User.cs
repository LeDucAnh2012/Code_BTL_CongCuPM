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
        DataTable dt;
        public fMuonSach_User()
        {
            InitializeComponent();
            
        }
        public fMuonSach_User( object sender,EventArgs e): this()
        {
            fMuonSach_User_Load(sender, e);
            InitializeComponent();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            bll.XoaPhieuMuonTam();
            fMainForUser f = new fMainForUser();
            f.FormClosed += new FormClosedEventHandler(fMainForUser);
            f.Show();
            this.Close();
        }
        private void fMainForUser(object sender,EventArgs e)
        {
            Application.Exit();
        }

        private void fMuonSach_User_Load(object sender, EventArgs e)
        {

            dgvTTSachMuon.DataSource = bll.PhieuMuon();
            dgvTTSachMuon.ForeColor = Color.FromArgb(0,0,0);
            //bll.XoaPhieuMuonTam();
        }
    }
}
