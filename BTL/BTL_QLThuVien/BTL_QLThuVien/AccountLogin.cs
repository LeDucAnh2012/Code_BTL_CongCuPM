using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QLThuVien
{
    public class AccountLogin
    {
        string nameLogin;
        string passWord;
        bool phanQuyen;

        public string NameLogin { get => nameLogin; set => nameLogin = value; }
        public string PassWord { get => passWord; set => passWord = value; }
        public bool PhanQuyen { get => phanQuyen; set => phanQuyen = value; }

        public AccountLogin() { }
        
        public AccountLogin(string namelogin, string password,bool phanquyen)
        {
            this.NameLogin = namelogin;
            this.PassWord = password;
            this.PhanQuyen = phanquyen;
        }
    }
}
