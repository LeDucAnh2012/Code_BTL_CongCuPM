using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace BTL_QLThuVien
{
    class BLL_MuonSach_User
    {
        DAls dal = new DAls();
        public DataTable showSach()
        {
            string sql = "select * from Sach";
            return dal.GetData(sql);
        }
        
        public DataTable getDataTmpLogin()
        {
            string sql = "select MaDocGia,TenDocGia,SDT from DocGia , tmp_Login where tmp_Login.username = Docgia.TenDangNhap";
            return dal.GetData(sql);
        }
        public DataTable getDataTmpSachMuon()
        {
            string sql = "select * from tmp_SachMuon, TheLoai where TheLoai.MaTheLoai=tmp_SachMuon.MaTheLoai1";
            return dal.GetData(sql);
        }
       // public bool themPhieuMuon(string MaPhieuMuon, string MaDocGia, string TenDocGia, string SDTDocGia,
         //                           string MaSach, string TenSach,string TenTheLoai, int SoLuong) {
           // string sql= "insert into PhieuMuon values() "
        //} 
        
        public DataTable timKiemBangTenSach(string TenSach)
        {
            string sql = "select * from Sach where TenSach like N'%" + TenSach + "%'";
            return dal.GetData(sql);
        }
        public bool MuonSach(string MaSach,string TenSach,DateTime NgayNhap,string TinhTrang ,string MaTheLoai)
        {
            string sql = "insert into tmp_SachMuon values('"+MaSach+ "',N'"+TenSach+ "','"+NgayNhap+"',N'"+TinhTrang+"','"+MaTheLoai+"')";
            return dal.Execute(sql);
        }
        //hiện data table ở data grid view trong form in
        public DataTable PhieuMuon()
        {
            string sql = "select * from tmp_SachMuon";
            return dal.GetData(sql);
        }
        public bool XoaPhieuMuonTam()
        {
            string sql = "delete from tmp_SachMuon";
            return dal.Execute(sql);
        }
        public bool themThieuMuon(string MaPhieuMuon, string MaDocGia, string TenDocGia, string SDTDocGia,DateTime NgayMuon)
        {
            string sql = "insert into PhieuMuon values('"+MaPhieuMuon+ "', '"+MaDocGia+ "', N'"+TenDocGia+ "', '"+SDTDocGia+ "','',N'','','"+NgayMuon+"',0)";
            return dal.Execute(sql);
        }
        public bool themListBooksPhieuMuon(string MaPhieuMuon, string MaSach,string TenSach, string TenTheLoai)
        {
            string sql = "insert into ListBooksPhieuMuon values('"+MaPhieuMuon+ "', '"+MaSach+ "', N'"+TenSach+ "', N'"+TenTheLoai+ "',0)";
            return dal.Execute(sql);
        }
    }
}
