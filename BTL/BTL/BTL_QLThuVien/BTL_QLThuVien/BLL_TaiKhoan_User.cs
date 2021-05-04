using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BTL_QLThuVien
{
    
    class BLL_TaiKhoan_User
    {
        DAls dal = new DAls();
        
        public DataTable GetDataTable()
        {
            string sql = "select * from DocGia,TaiKhoan Where TaiKhoan.TenDangNhap = DocGia.TenDangNhap";

            return dal.GetData(sql);
        }

        public bool SUA(string TenDangNhap,string MaDocGia, string TenDocGia, DateTime NgaySinh, string DiaChi, string SDT, string CCCD, DateTime NgayDangKy)
        {

            string sql = "update DocGia set MaDocGia='" + MaDocGia + "',TenDocGia=N'" + TenDocGia + "',NgaySinh='" + NgaySinh + "',DiaChi=N'" + DiaChi + "',SDT='" + SDT + "',CCCD='" + CCCD + "',NgayDangKy='" + NgayDangKy + "' where TenDangNhap='" + TenDangNhap+"' ";
            
            return dal.Execute(sql);
            
        }
        public bool SUAPASS(string TenDangNhap, string MatKhau) {
            string sql = "update TaiKhoan set MatKhau='" + MatKhau + "' where TenDangNhap='" + TenDangNhap + "'";
            return dal.Execute(sql);
        }

    }
}
