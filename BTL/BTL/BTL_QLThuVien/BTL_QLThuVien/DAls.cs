using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QLThuVien
{
    public class DAls
    {
        public SqlConnection GetConn()
        {
            return new SqlConnection(@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=QuanLyThuVien;Integrated Security=True");
        }
        public DataTable GetData(string sql)
        {
            GetConn().Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, GetConn());
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //Execute Instruction
        public bool Execute(string SQL)
        {
            SqlConnection con = GetConn();
            try
            {

                con.Open();
                SqlCommand cmd = new SqlCommand(SQL, con);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception)
            {

            }
            finally
            {
                con.Close();
            }
            return false;
        }

     
    }
}
