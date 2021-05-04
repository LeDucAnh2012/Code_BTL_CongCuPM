using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace BTL_QLThuVien
{
    public  class BULs
    {
        DAls dal = new DAls();

        // Funct Get Data TABLE Login
        public DataTable GetTableInforLogin(string user_name, string pass, bool Pk)
        {
            string sql = "select * from TaiKhoan Where TenDangNhap = '"+user_name+"' AND MatKhau = '"+pass+"' AND MaPhanQuyen = '"+Pk+"' ";
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
    }
}
