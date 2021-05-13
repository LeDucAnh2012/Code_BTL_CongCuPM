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

        //TaiKhoan Table
        #region
        public bool InsertAccountLogin(AccountLogin AcL)
        {
            string SqlInsert = "insert into TaiKhoan Values('"+AcL.NameLogin+"','"+AcL.PassWord+"','"+AcL.PhanQuyen+"')";
            return dal.Execute(SqlInsert);
        }
        public bool UpdateAccountLogin(AccountLogin AcL)
        {
            string SqlUpdate = "update TaiKhoan set MatKhau = '"+AcL.PassWord+"',MaPhanQuyen = '"+AcL.PhanQuyen+"' Where TenDangNhap = '"+AcL.NameLogin+"'";
            return dal.Execute(SqlUpdate);
        }
        public bool DeleteAccountLogin(AccountLogin AcL)
        {
            string SqlDelete = "delete from TaiKhoan where TenDangNhap = '" + AcL.NameLogin + "'";
            return dal.Execute(SqlDelete);
        }
        #endregion

        //librarian Management
        #region

        // Funct Get Data TABLE ThuThu
        public DataTable GetDataLibrarian()
        {
            string sqlSelect = "select TaiKhoan.TenDangNhap,TaiKhoan.MatKhau,ThuThu.MaThuThu,ThuThu.TenThuThu,NgaySinh,DiaChi,SDT,CCCD,NgayVaoLam From ThuThu,TaiKhoan WHERE TaiKhoan.TenDangNhap = ThuThu.TenDangNhap";
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
            string SqlUPDATE = "update ThuThu set MaThuThu = '" + libra.LibrarianCode + "', TenThuThu = N'"+libra.LibrarianName+"'" +
                ", NgaySinh = '"+libra.DateOfBirth+"', DiaChi = N'"+libra.Address+"',SDT = '"+libra.PhoneNumber+"',CCCD = '"+libra.CCCD+"',NgayVaoLam = '"+libra.DateBeginWork+"'where TenDangNhap = '" + libra.NameLogin + "'";
            return dal.Execute(SqlUPDATE);
        }
        //Insert Librarian
        public bool InsertLibrarian(Librarian libra)
        {
            string SqlINSERT = "Insert into ThuThu Values('"+libra.NameLogin+"','"+libra.LibrarianCode+"',N'"+libra.LibrarianName+"','"+libra.DateOfBirth+"',N'"+libra.Address+"','"+libra.PhoneNumber+"','"+libra.CCCD+"','"+libra.DateBeginWork+"')";
            return dal.Execute(SqlINSERT);
        }

        #endregion
        

        //User Management
        #region

        // Funct Get Data TABLE DocGia
        public DataTable GetDataUser()
        {
            string sqlSelect = "select TaiKhoan.TenDangNhap,TaiKhoan.MatKhau,DocGia.MaDocGia,DocGia.TenDocGia,NgaySinh,DiaChi,SDT,CCCD,NgayDangKy From DocGia,TaiKhoan WHERE TaiKhoan.TenDangNhap = DocGia.TenDangNhap";
            return dal.GetData(sqlSelect);
        }

        // Funct DELETE Data with NameLogin
        public bool DeleteUser(string UserName)
        {
            string sqlDELETE = "delete from DocGia Where TenDangNhap = '" + UserName + "'";
            return dal.Execute(sqlDELETE);
        }

        //Update Account
        public bool UpdateUser(User Us)
        {
            string SqlUPDATE = "update DocGia set MaDocGia = '" + Us.UserCode + "', TenDocGia = '" + Us.UserName + "'" +
                ", NgaySinh = '" + Us.DateOfBirth + "', DiaChi = '" + Us.Address + "',SDT = '" +Us.SDT+ "',CCCD = '" + Us.CCCD + "',NgayDangKy = '" + Us.DateResistration + "'where TenDangNhap = '" + Us.NameLogin + "'";
            return dal.Execute(SqlUPDATE);
        }
        //Insert Librarian
        public bool InsertUser(User Us)
        {
            string SqlINSERT = "Insert into DocGia Values('" +Us.NameLogin+ "','" +Us.UserCode+ "',N'" +Us.UserName+ "','" +Us.DateOfBirth+ "',N'" +Us.Address+ "','" +Us.SDT+ "','" +Us.CCCD+ "','" +Us.DateResistration+ "')";
            return dal.Execute(SqlINSERT);
        }

        #endregion

        //Books  Management
        #region
        public bool InsertBookManagement(Books b)
        {
            string SqlINSERT = "Insert into Sach Values('" + b.BookCode + "',N'" + b.BookName + "','" + b.Amount + "','" + b.DateOfAddedBooks + "',N'" + b.BooksStatus + "',N'" + b.CategoryCode + "')";
            return dal.Execute(SqlINSERT);
        }

        public bool UpdateBookManagement(Books b)
        {
            string SqlUPDATE = "update Sach set TenSach = N'"+b.BookName+"',SoLuong = '"+b.Amount+"',NgayNhap = '"+b.DateOfAddedBooks+"',TinhTrang = N'"+b.BooksStatus+"',MaTheLoai = '"+b.CategoryCode+"' where MaSach = '"+b.BookCode+"'";
            return dal.Execute(SqlUPDATE);
        }

        public bool DeleteBookManagement(string books_Code)
        {
            string SqlDELETE = "DELETE From Sach Where MaSach = '"+books_Code+"'";
            return dal.Execute(SqlDELETE);
        }
        public DataTable GetDataBooksManagement()
        {
            string SqlSELECT = "select MaSach,TenSach,SoLuong,NgayNhap,TinhTrang, TenTheLoai from Sach,TheLoai where sach.MaTheLoai = TheLoai.MaTheLoai";
            return dal.GetData(SqlSELECT);
        }
        #endregion

        //Category
        #region
        public DataTable GetDataCategory()
        {
            string SqlSELECT = "select * from TheLoai";
            return dal.GetData(SqlSELECT);
        }
        #endregion

        // Supplier Management
        #region
        public bool InsertSupplierManagement(Suppliers S)
        {
            string SqlINSERT = "Insert into NhaCungCap Values('"+S.SupplierCode+"',N'"+S.SupplierName+"','"+S.SupplierPhoneNumber+"',N'"+S.SupplierAddress+"')";
            return dal.Execute(SqlINSERT);
        }

        public bool UpdateSupplierManagement(Suppliers S)
        {
            string SqlUPDATE = "update NhaCungCap set TenNCC = N'"+S.SupplierName+"',SDT = '"+S.SupplierPhoneNumber+"',DiaChi = N'"+S.SupplierAddress+"' where MaNCC = '"+S.SupplierCode+"' ";
            return dal.Execute(SqlUPDATE);
        }

        public bool DeleteSupplierManagement(string suppliers_Code)
        {
            string SqlDELETE = "DELETE From NhaCungCap Where MaNCC = '" + suppliers_Code + "'";
            return dal.Execute(SqlDELETE);
        }
        public DataTable GetDataSupplierManagement()
        {
            string SqlSELECT = "Select * from NhaCungCap";
            return dal.GetData(SqlSELECT);
        }


        #endregion

        //Borrow And Return
        #region
        //Funct Select NameBook,Category
        public DataTable GetDataName_Category(string L)
        {
            string sql = "Select TenSach, TenTheLoai from Sach,TheLoai Where TheLoai.MaTheLoai = Sach.MaTheLoai AND MaSach = '"+L+"'";
            return dal.GetData(sql);
        }
        //Funct Add InforBook
        public bool InsertListBookBorrow(ListBooksBorrow L)
        {
            string SqlINSERT = "insert into ListBooksPhieuMuon values('"+L.MaPhieuMuon+"','"+L.BooksCode+"',N'"+L.BooksName+"',N'"+L.CategoryName+"','"+L.Amount+"')";
            return dal.Execute(SqlINSERT);
        }
        //Funct GetDataTableListBook
        public DataTable GetDataTableListBook()
        {
            string sql = "select * from ListBooksPhieuMuon";
                return dal.GetData(sql);
        }

        public DataTable GetDataTableListBook(string MaPhieu)
        {
            string sql = "select * from ListBooksPhieuMuon where MaPhieuMuon = '"+MaPhieu+"'";
            return dal.GetData(sql);
        }
        //Funct GetNameBooks
        public DataTable GetNameBook_BorrowAndReturn(string NameBooks)
        {
            string select = "select MaSach,TenSach From Sach Where MaSach = '"+NameBooks+"'";
            return dal.GetData(select);

        }

        //Funct GettableListBook
        public DataTable GettableListBook(string MaPhieu)
        {
            string sql = "select PhieuMuon.MaPhieuMuon,MaSach,TenSach,TenTheLoai,SoLuong From PhieuMuon,ListBooksPhieuMuon where PhieuMuon.MaPhieuMuon = ListBooksPhieuMuon.MaPhieuMuon and PhieuMuon.MaPhieuMuon = '"+MaPhieu+"'";
            return dal.GetData(sql);
        }
        //Funct GetdataPhieuMuon
        public DataTable GetdataPhieuMuon(string MaPhieu)
        {
            string sql = "select * from PhieuMuon,ListBooksPhieuMuon where PhieuMuon.MaPhieuMuon = ListBooksPhieuMuon.MaPhieuMuon and PhieuMuon.MaPhieuMuon = '"+MaPhieu+"'";
            return dal.GetData(sql);
        }
        // Funct Get Data TABLE Borrow And Return
        public DataTable GetDataBorrowAndReturnBooks()
        {
            string sqlSELECT = "select * from PhieuMuon,ListBooksPhieuMuon where PhieuMuon.MaPhieuMuon = ListBooksPhieuMuon.MaPhieuMuon";
            return dal.GetData(sqlSELECT);
        }
        public DataTable GetDataBorrowAndReturnBooks(string MaPhieu)
        {
            string sqlSELECT = "select * from PhieuMuon,ListBooksPhieuMuon where PhieuMuon.MaPhieuMuon = ListBooksPhieuMuon.MaPhieuMuon And PhieuMuon.MaPhieuMuon = '"+MaPhieu+"' ";
            return dal.GetData(sqlSELECT);
        }
        //Update table ListBooksPhieuMuon
        public bool UpdateListBooksPhieuMuon(string MaSach,int soluong,string MaPhieu)
        {
            string sql = "update ListBooksPhieuMuon set SoLuong = '"+soluong+"' where MaSach = '"+MaSach+"' and MaPhieuMuon = '"+MaPhieu+"'";
            return dal.Execute(sql);
        }
        //update table PhieuMuon
        public bool UpdatePhieuMuon (string MaPhieu,string MaTT,string TenTT,string SdtTT)
        {
            string sql = "update PhieuMuon set MaThuThu = '" + MaTT + "' , TenThuThu = N'"+TenTT+"' ,SDTThuThu = '"+SdtTT+"'   Where MaPhieuMuon = '"+MaPhieu+"'";
            return dal.Execute(sql);
        }
        public bool UpdatePhieuMuon(string MaPhieu,int SoNgayMuon)
        {
            string sql = "update PhieuMuon set SoNgayMuon = '" + SoNgayMuon + "'  Where MaPhieuMuon = '" + MaPhieu + "'";
            return dal.Execute(sql);
        }

        // Funct ReturnBooks
        public bool ReturnBooks(string MaPhieu)
        {
            string sql = "delete from PhieuMuon Where  MaPhieuMuon = '" + MaPhieu + "'";
            return dal.Execute(sql);
        }
        public bool ReturnBooks1(string MaPhieu)
        {
            string sql = "delete from ListBooksPhieuMuon Where  MaPhieuMuon = '" + MaPhieu + "'";
            return dal.Execute(sql);
        }


        #endregion

        // Book Import
        #region
        public DataTable GetDataPhieuNhap()
        {
            string sql = "select * from ListBooks , NhapSach where NhapSach.MaPhieu = ListBooks.MaPhieu";
            return dal.GetData(sql);
        }

        public bool Insert_Book_To_ListBook(string MaPhieu,string BookCode,string BookName, string Catogery,int Amount)
        {
            string sql = "insert into tmp_SachNhap values( '"+MaPhieu+"' , '"+BookCode+"' , N'"+BookName+"' , N'"+Catogery+"' , '"+Amount+"' )";
            return dal.Execute(sql);
        }

        public DataTable GetDataListBooks()
        {
            string sql = "select * from tmp_SachNhap";
            return dal.GetData(sql);
        }
       
        public DataTable GetDataListBooks(string MaPhieu)
        {
            string sql = "select * from ListBooks Where MaPhieu = '"+MaPhieu+"'";
            return dal.GetData(sql);
        }
        public bool Delete_Book_To_ListBooks(string BookCode)
        {
            string sql = "delete from tmp_SachNhap Where MaSach = '" + BookCode + "'";
            return dal.Execute(sql);
        }

        public bool Insert_Phieu_Nhap(string MaPhieu,string MaNCC ,string TenNCC , string MaTT,string TenTT,DateTime NgayNhap)
        {
            string sql = "INSERT INTO  ListBooks SELECT * FROM  tmp_SachNhap delete  from tmp_SachNhap insert into NhapSach values( '"+MaPhieu+"' , '"+MaNCC+"' , N'"+TenNCC+"', '"+MaTT+"', N'"+TenTT+"','"+NgayNhap+"')";
            return dal.Execute(sql);
        }

        public bool Update_Phieu_Nhap(string MaPhieu,string bookCode,string bookName,string category, int amount, string MaNCC,string TenNCC,DateTime NgayNhap)
        {
            string sql = "update NhapSach set MaNCC = '"+MaNCC+"', TenNCC = N'"+TenNCC+"', NgayNhap = '"+NgayNhap+"' where MaPhieu = '"+MaPhieu+"' update ListBooks set TenSach = N'"+bookName+"', TheLoai = N'"+category+"',SoLuong = '"+amount+"' where MaPhieu = '"+MaPhieu+"' and MaSach = '"+bookCode+"'  ";
            return dal.Execute(sql);
        }

        public bool Delete_Phieu_Nhap(string MaPhieu,string bookCode)
        {
            string sql = "delete from ListBooks where MaPhieu = '"+MaPhieu+"' and MaSach = '"+bookCode+"' delete from NhapSach where MaPhieu = '"+MaPhieu+"'";
            return dal.Execute(sql);
        }
        #endregion


        //search by name
        public DataTable Search_By_Name(string name, string table)
        {
            if (table == "ThuThu")
            {
                string sqlSelect = "select TaiKhoan.TenDangNhap,TaiKhoan.MatKhau,ThuThu.MaThuThu,ThuThu.TenThuThu,NgaySinh,DiaChi,SDT,CCCD,NgayVaoLam From ThuThu,TaiKhoan WHERE TaiKhoan.TenDangNhap = ThuThu.TenDangNhap and ThuThu.TenDangNhap = '"+name+"'";
                return dal.GetData(sqlSelect);
            }
            if (table == "DocGia")
            {
                string sqlSelect = "select TaiKhoan.TenDangNhap,TaiKhoan.MatKhau,DocGia.MaDocGia,DocGia.TenDocGia,NgaySinh,DiaChi,SDT,CCCD,NgayDangKy From DocGia,TaiKhoan WHERE TaiKhoan.TenDangNhap = DocGia.TenDangNhap and DocGia.TenDangNhap = '" + name + "'";
                return dal.GetData(sqlSelect);
            }
            if (table == "Sach")
            {
                string sqlSelect = "select * from Sach Where MaSach = '" + name + "'";
                return dal.GetData(sqlSelect);
            }
            if (table == "NhaCungCap")
            {
                string sqlSelect = "select * from NhaCungCap Where MaNCC = '" + name + "'";
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

        //public DataTable GetStringData_DataIn_DataOut(string DataIn,string DataOut, string Table,string condition)
        //{
        //    string sqlGetData = string.Format(" select MatKhau FROM TaiKhoan WHERE TenDangNhap = '" + condition+"' ");

        //    return dal.GetData(sqlGetData);
        //}


       
    }
}
