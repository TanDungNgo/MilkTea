using QuanLyBanTraSua.BLL;
using QuanLyBanTraSua.DAL;
using QuanLyBanTraSua.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanTraSua.GUI
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        public void Login()
        {
            string UserName = txbUser.Text;
            string Pass = txbPass.Text;
            if (UserName == null || UserName.Equals(""))
            {
                MessageBox.Show("Tài khoản không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (Pass == null || Pass.Equals(""))
            {
                MessageBox.Show("Mật khẩu không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (BLL_QLNV.Instance.Login(UserName, Pass))
                {
                    Staff s = BLL_QLNV.Instance.GetUserByUsername(txbUser.Text);
                    FormMain frmMain = new FormMain(s);
                    this.Hide();
                    frmMain.ShowDialog();
                    txbPass.Text = "";
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void check_CheckedChanged(object sender, EventArgs e)
        {
            if (checkpass.Checked == true && txbPass.Text != "Nhập Password")
            {
                txbPass.UseSystemPasswordChar = false;
            }
            if (checkpass.Checked == false && txbPass.Text != "Nhập Password")
            {
                txbPass.UseSystemPasswordChar = true;
            }
        }

        private void txbUser_Enter(object sender, EventArgs e)
        {
            if (txbUser.Text == "Nhập Username")
            {
                txbUser.Text = null;
            }
            txbUser.ForeColor = Color.Black;
        }

        private void txbUser_Leave(object sender, EventArgs e)
        {
            if (txbUser.Text == "")
            {
                txbUser.Text = "Nhập Username";
                txbUser.ForeColor = Color.DarkGray;
            }
        }

        private void txbPass_Leave(object sender, EventArgs e)
        {
            if (txbPass.Text == "")
            {
                txbPass.Text = "Nhập Password";
                txbPass.UseSystemPasswordChar = false;
                txbPass.ForeColor = Color.DarkGray;
            }
        }

        private void txbPass_Enter(object sender, EventArgs e)
        {
            if (txbPass.Text == "Nhập Password")
            {
                txbPass.Text = null;
                txbPass.UseSystemPasswordChar = true;
            }
            txbPass.ForeColor = Color.Black;
        }

        private void txbPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Login();
            }
        }

        private void QuenMatKhau_Click(object sender, EventArgs e)
        {
            ResetPassword f = new ResetPassword();
            this.Hide();
            f.ShowDialog();
            this.Show();
            txbPass.Text = "";
        }
    }
}
