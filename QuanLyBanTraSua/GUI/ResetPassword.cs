using QuanLyBanTraSua.BLL;
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
    public partial class ResetPassword : Form
    {
        public ResetPassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void QuenMatKhau()
        {



            string MaNV = txt_MaNV.Text;

            string SoDT = txt_SoDT.Text;
            if (MaNV == null || MaNV.Equals(""))
            {
                MessageBox.Show("Mã nhân viên không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (SoDT == null || SoDT.Equals(""))
            {
                MessageBox.Show("Số điện thoại không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (BLL_QLNV.Instance.CheckMaNVSDT(MaNV, SoDT))
                {
                    BLL_QLNV.Instance.ResetPass(txt_MaNV.Text);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thay đổi thất bại! Tài khoản hoặc email không chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            QuenMatKhau();
        }
    }
}
