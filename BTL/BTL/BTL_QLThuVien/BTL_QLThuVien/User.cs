using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QLThuVien
{
    public   class User
    {
        string nameLogin;
        string userCode;
        string userName;
        DateTime dateOfBirth;
        string address;
        string sDT;
        string cCCD;
        DateTime dateResistration;

        public string NameLogin { get => nameLogin; set => nameLogin = value; }
        public string UserCode { get => userCode; set => userCode = value; }
        public string UserName { get => userName; set => userName = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string Address { get => address; set => address = value; }
        public string SDT { get => sDT; set => sDT = value; }
        public string CCCD { get => cCCD; set => cCCD = value; }
        public DateTime DateResistration { get => dateResistration; set => dateResistration = value; }

        public User() { }
        public User(string nameLogin,string userCode,string userName,DateTime dateOfBirth,string address,string sDT,string cCCD,DateTime dateResistration)
        {
            this.NameLogin = nameLogin;
            this.UserCode = userCode;
            this.UserName = userName;
            this.DateOfBirth = dateOfBirth;
            this.Address = address;
            this.SDT = sDT;
            this.CCCD = cCCD;
            this.DateResistration = dateResistration;
        }
    }
}
