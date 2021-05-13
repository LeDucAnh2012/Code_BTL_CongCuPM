using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QLThuVien
{
    public partial class fMainForAdmin : Form
    {
        public fMainForAdmin()
        {
            InitializeComponent();
        }

        public static fMainForAdmin instance;
        
        void MakeInstance()
        {
            if (instance == null)
                instance = this;
        }
        BULs bull = new BULs();

        void Awake()
        {
            MakeInstance();
        }
        BUL_MainAdmin bul = new BUL_MainAdmin();
        BULs b = new BULs();
        //Timer
        #region

        int x = 300, y = 15, a = 2;
        Random random = new Random();

        //Funct Change Color Label
        private void ChangeColorLabel(Label lb)
        {
            lb.ForeColor = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
        }
        
        private void timerChangeColor_Tick(object sender, EventArgs e)
        {
            ChangeColorLabel(labelLibrarian);
            ChangeColorLabel(labelUserManagement);
            ChangeColorLabel(labelBooksManagement);
            ChangeColorLabel(labelBorrowAndReturn);
            ChangeColorLabel(labelEnterBooks);
            ChangeColorLabel(labelSuppiler);
            ChangeColorLabel(labelStatistical);
        }

        //Funct Change Location Label
        private void ChangeLocationLabel(Label lb)
        {   
            try
            {
                x += a;
                lb.Location = new Point(x, y);
                if (x >= tPAccount.Width - lb.Width - 12 - 150)
                    a = -2;
                if (x <= 12 + 150)
                    a = 2;
            }
            catch (Exception ex) { }
        }
        private void timerLabelAccount_Tick(object sender, EventArgs e)
        {
            if(tPAccount.SelectedIndex == 0)
            {
                ChangeLocationLabel(labelLibrarian);
            }
            if(tPAccount.SelectedIndex == 1)
            {
                ChangeLocationLabel(labelUserManagement);
            }
            if(tPAccount.SelectedIndex == 2)
            {
                ChangeLocationLabel(labelBooksManagement);
            }
            if(tPAccount.SelectedIndex == 3)
            {
                ChangeLocationLabel(labelSuppiler);
            }
            if(tPAccount.SelectedIndex == 4)
            {
                ChangeLocationLabel(labelBorrowAndReturn);
            }
            if(tPAccount.SelectedIndex == 5)
            {
                ChangeLocationLabel(labelEnterBooks);
            }
            if(tPAccount.SelectedIndex == 6)
            {
                ChangeLocationLabel(labelStatistical);
            }
            
        }
        #endregion

        //  Action Librarian Table
        #region

        bool change = true;
        private void btnSearchLibrarian_Click(object sender, EventArgs e)
        {
            if (change == true)
            {
                try
                {
                    if (bul.Search_By_Name(txtSearchLibrarian.Text, "ThuThu").Rows.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy kết quả");
                    }
                    else
                    {
                        dgvLibrarian.DataSource = bul.Search_By_Name(txtSearchLibrarian.Text, "ThuThu");
                        txtSearchLibrarian.Clear();
                        change = false;
                        btnSearchLibrarian.Text = "Show Again";
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể tìm được.Lỗi");
                    MessageBox.Show(ex.ToString());
                }

            }
            else
            {
                txtSearchLibrarian.Text = "Nhập tên đăng nhập";
                btnSearchLibrarian.Text = "Tìm Kiếm";
                dgvLibrarian.DataSource = bul.GetDataLibrarian();
                change = true;
            }
        }

        //Button Update Click
        private void btnUpdateLibrarian_Click(object sender, EventArgs e)
        {
            try
            {
                if (bul.UpdateLibrarian(MappingCodeOfLibrarian()) && CheckTextBoxEmptyOfLibrarian() && bul.UpdateAccountLogin(MappingCodeOfAccount()))
                { 
                    dgvLibrarian.DataSource = bul.GetDataLibrarian();
                    MessageBox.Show("Sửa thành công.");
                    CleanForm(tabLibrarian);
                }
                else MessageBox.Show("Sửa thất bại.Xem lại dữ liệu");

            }
            catch (Exception ex)
            {

            }
        }

        private void btnInsertLibrarian_Click(object sender, EventArgs e)
        {
            try
            {
                if (bul.InsertLibrarian(MappingCodeOfLibrarian()) && CheckTextBoxEmptyOfLibrarian() && bul.InsertAccountLogin(MappingCodeOfAccount()))
                {
                    dgvLibrarian.DataSource = bul.GetDataLibrarian();
                    MessageBox.Show("Thêm thành công.");
                    CleanForm(tabLibrarian);
                }
                else
                {
                    MessageBox.Show("Thêm thất bại.Xem lại dữ liệu");
                }
            }
            catch (Exception ex)
            {

            }
        }

        //Button Delete Click
        private void btnDeleteLibrarian_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn chắc chắn xóa tài khoản này?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                try
                {
                    if (bul.DeleteLibrarian(txtNameLoginLibrarian.Text) && CheckTextBoxEmptyOfLibrarian() && bul.DeleteAccountLogin(MappingCodeOfAccount()))
                    {
                        dgvLibrarian.DataSource = bul.GetDataLibrarian();
                        MessageBox.Show("Xóa thành công.");
                        CleanForm(tabLibrarian);
                    }
                    else MessageBox.Show("Xóa thất bại.Xem lại dữ liệu");

                }
                catch (Exception)
                {

                }
            }
        }

     
      
        // Ánh xạ code
        private AccountLogin MappingCodeOfAccount()
        {
            AccountLogin AcL = new AccountLogin();
            AcL.NameLogin = txtNameLoginLibrarian.Text;
            AcL.PassWord = txtPassWordLibrarion.Text;
            AcL.PhanQuyen = true;
            return AcL;
            
        }
        private Librarian MappingCodeOfLibrarian()
        {
            Librarian libra = new Librarian();
            libra.NameLogin = txtNameLoginLibrarian.Text;
            libra.LibrarianCode = txtLibrarianCode.Text;
            libra.LibrarianName = txtLibrarianName.Text;
            libra.DateOfBirth = dateTimePickerDateOfBirthLibrarian.Value;
            libra.Address = txtAddressLibrarian.Text;
            libra.PhoneNumber = txtPhoneNumberLibrarian.Text;
            libra.CCCD = txtCCCDLibrarian.Text;
            libra.DateBeginWork = dateTimePickerDateBeginWorkLibrarian.Value;
                return libra;
        }


     
    

        //DataGirdView Cell Click
        private void dgvLibrarian_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtNameLoginLibrarian.Text = dgvLibrarian.Rows[index].Cells[0].Value.ToString();
                txtPassWordLibrarion.Text = dgvLibrarian.Rows[index].Cells[1].Value.ToString();
                
                txtLibrarianCode.Text = dgvLibrarian.Rows[index].Cells[2].Value.ToString();
                txtLibrarianName.Text = dgvLibrarian.Rows[index].Cells[3].Value.ToString();

                dateTimePickerDateOfBirthLibrarian.Text = dgvLibrarian.Rows[index].Cells[4].Value.ToString();

                txtAddressLibrarian.Text = dgvLibrarian.Rows[index].Cells[5].Value.ToString();
                txtPhoneNumberLibrarian.Text = dgvLibrarian.Rows[index].Cells[6].Value.ToString();

                txtCCCDLibrarian.Text = dgvLibrarian.Rows[index].Cells[7].Value.ToString();
                dateTimePickerDateBeginWorkLibrarian.Text = dgvLibrarian.Rows[index].Cells[8].Value.ToString();
                

               

            }
            if(index == bul.GetDataLibrarian().Rows.Count)
            {
                txtPassWordLibrarion.Clear();
            }
        }

        #endregion

        // Action User Management
        #region

        // Button Insert click
        private void btnInsertUser_UserManagement_Click_1(object sender, EventArgs e)
        {
           
                try
                {
                    if (bul.InsertUser(MappingCodeOfUser()) && CheckTextBoxEmptyOfUser() && bul.InsertAccountLogin(MappingCodeOfUserAccount()))
                    {

                        dgvUser_UserManagement.DataSource = bul.GetDataUser();
                        MessageBox.Show("Thêm thành công.");
                        CleanForm(tabDocGia);
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại.Xem lại dữ liệu");
                    }
                }
                catch (Exception ex)
                {

                }
            
          
        }
        // Button Update click
        private void btnUpdateUser_UserManagement_Click(object sender, EventArgs e)
        {
            try
            {
                if (bul.UpdateUser(MappingCodeOfUser()) && CheckTextBoxEmptyOfUser() && bul.UpdateAccountLogin(MappingCodeOfUserAccount()))
                {
                    dgvUser_UserManagement.DataSource = bul.GetDataUser();
                    MessageBox.Show("Sửa thành công.");
                    CleanForm(tabDocGia);
                }
                else MessageBox.Show("Sửa thất bại.Xem lại dữ liệu");

            }
            catch (Exception)
            {

            }
        }
        //Button Delete Click
        private void btnDeleteUser_UserManagement_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn chắc chắn xóa tài khoản này?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                try
                {
                    if (bul.DeleteUser(txtUserName_UserManagement.Text) && CheckTextBoxEmptyOfUser() && bul.DeleteAccountLogin(MappingCodeOfUserAccount()))
                    {
                        dgvUser_UserManagement.DataSource = bul.GetDataUser();
                        MessageBox.Show("Xóa thành công.");
                        CleanForm(tabDocGia);
                    }
                    else MessageBox.Show("Xóa thất bại.Xem lại dữ liệu");

                }
                catch (Exception)
                {

                }
            }
               
        }
        //Button Search Click
        bool change1 = true;
        private void btnSearchUser_UsersManagement_Click(object sender, EventArgs e)
        {
            if (change1 == true)
            {
                try
                {
                    if (bul.Search_By_Name(txtSearchUser_UsersManagement.Text, "DocGia").Rows.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy kết quả");
                    }
                    else
                    {
                        dgvUser_UserManagement.DataSource = bul.Search_By_Name(txtSearchUser_UsersManagement.Text, "DocGia");
                        txtSearchUser_UsersManagement.Clear();
                        change1 = false;
                        btnSearchUser_UsersManagement.Text = "Show Again";
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể tìm được.Lỗi");
                    MessageBox.Show(ex.ToString());
                }

            }
            else
            {
                txtSearchUser_UsersManagement.Text = "Nhập tên đăng nhập";
                btnSearchUser_UsersManagement.Text = "Tìm Kiếm";
                dgvUser_UserManagement.DataSource = bul.GetDataUser();
                change1 = true;
            }
        }

        //DataGirdView Cell Click
        private void dgvUser_UserManagement_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {

                txtUserName_UserManagement.Text = dgvUser_UserManagement.Rows[index].Cells[0].Value.ToString();
                txtPassWord_UserMagament.Text = dgvUser_UserManagement.Rows[index].Cells[1].Value.ToString();

                txtUserCode_UsersManagement.Text = dgvUser_UserManagement.Rows[index].Cells[2].Value.ToString();
                txtUserName_UsersManagement.Text = dgvUser_UserManagement.Rows[index].Cells[3].Value.ToString();

                dateTimePikerDateOfBirthUser_UsersManagement.Text = dgvUser_UserManagement.Rows[index].Cells[4].Value.ToString();
                txtAddressUser_UsersManagement.Text = dgvUser_UserManagement.Rows[index].Cells[5].Value.ToString();

                txtPhoneNumberUser_UsersManagement.Text = dgvUser_UserManagement.Rows[index].Cells[6].Value.ToString();
                txtCCCDUser_UsersManagement.Text = dgvUser_UserManagement.Rows[index].Cells[7].Value.ToString();

                dateTimePickerRegistrationDate.Text = dgvUser_UserManagement.Rows[index].Cells[8].Value.ToString();
                


            }
            if(index == bul.GetDataUser().Rows.Count)
            {
                txtPassWord_UserMagament.Clear();
            }
        }

        // Ánh xạ code
        private User MappingCodeOfUser()
        {
            User us = new User();
            us.NameLogin = txtUserName_UserManagement.Text;
            us.UserCode = txtUserCode_UsersManagement.Text;
            us.UserName = txtUserName_UsersManagement.Text;
            us.DateOfBirth = dateTimePikerDateOfBirthUser_UsersManagement.Value;
            us.Address = txtAddressUser_UsersManagement.Text;
            us.SDT = txtPhoneNumberUser_UsersManagement.Text;
            us.CCCD = txtCCCDUser_UsersManagement.Text;
            us.DateResistration = dateTimePickerRegistrationDate.Value;
            return us;
        }

        private AccountLogin MappingCodeOfUserAccount()
        {
            AccountLogin ac = new AccountLogin();
            ac.NameLogin = txtUserName_UserManagement.Text;
            ac.PassWord = txtPassWord_UserMagament.Text;
            ac.PhanQuyen = false;
            return ac;
        }


        #endregion

        // Action Books Management
        #region

        //Button Insert
        private void btnInsertBook_BookManagement_Click(object sender, EventArgs e)
        {
            try
            {
                if (bul.InsertBookManagement(MappingCodeOfBooksManagement()) && CheckTextBoxEmptyOfBookManagement())
                {
                    dgvBooks_BookManagement.DataSource = bul.GetDataBooksManagement();
                    MessageBox.Show("Thêm thành công.");
                    CleanForm(tabQLSach);
                }
                else
                {
                    MessageBox.Show("Thêm thất bại.Xem lại dữ liệu");
                }
            }
            catch (Exception ex)
            {

            }

        }

        //Button Update
        private void btnUpdateBook_BookManagement_Click(object sender, EventArgs e)
        {
            try
            {
                if (bul.UpdateBookManagement(MappingCodeOfBooksManagement()) && CheckTextBoxEmptyOfBookManagement())
                {
                    dgvBooks_BookManagement.DataSource = bul.GetDataBooksManagement();
                    MessageBox.Show("Sửa thành công.");
                    CleanForm(tabQLSach);
                }
                else MessageBox.Show("Sửa thất bại.Xem lại dữ liệu");

            }
            catch (Exception ex)
            {

            }
        }

        //Button Delete
        private void btnDeleteBook_BookManagement_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn chắc chắn xóa thông tin sách này?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                try
                {
                    if (bul.DeleteBookManagement(txtBookCode_BookManagement.Text) && CheckTextBoxEmptyOfBookManagement())
                    {
                        dgvBooks_BookManagement.DataSource = bul.GetDataBooksManagement();
                        MessageBox.Show("Xóa thành công.");
                        CleanForm(tabQLSach);
                    }
                    else MessageBox.Show("Xóa thất bại.Xem lại dữ liệu");

                }
                catch (Exception)
                {

                }
            }
        }

        //Button Search
        bool change2 = true;
        private void btnSearchBook_BookManagement_Click(object sender, EventArgs e)
        {
            if (change2 == true)
            {
                try
                {
                    if (bul.Search_By_Name(txtSearchBook_BookManagement.Text, "Sach").Rows.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy kết quả");
                    }
                    else
                    {
                        dgvBooks_BookManagement.DataSource = bul.Search_By_Name(txtSearchBook_BookManagement.Text, "Sach");
                        txtSearchBook_BookManagement.Clear();
                        change2 = false;
                        btnSearchBook_BookManagement.Text = "Show Again";
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể tìm được.Lỗi");
                    MessageBox.Show(ex.ToString());
                }

            }
            else
            {
                txtSearchBook_BookManagement.Text = "Nhập Mã sách";
                btnSearchBook_BookManagement.Text = "Tìm Kiếm";
                dgvBooks_BookManagement.DataSource = bul.GetDataBooksManagement();
                change2 = true;
            }
        }
        //DataGirdView CellClick
        private void dgvBooks_BookManagement_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if(index >= 0)
            {
                txtBookCode_BookManagement.Text = dgvBooks_BookManagement.Rows[index].Cells[0].Value.ToString();
                txtBookName_BookManagement.Text = dgvBooks_BookManagement.Rows[index].Cells[1].Value.ToString();
                txtAmount_BookManagement.Text = dgvBooks_BookManagement.Rows[index].Cells[2].Value.ToString();
                dateTimePickerDateAdded_BookManagement.Text = dgvBooks_BookManagement.Rows[index].Cells[3].Value.ToString();
                txtStatusBook_BookManagement.Text = dgvBooks_BookManagement.Rows[index].Cells[4].Value.ToString();
                comboBoxCategoryCode_BookManagement.Text = dgvBooks_BookManagement.Rows[index].Cells[5].Value.ToString();
            }
        }

        //Ánh Xạ Code
        private Books MappingCodeOfBooksManagement()
        {
            Books b = new Books();
            b.BookCode = txtBookCode_BookManagement.Text;
            b.BookName = txtBookName_BookManagement.Text;
            if (txtAmount_BookManagement.Text == "") b.Amount = 0;
            else
            b.Amount = int.Parse(txtAmount_BookManagement.Text);
            b.DateOfAddedBooks = dateTimePickerDateAdded_BookManagement.Value;
            b.BooksStatus = txtStatusBook_BookManagement.Text;
            b.CategoryCode = comboBoxCategoryCode_BookManagement.SelectedValue.ToString();
            return b;
        }
        #endregion

        // Action Suppiler
        #region

        //Button Insert
        private void btnInsertSupplier_Supplier_Click(object sender, EventArgs e)
        {
            try
            {
                if (bul.InsertSupplierManagement(MappingCodeOfSuppliers()) && CheckTextBoxEmptyOfSuppliers())
                {
                    dgvSuppliers.DataSource = bul.GetDataSupplierManagement();
                    MessageBox.Show("Thêm Thành Công");
                    CleanForm(tabNCC);
                }
                else MessageBox.Show("Thêm Thất Bại.Xem Lại Dữ Liệu");
            }
            catch (Exception ex)
            {

            }
        }
        //Button Update
        private void btnUpdateSupplier_Supplier_Click(object sender, EventArgs e)
        {
            try
            {
                if (bul.UpdateSupplierManagement(MappingCodeOfSuppliers()) && CheckTextBoxEmptyOfSuppliers())
                {
                    dgvSuppliers.DataSource = bul.GetDataSupplierManagement();
                    MessageBox.Show("Sửa Thành Công");
                    CleanForm(tabNCC);
                }
                else MessageBox.Show("Sửa Thất Bại.Xem Lại Dữ Liệu");
            }
            catch (Exception ex)
            {

            }
        }
        //Button Delete
        private void btnDeleteSupplier_Supplier_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes == MessageBox.Show("Bạn có chắc chắn xóa nhà cung cấp này?","Thông Báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question))
            try
            {
                if (bul.DeleteSupplierManagement(txtSupplierCode_Supplier.Text) && CheckTextBoxEmptyOfSuppliers())
                {
                    dgvSuppliers.DataSource = bul.GetDataSupplierManagement();
                    MessageBox.Show("Xóa Thành Công");
                    CleanForm(tabNCC);
                    
                }
                else MessageBox.Show("Xóa Thất Bại.Xem Lại Dữ Liệu");
            }
            catch (Exception ex)
            {

            }
        }
        // DataGirdView CellClick
        private void dgvSuppliers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtSupplierCode_Supplier.Text = dgvSuppliers.Rows[index].Cells[0].Value.ToString();
                txtSupplierName_Supplier.Text = dgvSuppliers.Rows[index].Cells[1].Value.ToString();
                txtVendorPhoneNumber_Supplier.Text = dgvSuppliers.Rows[index].Cells[2].Value.ToString();
                txtAddressSupplier_Supplier.Text = dgvSuppliers.Rows[index].Cells[3].Value.ToString();
            }
        }
        // Button Search
        bool change3 = true;
        private void btnSearch_Supplier_Click(object sender, EventArgs e)
        {
            if (change3 == true)
            {
                try
                {
                    if (bul.Search_By_Name(txtSearch_Supplier.Text, "NhaCungCap").Rows.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy kết quả");
                    }
                    else
                    {
                        dgvSuppliers.DataSource = bul.Search_By_Name(txtSearch_Supplier.Text, "NhaCungCap");
                        txtSearch_Supplier.Clear();
                        change3 = false;
                        btnSearch_Supplier.Text = "Show Again";
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể tìm được.Lỗi");
                    MessageBox.Show(ex.ToString());
                }

            }
            else
            {
                txtSearch_Supplier.Text = "Nhập Mã nhà cung cấp";
                btnSearch_Supplier.Text = "Tìm Kiếm";
                dgvSuppliers.DataSource = bul.GetDataSupplierManagement();
                change3 = true;
            }
        }

        //Ánh xạ code
        private Suppliers MappingCodeOfSuppliers()
        {
            Suppliers S = new Suppliers();
            S.SupplierCode = txtSupplierCode_Supplier.Text;
            S.SupplierName = txtSupplierName_Supplier.Text;
            S.SupplierPhoneNumber = txtVendorPhoneNumber_Supplier.Text;
            S.SupplierAddress = txtAddressSupplier_Supplier.Text;
            return S;
        }
        #endregion

        // Action Borrow And Return Books
        #region
        //Add Books In listBox
        private void btnAdd_BorrowAndReturnBooks_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
           if( bul.InsertListBookBorrow(MappingCodeOfListBooks()))
            dgvListBooksBorrow.DataSource = bul.GetDataTableListBook();
            
        }

        
        //Check MaPhieu
        private void btnCheck_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = bul.GetdataPhieuMuon(txtMaPhieu.Text);
                foreach (DataRow row in dt.Rows)
                {
                    txtUserCode_BorrowAndReturnBooks.Text = row["MaDocGia"].ToString();
                    txtUserName_Borrow.Text = row["TenDocGia"].ToString();
                    txtPhoneNumberUser_Borrow.Text = row["SDTDocGia"].ToString();
                    break;
                }
                dgvListBooksBorrow.DataSource = bul.GettableListBook(txtMaPhieu.Text);
            }
            catch (Exception ex)
            {

            }
        }

        //DatagirdView CellClick
        private void dgvListBooksBorrow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if(index >= 0)
            {
                txtBookCode_Borrow.Text = dgvListBooksBorrow.Rows[index].Cells[1].Value.ToString();
            }

        }
        int index = 0;
        private void dgvBorrowAndReturnBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             index = e.RowIndex;
            if(index >=0)
            {
                txtMaPhieu.Text = dgvBorrowAndReturnBooks.Rows[index].Cells[0].Value.ToString();
                txtUserCode_BorrowAndReturnBooks.Text = dgvBorrowAndReturnBooks.Rows[index].Cells[1].Value.ToString();
                txtUserName_Borrow.Text = dgvBorrowAndReturnBooks.Rows[index].Cells[2].Value.ToString();
                txtPhoneNumberUser_Borrow.Text = dgvBorrowAndReturnBooks.Rows[index].Cells[3].Value.ToString();
                txtLibrarianName.Text = dgvBorrowAndReturnBooks.Rows[index].Cells[4].Value.ToString();
                txtLibrarianName_Borrow.Text = dgvBorrowAndReturnBooks.Rows[index].Cells[5].Value.ToString();
                txtPhoneNumberLibrarian_Borrow.Text = dgvBorrowAndReturnBooks.Rows[index].Cells[6].Value.ToString();
                dgvListBooksBorrow.DataSource = bul.GetDataTableListBook(dgvBorrowAndReturnBooks.Rows[index].Cells[0].Value.ToString());

            }
            
        }
        private void btnConfirm_Borrow_Click(object sender, EventArgs e)
        {
            try
            {
                if (bul.UpdateListBooksPhieuMuon(txtBookCode_Borrow.Text, int.Parse(txtAmountBorrowBooks.Text),txtMaPhieu.Text) &&
                    bul.UpdatePhieuMuon(txtMaPhieu.Text,int.Parse(txtAmont_Borrow.Text)))
                {
                    MessageBox.Show("Sửa thành công");

                    BULs b = new BULs();
                    DataTable dt = b.GetData_tmp_Login();
                    foreach (DataRow row in dt.Rows)
                    {
                        txtLibrarian_Borrow.Text = row["MaThuThu"].ToString();
                        txtLibrarianName_Borrow.Text = row["TenThuThu"].ToString();
                        txtPhoneNumberLibrarian_Borrow.Text = row["SDT"].ToString();
                        break;
                    }
                    dgvBorrowAndReturnBooks.DataSource = bul.GetDataBorrowAndReturnBooks();
                }
                else
                {

                }

            }
            catch (Exception ex)
            {

            }

        }
        //Button Confirm Borrow
        private void btnBorrowBooks_Click_1(object sender, EventArgs e)
        {
            if(DialogResult.Yes == MessageBox.Show("Bạn chắc chắn muốn Mượn những sách này??","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question))
            try
            {
                if (bul.UpdatePhieuMuon(txtMaPhieu.Text, txtLibrarian_Borrow.Text,
                    txtLibrarianName_Borrow.Text, txtPhoneNumberLibrarian_Borrow.Text))
                {
                    MessageBox.Show("Mượn thành công");
                        BULs b = new BULs();
                        DataTable dt = b.GetData_tmp_Login();
                        foreach (DataRow row in dt.Rows)
                        {
                            txtLibrarian_Borrow.Text = row["MaThuThu"].ToString();
                            txtLibrarianName_Borrow.Text = row["TenThuThu"].ToString();
                            txtPhoneNumberLibrarian_Borrow.Text = row["SDT"].ToString();
                            break;
                        }
                        dgvBorrowAndReturnBooks.DataSource = bul.GetDataBorrowAndReturnBooks();
                    }
                else
                {
                    MessageBox.Show("Mượn không thành công","Error");
                    
                   
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Mượn không thành công", "Error");
            }

        }

        // Button Return Books
        private void btnReturnBooks_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn chắc chắn muốn Trả những sách này??", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                try
            {
                if (bul.ReturnBooks1(dgvBorrowAndReturnBooks.Rows[index].Cells[0].Value.ToString()) &&
                    bul.ReturnBooks(dgvBorrowAndReturnBooks.Rows[index].Cells[0].Value.ToString()))
                {
                    dgvBorrowAndReturnBooks.DataSource = bul.GetDataBorrowAndReturnBooks();
                    MessageBox.Show("Trả sách thành công.", "Thông báo");
                    
                }
                else
                {
                    MessageBox.Show("Trả sách không thành công.", "Thông báo");
                }
            }
            catch(Exception ex)
            {

            }
        }


        //Ánh xạ code
        private ListBooksBorrow MappingCodeOfListBooks()
        {
            ListBooksBorrow L = new ListBooksBorrow();
            L.MaPhieuMuon = txtMaPhieu.Text;
            L.BooksCode = txtUserName_Borrow.Text;
            DataTable dt = bul.GetDataName_Category(txtUserName_Borrow.Text);
            foreach(DataRow row in dt.Rows)
            {
                L.BooksName = row["TenSach"].ToString();
                L.CategoryName = row["TenTheLoai"].ToString();
                break;
            }
            
            L.Amount = int.Parse(txtAmountBorrowBooks.Text);
            return L;
        }
        bool change4 = true;
        private void btnSearchBill_BorrowAndReturnBooks_Click(object sender, EventArgs e)
        {

            if (change4 == true)
            {
                try
                {
                    if (bul.GetDataBorrowAndReturnBooks(txtSearchBill_BorrowAndReturnBooks.Text).Rows.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy kết quả");
                    }
                    else
                    {
                        dgvBorrowAndReturnBooks.DataSource = bul.GetDataBorrowAndReturnBooks(txtSearchBill_BorrowAndReturnBooks.Text);
                        txtSearchBill_BorrowAndReturnBooks.Clear();
                        change4 = false;
                        btnSearchBill_BorrowAndReturnBooks.Text = "Show Again";
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể tìm được.Lỗi");
                    MessageBox.Show(ex.ToString());
                }

            }
            else
            {
                txtSearchBill_BorrowAndReturnBooks.Text = "Nhập Mã Phiếu";
                btnSearchBill_BorrowAndReturnBooks.Text = "Tìm Kiếm";
                dgvBorrowAndReturnBooks.DataSource = bul.GetDataBorrowAndReturnBooks();
                change4 = true;
            }
            
        }


        #endregion

        //


        //Load DataGirdView
        #region

        private void fMainForAdmin_Load(object sender, EventArgs e)
        {
            
            dgvLibrarian.DataSource = bul.GetDataLibrarian();
        }

      

        private void tPAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tPAccount.SelectedIndex == 0)
            {
                dgvLibrarian.DataSource = bul.GetDataLibrarian();

            }
            else if (tPAccount.SelectedIndex == 1)
            {

                dgvUser_UserManagement.DataSource = bul.GetDataUser();

            }
            else if(tPAccount.SelectedIndex == 2)
            {
                dgvBooks_BookManagement.DataSource = bul.GetDataBooksManagement();
                AddDataInComboboxCategory();
            }
            else if(tPAccount.SelectedIndex == 3)
            {
                dgvSuppliers.DataSource = bul.GetDataSupplierManagement();
            }
            else if (tPAccount.SelectedIndex == 4)
            {
                BULs b = new BULs();
                DataTable dt = b.GetData_tmp_Login();
                foreach (DataRow row in dt.Rows)
                {
                    txtLibrarian_Borrow.Text = row["MaThuThu"].ToString();
                    txtLibrarianName_Borrow.Text = row["TenThuThu"].ToString();
                    txtPhoneNumberLibrarian_Borrow.Text = row["SDT"].ToString();
                    break;
                }
                dgvBorrowAndReturnBooks.DataSource = bul.GetDataBorrowAndReturnBooks();
            }
            else if(tPAccount.SelectedIndex == 5)
            {
                AddDataInCombobox();
                BULs b = new BULs();
                DataTable dt = b.GetData_tmp_Login();
                foreach (DataRow row in dt.Rows)
                {
                    txtlibrarianCode_EnterBooks.Text = row["MaThuThu"].ToString();
                    txtTenThuThu1.Text = row["TenThuThu"].ToString();
              
                    break;
                }

                dgvEnterBooks.DataSource = bul.GetDataPhieuNhap();
            }
        }

        


        #endregion

        // Check TextBox
        #region
        private bool CheckTextBoxEmptyOfLibrarian()
        {
            if (txtLibrarianCode.Text == "") return false;
            if (txtNameLoginLibrarian.Text == "") return false;
            if (txtPassWordLibrarion.Text == "") return false;
            if (txtLibrarianName.Text == "") return false;
            if (dateTimePickerDateOfBirthLibrarian.Text == "") return false;
            if (txtAddressLibrarian.Text == "") return false;
            if (txtPhoneNumberLibrarian.Text == "") return false;
            if (txtCCCDLibrarian.Text == "") return false;
            if (dateTimePickerDateBeginWorkLibrarian.Text == "") return false;
            return true;
        }


        private bool CheckTextBoxEmptyOfUser()
        {
            if (txtUserName_UserManagement.Text == "") return false;
            if (txtUserCode_UsersManagement.Text == "") return false;
            if (txtPassWord_UserMagament.Text == "") return false;
            if (txtUserName_UsersManagement.Text == "") return false;
            if (dateTimePikerDateOfBirthUser_UsersManagement.Text == "") return false;
            if (txtAddressUser_UsersManagement.Text == "") return false;
            if (txtPhoneNumberUser_UsersManagement.Text == "") return false;
            if (txtCCCDUser_UsersManagement.Text == "") return false;
            if (dateTimePickerRegistrationDate.Text == "") return false;
            return true;
        }

        

        private bool CheckTextBoxEmptyOfBookManagement()
        {
            if (txtBookCode_BookManagement.Text == "") return false;
            if (txtBookName_BookManagement.Text == "") return false;
            if (txtAmount_BookManagement.Text == "") return false;
            if (dateTimePickerDateAdded_BookManagement.Text == "") return false;
            if (txtStatusBook_BookManagement.Text == "") return false;
            if (comboBoxCategoryCode_BookManagement.Text == "") return false;

            return true;
        }

        private bool CheckTextBoxEmptyOfSuppliers()
        {
            if (txtSupplierCode_Supplier.Text == "") return false;
            if (txtSupplierName_Supplier.Text == "") return false;
            if (txtVendorPhoneNumber_Supplier.Text == "") return false;
            if (txtAddressSupplier_Supplier.Text == "") return false;
            return true;
        }
        #endregion

        
        //clear All textbox
        #region
        private void CleanForm(TabPage tb)
        {
            foreach (var c in tb.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = String.Empty;
                }
            }
        }

       
        #endregion

        //Add Combobox category
        #region
        private void AddDataInComboboxCategory()
        {
            comboBoxCategoryCode_BookManagement.DataSource = bul.GetDataCategory();
            comboBoxCategoryCode_BookManagement.DisplayMember = "TenTheLoai";
            comboBoxCategoryCode_BookManagement.ValueMember = "MaTheLoai";
            comboBoxCategoryCode_BookManagement.Text = "<Hãy chọn tên thể loại>";
           
        }
        private void AddDataInCombobox()
        {
            comboBoxSupplier_CodeEnterBooks.DataSource = bul.GetDataSupplierManagement();
            comboBoxSupplier_CodeEnterBooks.DisplayMember = "TenNCC";
            comboBoxSupplier_CodeEnterBooks.ValueMember = "MaNCC";
            comboBoxSupplier_CodeEnterBooks.Text = "<Hãy chọn tên NCC>";

        }

        #endregion

        // Action statistical

        private void btnLoc_Click(object sender, EventArgs e)
        {

            dgvDocGia.DataSource = bull.GetData_thongke(Convert.ToDateTime(dateNgayMuon.Value), Convert.ToDateTime(DateDenNgay.Value));
            dgvSach.DataSource = bull.GetData_thongke1(Convert.ToDateTime(dateNgayMuon.Value), Convert.ToDateTime(DateDenNgay.Value));
        }




        // Action Book import
        #region
        private void btnADD_Click(object sender, EventArgs e)
        {
            try
            {
                if(bul.Insert_Book_To_ListBook(txtFormCode_EnterBooks.Text,txtBookcode_EnterBooks.Text
                    , txtBookName_EnterBooks.Text, txtCategory_EnterBooks.Text, int.Parse(txtAmount_EnterBooks.Text)))
                {
                    dgvListBook_EnterBooks.DataSource = bul.GetDataListBooks();
                }
                else
                {
                    MessageBox.Show("Dữ liệu nhập vào bị sai định dạng, độ dài hoặc bị trùng nhau.", "Error");
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (bul.Delete_Book_To_ListBooks(txtBookcode_EnterBooks.Text))
                {
                    dgvListBook_EnterBooks.DataSource = bul.GetDataListBooks();
                }

            }
            catch (Exception ex)
            {

            }
        }

        private void btnInsert_EnterBooks_Click(object sender, EventArgs e)
        {
            try
            {
                if (bul.Insert_Phieu_Nhap(txtFormCode_EnterBooks.Text,comboBoxSupplier_CodeEnterBooks.SelectedValue.ToString(),
                    comboBoxSupplier_CodeEnterBooks.Text,txtlibrarianCode_EnterBooks.Text,txtTenThuThu1.Text,
                    dateTimePickerDate_EnterBooks.Value))
                {
                    dgvEnterBooks.DataSource = bul.GetDataPhieuNhap();
                    MessageBox.Show("Nhập thành công");
                }
                else
                {
                    MessageBox.Show("Nhập sách thất bại, xem lại dữ liệu", "Thông báo");
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnUpdate_EnterBooks_Click(object sender, EventArgs e)
        {
            try
            {
                if (bul.Update_Phieu_Nhap(txtFormCode_EnterBooks.Text,txtBookcode_EnterBooks.Text,txtBookName_EnterBooks.Text,
                    txtCategory_EnterBooks.Text,int.Parse(txtAmount_EnterBooks.Text),comboBoxSupplier_CodeEnterBooks.SelectedValue.ToString(),
                    comboBoxSupplier_CodeEnterBooks.Text,dateTimePickerDate_EnterBooks.Value))
                {
                    dgvEnterBooks.DataSource = bul.GetDataPhieuNhap();
                    MessageBox.Show("sửa thành công");
                }
                else
                {
                    MessageBox.Show("sửa sách thất bại, xem lại dữ liệu", "Thông báo");
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnDelete_EnterBooks_Click(object sender, EventArgs e)
        {
            try
            {
                if (bul.Delete_Phieu_Nhap(txtFormCode_EnterBooks.Text,txtBookcode_EnterBooks.Text))
                {
                    dgvEnterBooks.DataSource = bul.GetDataPhieuNhap();
                    MessageBox.Show("Xóa thành công");
                }
                else
                {
                    MessageBox.Show("Xóa Thất bại. xem lại thông tin xóa", "Thông báo");
                }
            }
            catch(Exception ex)
            {

            }
        }

        private void dgvListBook_EnterBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if(index >= 0)
            {
                txtFormCode_EnterBooks.Text = dgvListBook_EnterBooks.Rows[index].Cells[0].Value.ToString();
                txtBookcode_EnterBooks.Text = dgvListBook_EnterBooks.Rows[index].Cells[1].Value.ToString();
                txtBookName_EnterBooks.Text = dgvListBook_EnterBooks.Rows[index].Cells[2].Value.ToString();
                txtCategory_EnterBooks.Text = dgvListBook_EnterBooks.Rows[index].Cells[3].Value.ToString();
                txtAmount_EnterBooks.Text = dgvListBook_EnterBooks.Rows[index].Cells[4].Value.ToString();
            }
        }

        private void dgvEnterBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtFormCode_EnterBooks.Text = dgvEnterBooks.Rows[index].Cells[0].Value.ToString();
                txtBookcode_EnterBooks.Text = dgvEnterBooks.Rows[index].Cells[1].Value.ToString();
                txtBookName_EnterBooks.Text = dgvEnterBooks.Rows[index].Cells[2].Value.ToString();
                txtCategory_EnterBooks.Text = dgvEnterBooks.Rows[index].Cells[3].Value.ToString();
                txtAmount_EnterBooks.Text = dgvEnterBooks.Rows[index].Cells[4].Value.ToString();
                comboBoxSupplier_CodeEnterBooks.Text = dgvEnterBooks.Rows[index].Cells[6].Value.ToString();
                dateTimePickerDate_EnterBooks.Text = dgvEnterBooks.Rows[index].Cells[10].Value.ToString();

                dgvListBook_EnterBooks.DataSource = bul.GetDataListBooks(txtFormCode_EnterBooks.Text);
            }
        }




        #endregion




        //Chuyen doi Form
        #region
        private void btnBorrowBooks_Click(object sender, EventArgs e)
        {
            fResistration f = new fResistration();
            f.ShowDialog();
        }

       

        private void fMainForAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            BULs bul = new BULs();
            bul.DeleteInforLoginTo_TMP_TABLE();
        }
     

        #endregion




    }
}
