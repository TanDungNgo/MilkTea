using QuanLyBanTraSua.BLL;
using QuanLyBanTraSua.DAL;
using QuanLyBanTraSua.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanTraSua.GUI
{
    public partial class FormMain : Form
    {
        private Staff s;
        private Bitmap bmp;
        public FormMain(Staff s)
        {
            InitializeComponent();
            this.s = s;
            SetGUI();
        }
        public void SetCBB()
        {
            if (cbbBill != null)
                cbbBill.Items.Clear();
            cbbBill.Items.AddRange(BLL_QLBill.Instance.GetListMaHD().Distinct().ToArray());
            int temp = 0;
            txtTotalPrice.Text = temp.ToString();
            txtTotalPayment.Text = temp.ToString();
            if (cbbSale != null)
                cbbSale.Items.Clear();
            cbbSale.Items.Add("Giảm 50%");
            cbbSale.Items.Add("Giảm 30%");
            cbbSale.Items.Add("None");
        }
        public void SetGUI()
        {
            SetCBB();
            cbbSale.Text = "None";
            flpMenu.Controls.Clear();
            txtStaff.Text = s.TenNV;
            foreach (Drink item in DAL_QLDrinks.Instance.GetAllDrink())
            {
                PictureBox ptb = new PictureBox { Width = 140, Height = 120 };
                if (item.Anh != null)
                {
                    this.bmp = new Bitmap(item.Anh);
                    ptb.SizeMode = PictureBoxSizeMode.StretchImage;
                    ptb.Image = this.bmp;
                }
                Button btn = new Button { Width = 120, Height = 60 };
                btn.Text = item.TenDoUong + Environment.NewLine + item.Gia + "đ";
                switch (item.TinhTrang)
                {
                    case "Còn":
                        btn.BackColor = Color.White;
                        break;
                    default:
                        btn.BackColor = Color.Red;
                        break;
                }    
                btn.Click += btn_Click;
                btn.Tag = item;
                flpMenu.Controls.Add(ptb);
                flpMenu.Controls.Add(btn);
            }
        }
        public int TotalPrice()
        {
            int total = 0;
            for (int i = 0; i < lvBill.Items.Count; i++)
            {
                total += int.Parse(lvBill.Items[i].SubItems[5].Text);
            }
            return total;
        }
        public int TotalPayment()
        {
            int totalpayment = 0;
            if (cbbSale.Text == "Giảm 30%")
                totalpayment = TotalPrice() * 70 / 100;
            else if (cbbSale.Text == "Giảm 50%")
                totalpayment = TotalPrice() * 50 / 100;
            else
                totalpayment = TotalPrice();
            return totalpayment;
        }
        public void ShowLV(Drink item)
        {
            for (int i = 0; i < lvBill.Items.Count; i++)
            {
                if (lvBill.Items[i].SubItems[2].Text == item.TenDoUong)
                {
                    int sl = int.Parse(lvBill.Items[i].SubItems[3].Text) + 1;
                    lvBill.Items[i].SubItems[3].Text = sl.ToString();
                    lvBill.Items[i].SubItems[5].Text = (sl * item.Gia).ToString();
                    txtTotalPrice.Text = TotalPrice().ToString();
                    txtTotalPayment.Text = TotalPayment().ToString();
                    return;
                }
            }
            ListViewItem lvitem = new ListViewItem();
            lvitem.Text = (lvBill.Items.Count + 1).ToString();
            lvitem.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = item.MaDoUong.ToString() });
            lvitem.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = item.TenDoUong });
            int soluong = 1;
            lvitem.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = soluong.ToString() });
            lvitem.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = item.Gia.ToString() });
            lvitem.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = (soluong * item.Gia).ToString() });
            lvBill.Items.Add(lvitem);
            txtTotalPrice.Text = TotalPrice().ToString();
            txtTotalPayment.Text = TotalPayment().ToString();
        }
        private void btn_Click(object sender, EventArgs e)
        {
            Drink item = (sender as Button).Tag as Drink;
            if (item.TinhTrang == "Còn")
                ShowLV(item);
            else
                MessageBox.Show("Đã hết !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            if (pnlList.Visible == false)
            {
                pnlList.Visible = true;
                pnlList.BringToFront();
            }
            else
            {
                pnlList.Visible = false;
            }
        }
        private void btnStaff_Click(object sender, EventArgs e)
        {
            FormStaff f = new FormStaff(s.ChucVu, s.MaNV);
            f.ShowDialog();
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            FormStatistic f = new FormStatistic();
            f.ShowDialog();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            FormManagerMenu f = new FormManagerMenu();
            f.md += new FormManagerMenu.MyDel(SetGUI);
            f.ShowDialog();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            FormChangeAccount f = new FormChangeAccount(s.MaNV);
            f.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn đăng suất ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.OK)
                this.Close();
        }

        private void cbbSale_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTotalPayment.Text = TotalPayment().ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbbBill != null)
                cbbBill.Items.Clear();
            cbbBill.Items.AddRange(BLL_QLBill.Instance.GetListMaHD().Distinct().ToArray());
            lvBill.Items.Clear();
            txtTotalPrice.Text = 0.ToString();
            txtTotalPayment.Text = 0.ToString();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            lvBill.Items.Clear();
            foreach (Bill i in DAL_QLBill.Instance.GetBillByMaHD(cbbBill.Text))
            {
                ListViewItem lvitem = new ListViewItem();
                lvitem.Text = (lvBill.Items.Count + 1).ToString();
                lvitem.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = i.MaDoUong.ToString() });
                lvitem.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = i.TenDoUong });
                lvitem.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = i.SoLuong.ToString() });
                lvitem.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = i.Gia.ToString() });
                lvitem.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = (i.SoLuong * i.Gia).ToString() });
                lvBill.Items.Add(lvitem);
            }
            txtTotalPrice.Text = TotalPrice().ToString();
            cbbSale.Text = BLL_QLBill.Instance.GetMaGiamGia(cbbBill.Text);
            txtTotalPayment.Text = TotalPayment().ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lvBill.Items.Count; i++)
            {
                if (lvBill.Items[i].Selected)
                {
                    lvBill.Items.RemoveAt(i);
                    i--;
                }
            }
            txtTotalPrice.Text = TotalPrice().ToString();
            txtTotalPayment.Text = TotalPayment().ToString();
        }

        private void btnThanhtoan_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            int n = BLL_QLBill.Instance.Count();
            string MaHD = "HD" + now.Day.ToString() + "/" + now.Month.ToString() + "/" + now.Year.ToString() + "." + (n + 1).ToString();
            string sale = cbbSale.Text;
            List<Drink> list = new List<Drink>();
            for (int i = 0; i < lvBill.Items.Count; i++)
            {
                Drink item = new Drink
                {
                    MaDoUong = int.Parse(lvBill.Items[i].SubItems[1].Text),
                    SoLuong = int.Parse(lvBill.Items[i].SubItems[3].Text),
                };
                list.Add(item);
            }
            BLL_QLBill.Instance.AddBill(MaHD, s.MaNV, sale, TotalPayment().ToString(), list);
            SetCBB();
            txtTotalPrice.Text = TotalPrice().ToString();
            txtTotalPayment.Text = TotalPayment().ToString();
        }

        private void btnInhoadon_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            string MaHD;
            if (cbbBill.Text != "")
            {
                MaHD = cbbBill.Text;
            }
            else
            {
                int n = BLL_QLBill.Instance.Count();
                MaHD = "HD" + now.Day.ToString() + "/" + now.Month.ToString() + "/" + now.Year.ToString() + "." + (n+1).ToString();
            }    
            string sale = cbbSale.Text;
            List<Drink> list = new List<Drink>();
            for (int i = 0; i < lvBill.Items.Count; i++)
            {
                Drink item = new Drink
                {
                    TenDoUong = lvBill.Items[i].SubItems[2].Text,
                    SoLuong = int.Parse(lvBill.Items[i].SubItems[3].Text),
                    Gia = int.Parse(lvBill.Items[i].SubItems[4].Text),
                };
                list.Add(item);
            }
            BLL_QLBill.Instance.PrintBill(MaHD, sale, txtTotalPrice.Text, txtTotalPayment.Text, list);
        }

        private void txbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                
            }
        }
    }
}
