namespace QuanLySinhVien.GUI
{
    partial class TrangChu
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
            this.menuTrangChu = new System.Windows.Forms.MenuStrip();
            this.menuHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.menuThongTin = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQLSV = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQLGV = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQLKhoa = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQLLop = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQLMH = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQLDiem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTroGiup = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.qlSV = new System.Windows.Forms.Button();
            this.qlGV = new System.Windows.Forms.Button();
            this.qlDiem = new System.Windows.Forms.Button();
            this.qlKhoa = new System.Windows.Forms.Button();
            this.qlLop = new System.Windows.Forms.Button();
            this.qlMH = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.menuTrangChu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuTrangChu
            // 
            this.menuTrangChu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.menuTrangChu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuTrangChu.GripMargin = new System.Windows.Forms.Padding(0);
            this.menuTrangChu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuTrangChu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHeThong,
            this.menuQuanLy,
            this.menuTroGiup});
            this.menuTrangChu.Location = new System.Drawing.Point(0, 0);
            this.menuTrangChu.Name = "menuTrangChu";
            this.menuTrangChu.Padding = new System.Windows.Forms.Padding(11, 3, 0, 3);
            this.menuTrangChu.Size = new System.Drawing.Size(1075, 30);
            this.menuTrangChu.TabIndex = 0;
            this.menuTrangChu.Text = "menuStrip1";
            // 
            // menuHeThong
            // 
            this.menuHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuThongTin,
            this.toolStripSeparator1,
            this.menuDangXuat});
            this.menuHeThong.Name = "menuHeThong";
            this.menuHeThong.Size = new System.Drawing.Size(88, 24);
            this.menuHeThong.Text = "Hệ thống";
            // 
            // menuThongTin
            // 
            this.menuThongTin.Name = "menuThongTin";
            this.menuThongTin.Size = new System.Drawing.Size(229, 26);
            this.menuThongTin.Text = "Thông tin tài khoản";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(226, 6);
            // 
            // menuDangXuat
            // 
            this.menuDangXuat.Name = "menuDangXuat";
            this.menuDangXuat.Size = new System.Drawing.Size(229, 26);
            this.menuDangXuat.Text = "Đăng xuất";
            // 
            // menuQuanLy
            // 
            this.menuQuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuQLSV,
            this.menuQLGV,
            this.menuQLKhoa,
            this.menuQLLop,
            this.menuQLMH,
            this.menuQLDiem});
            this.menuQuanLy.Name = "menuQuanLy";
            this.menuQuanLy.Size = new System.Drawing.Size(76, 24);
            this.menuQuanLy.Text = "Quản lý";
            // 
            // menuQLSV
            // 
            this.menuQLSV.Name = "menuQLSV";
            this.menuQLSV.Size = new System.Drawing.Size(221, 26);
            this.menuQLSV.Text = "Quản lý sinh viên";
            // 
            // menuQLGV
            // 
            this.menuQLGV.Name = "menuQLGV";
            this.menuQLGV.Size = new System.Drawing.Size(221, 26);
            this.menuQLGV.Text = "Quản lý giảng viên";
            this.menuQLGV.Click += new System.EventHandler(this.qlGV_Click);
            // 
            // menuQLKhoa
            // 
            this.menuQLKhoa.Name = "menuQLKhoa";
            this.menuQLKhoa.Size = new System.Drawing.Size(221, 26);
            this.menuQLKhoa.Text = "Quản lý khoa";
            this.menuQLKhoa.Click += new System.EventHandler(this.qlKhoa_Click);
            // 
            // menuQLLop
            // 
            this.menuQLLop.Name = "menuQLLop";
            this.menuQLLop.Size = new System.Drawing.Size(224, 26);
            this.menuQLLop.Text = "Quản lý lớp";
            this.menuQLLop.Click += new System.EventHandler(this.qlLop_Click);
            // 
            // menuQLMH
            // 
            this.menuQLMH.Name = "menuQLMH";
            this.menuQLMH.Size = new System.Drawing.Size(221, 26);
            this.menuQLMH.Text = "Quản lý môn học";
            // 
            // menuQLDiem
            // 
            this.menuQLDiem.Name = "menuQLDiem";
            this.menuQLDiem.Size = new System.Drawing.Size(221, 26);
            this.menuQLDiem.Text = "Quản lý điểm thi";
            // 
            // menuTroGiup
            // 
            this.menuTroGiup.Name = "menuTroGiup";
            this.menuTroGiup.Size = new System.Drawing.Size(81, 24);
            this.menuTroGiup.Text = "Trợ giúp";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(0, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1075, 59);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÝ SINH VIÊN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // qlSV
            // 
            this.qlSV.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.qlSV.Location = new System.Drawing.Point(176, 117);
            this.qlSV.Margin = new System.Windows.Forms.Padding(4);
            this.qlSV.Name = "qlSV";
            this.qlSV.Size = new System.Drawing.Size(234, 56);
            this.qlSV.TabIndex = 2;
            this.qlSV.TabStop = false;
            this.qlSV.Text = "Quản lý sinh viên";
            this.qlSV.UseVisualStyleBackColor = true;
            // 
            // qlGV
            // 
            this.qlGV.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.qlGV.Location = new System.Drawing.Point(176, 219);
            this.qlGV.Margin = new System.Windows.Forms.Padding(4);
            this.qlGV.Name = "qlGV";
            this.qlGV.Size = new System.Drawing.Size(234, 56);
            this.qlGV.TabIndex = 2;
            this.qlGV.TabStop = false;
            this.qlGV.Text = "Quản lý giảng viên";
            this.qlGV.UseVisualStyleBackColor = true;
            this.qlGV.Click += new System.EventHandler(this.qlGV_Click);
            // 
            // qlDiem
            // 
            this.qlDiem.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.qlDiem.Location = new System.Drawing.Point(176, 321);
            this.qlDiem.Margin = new System.Windows.Forms.Padding(4);
            this.qlDiem.Name = "qlDiem";
            this.qlDiem.Size = new System.Drawing.Size(234, 56);
            this.qlDiem.TabIndex = 2;
            this.qlDiem.TabStop = false;
            this.qlDiem.Text = "Quản lý điểm thi";
            this.qlDiem.UseVisualStyleBackColor = true;
            // 
            // qlKhoa
            // 
            this.qlKhoa.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.qlKhoa.Location = new System.Drawing.Point(625, 117);
            this.qlKhoa.Margin = new System.Windows.Forms.Padding(4);
            this.qlKhoa.Name = "qlKhoa";
            this.qlKhoa.Size = new System.Drawing.Size(234, 56);
            this.qlKhoa.TabIndex = 2;
            this.qlKhoa.TabStop = false;
            this.qlKhoa.Text = "Quản lý khoa";
            this.qlKhoa.UseVisualStyleBackColor = true;
            this.qlKhoa.Click += new System.EventHandler(this.qlKhoa_Click);
            // 
            // qlLop
            // 
            this.qlLop.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.qlLop.Location = new System.Drawing.Point(625, 219);
            this.qlLop.Margin = new System.Windows.Forms.Padding(4);
            this.qlLop.Name = "qlLop";
            this.qlLop.Size = new System.Drawing.Size(234, 56);
            this.qlLop.TabIndex = 2;
            this.qlLop.TabStop = false;
            this.qlLop.Text = "Quản lý lớp";
            this.qlLop.UseVisualStyleBackColor = true;
            this.qlLop.Click += new System.EventHandler(this.qlLop_Click);
            // 
            // qlMH
            // 
            this.qlMH.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.qlMH.Location = new System.Drawing.Point(625, 321);
            this.qlMH.Margin = new System.Windows.Forms.Padding(4);
            this.qlMH.Name = "qlMH";
            this.qlMH.Size = new System.Drawing.Size(234, 56);
            this.qlMH.TabIndex = 2;
            this.qlMH.TabStop = false;
            this.qlMH.Text = "Quản lý môn học";
            this.qlMH.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnThoat.Location = new System.Drawing.Point(917, 470);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(127, 47);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.TabStop = false;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::QuanLySinhVien.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1075, 529);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.qlMH);
            this.Controls.Add(this.qlLop);
            this.Controls.Add(this.qlDiem);
            this.Controls.Add(this.qlKhoa);
            this.Controls.Add(this.qlGV);
            this.Controls.Add(this.qlSV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuTrangChu);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.MainMenuStrip = this.menuTrangChu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "TrangChu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sinh viên";
            this.menuTrangChu.ResumeLayout(false);
            this.menuTrangChu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuTrangChu;
        private System.Windows.Forms.ToolStripMenuItem menuHeThong;
        private System.Windows.Forms.ToolStripMenuItem menuThongTin;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuDangXuat;
        private System.Windows.Forms.ToolStripMenuItem menuQuanLy;
        private System.Windows.Forms.ToolStripMenuItem menuQLSV;
        private System.Windows.Forms.ToolStripMenuItem menuQLGV;
        private System.Windows.Forms.ToolStripMenuItem menuQLKhoa;
        private System.Windows.Forms.ToolStripMenuItem menuQLLop;
        private System.Windows.Forms.ToolStripMenuItem menuQLMH;
        private System.Windows.Forms.ToolStripMenuItem menuQLDiem;
        private System.Windows.Forms.ToolStripMenuItem menuTroGiup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button qlSV;
        private System.Windows.Forms.Button qlGV;
        private System.Windows.Forms.Button qlDiem;
        private System.Windows.Forms.Button qlKhoa;
        private System.Windows.Forms.Button qlLop;
        private System.Windows.Forms.Button qlMH;
        private System.Windows.Forms.Button btnThoat;
    }
}