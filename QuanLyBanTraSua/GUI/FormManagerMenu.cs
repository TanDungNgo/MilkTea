using QuanLyBanTraSua.BLL;
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
    public partial class FormManagerMenu : Form
    {
        private int _MaDoUong;
        private Bitmap bmp;
        public delegate void MyDel();
        public MyDel md { get; set; }
        public string filePath;
        public FormManagerMenu()
        {
            InitializeComponent();
            SetGUI(this._MaDoUong);
        }
        public void SetCBB()
        {
            if(cbbStatus != null)
                cbbStatus.Items.Clear();
            cbbStatus.Items.Add("Còn");
            cbbStatus.Items.Add("Hết");
        }
        public void SetGUI(int MaDoUong)
        {
            this._MaDoUong = MaDoUong;
            SetCBB();
            Drink d = BLL_QLDrinks.Instance.GetDrinkByID(_MaDoUong);
            if (d != null)
            {
                txbName.Text = d.TenDoUong.ToString();
                ptbAnh.Text = d.Anh.ToString();
                if (d.Anh != null)
                {
                    this.bmp = new Bitmap(d.Anh);
                    this.ptbAnh.SizeMode = PictureBoxSizeMode.StretchImage;
                    this.ptbAnh.Image = this.bmp;
                }
                txbPrice.Text = d.Gia.ToString();
                cbbStatus.Text = d.TinhTrang.ToString();
            }

        }
        private void DGVShow()
        {
            DataTable dt = BLL_QLDrinks.Instance.GetListMenu();
            if (lvDrink.Items != null)
            {
                lvDrink.Items.Clear();
            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                ListViewItem item = new ListViewItem(dr[0].ToString());
                ListViewItem.ListViewSubItem subitem = new ListViewItem.ListViewSubItem(item, dt.Rows[i][0].ToString());
                item.SubItems.Add(dr[1].ToString());
                item.SubItems.Add(dr[3].ToString());
                item.SubItems.Add(dr[4].ToString());
                item.SubItems.Add(subitem);
                lvDrink.Items.Add(item);
            }
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            DGVShow();
        }
        public bool Error()
        {
            bool check = false;
            if (txbName.Text == "")
            {
                lblerName1.Visible = true;
                check = true;
            }
            else
            {
                lblerName1.Visible = false;
                if (isName(txbName.Text) == false)
                {
                    lblerName2.Visible = true;
                    check = true;
                }
                else
                    lblerName2.Visible = false;
            }
            if (txbPrice.Text == "")
            {
                lblerPrice1.Visible = true;
                check = true;
            }
            else
            {
                lblerPrice1.Visible = false;
                if (isPrice(txbPrice.Text) == false)
                {
                    lblerPrice2.Visible = true;
                    check = true;
                }
                else
                    lblerPrice2.Visible = false;
            }
            if (cbbStatus.Text == "")
            {
                lblerStatus.Visible = true;
                check = true;
            }
            else
                lblerStatus.Visible = false;
            return check;
        }
        private void btnExitMenu_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (lvDrink.SelectedItems.Count == 0)
            {
                MessageBox.Show("Chưa chọn đồ uống muốn xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                List<int> LMaDoUong = new List<int>();
                foreach (ListViewItem item in lvDrink.SelectedItems)
                {
                    LMaDoUong.Add(int.Parse(item.Text));
                }
                if (MessageBox.Show("Bạn có thật sự muốn xóa ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.OK)
                {
                    BLL_QLDrinks.Instance.Delete(LMaDoUong);
                    DGVShow();
                    md();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(Error() == false)
            {
                string name = txbName.Text.Replace(" ", "");
                string fileName = name + ".jpg";
                this.filePath = "Resources\\" + fileName;
                if (System.IO.File.Exists(filePath) == false)
                    this.bmp.Save(filePath);
                Drink d = new Drink
                {
                    MaDoUong = this._MaDoUong,
                    TenDoUong = txbName.Text,
                    Anh = filePath,
                    Gia = int.Parse(txbPrice.Text),
                    TinhTrang = cbbStatus.Text,
                };
                BLL_QLDrinks.Instance.ExecuteDB(d);
                DGVShow();
                md();
            }    
        }

        private void btnPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string fileName;
                    fileName = dlg.FileName;
                    this.bmp = new Bitmap(fileName);
                    this.ptbAnh.SizeMode = PictureBoxSizeMode.StretchImage;
                    this.ptbAnh.Image = this.bmp;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lvDrink.SelectedItems.Count == 0)
            {
                MessageBox.Show("Chưa chọn đồ uống muốn edit", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SetGUI(_MaDoUong);
            }
        }

        private void lvBill_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView lsv = sender as ListView;

            if (lsv.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in lsv.SelectedItems)
                {
                    this._MaDoUong = int.Parse(item.Text);
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txbName.Text = "";
            txbPrice.Text = "";
            ptbAnh.Image = null;
        }
        internal static bool isName(string name)
        {
            bool match = Regex.IsMatch(name, "^[^0-9]+[^0-9]$");
            return match;
        }
        internal static bool isPrice(string m)
        {
            if (int.Parse(m) <= 100000 && int.Parse(m) > 10000)
                return true;
            return false;
        }

        private void btnsort_Click(object sender, EventArgs e)
        {
            DataTable dt = BLL_QLDrinks.Instance.SortListMenu();
            if (lvDrink.Items != null)
            {
                lvDrink.Items.Clear();
            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                ListViewItem item = new ListViewItem(dr[0].ToString());
                ListViewItem.ListViewSubItem subitem = new ListViewItem.ListViewSubItem(item, dt.Rows[i][0].ToString());
                item.SubItems.Add(dr[1].ToString());
                item.SubItems.Add(dr[3].ToString());
                item.SubItems.Add(dr[4].ToString());
                item.SubItems.Add(subitem);
                lvDrink.Items.Add(item);
            }
        }
    }
}
