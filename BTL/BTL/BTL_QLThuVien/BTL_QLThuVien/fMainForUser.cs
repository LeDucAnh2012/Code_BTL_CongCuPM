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
        BLL_TaiKhoan_User bll = new BLL_TaiKhoan_User();
        BLL_MuonSach_User bllMuon = new BLL_MuonSach_User();

        public fMainForUser()
        {
            InitializeComponent();
        }


        private void fUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (fUser.SelectedIndex==1) {
                DataTable dt = bll.GetDataTable();
                foreach(DataRow row in dt.Rows) {
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

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            bll.SUA(txtTenDangNhap.Text, txtMaDocGia.Text, txtTenDocGia.Text, Convert.ToDateTime(dtpNgaySinh.Value),
                txtDiaChi.Text, (txtSDT.Text), (txtCMND.Text),dtpNgayDangKy.Value);
            bll.SUAPASS(txtTenDangNhap.Text, txtMatKhau.Text);
            MessageBox.Show("Sửa thành công!");
        }

        

        private void btnThoat_MuonSach_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void btnTimKiem_MuonSach_Click(object sender, EventArgs e)
        {
            
            dgvMuonSach.DataSource = bllMuon.timKiemBangTenSach(txtTimKiem.Text);
            /*if (dgvMuonSach.Rows.Count <= 0)
            {
                dgvMuonSach.DataSource = bllMuon.timKiemBangTenSach(txtTimKiem.Text);
                if(dgvMuonSach.Rows.Count <= 0)
                {
                    dgvMuonSach.DataSource = bllMuon.timKiemBangMaTheLoai(txtTimKiem.Text);
                }
            }*/
            
        }

        private void fMainForUser_Load(object sender, EventArgs e)
        {
            dgvMuonSach.DataSource = bllMuon.showSach();
            //DuLieu();

        }

        //tạo datatable tạm
        DataTable tmp_dt = new DataTable();
        
        private void btnThemMot_Click(object sender, EventArgs e)
        {
          
            //listSachMuon.Items.Add();
           
            listSachMuon.View = View.Details;


            string[] x = {dgvMuonSach.Rows[row].Cells[0].Value.ToString(), dgvMuonSach.Rows[row].Cells[1].Value.ToString(),
                dgvMuonSach.Rows[row].Cells[2].Value.ToString(), dgvMuonSach.Rows[row].Cells[3].Value.ToString(),
                dgvMuonSach.Rows[row].Cells[4].Value.ToString(), dgvMuonSach.Rows[row].Cells[5].Value.ToString() };

            ListViewItem Lvi = new ListViewItem(x);
            
            listSachMuon.Items.Add(Lvi);

            int index = dgvMuonSach.CurrentCell.RowIndex;
            
            bllMuon.MuonSach(dgvMuonSach.Rows[row].Cells[0].Value.ToString(), dgvMuonSach.Rows[row].Cells[1].Value.ToString(),
               Convert.ToDateTime( dgvMuonSach.Rows[row].Cells[3].Value.ToString()),
                dgvMuonSach.Rows[row].Cells[4].Value.ToString(), dgvMuonSach.Rows[row].Cells[5].Value.ToString());
          

            
        }
        private String epDanhSach(DataRow row)
        {
            string x;
            x = row["MaSach"].ToString()+row["TenSach"].ToString()+ row["SoTrang"].ToString() + row["NgayNhap"].ToString() + row["TinhTrang"].ToString() + row["MaTheLoai"].ToString() ;
            return x;
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

        private void listSachMuon_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void btnBotNhieu_Click(object sender, EventArgs e)
        {
            
                DialogResult dl = MessageBox.Show("Bạn muốn xóa tất cả?", "canh bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dl == DialogResult.OK)
                    listSachMuon.Items.Clear();
            
            
        }

    

        private void fMainForUser_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            BULs bul = new BULs();
            bul.DeleteInforLoginTo_TMP_TABLE();
            fLogin f = new fLogin();
            this.Close();
            f.Show();
        }
        /*private void DuLieu()
{
   tmp_dt.Columns.Add("MaSach", typeof(string));
   tmp_dt.Columns.Add("TenSach", typeof(string));
   tmp_dt.Columns.Add("NgayNhap", typeof(DateTime));
   tmp_dt.Columns.Add("TinhTrang", typeof(string));
   tmp_dt.Columns.Add("MaTheLoai", typeof(string));

}*/

    }
}
