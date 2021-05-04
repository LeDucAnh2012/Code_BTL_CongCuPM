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

        BUL_MainAdmin bul = new BUL_MainAdmin();

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

        private void btnSearchLibrarian_Click(object sender, EventArgs e)
        {
            if (change == true)
            {
                try
                {
                    if (bul.Search_By_Name(txtNameLoginLibrarian.Text, "ThuThu").Rows.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy kết quả");
                    }
                    else
                    {
                        dgvLibrarian.DataSource = bul.Search_By_Name(txtNameLoginLibrarian.Text, "ThuThu");
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


                if (bul.UpdateLibrarian(MappingCode()))
                {
                    MessageBox.Show("Sửa thành công.");
                    dgvLibrarian.DataSource = bul.GetDataLibrarian();
                }
                else MessageBox.Show("Sửa thất bại.");

            }
            catch (Exception)
            {

            }
        }

        private void btnInsertLibrarian_Click(object sender, EventArgs e)
        {

        }

        //Button Delete Click
        private void btnDeleteLibrarian_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn chắc chắn xóa tài khoản này?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                try
                {
                    if (bul.DeleteLibrarian(txtNameLoginLibrarian.Text))
                    {
                        dgvLibrarian.DataSource = bul.GetDataLibrarian();
                        MessageBox.Show("Xóa thành công.");
                    }
                    else MessageBox.Show("Xóa thất bại.");

                }
                catch (Exception)
                {

                }
            }
        }

     
      
        // Ánh xạ code
        private Librarian MappingCode()
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

        private void btnUpdateAccount_Click(object sender, EventArgs e)
        {
           
        }

        // Button Search click
        bool change = true;

        //DataGirdView Cell Click
        private void dgvLibrarian_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtNameLoginLibrarian.Text = dgvLibrarian.Rows[index].Cells[0].Value.ToString();
                txtLibrarianCode.Text = dgvLibrarian.Rows[index].Cells[1].Value.ToString();

                txtLibrarianName.Text = dgvLibrarian.Rows[index].Cells[2].Value.ToString();
                dateTimePickerDateOfBirthLibrarian.Text = dgvLibrarian.Rows[index].Cells[3].Value.ToString();

                txtAddressLibrarian.Text = dgvLibrarian.Rows[index].Cells[4].Value.ToString();
                txtPhoneNumberLibrarian.Text = dgvLibrarian.Rows[index].Cells[5].Value.ToString();

                txtCCCDLibrarian.Text = dgvLibrarian.Rows[index].Cells[6].Value.ToString();
                dateTimePickerDateBeginWorkLibrarian.Text = dgvLibrarian.Rows[index].Cells[7].Value.ToString();
                DataTable dt = new DataTable();
                dt = bul.GetStringData_DataIn_DataOut("TenDangNhap", "MatKhau", "TaiKhoan", dgvLibrarian.Rows[index].Cells[0].Value.ToString());

                foreach (DataRow row in dt.Rows)
                {
                    txtPassWordLibrarion.Text = row["MatKhau"].ToString();
                    break;
                }

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
        private void btnInsertUser_UserManagement_Click(object sender, EventArgs e)
        {
            try
            {
               
            }
            catch (Exception ex)
            {

            }
        }

       // button Update Click
        private void btnUpdateUser_UserManagement_Click(object sender, EventArgs e)
        {

        }

        // Button Delete Click
        private void btnDeleteUser_UserManagement_Click(object sender, EventArgs e)
        {

        }

        //Button Search Click
        private void btnSearchUser_UsersManagement_Click(object sender, EventArgs e)
        {

        }

        //DataGirdView Cell Click
        private void dgvUser_UserManagement_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {

                txtUserName_UserManagement.Text = dgvUser_UserManagement.Rows[index].Cells[0].Value.ToString();
                txtUserCode_UsersManagement.Text = dgvUser_UserManagement.Rows[index].Cells[1].Value.ToString();

                txtUserName_UsersManagement.Text = dgvUser_UserManagement.Rows[index].Cells[2].Value.ToString();
                dateTimePikerDateOfBirthUser_UsersManagement.Text = dgvUser_UserManagement.Rows[index].Cells[3].Value.ToString();

                txtAddressUser_UsersManagement.Text = dgvUser_UserManagement.Rows[index].Cells[4].Value.ToString();
                txtPhoneNumberUser_UsersManagement.Text = dgvUser_UserManagement.Rows[index].Cells[5].Value.ToString();

                txtCCCDUser_UsersManagement.Text = dgvUser_UserManagement.Rows[index].Cells[6].Value.ToString();
                dateTimePickerRegistrationDate.Text = dgvUser_UserManagement.Rows[index].Cells[7].Value.ToString();
                DataTable dt = new DataTable();
                dt = bul.GetStringData_DataIn_DataOut("TenDangNhap", "MatKhau", "TaiKhoan", dgvUser_UserManagement.Rows[index].Cells[0].Value.ToString());

                foreach (DataRow row in dt.Rows)
                {
                    txtPassWord_UserMagament.Text = row["MatKhau"].ToString();
                    break;
                }


            }
            if(index == bul.GetInforUser().Rows.Count)
            {
                txtPassWord_UserMagament.Clear();
            }
        }
        #endregion


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

                dgvUser_UserManagement.DataSource = bul.GetInforUser();

            }
            else if(tPAccount.SelectedIndex == 2)
            {

            }
            else if(tPAccount.SelectedIndex == 3)
            {

            }
            else if (tPAccount.SelectedIndex == 4)
            {
                dgvBorrowAndReturnBooks.DataSource = bul.GetInforBorrowAndReturnBooks();
            }
            else if(tPAccount.SelectedIndex == 5)
            {

            }
        }
        #endregion


        

       




        

       


        private void dgvBorrowAndReturnBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
           // if()
        }
        
       
        

       
    }
}
