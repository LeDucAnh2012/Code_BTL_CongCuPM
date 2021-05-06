using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QLThuVien
{
   public class Suppliers
    {
        string supplierCode;
        string supplierName;
        string supplierPhoneNumber;
        string supplierAddress;

        public string SupplierCode { get => supplierCode; set => supplierCode = value; }
        public string SupplierName { get => supplierName; set => supplierName = value; }
        public string SupplierPhoneNumber { get => supplierPhoneNumber; set => supplierPhoneNumber = value; }
        public string SupplierAddress { get => supplierAddress; set => supplierAddress = value; }

        public Suppliers() { }
        public Suppliers(string supplierCode,string supplierName, string supplierPhoneNumber, string supplierAddress)
        {
            this.SupplierCode = supplierCode;
            this.SupplierName = supplierName;
            this.SupplierPhoneNumber = supplierPhoneNumber;
            this.SupplierAddress = supplierAddress;
        }
    }
}
