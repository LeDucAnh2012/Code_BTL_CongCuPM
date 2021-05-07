
namespace BTL_QLThuVien
{
    partial class fMuonSach_User
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvTTSachMuon = new System.Windows.Forms.DataGridView();
            this.MaSach1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhap1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTheLoai1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnMuon = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.dtpNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtMaPhieu1 = new System.Windows.Forms.TextBox();
            this.labSDT = new System.Windows.Forms.Label();
            this.labMaDocGia = new System.Windows.Forms.Label();
            this.labTenDocGia = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTSachMuon)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvTTSachMuon);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(96, 145);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(579, 208);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sách mượn";
            // 
            // dgvTTSachMuon
            // 
            this.dgvTTSachMuon.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvTTSachMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTTSachMuon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSach1,
            this.TenSach1,
            this.NgayNhap1,
            this.TinhTrang1,
            this.MaTheLoai1});
            this.dgvTTSachMuon.Location = new System.Drawing.Point(6, 24);
            this.dgvTTSachMuon.Margin = new System.Windows.Forms.Padding(2);
            this.dgvTTSachMuon.Name = "dgvTTSachMuon";
            this.dgvTTSachMuon.RowHeadersWidth = 51;
            this.dgvTTSachMuon.RowTemplate.Height = 24;
            this.dgvTTSachMuon.Size = new System.Drawing.Size(568, 171);
            this.dgvTTSachMuon.TabIndex = 17;
            // 
            // MaSach1
            // 
            this.MaSach1.DataPropertyName = "MaSach1";
            this.MaSach1.HeaderText = "Mã sách";
            this.MaSach1.MinimumWidth = 6;
            this.MaSach1.Name = "MaSach1";
            this.MaSach1.Width = 125;
            // 
            // TenSach1
            // 
            this.TenSach1.DataPropertyName = "TenSach1";
            this.TenSach1.HeaderText = "Tên sách";
            this.TenSach1.MinimumWidth = 6;
            this.TenSach1.Name = "TenSach1";
            this.TenSach1.Width = 125;
            // 
            // NgayNhap1
            // 
            this.NgayNhap1.DataPropertyName = "NgayNhap1";
            this.NgayNhap1.HeaderText = "Ngày nhập";
            this.NgayNhap1.MinimumWidth = 6;
            this.NgayNhap1.Name = "NgayNhap1";
            this.NgayNhap1.Width = 125;
            // 
            // TinhTrang1
            // 
            this.TinhTrang1.DataPropertyName = "TinhTrang1";
            this.TinhTrang1.HeaderText = "Tình trạng";
            this.TinhTrang1.MinimumWidth = 6;
            this.TinhTrang1.Name = "TinhTrang1";
            this.TinhTrang1.Width = 125;
            // 
            // MaTheLoai1
            // 
            this.MaTheLoai1.DataPropertyName = "MaTheLoai1";
            this.MaTheLoai1.HeaderText = "Mã thể loại";
            this.MaTheLoai1.MinimumWidth = 6;
            this.MaTheLoai1.Name = "MaTheLoai1";
            this.MaTheLoai1.Width = 125;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Red;
            this.btnThoat.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThoat.Location = new System.Drawing.Point(462, 367);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(113, 42);
            this.btnThoat.TabIndex = 22;
            this.btnThoat.Text = "Hủy";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnMuon
            // 
            this.btnMuon.BackColor = System.Drawing.Color.Aqua;
            this.btnMuon.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMuon.Location = new System.Drawing.Point(190, 362);
            this.btnMuon.Margin = new System.Windows.Forms.Padding(2);
            this.btnMuon.Name = "btnMuon";
            this.btnMuon.Size = new System.Drawing.Size(113, 52);
            this.btnMuon.TabIndex = 21;
            this.btnMuon.Text = "In Phiếu";
            this.btnMuon.UseVisualStyleBackColor = false;
            this.btnMuon.Click += new System.EventHandler(this.btnMuon_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtMaPhieu1);
            this.groupBox6.Controls.Add(this.label22);
            this.groupBox6.Controls.Add(this.dtpNgayMuon);
            this.groupBox6.Controls.Add(this.label18);
            this.groupBox6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox6.Location = new System.Drawing.Point(94, 30);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox6.Size = new System.Drawing.Size(250, 111);
            this.groupBox6.TabIndex = 20;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Phiếu mượn";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Orange;
            this.label22.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(5, 26);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(73, 19);
            this.label22.TabIndex = 20;
            this.label22.Text = "Mã phiếu";
            // 
            // dtpNgayMuon
            // 
            this.dtpNgayMuon.Enabled = false;
            this.dtpNgayMuon.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayMuon.Location = new System.Drawing.Point(96, 50);
            this.dtpNgayMuon.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNgayMuon.Name = "dtpNgayMuon";
            this.dtpNgayMuon.Size = new System.Drawing.Size(142, 28);
            this.dtpNgayMuon.TabIndex = 14;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Orange;
            this.label18.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(5, 55);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(90, 19);
            this.label18.TabIndex = 4;
            this.label18.Text = "Ngày mượn";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.labSDT);
            this.groupBox5.Controls.Add(this.labMaDocGia);
            this.groupBox5.Controls.Add(this.labTenDocGia);
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Controls.Add(this.label21);
            this.groupBox5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox5.Location = new System.Drawing.Point(359, 30);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(317, 111);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Người mượn";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Orange;
            this.label19.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(16, 28);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(83, 19);
            this.label19.TabIndex = 12;
            this.label19.Text = "Mã độc giả";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Orange;
            this.label20.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(16, 56);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(87, 19);
            this.label20.TabIndex = 16;
            this.label20.Text = "Tên độc giả";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Orange;
            this.label21.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(16, 85);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(37, 19);
            this.label21.TabIndex = 18;
            this.label21.Text = "SĐT";
            // 
            // txtMaPhieu1
            // 
            this.txtMaPhieu1.Location = new System.Drawing.Point(96, 20);
            this.txtMaPhieu1.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaPhieu1.Name = "txtMaPhieu1";
            this.txtMaPhieu1.Size = new System.Drawing.Size(142, 26);
            this.txtMaPhieu1.TabIndex = 22;
            // 
            // labSDT
            // 
            this.labSDT.AutoSize = true;
            this.labSDT.Location = new System.Drawing.Point(108, 85);
            this.labSDT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labSDT.Name = "labSDT";
            this.labSDT.Size = new System.Drawing.Size(37, 19);
            this.labSDT.TabIndex = 27;
            this.labSDT.Text = "SĐT";
            // 
            // labMaDocGia
            // 
            this.labMaDocGia.AutoSize = true;
            this.labMaDocGia.Location = new System.Drawing.Point(108, 26);
            this.labMaDocGia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labMaDocGia.Name = "labMaDocGia";
            this.labMaDocGia.Size = new System.Drawing.Size(83, 19);
            this.labMaDocGia.TabIndex = 25;
            this.labMaDocGia.Text = "Mã độc giả";
            // 
            // labTenDocGia
            // 
            this.labTenDocGia.AutoSize = true;
            this.labTenDocGia.Location = new System.Drawing.Point(108, 55);
            this.labTenDocGia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labTenDocGia.Name = "labTenDocGia";
            this.labTenDocGia.Size = new System.Drawing.Size(87, 19);
            this.labTenDocGia.TabIndex = 26;
            this.labTenDocGia.Text = "Tên độc giả";
            // 
            // fMuonSach_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnMuon);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Name = "fMuonSach_User";
            this.Text = "fMuonSach_User";
            this.Load += new System.EventHandler(this.fMuonSach_User_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTSachMuon)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvTTSachMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhap1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTheLoai1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnMuon;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.DateTimePicker dtpNgayMuon;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtMaPhieu1;
        private System.Windows.Forms.Label labSDT;
        private System.Windows.Forms.Label labMaDocGia;
        private System.Windows.Forms.Label labTenDocGia;
    }
}