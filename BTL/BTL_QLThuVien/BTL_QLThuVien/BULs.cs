using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace BTL_QLThuVien
{
    public class BULs
    {
        DAls dal = new DAls();

        // Funct Get Data TABLE Login
        public DataTable GetTableInforLogin(string user_name, string pass, bool Pk)
        {
            string sql = "select * from TaiKhoan Where TenDangNhap = '" + user_name + "' AND MatKhau = '" + pass + "' AND MaPhanQuyen = '" + Pk + "' ";
            DataTable dt = new DataTable();

            dt = dal.GetData(sql);
            return dt;
        }

        // Funct Insert Data to TABLE "TaiKhoan"
        public bool InsertInforLoginTo_TMP_TABLE(string user_name, string pass, bool Pk)
        {
            string sqlInsert = "insert into tmp_Login values ('" + user_name + "','" + pass + "','" + Pk + "')";
            return dal.Execute(sqlInsert);
        }

        // Funct DELETE Data table
        public void DeleteInforLoginTo_TMP_TABLE()
        {
            string sqlDELETE = "DELETE FROM tmp_Login";
            dal.Execute(sqlDELETE);
        }

        //Funct GetData tmp_Login
        public DataTable GetData_tmp_Login()
        {
            string SQL = "select MaThuThu,TenThuThu,SDT from ThuThu,tmp_Login where tmp_Login.username = ThuThu.TenDangNhap";
            return dal.GetData(SQL);
        }

        public DataTable GetData_thongke(DateTime Ngay, DateTime DenNgay)
        {
            string DG = "select TenDangNhap, DocGia.MaDocGia, DocGia.TenDocGia, NgaySinh, DiaChi, SDT, NgayMuon, SoNgayMuon from DocGia inner join PhieuMuon on DocGia.MaDocGia = PhieuMuon.MaDocGia where NgayMuon between '"+Ngay+"' And  '"+DenNgay+"'";
            return dal.GetData(DG);
        }

        public DataTable GetData_thongke1(DateTime Ngay, DateTime DenNgay)
        {
            string sach = "Select ListBooksPhieuMuon.MaPhieuMuon, MaSach, TenSach, TenTheLoai, SoLuong, TenDocGia, NgayMuon from ListBooksPhieuMuon inner join PhieuMuon on ListBooksPhieuMuon.MaPhieuMuon = PhieuMuon.MaPhieuMuon where NgayMuon between '" + Ngay + "' And  '" + DenNgay + "'";
            return dal.GetData(sach);
        }
    }
}
