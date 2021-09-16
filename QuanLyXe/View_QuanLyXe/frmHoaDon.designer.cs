namespace BaiTapLon
{
    partial class frmHoaDon
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHoaDon));
            this.grHD_ChucNang = new System.Windows.Forms.GroupBox();
            this.btnHD_Xoa = new System.Windows.Forms.Button();
            this.btnHD_Sua = new System.Windows.Forms.Button();
            this.btnHD_ThanhToan = new System.Windows.Forms.Button();
            this.btnHD_XuatHD = new System.Windows.Forms.Button();
            this.grHD_ThongTin = new System.Windows.Forms.GroupBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.cbbHD_MaXe = new System.Windows.Forms.ComboBox();
            this.txtHD_SoLuong = new System.Windows.Forms.TextBox();
            this.txtHD_MaHoaDon = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.cbbHD_LoaiHD = new System.Windows.Forms.ComboBox();
            this.txtHD_ThanhTien = new System.Windows.Forms.TextBox();
            this.txtHD_DonGia = new System.Windows.Forms.TextBox();
            this.dtpkHD_NgayLapHD = new System.Windows.Forms.DateTimePicker();
            this.txtHD_CongDung = new System.Windows.Forms.TextBox();
            this.txtHD_TenXe = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.grHD_HoaDonInfo = new System.Windows.Forms.GroupBox();
            this.grHD_LoaiHoaDon = new System.Windows.Forms.GroupBox();
            this.treHD_LoaiHD = new System.Windows.Forms.TreeView();
            this.lvwHD = new System.Windows.Forms.ListView();
            this.imgTree = new System.Windows.Forms.ImageList(this.components);
            this.imgLon = new System.Windows.Forms.ImageList(this.components);
            this.imgNho = new System.Windows.Forms.ImageList(this.components);
            this.grHD_ChucNang.SuspendLayout();
            this.grHD_ThongTin.SuspendLayout();
            this.grHD_LoaiHoaDon.SuspendLayout();
            this.SuspendLayout();
            // 
            // grHD_ChucNang
            // 
            this.grHD_ChucNang.Controls.Add(this.btnHD_Xoa);
            this.grHD_ChucNang.Controls.Add(this.btnHD_Sua);
            this.grHD_ChucNang.Controls.Add(this.btnHD_ThanhToan);
            this.grHD_ChucNang.Controls.Add(this.btnHD_XuatHD);
            this.grHD_ChucNang.Location = new System.Drawing.Point(281, 550);
            this.grHD_ChucNang.Name = "grHD_ChucNang";
            this.grHD_ChucNang.Size = new System.Drawing.Size(917, 82);
            this.grHD_ChucNang.TabIndex = 8;
            this.grHD_ChucNang.TabStop = false;
            this.grHD_ChucNang.Text = "Chức năng";
            // 
            // btnHD_Xoa
            // 
            this.btnHD_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHD_Xoa.Location = new System.Drawing.Point(746, 29);
            this.btnHD_Xoa.Name = "btnHD_Xoa";
            this.btnHD_Xoa.Size = new System.Drawing.Size(103, 35);
            this.btnHD_Xoa.TabIndex = 20;
            this.btnHD_Xoa.Text = "Xóa";
            this.btnHD_Xoa.UseVisualStyleBackColor = true;
            // 
            // btnHD_Sua
            // 
            this.btnHD_Sua.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHD_Sua.Location = new System.Drawing.Point(559, 29);
            this.btnHD_Sua.Name = "btnHD_Sua";
            this.btnHD_Sua.Size = new System.Drawing.Size(105, 35);
            this.btnHD_Sua.TabIndex = 19;
            this.btnHD_Sua.Text = "Lưu sửa";
            this.btnHD_Sua.UseVisualStyleBackColor = true;
            // 
            // btnHD_ThanhToan
            // 
            this.btnHD_ThanhToan.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHD_ThanhToan.Location = new System.Drawing.Point(333, 29);
            this.btnHD_ThanhToan.Name = "btnHD_ThanhToan";
            this.btnHD_ThanhToan.Size = new System.Drawing.Size(129, 35);
            this.btnHD_ThanhToan.TabIndex = 16;
            this.btnHD_ThanhToan.Text = "Thanh toán";
            this.btnHD_ThanhToan.UseVisualStyleBackColor = true;
            // 
            // btnHD_XuatHD
            // 
            this.btnHD_XuatHD.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHD_XuatHD.Location = new System.Drawing.Point(120, 29);
            this.btnHD_XuatHD.Name = "btnHD_XuatHD";
            this.btnHD_XuatHD.Size = new System.Drawing.Size(148, 35);
            this.btnHD_XuatHD.TabIndex = 15;
            this.btnHD_XuatHD.Text = "Xuất hóa đơn";
            this.btnHD_XuatHD.UseVisualStyleBackColor = true;
            // 
            // grHD_ThongTin
            // 
            this.grHD_ThongTin.Controls.Add(this.txtTenKH);
            this.grHD_ThongTin.Controls.Add(this.cbbHD_MaXe);
            this.grHD_ThongTin.Controls.Add(this.txtHD_SoLuong);
            this.grHD_ThongTin.Controls.Add(this.txtHD_MaHoaDon);
            this.grHD_ThongTin.Controls.Add(this.label27);
            this.grHD_ThongTin.Controls.Add(this.label25);
            this.grHD_ThongTin.Controls.Add(this.cbbHD_LoaiHD);
            this.grHD_ThongTin.Controls.Add(this.txtHD_ThanhTien);
            this.grHD_ThongTin.Controls.Add(this.txtHD_DonGia);
            this.grHD_ThongTin.Controls.Add(this.dtpkHD_NgayLapHD);
            this.grHD_ThongTin.Controls.Add(this.txtHD_CongDung);
            this.grHD_ThongTin.Controls.Add(this.txtHD_TenXe);
            this.grHD_ThongTin.Controls.Add(this.label24);
            this.grHD_ThongTin.Controls.Add(this.label17);
            this.grHD_ThongTin.Controls.Add(this.label23);
            this.grHD_ThongTin.Controls.Add(this.label19);
            this.grHD_ThongTin.Controls.Add(this.label18);
            this.grHD_ThongTin.Controls.Add(this.label20);
            this.grHD_ThongTin.Controls.Add(this.label21);
            this.grHD_ThongTin.Controls.Add(this.label22);
            this.grHD_ThongTin.Location = new System.Drawing.Point(281, 271);
            this.grHD_ThongTin.Name = "grHD_ThongTin";
            this.grHD_ThongTin.Size = new System.Drawing.Size(920, 273);
            this.grHD_ThongTin.TabIndex = 7;
            this.grHD_ThongTin.TabStop = false;
            this.grHD_ThongTin.Text = "Thông tin:";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(177, 175);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(255, 30);
            this.txtTenKH.TabIndex = 27;
            // 
            // cbbHD_MaXe
            // 
            this.cbbHD_MaXe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbHD_MaXe.FormattingEnabled = true;
            this.cbbHD_MaXe.Location = new System.Drawing.Point(675, 35);
            this.cbbHD_MaXe.Name = "cbbHD_MaXe";
            this.cbbHD_MaXe.Size = new System.Drawing.Size(223, 33);
            this.cbbHD_MaXe.TabIndex = 24;
            // 
            // txtHD_SoLuong
            // 
            this.txtHD_SoLuong.Location = new System.Drawing.Point(675, 231);
            this.txtHD_SoLuong.Name = "txtHD_SoLuong";
            this.txtHD_SoLuong.Size = new System.Drawing.Size(223, 30);
            this.txtHD_SoLuong.TabIndex = 23;
            // 
            // txtHD_MaHoaDon
            // 
            this.txtHD_MaHoaDon.Location = new System.Drawing.Point(177, 37);
            this.txtHD_MaHoaDon.Name = "txtHD_MaHoaDon";
            this.txtHD_MaHoaDon.Size = new System.Drawing.Size(255, 30);
            this.txtHD_MaHoaDon.TabIndex = 21;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(58, 37);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(117, 24);
            this.label27.TabIndex = 20;
            this.label27.Text = "Mã hóa đơn:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(586, 40);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(71, 24);
            this.label25.TabIndex = 18;
            this.label25.Text = "Mã Xe:";
            // 
            // cbbHD_LoaiHD
            // 
            this.cbbHD_LoaiHD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbHD_LoaiHD.FormattingEnabled = true;
            this.cbbHD_LoaiHD.Location = new System.Drawing.Point(177, 127);
            this.cbbHD_LoaiHD.Name = "cbbHD_LoaiHD";
            this.cbbHD_LoaiHD.Size = new System.Drawing.Size(255, 33);
            this.cbbHD_LoaiHD.TabIndex = 16;
            // 
            // txtHD_ThanhTien
            // 
            this.txtHD_ThanhTien.Location = new System.Drawing.Point(177, 225);
            this.txtHD_ThanhTien.Name = "txtHD_ThanhTien";
            this.txtHD_ThanhTien.Size = new System.Drawing.Size(255, 30);
            this.txtHD_ThanhTien.TabIndex = 12;
            // 
            // txtHD_DonGia
            // 
            this.txtHD_DonGia.Location = new System.Drawing.Point(675, 183);
            this.txtHD_DonGia.Name = "txtHD_DonGia";
            this.txtHD_DonGia.Size = new System.Drawing.Size(223, 30);
            this.txtHD_DonGia.TabIndex = 11;
            // 
            // dtpkHD_NgayLapHD
            // 
            this.dtpkHD_NgayLapHD.Location = new System.Drawing.Point(177, 82);
            this.dtpkHD_NgayLapHD.Name = "dtpkHD_NgayLapHD";
            this.dtpkHD_NgayLapHD.Size = new System.Drawing.Size(271, 30);
            this.dtpkHD_NgayLapHD.TabIndex = 15;
            // 
            // txtHD_CongDung
            // 
            this.txtHD_CongDung.Location = new System.Drawing.Point(675, 131);
            this.txtHD_CongDung.Name = "txtHD_CongDung";
            this.txtHD_CongDung.Size = new System.Drawing.Size(223, 30);
            this.txtHD_CongDung.TabIndex = 10;
            // 
            // txtHD_TenXe
            // 
            this.txtHD_TenXe.Location = new System.Drawing.Point(675, 87);
            this.txtHD_TenXe.Name = "txtHD_TenXe";
            this.txtHD_TenXe.Size = new System.Drawing.Size(223, 30);
            this.txtHD_TenXe.TabIndex = 9;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(35, 130);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(126, 24);
            this.label24.TabIndex = 1;
            this.label24.Text = "Loại hóa đơn:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(55, 227);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(105, 24);
            this.label17.TabIndex = 8;
            this.label17.Text = "Thành tiền:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(6, 81);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(165, 24);
            this.label23.TabIndex = 2;
            this.label23.Text = "Ngày lập hóa đơn:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(566, 230);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(91, 24);
            this.label19.TabIndex = 6;
            this.label19.Text = "Số lượng:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(6, 175);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(153, 24);
            this.label18.TabIndex = 7;
            this.label18.Text = "Tên khách hàng:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(555, 132);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(102, 24);
            this.label20.TabIndex = 5;
            this.label20.Text = "Phân Khối:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(577, 183);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(80, 24);
            this.label21.TabIndex = 4;
            this.label21.Text = "Đơn giá:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(578, 87);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(79, 24);
            this.label22.TabIndex = 3;
            this.label22.Text = "Tên Xe:";
            // 
            // grHD_HoaDonInfo
            // 
            this.grHD_HoaDonInfo.Location = new System.Drawing.Point(281, 0);
            this.grHD_HoaDonInfo.Name = "grHD_HoaDonInfo";
            this.grHD_HoaDonInfo.Size = new System.Drawing.Size(920, 265);
            this.grHD_HoaDonInfo.TabIndex = 6;
            this.grHD_HoaDonInfo.TabStop = false;
            this.grHD_HoaDonInfo.Text = "Chi tiết hóa đơn";
            // 
            // grHD_LoaiHoaDon
            // 
            this.grHD_LoaiHoaDon.Controls.Add(this.treHD_LoaiHD);
            this.grHD_LoaiHoaDon.Location = new System.Drawing.Point(1, 0);
            this.grHD_LoaiHoaDon.Name = "grHD_LoaiHoaDon";
            this.grHD_LoaiHoaDon.Size = new System.Drawing.Size(274, 544);
            this.grHD_LoaiHoaDon.TabIndex = 5;
            this.grHD_LoaiHoaDon.TabStop = false;
            this.grHD_LoaiHoaDon.Text = "Loại hóa đơn";
            // 
            // treHD_LoaiHD
            // 
            this.treHD_LoaiHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treHD_LoaiHD.Location = new System.Drawing.Point(3, 26);
            this.treHD_LoaiHD.Name = "treHD_LoaiHD";
            this.treHD_LoaiHD.Size = new System.Drawing.Size(268, 515);
            this.treHD_LoaiHD.TabIndex = 0;
            this.treHD_LoaiHD.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treHD_LoaiHD_AfterSelect);
            // 
            // lvwHD
            // 
            this.lvwHD.HideSelection = false;
            this.lvwHD.Location = new System.Drawing.Point(291, 29);
            this.lvwHD.Name = "lvwHD";
            this.lvwHD.Size = new System.Drawing.Size(888, 236);
            this.lvwHD.TabIndex = 0;
            this.lvwHD.UseCompatibleStateImageBehavior = false;
            // 
            // imgTree
            // 
            this.imgTree.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgTree.ImageStream")));
            this.imgTree.TransparentColor = System.Drawing.Color.Transparent;
            this.imgTree.Images.SetKeyName(0, "bill.png");
            this.imgTree.Images.SetKeyName(1, "bil.png");
            // 
            // imgLon
            // 
            this.imgLon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgLon.ImageStream")));
            this.imgLon.TransparentColor = System.Drawing.Color.Transparent;
            this.imgLon.Images.SetKeyName(0, "invoice.png");
            // 
            // imgNho
            // 
            this.imgNho.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgNho.ImageStream")));
            this.imgNho.TransparentColor = System.Drawing.Color.Transparent;
            this.imgNho.Images.SetKeyName(0, "receipt.png");
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1213, 644);
            this.Controls.Add(this.lvwHD);
            this.Controls.Add(this.grHD_ChucNang);
            this.Controls.Add(this.grHD_ThongTin);
            this.Controls.Add(this.grHD_HoaDonInfo);
            this.Controls.Add(this.grHD_LoaiHoaDon);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hoa Don";
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            this.grHD_ChucNang.ResumeLayout(false);
            this.grHD_ThongTin.ResumeLayout(false);
            this.grHD_ThongTin.PerformLayout();
            this.grHD_LoaiHoaDon.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grHD_ChucNang;
        private System.Windows.Forms.Button btnHD_Xoa;
        private System.Windows.Forms.Button btnHD_Sua;
        private System.Windows.Forms.Button btnHD_ThanhToan;
        private System.Windows.Forms.Button btnHD_XuatHD;
        private System.Windows.Forms.GroupBox grHD_ThongTin;
        private System.Windows.Forms.ComboBox cbbHD_MaXe;
        private System.Windows.Forms.TextBox txtHD_MaHoaDon;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ComboBox cbbHD_LoaiHD;
        private System.Windows.Forms.TextBox txtHD_ThanhTien;
        private System.Windows.Forms.TextBox txtHD_DonGia;
        private System.Windows.Forms.TextBox txtHD_CongDung;
        private System.Windows.Forms.TextBox txtHD_TenXe;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.GroupBox grHD_HoaDonInfo;
        private System.Windows.Forms.GroupBox grHD_LoaiHoaDon;
        private System.Windows.Forms.TreeView treHD_LoaiHD;
        private System.Windows.Forms.ListView lvwHD;
        private System.Windows.Forms.ImageList imgTree;
        private System.Windows.Forms.ImageList imgLon;
        private System.Windows.Forms.ImageList imgNho;
        public System.Windows.Forms.DateTimePicker dtpkHD_NgayLapHD;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtHD_SoLuong;
    }
}