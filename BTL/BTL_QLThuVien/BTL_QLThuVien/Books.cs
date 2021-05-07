using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QLThuVien
{
    public class Books
    {
        string bookCode;
        string bookName;
        int amount;
        DateTime dateOfAddedBooks;
        string booksStatus;
        string categoryCode;

        public string BookCode { get => bookCode; set => bookCode = value; }
        public string BookName { get => bookName; set => bookName = value; }
        public int Amount { get => amount; set => amount = value; }
        public DateTime DateOfAddedBooks { get => dateOfAddedBooks; set => dateOfAddedBooks = value; }
        public string BooksStatus { get => booksStatus; set => booksStatus = value; }
        public string CategoryCode { get => categoryCode; set => categoryCode = value; }

        public Books() { }
        public Books(string bookcode, string bookname,int amount,DateTime dateofAddedBooks,string booksstatus,string categoryBooks)
        {
            this.BookCode = bookcode;
            this.BookName = bookname;
            this.Amount = amount;
            this.DateOfAddedBooks = dateofAddedBooks;
            this.BooksStatus = booksstatus;
            this.CategoryCode = categoryBooks;
        }
    }
}
