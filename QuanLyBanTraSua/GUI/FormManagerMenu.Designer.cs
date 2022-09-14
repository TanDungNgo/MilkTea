using System.Windows.Forms;

namespace QuanLyBanTraSua.GUI
{
    partial class FormManagerMenu
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
            this.btnExitMenu = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblerPrice2 = new System.Windows.Forms.Label();
            this.lblerName2 = new System.Windows.Forms.Label();
            this.lblerPrice1 = new System.Windows.Forms.Label();
            this.lblerStatus = new System.Windows.Forms.Label();
            this.lblerName1 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.cbbStatus = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbPrice = new System.Windows.Forms.TextBox();
            this.btnPicture = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.ptbAnh = new System.Windows.Forms.PictureBox();
            this.txbName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lvDrink = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnsort = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExitMenu
            // 
            this.btnExitMenu.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnExitMenu.Location = new System.Drawing.Point(629, 648);
            this.btnExitMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExitMenu.Name = "btnExitMenu";
            this.btnExitMenu.Size = new System.Drawing.Size(146, 50);
            this.btnExitMenu.TabIndex = 43;
            this.btnExitMenu.Text = "Thoát";
            this.btnExitMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExitMenu.UseVisualStyleBackColor = true;
            this.btnExitMenu.Click += new System.EventHandler(this.btnExitMenu_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnEdit.Location = new System.Drawing.Point(167, 648);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(146, 50);
            this.btnEdit.TabIndex = 41;
            this.btnEdit.Text = "Chỉnh sửa";
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnDel.Location = new System.Drawing.Point(321, 648);
            this.btnDel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(146, 50);
            this.btnDel.TabIndex = 40;
            this.btnDel.Text = "Xóa";
            this.btnDel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnShow.Location = new System.Drawing.Point(13, 648);
            this.btnShow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(146, 50);
            this.btnShow.TabIndex = 42;
            this.btnShow.Text = "Hiển thị";
            this.btnShow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblerPrice2);
            this.panel1.Controls.Add(this.lblerName2);
            this.panel1.Controls.Add(this.lblerPrice1);
            this.panel1.Controls.Add(this.lblerStatus);
            this.panel1.Controls.Add(this.lblerName1);
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.cbbStatus);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txbPrice);
            this.panel1.Controls.Add(this.btnPicture);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.ptbAnh);
            this.panel1.Controls.Add(this.txbName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(27, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(747, 298);
            this.panel1.TabIndex = 38;
            // 
            // lblerPrice2
            // 
            this.lblerPrice2.AutoSize = true;
            this.lblerPrice2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerPrice2.ForeColor = System.Drawing.Color.Red;
            this.lblerPrice2.Location = new System.Drawing.Point(334, 144);
            this.lblerPrice2.Name = "lblerPrice2";
            this.lblerPrice2.Size = new System.Drawing.Size(165, 20);
            this.lblerPrice2.TabIndex = 44;
            this.lblerPrice2.Text = "Đơn giá không hợp lệ";
            this.lblerPrice2.Visible = false;
            // 
            // lblerName2
            // 
            this.lblerName2.AutoSize = true;
            this.lblerName2.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.lblerName2.ForeColor = System.Drawing.Color.Red;
            this.lblerName2.Location = new System.Drawing.Point(361, 84);
            this.lblerName2.Name = "lblerName2";
            this.lblerName2.Size = new System.Drawing.Size(137, 20);
            this.lblerName2.TabIndex = 43;
            this.lblerName2.Text = "Tên không hợp lệ";
            this.lblerName2.Visible = false;
            // 
            // lblerPrice1
            // 
            this.lblerPrice1.AutoSize = true;
            this.lblerPrice1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerPrice1.ForeColor = System.Drawing.Color.Red;
            this.lblerPrice1.Location = new System.Drawing.Point(187, 144);
            this.lblerPrice1.Name = "lblerPrice1";
            this.lblerPrice1.Size = new System.Drawing.Size(106, 20);
            this.lblerPrice1.TabIndex = 41;
            this.lblerPrice1.Text = "Nhập đơn giá";
            this.lblerPrice1.Visible = false;
            // 
            // lblerStatus
            // 
            this.lblerStatus.AutoSize = true;
            this.lblerStatus.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerStatus.ForeColor = System.Drawing.Color.Red;
            this.lblerStatus.Location = new System.Drawing.Point(187, 208);
            this.lblerStatus.Name = "lblerStatus";
            this.lblerStatus.Size = new System.Drawing.Size(122, 20);
            this.lblerStatus.TabIndex = 40;
            this.lblerStatus.Text = "Nhập tình trạng";
            this.lblerStatus.Visible = false;
            // 
            // lblerName1
            // 
            this.lblerName1.AutoSize = true;
            this.lblerName1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerName1.ForeColor = System.Drawing.Color.Red;
            this.lblerName1.Location = new System.Drawing.Point(187, 84);
            this.lblerName1.Name = "lblerName1";
            this.lblerName1.Size = new System.Drawing.Size(112, 20);
            this.lblerName1.TabIndex = 39;
            this.lblerName1.Text = "Nhập tên món";
            this.lblerName1.Visible = false;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnReset.Location = new System.Drawing.Point(190, 240);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(135, 49);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Đặt lại";
            this.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // cbbStatus
            // 
            this.cbbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbStatus.FormattingEnabled = true;
            this.cbbStatus.Location = new System.Drawing.Point(190, 174);
            this.cbbStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbStatus.Name = "cbbStatus";
            this.cbbStatus.Size = new System.Drawing.Size(152, 28);
            this.cbbStatus.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label5.Location = new System.Drawing.Point(63, 175);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 27);
            this.label5.TabIndex = 38;
            this.label5.Text = "Tình trạng:";
            // 
            // txbPrice
            // 
            this.txbPrice.Location = new System.Drawing.Point(190, 112);
            this.txbPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txbPrice.Name = "txbPrice";
            this.txbPrice.Size = new System.Drawing.Size(294, 26);
            this.txbPrice.TabIndex = 4;
            // 
            // btnPicture
            // 
            this.btnPicture.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnPicture.Location = new System.Drawing.Point(562, 240);
            this.btnPicture.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPicture.Name = "btnPicture";
            this.btnPicture.Size = new System.Drawing.Size(152, 49);
            this.btnPicture.TabIndex = 6;
            this.btnPicture.Text = "Chọn ảnh";
            this.btnPicture.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPicture.UseVisualStyleBackColor = true;
            this.btnPicture.Click += new System.EventHandler(this.btnPicture_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnSave.Location = new System.Drawing.Point(350, 240);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(135, 49);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Lưu";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ptbAnh
            // 
            this.ptbAnh.BackColor = System.Drawing.SystemColors.Control;
            this.ptbAnh.Location = new System.Drawing.Point(562, 26);
            this.ptbAnh.Margin = new System.Windows.Forms.Padding(4);
            this.ptbAnh.Name = "ptbAnh";
            this.ptbAnh.Size = new System.Drawing.Size(152, 178);
            this.ptbAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbAnh.TabIndex = 7;
            this.ptbAnh.TabStop = false;
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(190, 52);
            this.txbName.Margin = new System.Windows.Forms.Padding(4);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(294, 26);
            this.txbName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label3.Location = new System.Drawing.Point(63, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Đơn giá:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label2.Location = new System.Drawing.Point(63, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên món:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thêm món";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lvDrink
            // 
            this.lvDrink.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvDrink.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lvDrink.FullRowSelect = true;
            this.lvDrink.GridLines = true;
            this.lvDrink.HideSelection = false;
            this.lvDrink.Location = new System.Drawing.Point(27, 319);
            this.lvDrink.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.lvDrink.Name = "lvDrink";
            this.lvDrink.Size = new System.Drawing.Size(746, 311);
            this.lvDrink.TabIndex = 44;
            this.lvDrink.UseCompatibleStateImageBehavior = false;
            this.lvDrink.View = System.Windows.Forms.View.Details;
            this.lvDrink.SelectedIndexChanged += new System.EventHandler(this.lvBill_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "MaDoUong";
            this.columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "TenDoUong";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 190;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Gia";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "TinhTrang";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 100;
            // 
            // btnsort
            // 
            this.btnsort.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnsort.Location = new System.Drawing.Point(475, 648);
            this.btnsort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnsort.Name = "btnsort";
            this.btnsort.Size = new System.Drawing.Size(146, 50);
            this.btnsort.TabIndex = 45;
            this.btnsort.Text = "Sắp xếp";
            this.btnsort.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsort.UseVisualStyleBackColor = true;
            this.btnsort.Click += new System.EventHandler(this.btnsort_Click);
            // 
            // FormManagerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(803, 860);
            this.Controls.Add(this.btnsort);
            this.Controls.Add(this.lvDrink);
            this.Controls.Add(this.btnExitMenu);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormManagerMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager Menu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAnh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnExitMenu;
        private Button btnEdit;
        private Button btnDel;
        private Button btnShow;
        private Panel panel1;
        private Label label5;
        private TextBox txbPrice;
        private Button btnPicture;
        private Button btnSave;
        private PictureBox ptbAnh;
        private TextBox txbName;
        private Label label3;
        private Label label2;
        private Label label1;
        private ListView lvDrink;
        public ColumnHeader columnHeader1;
        public ColumnHeader columnHeader2;
        public ColumnHeader columnHeader3;
        public ColumnHeader columnHeader4;
        private ComboBox cbbStatus;
        private Button btnReset;
        private Label lblerPrice1;
        private Label lblerStatus;
        private Label lblerName1;
        private Label lblerName2;
        private Label lblerPrice2;
        private Button btnsort;
    }
}