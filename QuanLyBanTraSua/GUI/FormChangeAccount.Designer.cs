namespace QuanLyBanTraSua.GUI
{
    partial class FormChangeAccount
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
            this.label4 = new System.Windows.Forms.Label();
            this.txbRePass = new System.Windows.Forms.TextBox();
            this.txbNewPass = new System.Windows.Forms.TextBox();
            this.txbPass = new System.Windows.Forms.TextBox();
            this.txbUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblerRePass = new System.Windows.Forms.Label();
            this.lblerNewPass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label4.Location = new System.Drawing.Point(40, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 22);
            this.label4.TabIndex = 45;
            this.label4.Text = "Nhập lại mật khẩu:";
            // 
            // txbRePass
            // 
            this.txbRePass.Location = new System.Drawing.Point(213, 190);
            this.txbRePass.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.txbRePass.Name = "txbRePass";
            this.txbRePass.PasswordChar = '*';
            this.txbRePass.Size = new System.Drawing.Size(274, 22);
            this.txbRePass.TabIndex = 44;
            // 
            // txbNewPass
            // 
            this.txbNewPass.Location = new System.Drawing.Point(213, 142);
            this.txbNewPass.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.txbNewPass.Name = "txbNewPass";
            this.txbNewPass.PasswordChar = '*';
            this.txbNewPass.Size = new System.Drawing.Size(274, 22);
            this.txbNewPass.TabIndex = 43;
            // 
            // txbPass
            // 
            this.txbPass.Enabled = false;
            this.txbPass.Location = new System.Drawing.Point(213, 100);
            this.txbPass.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.txbPass.Name = "txbPass";
            this.txbPass.PasswordChar = '*';
            this.txbPass.Size = new System.Drawing.Size(274, 22);
            this.txbPass.TabIndex = 42;
            // 
            // txbUserName
            // 
            this.txbUserName.BackColor = System.Drawing.SystemColors.Window;
            this.txbUserName.Enabled = false;
            this.txbUserName.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txbUserName.Location = new System.Drawing.Point(213, 58);
            this.txbUserName.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.ReadOnly = true;
            this.txbUserName.Size = new System.Drawing.Size(274, 22);
            this.txbUserName.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label3.Location = new System.Drawing.Point(40, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 22);
            this.label3.TabIndex = 40;
            this.label3.Text = "Mật khẩu mới:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label2.Location = new System.Drawing.Point(40, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 22);
            this.label2.TabIndex = 39;
            this.label2.Text = "Mật khẩu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label1.Location = new System.Drawing.Point(40, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 22);
            this.label1.TabIndex = 37;
            this.label1.Text = "Tài khoản:";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.Control;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnExit.Location = new System.Drawing.Point(323, 265);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(120, 45);
            this.btnExit.TabIndex = 46;
            this.btnExit.Text = "Hủy";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSave.Location = new System.Drawing.Point(76, 265);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 45);
            this.btnSave.TabIndex = 38;
            this.btnSave.Text = "Lưu";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblerRePass
            // 
            this.lblerRePass.AutoSize = true;
            this.lblerRePass.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerRePass.ForeColor = System.Drawing.Color.Red;
            this.lblerRePass.Location = new System.Drawing.Point(210, 215);
            this.lblerRePass.Name = "lblerRePass";
            this.lblerRePass.Size = new System.Drawing.Size(115, 17);
            this.lblerRePass.TabIndex = 47;
            this.lblerRePass.Text = "Nhập lại mật khẩu";
            this.lblerRePass.Visible = false;
            // 
            // lblerNewPass
            // 
            this.lblerNewPass.AutoSize = true;
            this.lblerNewPass.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerNewPass.ForeColor = System.Drawing.Color.Red;
            this.lblerNewPass.Location = new System.Drawing.Point(210, 167);
            this.lblerNewPass.Name = "lblerNewPass";
            this.lblerNewPass.Size = new System.Drawing.Size(124, 17);
            this.lblerNewPass.TabIndex = 48;
            this.lblerNewPass.Text = "Nhập mật khẩu mới";
            this.lblerNewPass.Visible = false;
            // 
            // FormChangeAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(567, 376);
            this.Controls.Add(this.lblerNewPass);
            this.Controls.Add(this.lblerRePass);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbRePass);
            this.Controls.Add(this.txbNewPass);
            this.Controls.Add(this.txbPass);
            this.Controls.Add(this.txbUserName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Name = "FormChangeAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormChangeAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbRePass;
        private System.Windows.Forms.TextBox txbNewPass;
        private System.Windows.Forms.TextBox txbPass;
        private System.Windows.Forms.TextBox txbUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblerRePass;
        private System.Windows.Forms.Label lblerNewPass;
    }
}