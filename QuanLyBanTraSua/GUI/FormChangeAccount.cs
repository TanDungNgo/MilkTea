using QuanLyBanTraSua.BLL;
using QuanLyBanTraSua.DAL;
using QuanLyBanTraSua.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanTraSua.GUI
{
    public partial class FormChangeAccount : Form
    {
        private string _MaNV;
        public FormChangeAccount(string MaNV)
        {
            InitializeComponent();
            this._MaNV = MaNV;
            SetGUI();
        }
        public void SetGUI()
        {
            Staff staff = BLL_QLNV.Instance.GetNVByID(this._MaNV);
            txbUserName.Text = staff.SoDT;
            txbPass.Text = staff.MatKhau;
        }
        public bool Error()
        {
            bool check = false;
            if (txbNewPass.Text == "")
            {
                lblerNewPass.Visible = true;
                check = true;
            }
            else
                lblerNewPass.Visible = false;
            if (txbRePass.Text == "")
            {
                lblerRePass.Visible = true;
                check = true;
            }
            else
                lblerRePass.Visible = false;
            return check;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(Error() == false)
            {
                Staff staff = BLL_QLNV.Instance.GetNVByID(this._MaNV);
                if (txbNewPass.Text != "")
                {
                    staff.MatKhau = txbNewPass.Text;
                }
                if (txbRePass.Text != txbNewPass.Text)
                {
                    MessageBox.Show("Mật khẩu nhập lại không đúng!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                BLL_QLNV.Instance.UpdateUser(staff);
            }    
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
