using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QLThuVien
{
    public class ListBooksBorrow
    {
        string maPhieuMuon;
        string booksCode;
        string booksName;
        string categoryName;
        int amount;

        public string MaPhieuMuon { get => maPhieuMuon; set => maPhieuMuon = value; }
        public string BooksCode { get => booksCode; set => booksCode = value; }
        public string BooksName { get => booksName; set => booksName = value; }
        public string CategoryName { get => categoryName; set => categoryName = value; }
        public int Amount { get => amount; set => amount = value; }

        public ListBooksBorrow() { }

        public ListBooksBorrow(string maPhieuMuon,string booksCode,string booksName,string categoryName,int amount ) 
        {
            this.MaPhieuMuon = maPhieuMuon;
            this.BooksCode = booksCode;
            this.BooksName = booksName;
            this.CategoryName = categoryName;
            this.Amount = amount;
        }
    }
}
