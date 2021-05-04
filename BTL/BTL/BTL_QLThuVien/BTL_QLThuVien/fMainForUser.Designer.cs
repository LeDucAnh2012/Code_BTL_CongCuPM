
namespace BTL_QLThuVien
{
    partial class fMainForUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fUser = new System.Windows.Forms.TabControl();
            this.tabMuonTraSach = new System.Windows.Forms.TabPage();
            this.btnInPhieuMuon = new System.Windows.Forms.Button();
            this.btnBotNhieu = new System.Windows.Forms.Button();
            this.btnBotMot = new System.Windows.Forms.Button();
            this.btnThemMot = new System.Windows.Forms.Button();
            this.listSachMuon = new System.Windows.Forms.ListView();
            this.lstMaSach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstTenSach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstSoTrang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstNgayNhap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstTinhTrang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstMaTheLoai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.dgvMuonSach = new System.Windows.Forms.DataGridView();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTimKiem_MuonSach = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.tabDocGia = new System.Windows.Forms.TabPage();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtMaDocGia = new System.Windows.Forms.TextBox();
            this.dtpNgayDangKy = new System.Windows.Forms.DateTimePicker();
            this.txtTenDocGia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.fUser.SuspendLayout();
            this.tabMuonTraSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuonSach)).BeginInit();
            this.tabDocGia.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // fUser
            // 
            this.fUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fUser.Controls.Add(this.tabMuonTraSach);
            this.fUser.Controls.Add(this.tabDocGia);
            this.fUser.Location = new System.Drawing.Point(3, 4);
            this.fUser.Margin = new System.Windows.Forms.Padding(4);
            this.fUser.Name = "fUser";
            this.fUser.SelectedIndex = 0;
            this.fUser.Size = new System.Drawing.Size(1171, 715);
            this.fUser.TabIndex = 1;
            this.fUser.SelectedIndexChanged += new System.EventHandler(this.fUser_SelectedIndexChanged);
            // 
            // tabMuonTraSach
            // 
            this.tabMuonTraSach.BackColor = System.Drawing.Color.Gray;
            this.tabMuonTraSach.Controls.Add(this.btnInPhieuMuon);
            this.tabMuonTraSach.Controls.Add(this.btnBotNhieu);
            this.tabMuonTraSach.Controls.Add(this.btnBotMot);
            this.tabMuonTraSach.Controls.Add(this.btnThemMot);
            this.tabMuonTraSach.Controls.Add(this.listSachMuon);
            this.tabMuonTraSach.Controls.Add(this.txtTimKiem);
            this.tabMuonTraSach.Controls.Add(this.dgvMuonSach);
            this.tabMuonTraSach.Controls.Add(this.btnTimKiem_MuonSach);
            this.tabMuonTraSach.Controls.Add(this.label10);
            this.tabMuonTraSach.Location = new System.Drawing.Point(4, 25);
            this.tabMuonTraSach.Margin = new System.Windows.Forms.Padding(4);
            this.tabMuonTraSach.Name = "tabMuonTraSach";
            this.tabMuonTraSach.Padding = new System.Windows.Forms.Padding(4);
            this.tabMuonTraSach.Size = new System.Drawing.Size(1163, 686);
            this.tabMuonTraSach.TabIndex = 1;
            this.tabMuonTraSach.Text = "Mượn sách";
            // 
            // btnInPhieuMuon
            // 
            this.btnInPhieuMuon.BackColor = System.Drawing.Color.Red;
            this.btnInPhieuMuon.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInPhieuMuon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInPhieuMuon.Location = new System.Drawing.Point(994, 627);
            this.btnInPhieuMuon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInPhieuMuon.Name = "btnInPhieuMuon";
            this.btnInPhieuMuon.Size = new System.Drawing.Size(151, 52);
            this.btnInPhieuMuon.TabIndex = 22;
            this.btnInPhieuMuon.Text = "In phiếu";
            this.btnInPhieuMuon.UseVisualStyleBackColor = false;
            this.btnInPhieuMuon.Click += new System.EventHandler(this.btnInPhieuMuon_Click);
            // 
            // btnBotNhieu
            // 
            this.btnBotNhieu.BackColor = System.Drawing.Color.Aqua;
            this.btnBotNhieu.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBotNhieu.Location = new System.Drawing.Point(683, 376);
            this.btnBotNhieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBotNhieu.Name = "btnBotNhieu";
            this.btnBotNhieu.Size = new System.Drawing.Size(84, 44);
            this.btnBotNhieu.TabIndex = 21;
            this.btnBotNhieu.Text = "<<";
            this.btnBotNhieu.UseVisualStyleBackColor = false;
            this.btnBotNhieu.Click += new System.EventHandler(this.btnBotNhieu_Click);
            // 
            // btnBotMot
            // 
            this.btnBotMot.BackColor = System.Drawing.Color.Aqua;
            this.btnBotMot.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBotMot.Location = new System.Drawing.Point(484, 376);
            this.btnBotMot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBotMot.Name = "btnBotMot";
            this.btnBotMot.Size = new System.Drawing.Size(84, 44);
            this.btnBotMot.TabIndex = 20;
            this.btnBotMot.Text = "<";
            this.btnBotMot.UseVisualStyleBackColor = false;
            this.btnBotMot.Click += new System.EventHandler(this.btnBotMot_Click);
            // 
            // btnThemMot
            // 
            this.btnThemMot.BackColor = System.Drawing.Color.Aqua;
            this.btnThemMot.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMot.Location = new System.Drawing.Point(299, 376);
            this.btnThemMot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemMot.Name = "btnThemMot";
            this.btnThemMot.Size = new System.Drawing.Size(84, 44);
            this.btnThemMot.TabIndex = 18;
            this.btnThemMot.Text = ">";
            this.btnThemMot.UseVisualStyleBackColor = false;
            this.btnThemMot.Click += new System.EventHandler(this.btnThemMot_Click);
            // 
            // listSachMuon
            // 
            this.listSachMuon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lstMaSach,
            this.lstTenSach,
            this.lstSoTrang,
            this.lstNgayNhap,
            this.lstTinhTrang,
            this.lstMaTheLoai});
            this.listSachMuon.FullRowSelect = true;
            this.listSachMuon.HideSelection = false;
            this.listSachMuon.Location = new System.Drawing.Point(19, 454);
            this.listSachMuon.Name = "listSachMuon";
            this.listSachMuon.Size = new System.Drawing.Size(948, 225);
            this.listSachMuon.TabIndex = 17;
            this.listSachMuon.UseCompatibleStateImageBehavior = false;
            this.listSachMuon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listSachMuon_MouseClick);
            // 
            // lstMaSach
            // 
            this.lstMaSach.Text = "Mã sách";
            // 
            // lstTenSach
            // 
            this.lstTenSach.Text = "Tên sách";
            this.lstTenSach.Width = 100;
            // 
            // lstSoTrang
            // 
            this.lstSoTrang.Text = "Số trang";
            this.lstSoTrang.Width = 50;
            // 
            // lstNgayNhap
            // 
            this.lstNgayNhap.Text = "Ngày nhập";
            this.lstNgayNhap.Width = 120;
            // 
            // lstTinhTrang
            // 
            this.lstTinhTrang.Text = "Tình trạng";
            // 
            // lstMaTheLoai
            // 
            this.lstMaTheLoai.Text = "Mã thể loại";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(661, 114);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(306, 37);
            this.txtTimKiem.TabIndex = 16;
            // 
            // dgvMuonSach
            // 
            this.dgvMuonSach.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvMuonSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMuonSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSach,
            this.TenSach,
            this.SoTrang,
            this.NgayNhap,
            this.TinhTrang,
            this.MaTheLoai});
            this.dgvMuonSach.Location = new System.Drawing.Point(19, 176);
            this.dgvMuonSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMuonSach.Name = "dgvMuonSach";
            this.dgvMuonSach.RowHeadersWidth = 51;
            this.dgvMuonSach.RowTemplate.Height = 24;
            this.dgvMuonSach.Size = new System.Drawing.Size(948, 182);
            this.dgvMuonSach.TabIndex = 13;
            this.dgvMuonSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMuonSach_CellClick);
            // 
            // MaSach
            // 
            this.MaSach.DataPropertyName = "MaSach";
            this.MaSach.HeaderText = "Mã sách";
            this.MaSach.MinimumWidth = 6;
            this.MaSach.Name = "MaSach";
            this.MaSach.Width = 125;
            // 
            // TenSach
            // 
            this.TenSach.DataPropertyName = "TenSach";
            this.TenSach.HeaderText = "Tên sách";
            this.TenSach.MinimumWidth = 6;
            this.TenSach.Name = "TenSach";
            this.TenSach.Width = 125;
            // 
            // SoTrang
            // 
            this.SoTrang.DataPropertyName = "SoLuong";
            this.SoTrang.HeaderText = "Số lượng";
            this.SoTrang.MinimumWidth = 6;
            this.SoTrang.Name = "SoTrang";
            this.SoTrang.Width = 125;
            // 
            // NgayNhap
            // 
            this.NgayNhap.DataPropertyName = "NgayNhap";
            this.NgayNhap.HeaderText = "Ngày nhập";
            this.NgayNhap.MinimumWidth = 6;
            this.NgayNhap.Name = "NgayNhap";
            this.NgayNhap.Width = 125;
            // 
            // TinhTrang
            // 
            this.TinhTrang.DataPropertyName = "TinhTrang";
            this.TinhTrang.HeaderText = "Tình trạng";
            this.TinhTrang.MinimumWidth = 6;
            this.TinhTrang.Name = "TinhTrang";
            this.TinhTrang.Width = 125;
            // 
            // MaTheLoai
            // 
            this.MaTheLoai.DataPropertyName = "MaTheLoai";
            this.MaTheLoai.HeaderText = "Mã thể loại";
            this.MaTheLoai.MinimumWidth = 6;
            this.MaTheLoai.Name = "MaTheLoai";
            this.MaTheLoai.Width = 125;
            // 
            // btnTimKiem_MuonSach
            // 
            this.btnTimKiem_MuonSach.BackColor = System.Drawing.Color.Red;
            this.btnTimKiem_MuonSach.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem_MuonSach.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTimKiem_MuonSach.Location = new System.Drawing.Point(984, 99);
            this.btnTimKiem_MuonSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiem_MuonSach.Name = "btnTimKiem_MuonSach";
            this.btnTimKiem_MuonSach.Size = new System.Drawing.Size(151, 52);
            this.btnTimKiem_MuonSach.TabIndex = 2;
            this.btnTimKiem_MuonSach.Text = "Tìm Kiếm";
            this.btnTimKiem_MuonSach.UseVisualStyleBackColor = false;
            this.btnTimKiem_MuonSach.Click += new System.EventHandler(this.btnTimKiem_MuonSach_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Yellow;
            this.label10.Location = new System.Drawing.Point(199, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(783, 47);
            this.label10.TabIndex = 0;
            this.label10.Text = "CHÀO MỪNG CÁC BẠN ĐẾN VỚI THƯ VIỆN";
            // 
            // tabDocGia
            // 
            this.tabDocGia.BackColor = System.Drawing.Color.Gray;
            this.tabDocGia.Controls.Add(this.btnThoat);
            this.tabDocGia.Controls.Add(this.groupBox7);
            this.tabDocGia.Controls.Add(this.btnSua);
            this.tabDocGia.Controls.Add(this.label1);
            this.tabDocGia.Location = new System.Drawing.Point(4, 25);
            this.tabDocGia.Margin = new System.Windows.Forms.Padding(4);
            this.tabDocGia.Name = "tabDocGia";
            this.tabDocGia.Padding = new System.Windows.Forms.Padding(4);
            this.tabDocGia.Size = new System.Drawing.Size(1163, 686);
            this.tabDocGia.TabIndex = 0;
            this.tabDocGia.Text = "Độc giả";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.DarkViolet;
            this.btnThoat.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThoat.Location = new System.Drawing.Point(909, 154);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(213, 62);
            this.btnThoat.TabIndex = 23;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click_1);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txtMatKhau);
            this.groupBox7.Controls.Add(this.label23);
            this.groupBox7.Controls.Add(this.dtpNgaySinh);
            this.groupBox7.Controls.Add(this.txtTenDangNhap);
            this.groupBox7.Controls.Add(this.txtCMND);
            this.groupBox7.Controls.Add(this.txtSDT);
            this.groupBox7.Controls.Add(this.txtDiaChi);
            this.groupBox7.Controls.Add(this.txtMaDocGia);
            this.groupBox7.Controls.Add(this.dtpNgayDangKy);
            this.groupBox7.Controls.Add(this.txtTenDocGia);
            this.groupBox7.Controls.Add(this.label7);
            this.groupBox7.Controls.Add(this.label6);
            this.groupBox7.Controls.Add(this.label9);
            this.groupBox7.Controls.Add(this.label5);
            this.groupBox7.Controls.Add(this.label8);
            this.groupBox7.Controls.Add(this.label4);
            this.groupBox7.Controls.Add(this.label3);
            this.groupBox7.Controls.Add(this.label2);
            this.groupBox7.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox7.Location = new System.Drawing.Point(19, 47);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox7.Size = new System.Drawing.Size(875, 534);
            this.groupBox7.TabIndex = 20;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Thông tin tài khoản";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(275, 84);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(4);
            this.txtMatKhau.Multiline = true;
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(567, 36);
            this.txtMatKhau.TabIndex = 27;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Orange;
            this.label23.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label23.Location = new System.Drawing.Point(30, 92);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(108, 28);
            this.label23.TabIndex = 26;
            this.label23.Text = "Mật khẩu";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(275, 264);
            this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(567, 36);
            this.dtpNgaySinh.TabIndex = 25;
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Location = new System.Drawing.Point(275, 28);
            this.txtTenDangNhap.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenDangNhap.Multiline = true;
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(567, 36);
            this.txtTenDangNhap.TabIndex = 24;
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(275, 439);
            this.txtCMND.Margin = new System.Windows.Forms.Padding(4);
            this.txtCMND.Multiline = true;
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(567, 36);
            this.txtCMND.TabIndex = 22;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(275, 380);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4);
            this.txtSDT.Multiline = true;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(567, 36);
            this.txtSDT.TabIndex = 21;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(275, 325);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(567, 36);
            this.txtDiaChi.TabIndex = 20;
            // 
            // txtMaDocGia
            // 
            this.txtMaDocGia.Location = new System.Drawing.Point(275, 143);
            this.txtMaDocGia.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaDocGia.Multiline = true;
            this.txtMaDocGia.Name = "txtMaDocGia";
            this.txtMaDocGia.Size = new System.Drawing.Size(567, 36);
            this.txtMaDocGia.TabIndex = 18;
            // 
            // dtpNgayDangKy
            // 
            this.dtpNgayDangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayDangKy.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayDangKy.Location = new System.Drawing.Point(275, 494);
            this.dtpNgayDangKy.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayDangKy.Name = "dtpNgayDangKy";
            this.dtpNgayDangKy.Size = new System.Drawing.Size(567, 36);
            this.dtpNgayDangKy.TabIndex = 16;
            // 
            // txtTenDocGia
            // 
            this.txtTenDocGia.Location = new System.Drawing.Point(275, 208);
            this.txtTenDocGia.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenDocGia.Multiline = true;
            this.txtTenDocGia.Name = "txtTenDocGia";
            this.txtTenDocGia.Size = new System.Drawing.Size(567, 36);
            this.txtTenDocGia.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Orange;
            this.label7.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(30, 389);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 28);
            this.label7.TabIndex = 16;
            this.label7.Text = "Số điện thoại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Orange;
            this.label6.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(30, 327);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 28);
            this.label6.TabIndex = 15;
            this.label6.Text = "Địa chỉ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Orange;
            this.label9.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(30, 502);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 28);
            this.label9.TabIndex = 8;
            this.label9.Text = "Ngày đăng ký";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Orange;
            this.label5.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(30, 146);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 28);
            this.label5.TabIndex = 14;
            this.label5.Text = "Mã độc giả";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Orange;
            this.label8.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(30, 447);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 28);
            this.label8.TabIndex = 7;
            this.label8.Text = "CMT / CCCD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Orange;
            this.label4.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(30, 208);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 28);
            this.label4.TabIndex = 13;
            this.label4.Text = "Tên độc giả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Orange;
            this.label3.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(30, 272);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Orange;
            this.label2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(30, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên đăng nhập";
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Aqua;
            this.btnSua.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(909, 59);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(213, 62);
            this.btnSua.TabIndex = 18;
            this.btnSua.Text = "Cập nhật";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(352, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN TÀI KHOẢN";
            // 
            // fMainForUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 724);
            this.Controls.Add(this.fUser);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fMainForUser";
            this.Text = "fMainForUser";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fMainForUser_FormClosed_1);
            this.Load += new System.EventHandler(this.fMainForUser_Load);
            this.fUser.ResumeLayout(false);
            this.tabMuonTraSach.ResumeLayout(false);
            this.tabMuonTraSach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuonSach)).EndInit();
            this.tabDocGia.ResumeLayout(false);
            this.tabDocGia.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl fUser;
        private System.Windows.Forms.TabPage tabDocGia;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtMaDocGia;
        private System.Windows.Forms.DateTimePicker dtpNgayDangKy;
        private System.Windows.Forms.TextBox txtTenDocGia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabMuonTraSach;
        private System.Windows.Forms.DataGridView dgvMuonSach;
        private System.Windows.Forms.Button btnTimKiem_MuonSach;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnInPhieuMuon;
        private System.Windows.Forms.Button btnBotNhieu;
        private System.Windows.Forms.Button btnBotMot;
        private System.Windows.Forms.Button btnThemMot;
        private System.Windows.Forms.ListView listSachMuon;
        private System.Windows.Forms.ColumnHeader lstMaSach;
        private System.Windows.Forms.ColumnHeader lstTenSach;
        private System.Windows.Forms.ColumnHeader lstSoTrang;
        private System.Windows.Forms.ColumnHeader lstNgayNhap;
        private System.Windows.Forms.ColumnHeader lstTinhTrang;
        private System.Windows.Forms.ColumnHeader lstMaTheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTheLoai;
    }
}