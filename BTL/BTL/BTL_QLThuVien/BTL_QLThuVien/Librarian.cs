using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QLThuVien
{
    public class Librarian
    {
        string nameLogin;
        string librarianCode;
        string librarianName;
        DateTime dateOfBirth;
        string address;
        string phoneNumber;
        string cCCD;
        DateTime dateBeginWork;

        public string NameLogin { get => nameLogin; set => nameLogin = value; }
        public string LibrarianCode { get => librarianCode; set => librarianCode = value; }
        public string LibrarianName { get => librarianName; set => librarianName = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string Address { get => address; set => address = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string CCCD { get => cCCD; set => cCCD = value; }
        public DateTime DateBeginWork { get => dateBeginWork; set => dateBeginWork = value; }

        public Librarian()
        {

        }
        public Librarian(string nameLogin,string librarianCode,string librarianName,DateTime dateOfBirth,string address,string phoneNumber,string cccd,DateTime dateBeginWork)
        {
            this.NameLogin = nameLogin;
            this.LibrarianCode = librarianCode;
            this.LibrarianName = librarianName;
            this.DateOfBirth = dateOfBirth;
            this.Address = address;
            this.PhoneNumber = phoneNumber;
            this.CCCD = cccd;
            this.DateBeginWork = dateOfBirth;
        }
    }
}
