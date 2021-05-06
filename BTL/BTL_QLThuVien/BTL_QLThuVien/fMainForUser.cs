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
    public partial class fMainForUser : Form
    {
        public static fMainForUser instance ;

        void Awake()
        {
            MaktInstance();
        }
        void MaktInstance()
        {
            if (instance == null)
                instance = this;
        }

        BLL_TaiKhoan_User bll = new BLL_TaiKhoan_User();
        BLL_MuonSach_User bllMuon = new BLL_MuonSach_User();
        public fMainForUser()
        {
            InitializeComponent();
        }

        private void btnInPhieuMuon_Click(object sender, EventArgs e)
        {
            fMuonSach_User f = new fMuonSach_User();
            f.FormClosed += new FormClosedEventHandler(fMuonSach_);
            f.Show();
            this.Hide();
        }

        private void fMuonSach_(object sender, EventArgs e)
        {
            this.Show();
        }

        private void fUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (fUser.SelectedIndex == 1)
            {
                DataTable dt = bll.GetDataTable();
                foreach (DataRow row in dt.Rows)
                {
                    txtTenDangNhap.Text = row["TenDangNhap"].ToString();
                    txtMatKhau.Text = row["MatKhau"].ToString();
                    txtMaDocGia.Text = row["MaDocGia"].ToString();
                    txtTenDocGia.Text = row["TenDocGia"].ToString();
                    dtpNgaySinh.Value = Convert.ToDateTime(row["NgaySinh"].ToString());
                    txtDiaChi.Text = row["DiaChi"].ToString();
                    txtSDT.Text = row["SDT"].ToString();
                    txtCMND.Text = row["CCCD"].ToString();
                    dtpNgayDangKy.Value = Convert.ToDateTime(row["NgayDangKy"].ToString());
                    break;
                }

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            bll.SUA(txtTenDangNhap.Text, txtMaDocGia.Text, txtTenDocGia.Text, Convert.ToDateTime(dtpNgaySinh.Value),
               txtDiaChi.Text, (txtSDT.Text), (txtCMND.Text), dtpNgayDangKy.Value);
            bll.SUAPASS(txtTenDangNhap.Text, txtMatKhau.Text);
            MessageBox.Show("Sửa thành công!");
        }

        private void btnTimKiem_MuonSach_Click(object sender, EventArgs e)
        {
            dgvMuonSach.DataSource = bllMuon.timKiemBangTenSach(txtTimKiem.Text);
        }

        private void fMainForUser_Load(object sender, EventArgs e)
        {
          
            dgvMuonSach.DataSource = bllMuon.showSach();
        }

        //tạo datatable tạm
        DataTable tmp_dt = new DataTable();

        private void btnThemMot_Click(object sender, EventArgs e)
        {
            listSachMuon.View = View.Details;


            string[] x = {dgvMuonSach.Rows[row].Cells[0].Value.ToString(), dgvMuonSach.Rows[row].Cells[1].Value.ToString(),
                dgvMuonSach.Rows[row].Cells[2].Value.ToString(), dgvMuonSach.Rows[row].Cells[3].Value.ToString(),
                dgvMuonSach.Rows[row].Cells[4].Value.ToString(), dgvMuonSach.Rows[row].Cells[5].Value.ToString() };

            ListViewItem Lvi = new ListViewItem(x);

            listSachMuon.Items.Add(Lvi);

            int index = dgvMuonSach.CurrentCell.RowIndex;

            bllMuon.MuonSach(dgvMuonSach.Rows[row].Cells[0].Value.ToString(), dgvMuonSach.Rows[row].Cells[1].Value.ToString(),
               Convert.ToDateTime(dgvMuonSach.Rows[row].Cells[3].Value.ToString()),
                dgvMuonSach.Rows[row].Cells[4].Value.ToString(), dgvMuonSach.Rows[row].Cells[5].Value.ToString());

        }
        int row = 0;
        private void dgvMuonSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
        }

        private void btnBotMot_Click(object sender, EventArgs e)
        {

            if (listSachMuon.SelectedItems.Count > 0)
            {
                DialogResult dl = MessageBox.Show("Bạn muốn xóa?", "canh bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dl == DialogResult.OK)
                    listSachMuon.Items.Remove(listSachMuon.SelectedItems[0]);
            }
            else MessageBox.Show("Xóa lỗi");

        }

        private void btnBotNhieu_Click(object sender, EventArgs e)
        {

            DialogResult dl = MessageBox.Show("Bạn muốn xóa tất cả?", "canh bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dl == DialogResult.OK)
                listSachMuon.Items.Clear();

        }

        private void btnThoatfMainUser_Click(object sender, EventArgs e)
        {
            BULs bul = new BULs();
            bul.DeleteInforLoginTo_TMP_TABLE();
            fLogin f = new fLogin();
            f.FormClosed += new FormClosedEventHandler(fLogin1);
            f.Show();
            this.Hide();
        }
        private void fLogin1 (object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgvMuonSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
