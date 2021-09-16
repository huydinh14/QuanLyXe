namespace BaiTapLon
{
    partial class frmXe
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
            this.grTimKiem = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbTimLoaiXe = new System.Windows.Forms.ComboBox();
            this.txtTimTenXe = new System.Windows.Forms.TextBox();
            this.grDanhSach = new System.Windows.Forms.GroupBox();
            this.dtgvShow = new System.Windows.Forms.DataGridView();
            this.MaThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhaCungCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CongDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HanSD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grTimKiem.SuspendLayout();
            this.grDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvShow)).BeginInit();
            this.SuspendLayout();
            // 
            // grTimKiem
            // 
            this.grTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grTimKiem.Controls.Add(this.btnTimKiem);
            this.grTimKiem.Controls.Add(this.label2);
            this.grTimKiem.Controls.Add(this.label1);
            this.grTimKiem.Controls.Add(this.cbbTimLoaiXe);
            this.grTimKiem.Controls.Add(this.txtTimTenXe);
            this.grTimKiem.Location = new System.Drawing.Point(2, 14);
            this.grTimKiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grTimKiem.Name = "grTimKiem";
            this.grTimKiem.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grTimKiem.Size = new System.Drawing.Size(966, 107);
            this.grTimKiem.TabIndex = 8;
            this.grTimKiem.TabStop = false;
            this.grTimKiem.Text = "Chức năng";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.Location = new System.Drawing.Point(447, 17);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(188, 62);
            this.btnTimKiem.TabIndex = 1;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(644, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Loại Xe:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên Xe:";
            // 
            // cbbTimLoaiXe
            // 
            this.cbbTimLoaiXe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTimLoaiXe.FormattingEnabled = true;
            this.cbbTimLoaiXe.Location = new System.Drawing.Point(754, 28);
            this.cbbTimLoaiXe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbbTimLoaiXe.Name = "cbbTimLoaiXe";
            this.cbbTimLoaiXe.Size = new System.Drawing.Size(196, 28);
            this.cbbTimLoaiXe.TabIndex = 2;
            // 
            // txtTimTenXe
            // 
            this.txtTimTenXe.Location = new System.Drawing.Point(147, 34);
            this.txtTimTenXe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTimTenXe.Name = "txtTimTenXe";
            this.txtTimTenXe.Size = new System.Drawing.Size(289, 26);
            this.txtTimTenXe.TabIndex = 0;
            // 
            // grDanhSach
            // 
            this.grDanhSach.Controls.Add(this.dtgvShow);
            this.grDanhSach.Location = new System.Drawing.Point(12, 129);
            this.grDanhSach.Name = "grDanhSach";
            this.grDanhSach.Size = new System.Drawing.Size(1017, 343);
            this.grDanhSach.TabIndex = 9;
            this.grDanhSach.TabStop = false;
            this.grDanhSach.Text = "Danh sách";
            // 
            // dtgvShow
            // 
            this.dtgvShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvShow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaThuoc,
            this.TenNhaCungCap,
            this.TenThuoc,
            this.CongDung,
            this.DonViTinh,
            this.DonGia,
            this.NgaySX,
            this.HanSD,
            this.SoLuong,
            this.LoaiThuoc});
            this.dtgvShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvShow.Location = new System.Drawing.Point(3, 22);
            this.dtgvShow.Name = "dtgvShow";
            this.dtgvShow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvShow.Size = new System.Drawing.Size(1011, 318);
            this.dtgvShow.TabIndex = 0;
            this.dtgvShow.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvShow_CellContentClick);
            // 
            // MaThuoc
            // 
            this.MaThuoc.DataPropertyName = "MaXe";
            this.MaThuoc.HeaderText = "Mã Xe";
            this.MaThuoc.Name = "MaThuoc";
            // 
            // TenNhaCungCap
            // 
            this.TenNhaCungCap.DataPropertyName = "TenXe";
            this.TenNhaCungCap.HeaderText = "Tên Xe";
            this.TenNhaCungCap.Name = "TenNhaCungCap";
            // 
            // TenThuoc
            // 
            this.TenThuoc.DataPropertyName = "PhanKhoi";
            this.TenThuoc.HeaderText = "Phân Khối";
            this.TenThuoc.Name = "TenThuoc";
            // 
            // CongDung
            // 
            this.CongDung.DataPropertyName = "SoLuongTon";
            this.CongDung.HeaderText = "Số Lượng Tồn";
            this.CongDung.Name = "CongDung";
            // 
            // DonViTinh
            // 
            this.DonViTinh.DataPropertyName = "MaMau";
            this.DonViTinh.HeaderText = "Mã Màu";
            this.DonViTinh.Name = "DonViTinh";
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "MaLoai";
            this.DonGia.HeaderText = "Mã Loại";
            this.DonGia.Name = "DonGia";
            // 
            // NgaySX
            // 
            this.NgaySX.DataPropertyName = "DonGiaNhap";
            this.NgaySX.HeaderText = "Đơn Giá Nhập";
            this.NgaySX.Name = "NgaySX";
            // 
            // HanSD
            // 
            this.HanSD.DataPropertyName = "DonGiaBan";
            this.HanSD.HeaderText = "Đơn Giá Bán";
            this.HanSD.Name = "HanSD";
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "GhiChu";
            this.SoLuong.HeaderText = "Ghi Chú";
            this.SoLuong.Name = "SoLuong";
            // 
            // LoaiThuoc
            // 
            this.LoaiThuoc.DataPropertyName = "MaNCC";
            this.LoaiThuoc.HeaderText = "Mã Nhà Cung Cấp";
            this.LoaiThuoc.Name = "LoaiThuoc";
            // 
            // Xe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1296, 661);
            this.Controls.Add(this.grDanhSach);
            this.Controls.Add(this.grTimKiem);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Xe";
            this.Text = "Xe";
            this.grTimKiem.ResumeLayout(false);
            this.grTimKiem.PerformLayout();
            this.grDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvShow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbTimLoaiXe;
        private System.Windows.Forms.TextBox txtTimTenXe;
        private System.Windows.Forms.GroupBox grDanhSach;
        private System.Windows.Forms.DataGridView dtgvShow;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhaCungCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn CongDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySX;
        private System.Windows.Forms.DataGridViewTextBoxColumn HanSD;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiThuoc;
    }
}