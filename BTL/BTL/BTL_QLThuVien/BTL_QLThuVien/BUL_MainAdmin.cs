using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BTL_QLThuVien
{
    public class BUL_MainAdmin
    {
        DAls dal = new DAls();
        //ThuThu Table
        #region
        
        // Funct Get Data TABLE ThuThu
        public DataTable GetDataLibrarian()
        {
            string sqlSelect = "select * from ThuThu";
            return dal.GetData(sqlSelect);
        }

        // Funct DELETE Data with NameLogin
        public bool DeleteLibrarian(string UserName)
        {
            string sqlDELETE = "delete from ThuThu Where TenDangNhap = '" + UserName + "'";
            return dal.Execute(sqlDELETE);
        }

        //Update Account
        public bool UpdateLibrarian(Librarian libra)
        {
            string SqlUPDATE = "update ThuThu set TenDangNhap = '" + libra.NameLogin + "', MaThuThu = '" + libra.LibrarianCode + "', TenThuThu = '"+libra.LibrarianName+"'" +
                ", NgaySinh = '"+libra.DateOfBirth+"', DiaChi = '"+libra.Address+"',SDT = '"+libra.PhoneNumber+"',CCCD = '"+libra.CCCD+"',NgayVaoLam = '"+libra.DateBeginWork+"'where TenDangNhap = '" + libra.NameLogin + "'";
            return dal.Execute(SqlUPDATE);
        }

        #endregion
        //---------------------------------------------------------------
        //-----------------------------------------------------------------
        //User Management
        #region

        // Funct Get Data TABLE User
        public DataTable GetInforUser()
        {
            string sqlSELECT = "select * FROM DocGia";
            return dal.GetData(sqlSELECT);
        }

        //Funct Insert 
        public bool InsertUser()
        {
            string sqlINSERT = "insert into DocGia values(,,,,,,,)";
            return dal.Execute(sqlINSERT);
        }
        #endregion

        //Borrow And Return
        #region
        // Funct Get Data TABLE Borrow And Return
        public DataTable GetInforBorrowAndReturnBooks()
        {
            string sqlSELECT = "select * FROM PhieuMuon";
            return dal.GetData(sqlSELECT);
        }
        #endregion

        #region
        


        #endregion



        //search by name
        public DataTable Search_By_Name(string name, string table)
        {
            if (table == "TaiKhoan")
            {
                string sqlSelect = "select TenDangNhap,MatKhau,PhanQuyen.TenPhanQuyen from TaiKhoan,PhanQuyen Where TaiKhoan.MaPhanQuyen = PhanQuyen.MaPhanQuyen AND TaiKhoan.TenDangNhap = '" + name + "'";
                return dal.GetData(sqlSelect);
            }
            if (table == "Docgia")
            {
                string sqlSelect = "select * from DocGia Where TenDangNhap = '" + name + "'";
                return dal.GetData(sqlSelect);
            }
            if (table == "Sach")
            {
                string sqlSelect = "select * from Sach Where TenSach = '" + name + "'";
                return dal.GetData(sqlSelect);
            }
            if (table == "NhaCungCap")
            {
                string sqlSelect = "select * from NhaCungCap Where TenNCC = '" + name + "'";
                return dal.GetData(sqlSelect);
            }
            if (table == "ThongKe")
            {
                string sqlSelect = "select * from DocGia Where TenDangNhap = '" + name + "'";
                return dal.GetData(sqlSelect);
            }
            return
                null;
        }

        //Get Data

        public DataTable GetStringData_DataIn_DataOut(string DataIn,string DataOut, string Table,string condition)
        {
            string sqlGetData = string.Format(" select MatKhau FROM TaiKhoan WHERE TenDangNhap = '" + condition+"' ");

            return dal.GetData(sqlGetData);
        }


       
    }
}
