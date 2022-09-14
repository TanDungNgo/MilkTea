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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanTraSua.GUI
{
    public partial class FormStaff : Form
    {
        public string PhanQuyen { get; set; }
        public string MaNV { get; set; }
        public delegate void MyDel();
        public MyDel d { get; set; }
        public FormStaff(string PhanQuyen, string MaNV)
        {
            InitializeComponent();
            this.PhanQuyen = PhanQuyen;
            this.MaNV = MaNV;
            SetGUI();
        }
        public void SetGUI(string MaNV = null)
        {

            SetCBB();
            Staff staff = BLL_QLNV.Instance.GetNVByID(MaNV);
            if (staff != null)
            {
                txtMaNV.Text = staff.MaNV;
                txtMaNV.Enabled = false;
                txtTenNV.Text = staff.TenNV;
                txtPhoneNumber.Text = staff.SoDT;
                cbbchucvu.Text = staff.ChucVu;
                txtLuong.Text = staff.Luong.ToString();
                if (staff.GioiTinh == "Nam")
                {
                    rbMale.Checked = true;
                }
                else
                    rbFeMale.Checked = true;

            }
            else
            {
                int count = BLL_QLNV.Instance.Count() + 1;
                if (count < 10)
                {
                    txtMaNV.Text = "NV00" + count.ToString();
                }
                else if (count < 100)
                {
                    txtMaNV.Text = "NV0" + count.ToString();
                }
                else
                {
                    txtMaNV.Text = "NV" + count.ToString();
                }
            }
        }
        private void SetCBB()
        {
            if (cbbchucvu != null)
                cbbchucvu.Items.Clear();
            cbbchucvu.Items.Add("Nhân Viên");
            cbbchucvu.Items.Add("Quản Lý");


        }
        public bool Error()
        {
            bool check = false;
            if (txtTenNV.Text == "")
            {
                lblername.Visible = true;
                check = true;
            }
            else
            {
                lblername.Visible = false;
                if (isName(txtTenNV.Text) == false)
                {
                    lblername2.Visible = true;
                    check = true;
                }
                else
                    lblername2.Visible = false;
            }
            if (isDigit(txtPhoneNumber.Text) == false || txtPhoneNumber.Text.Length < 10)
            {
                lblerphone.Visible = true;
                check = true;
            }
            else
                lblerphone.Visible = false;
            if (BLL_QLNV.Instance.CheckPhone(txtMaNV.Text,txtPhoneNumber.Text) == false)
            {
                erphone.Visible = true;
                check = true;

            }
            else
                erphone.Visible = false;
            return check;
        }
        private void DGVShow()
        {
            if (lvStaff.Items != null)
            {
                lvStaff.Items.Clear();
            }
            foreach (Staff s in BLL_QLNV.Instance.GetListStaff())
            {
                ListViewItem item = new ListViewItem(s.MaNV);
                item.SubItems.Add(s.TenNV);
                item.SubItems.Add(s.GioiTinh);
                item.SubItems.Add(s.SoDT);
                item.SubItems.Add(s.ChucVu);
                item.SubItems.Add(s.Luong.ToString());
                lvStaff.Items.Add(item);
            }    
        }
        private void btnHienThi_Click(object sender, EventArgs e)
        {
            DGVShow();
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            if (Error() == false)
            {
                Staff s = new Staff
                {
                    MaNV = txtMaNV.Text,
                    TenNV = txtTenNV.Text,
                    GioiTinh = rbMale.Checked.ToString(),
                    Luong = int.Parse(txtLuong.Text),
                    SoDT = txtPhoneNumber.Text,
                    ChucVu = cbbchucvu.Text,
                };
                BLL_QLNV.Instance.ExecuteDB(s);
                DGVShow();
            }
        }
        private void btnDelStaff_Click(object sender, EventArgs e)
        {
            if (PhanQuyen == "Quản Lý")
            {
                if (lvStaff.SelectedItems.Count > 0)
                {
                    List<string> LMaNV = new List<string>();
                    foreach (ListViewItem item in lvStaff.SelectedItems)
                    {
                        string MaNV = item.Text;
                        if (MaNV == this.MaNV)
                        {
                            MessageBox.Show("Không thể xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        LMaNV.Add(MaNV);
                    }
                    if (MessageBox.Show("Bạn có thật sự muốn xóa ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.OK)
                    {
                        BLL_QLNV.Instance.Delete(LMaNV);
                        SetGUI();
                        Reset();
                        DGVShow();
                    }
                }
                else
                    MessageBox.Show("Chưa chọn nhân viên muốn xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Bạn không có chức năng này !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnEditStaff_Click(object sender, EventArgs e)
        {
            if (PhanQuyen == "Quản Lý")
            {
                if (Error() == false)
                {
                    Staff s = new Staff
                    {
                        MaNV = txtMaNV.Text,
                        TenNV = txtTenNV.Text,
                        GioiTinh = rbMale.Checked.ToString(),
                        Luong = int.Parse(txtLuong.Text),
                        SoDT = txtPhoneNumber.Text,
                        ChucVu = cbbchucvu.Text,
                    };
                    BLL_QLNV.Instance.ExecuteDB(s);
                    DGVShow();
                }
            }
            else
            {
                MessageBox.Show("Bạn không có chức năng này !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        internal static bool isName(string name)
        {
            bool match = Regex.IsMatch(name, "^[^0-9]+[^0-9]$");
            return match;
        }
        internal static bool isDigit(string v)
        {
            var isNumeric = !string.IsNullOrEmpty(v) && v.All(Char.IsDigit);
            return isNumeric;
        }
        public void Reset()
        {
            int count = BLL_QLNV.Instance.Count() + 1;
            if (count < 10)
            {
                txtMaNV.Text = "NV00" + count.ToString();
            }
            else if (count < 100)
            {
                txtMaNV.Text = "NV0" + count.ToString();
            }
            else
            {
                txtMaNV.Text = "NV" + count.ToString();
            }
            txtTenNV.Text = "";
            txtPhoneNumber.Text = "";
            txtLuong.Text = "";
            cbbchucvu.Text = "";
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void lvStaff_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvStaff.SelectedItems.Count == 1)
            {
                foreach (ListViewItem item in lvStaff.SelectedItems)
                {
                    string MaNV = item.Text;
                    SetGUI(MaNV);
                }
            }
        }
    }
}
