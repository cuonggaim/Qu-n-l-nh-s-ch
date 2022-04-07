namespace QLBS
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhaCungCap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTheLoai = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhaXuatBan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSach = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTacGia = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHoaDonNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHoaDonBan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTimKiem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFindSach = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFindNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFindBan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFindKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBaoCao = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBCHangTon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBCDoanhThu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTroGiup = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHienTroGiup = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVaiNet = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.danhMụcToolStripMenuItem,
            this.mnuHoaDon,
            this.mnuTimKiem,
            this.mnuBaoCao,
            this.mnuTroGiup});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuThoat});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(55, 20);
            this.mnuFile.Text = "Tệp tin";
            // 
            // mnuThoat
            // 
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mnuThoat.Size = new System.Drawing.Size(180, 22);
            this.mnuThoat.Text = "Thoat";
            this.mnuThoat.Click += new System.EventHandler(this.mnuThoat_Click);
            // 
            // danhMụcToolStripMenuItem
            // 
            this.danhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNhaCungCap,
            this.mnuKhachHang,
            this.mnuNhanVien,
            this.mnuTheLoai,
            this.mnuNhaXuatBan,
            this.mnuSach,
            this.mnuTacGia});
            this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.danhMụcToolStripMenuItem.Text = "Danh mục";
            // 
            // mnuNhaCungCap
            // 
            this.mnuNhaCungCap.Name = "mnuNhaCungCap";
            this.mnuNhaCungCap.Size = new System.Drawing.Size(180, 22);
            this.mnuNhaCungCap.Text = "Nhà cung cấp";
            // 
            // mnuKhachHang
            // 
            this.mnuKhachHang.Name = "mnuKhachHang";
            this.mnuKhachHang.Size = new System.Drawing.Size(180, 22);
            this.mnuKhachHang.Text = "Khách hàng";
            // 
            // mnuNhanVien
            // 
            this.mnuNhanVien.Name = "mnuNhanVien";
            this.mnuNhanVien.Size = new System.Drawing.Size(180, 22);
            this.mnuNhanVien.Text = "Nhân viên";
            // 
            // mnuTheLoai
            // 
            this.mnuTheLoai.Name = "mnuTheLoai";
            this.mnuTheLoai.Size = new System.Drawing.Size(180, 22);
            this.mnuTheLoai.Text = "Thể loại";
            this.mnuTheLoai.Click += new System.EventHandler(this.mnuTheLoai_Click);
            // 
            // mnuNhaXuatBan
            // 
            this.mnuNhaXuatBan.Name = "mnuNhaXuatBan";
            this.mnuNhaXuatBan.Size = new System.Drawing.Size(180, 22);
            this.mnuNhaXuatBan.Text = "Nhà xuất bản";
            // 
            // mnuSach
            // 
            this.mnuSach.Name = "mnuSach";
            this.mnuSach.Size = new System.Drawing.Size(180, 22);
            this.mnuSach.Text = "Sách";
            // 
            // mnuTacGia
            // 
            this.mnuTacGia.Name = "mnuTacGia";
            this.mnuTacGia.Size = new System.Drawing.Size(180, 22);
            this.mnuTacGia.Text = "Tác giả";
            // 
            // mnuHoaDon
            // 
            this.mnuHoaDon.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHoaDonNhap,
            this.mnuHoaDonBan});
            this.mnuHoaDon.Name = "mnuHoaDon";
            this.mnuHoaDon.Size = new System.Drawing.Size(65, 20);
            this.mnuHoaDon.Text = "Hóa đơn";
            // 
            // mnuHoaDonNhap
            // 
            this.mnuHoaDonNhap.Name = "mnuHoaDonNhap";
            this.mnuHoaDonNhap.Size = new System.Drawing.Size(150, 22);
            this.mnuHoaDonNhap.Text = "Hóa đơn nhập";
            // 
            // mnuHoaDonBan
            // 
            this.mnuHoaDonBan.Name = "mnuHoaDonBan";
            this.mnuHoaDonBan.Size = new System.Drawing.Size(150, 22);
            this.mnuHoaDonBan.Text = "Hóa đơn bán";
            // 
            // mnuTimKiem
            // 
            this.mnuTimKiem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFindSach,
            this.hóaĐơnToolStripMenuItem,
            this.mnuFindKhachHang});
            this.mnuTimKiem.Name = "mnuTimKiem";
            this.mnuTimKiem.Size = new System.Drawing.Size(68, 20);
            this.mnuTimKiem.Text = "Tìm kiếm";
            // 
            // mnuFindSach
            // 
            this.mnuFindSach.Name = "mnuFindSach";
            this.mnuFindSach.Size = new System.Drawing.Size(180, 22);
            this.mnuFindSach.Text = "Sách";
            // 
            // hóaĐơnToolStripMenuItem
            // 
            this.hóaĐơnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFindNhap,
            this.mnuFindBan});
            this.hóaĐơnToolStripMenuItem.Name = "hóaĐơnToolStripMenuItem";
            this.hóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hóaĐơnToolStripMenuItem.Text = "Hóa đơn";
            // 
            // mnuFindNhap
            // 
            this.mnuFindNhap.Name = "mnuFindNhap";
            this.mnuFindNhap.Size = new System.Drawing.Size(103, 22);
            this.mnuFindNhap.Text = "Nhập";
            // 
            // mnuFindBan
            // 
            this.mnuFindBan.Name = "mnuFindBan";
            this.mnuFindBan.Size = new System.Drawing.Size(103, 22);
            this.mnuFindBan.Text = "Bán";
            // 
            // mnuFindKhachHang
            // 
            this.mnuFindKhachHang.Name = "mnuFindKhachHang";
            this.mnuFindKhachHang.Size = new System.Drawing.Size(180, 22);
            this.mnuFindKhachHang.Text = "Khách hàng";
            // 
            // mnuBaoCao
            // 
            this.mnuBaoCao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBCHangTon,
            this.mnuBCDoanhThu});
            this.mnuBaoCao.Name = "mnuBaoCao";
            this.mnuBaoCao.Size = new System.Drawing.Size(61, 20);
            this.mnuBaoCao.Text = "Báo cáo";
            // 
            // mnuBCHangTon
            // 
            this.mnuBCHangTon.Name = "mnuBCHangTon";
            this.mnuBCHangTon.Size = new System.Drawing.Size(130, 22);
            this.mnuBCHangTon.Text = "Hàng tồn";
            // 
            // mnuBCDoanhThu
            // 
            this.mnuBCDoanhThu.Name = "mnuBCDoanhThu";
            this.mnuBCDoanhThu.Size = new System.Drawing.Size(130, 22);
            this.mnuBCDoanhThu.Text = "Doanh thu";
            // 
            // mnuTroGiup
            // 
            this.mnuTroGiup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHienTroGiup,
            this.mnuVaiNet});
            this.mnuTroGiup.Name = "mnuTroGiup";
            this.mnuTroGiup.Size = new System.Drawing.Size(62, 20);
            this.mnuTroGiup.Text = "Trợ giúp";
            // 
            // mnuHienTroGiup
            // 
            this.mnuHienTroGiup.Name = "mnuHienTroGiup";
            this.mnuHienTroGiup.Size = new System.Drawing.Size(117, 22);
            this.mnuHienTroGiup.Text = "Trợ giúp";
            // 
            // mnuVaiNet
            // 
            this.mnuVaiNet.Name = "mnuVaiNet";
            this.mnuVaiNet.Size = new System.Drawing.Size(117, 22);
            this.mnuVaiNet.Text = "Vài nét";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Chương trình quản lý bán sách";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuNhaCungCap;
        private System.Windows.Forms.ToolStripMenuItem mnuKhachHang;
        private System.Windows.Forms.ToolStripMenuItem mnuNhanVien;
        private System.Windows.Forms.ToolStripMenuItem mnuTheLoai;
        private System.Windows.Forms.ToolStripMenuItem mnuNhaXuatBan;
        private System.Windows.Forms.ToolStripMenuItem mnuSach;
        private System.Windows.Forms.ToolStripMenuItem mnuTacGia;
        private System.Windows.Forms.ToolStripMenuItem mnuHoaDon;
        private System.Windows.Forms.ToolStripMenuItem mnuHoaDonNhap;
        private System.Windows.Forms.ToolStripMenuItem mnuHoaDonBan;
        private System.Windows.Forms.ToolStripMenuItem mnuTimKiem;
        private System.Windows.Forms.ToolStripMenuItem mnuFindSach;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuFindNhap;
        private System.Windows.Forms.ToolStripMenuItem mnuFindBan;
        private System.Windows.Forms.ToolStripMenuItem mnuFindKhachHang;
        private System.Windows.Forms.ToolStripMenuItem mnuBaoCao;
        private System.Windows.Forms.ToolStripMenuItem mnuBCHangTon;
        private System.Windows.Forms.ToolStripMenuItem mnuBCDoanhThu;
        private System.Windows.Forms.ToolStripMenuItem mnuTroGiup;
        private System.Windows.Forms.ToolStripMenuItem mnuHienTroGiup;
        private System.Windows.Forms.ToolStripMenuItem mnuVaiNet;
    }
}

