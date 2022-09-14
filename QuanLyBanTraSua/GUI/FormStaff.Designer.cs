using System.Windows.Forms;

namespace QuanLyBanTraSua.GUI
{
    partial class FormStaff
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
            this.cbbchucvu = new System.Windows.Forms.ComboBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblSoDT = new System.Windows.Forms.Label();
            this.Gender = new System.Windows.Forms.GroupBox();
            this.rbFeMale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDelStaff = new System.Windows.Forms.Button();
            this.btnEditStaff = new System.Windows.Forms.Button();
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.lblLuong = new System.Windows.Forms.Label();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.lblChucVu = new System.Windows.Forms.Label();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.lblername = new System.Windows.Forms.Label();
            this.lblername2 = new System.Windows.Forms.Label();
            this.lblerphone = new System.Windows.Forms.Label();
            this.lblerchucvu = new System.Windows.Forms.Label();
            this.erphone = new System.Windows.Forms.Label();
            this.lvStaff = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Gender.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbbchucvu
            // 
            this.cbbchucvu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbchucvu.FormattingEnabled = true;
            this.cbbchucvu.Location = new System.Drawing.Point(548, 237);
            this.cbbchucvu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbbchucvu.Name = "cbbchucvu";
            this.cbbchucvu.Size = new System.Drawing.Size(210, 28);
            this.cbbchucvu.TabIndex = 33;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(233, 92);
            this.txtTenNV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(299, 26);
            this.txtTenNV.TabIndex = 26;
            // 
            // lblTenNV
            // 
            this.lblTenNV.AutoSize = true;
            this.lblTenNV.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblTenNV.Location = new System.Drawing.Point(34, 92);
            this.lblTenNV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(198, 27);
            this.lblTenNV.TabIndex = 23;
            this.lblTenNV.Text = "Họ Tên Nhân Viên:";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(233, 163);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(299, 26);
            this.txtPhoneNumber.TabIndex = 27;
            // 
            // lblSoDT
            // 
            this.lblSoDT.AutoSize = true;
            this.lblSoDT.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblSoDT.Location = new System.Drawing.Point(36, 164);
            this.lblSoDT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoDT.Name = "lblSoDT";
            this.lblSoDT.Size = new System.Drawing.Size(155, 27);
            this.lblSoDT.TabIndex = 25;
            this.lblSoDT.Text = "Số Điện Thoại:";
            // 
            // Gender
            // 
            this.Gender.Controls.Add(this.rbFeMale);
            this.Gender.Controls.Add(this.rbMale);
            this.Gender.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.Gender.Location = new System.Drawing.Point(584, 44);
            this.Gender.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Gender.Name = "Gender";
            this.Gender.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Gender.Size = new System.Drawing.Size(174, 116);
            this.Gender.TabIndex = 28;
            this.Gender.TabStop = false;
            this.Gender.Text = "Giới Tính";
            // 
            // rbFeMale
            // 
            this.rbFeMale.AutoSize = true;
            this.rbFeMale.Location = new System.Drawing.Point(12, 64);
            this.rbFeMale.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbFeMale.Name = "rbFeMale";
            this.rbFeMale.Size = new System.Drawing.Size(65, 29);
            this.rbFeMale.TabIndex = 1;
            this.rbFeMale.TabStop = true;
            this.rbFeMale.Text = "Nữ";
            this.rbFeMale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(12, 29);
            this.rbMale.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(79, 29);
            this.rbMale.TabIndex = 0;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Nam";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnReset.Location = new System.Drawing.Point(613, 640);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(165, 51);
            this.btnReset.TabIndex = 31;
            this.btnReset.Text = "Đặt Lại";
            this.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnDelStaff
            // 
            this.btnDelStaff.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnDelStaff.Location = new System.Drawing.Point(469, 640);
            this.btnDelStaff.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelStaff.Name = "btnDelStaff";
            this.btnDelStaff.Size = new System.Drawing.Size(135, 51);
            this.btnDelStaff.TabIndex = 30;
            this.btnDelStaff.Text = "Xóa";
            this.btnDelStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelStaff.UseVisualStyleBackColor = true;
            this.btnDelStaff.Click += new System.EventHandler(this.btnDelStaff_Click);
            // 
            // btnEditStaff
            // 
            this.btnEditStaff.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnEditStaff.Location = new System.Drawing.Point(325, 640);
            this.btnEditStaff.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditStaff.Name = "btnEditStaff";
            this.btnEditStaff.Size = new System.Drawing.Size(135, 51);
            this.btnEditStaff.TabIndex = 29;
            this.btnEditStaff.Text = "Sửa";
            this.btnEditStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditStaff.UseVisualStyleBackColor = true;
            this.btnEditStaff.Click += new System.EventHandler(this.btnEditStaff_Click);
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnAddStaff.Location = new System.Drawing.Point(181, 640);
            this.btnAddStaff.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(135, 51);
            this.btnAddStaff.TabIndex = 24;
            this.btnAddStaff.Text = "Thêm";
            this.btnAddStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddStaff.UseVisualStyleBackColor = true;
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // lblLuong
            // 
            this.lblLuong.AutoSize = true;
            this.lblLuong.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblLuong.Location = new System.Drawing.Point(109, 238);
            this.lblLuong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLuong.Name = "lblLuong";
            this.lblLuong.Size = new System.Drawing.Size(82, 27);
            this.lblLuong.TabIndex = 34;
            this.lblLuong.Text = "Lương:";
            // 
            // txtLuong
            // 
            this.txtLuong.Location = new System.Drawing.Point(236, 239);
            this.txtLuong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(181, 26);
            this.txtLuong.TabIndex = 35;
            // 
            // lblChucVu
            // 
            this.lblChucVu.AutoSize = true;
            this.lblChucVu.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblChucVu.Location = new System.Drawing.Point(443, 242);
            this.lblChucVu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(104, 27);
            this.lblChucVu.TabIndex = 36;
            this.lblChucVu.Text = "Chức Vụ:";
            // 
            // btnHienThi
            // 
            this.btnHienThi.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnHienThi.Location = new System.Drawing.Point(35, 640);
            this.btnHienThi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(135, 51);
            this.btnHienThi.TabIndex = 37;
            this.btnHienThi.Text = "Hiển Thị";
            this.btnHienThi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHienThi.UseVisualStyleBackColor = true;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblMaNV.Location = new System.Drawing.Point(34, 44);
            this.lblMaNV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(158, 27);
            this.lblMaNV.TabIndex = 38;
            this.lblMaNV.Text = "Mã Nhân Viên:";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Enabled = false;
            this.txtMaNV.Location = new System.Drawing.Point(233, 44);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(181, 26);
            this.txtMaNV.TabIndex = 39;
            // 
            // lblername
            // 
            this.lblername.AutoSize = true;
            this.lblername.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.lblername.ForeColor = System.Drawing.Color.Red;
            this.lblername.Location = new System.Drawing.Point(230, 124);
            this.lblername.Name = "lblername";
            this.lblername.Size = new System.Drawing.Size(105, 20);
            this.lblername.TabIndex = 41;
            this.lblername.Text = "Nhập tên NV";
            this.lblername.Visible = false;
            // 
            // lblername2
            // 
            this.lblername2.AutoSize = true;
            this.lblername2.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.lblername2.ForeColor = System.Drawing.Color.Red;
            this.lblername2.Location = new System.Drawing.Point(395, 124);
            this.lblername2.Name = "lblername2";
            this.lblername2.Size = new System.Drawing.Size(137, 20);
            this.lblername2.TabIndex = 42;
            this.lblername2.Text = "Tên không hợp lệ";
            this.lblername2.Visible = false;
            // 
            // lblerphone
            // 
            this.lblerphone.AutoSize = true;
            this.lblerphone.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.lblerphone.ForeColor = System.Drawing.Color.Red;
            this.lblerphone.Location = new System.Drawing.Point(232, 194);
            this.lblerphone.Name = "lblerphone";
            this.lblerphone.Size = new System.Drawing.Size(202, 20);
            this.lblerphone.TabIndex = 43;
            this.lblerphone.Text = "Số điện thoại không hợp lệ";
            this.lblerphone.Visible = false;
            // 
            // lblerchucvu
            // 
            this.lblerchucvu.AutoSize = true;
            this.lblerchucvu.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.lblerchucvu.ForeColor = System.Drawing.Color.Red;
            this.lblerchucvu.Location = new System.Drawing.Point(548, 274);
            this.lblerchucvu.Name = "lblerchucvu";
            this.lblerchucvu.Size = new System.Drawing.Size(111, 20);
            this.lblerchucvu.TabIndex = 44;
            this.lblerchucvu.Text = "Nhập chức vụ";
            this.lblerchucvu.Visible = false;
            // 
            // erphone
            // 
            this.erphone.AutoSize = true;
            this.erphone.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.erphone.ForeColor = System.Drawing.Color.Red;
            this.erphone.Location = new System.Drawing.Point(462, 194);
            this.erphone.Name = "erphone";
            this.erphone.Size = new System.Drawing.Size(175, 20);
            this.erphone.TabIndex = 45;
            this.erphone.Text = "Số điện thoại đã tồn tại";
            this.erphone.Visible = false;
            // 
            // lvStaff
            // 
            this.lvStaff.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvStaff.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lvStaff.FullRowSelect = true;
            this.lvStaff.GridLines = true;
            this.lvStaff.HideSelection = false;
            this.lvStaff.Location = new System.Drawing.Point(13, 308);
            this.lvStaff.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.lvStaff.Name = "lvStaff";
            this.lvStaff.Size = new System.Drawing.Size(784, 300);
            this.lvStaff.TabIndex = 46;
            this.lvStaff.UseCompatibleStateImageBehavior = false;
            this.lvStaff.View = System.Windows.Forms.View.Details;
            this.lvStaff.SelectedIndexChanged += new System.EventHandler(this.lvStaff_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "MaNV";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "HoTen";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "GioiTinh";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 65;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "SDT";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "ChucVu";
            this.columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Luong";
            this.columnHeader6.Width = 75;
            // 
            // FormStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(810, 764);
            this.Controls.Add(this.lvStaff);
            this.Controls.Add(this.erphone);
            this.Controls.Add(this.lblerchucvu);
            this.Controls.Add(this.lblerphone);
            this.Controls.Add(this.lblername2);
            this.Controls.Add(this.lblername);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.lblMaNV);
            this.Controls.Add(this.btnHienThi);
            this.Controls.Add(this.lblChucVu);
            this.Controls.Add(this.txtLuong);
            this.Controls.Add(this.lblLuong);
            this.Controls.Add(this.cbbchucvu);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtTenNV);
            this.Controls.Add(this.btnDelStaff);
            this.Controls.Add(this.lblTenNV);
            this.Controls.Add(this.btnEditStaff);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.btnAddStaff);
            this.Controls.Add(this.lblSoDT);
            this.Controls.Add(this.Gender);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhân Viên";
            this.Gender.ResumeLayout(false);
            this.Gender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbchucvu;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Button btnDelStaff;
        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.Button btnEditStaff;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Button btnAddStaff;
        private System.Windows.Forms.Label lblSoDT;
        private System.Windows.Forms.GroupBox Gender;
        private System.Windows.Forms.RadioButton rbFeMale;
        private System.Windows.Forms.RadioButton rbMale;
        private Label lblLuong;
        private TextBox txtLuong;
        private Label lblChucVu;
        private Button btnHienThi;
        private Label lblMaNV;
        private TextBox txtMaNV;
        private Label lblername;
        private Label lblername2;
        private Label lblerphone;
        private Label lblerchucvu;
        private Label erphone;
        private ListView lvStaff;
        public ColumnHeader columnHeader1;
        public ColumnHeader columnHeader2;
        public ColumnHeader columnHeader3;
        public ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
    }
}