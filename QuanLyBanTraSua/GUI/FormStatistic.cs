using QuanLyBanTraSua.BLL;
using QuanLyBanTraSua.DAL;
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
    public partial class FormStatistic : Form
    {
        public FormStatistic()
        {
            InitializeComponent();
            SetCBB();
        }
        public void SetCBB()
        {
            if (comboBox1 != null)
            {
                comboBox1.Items.Clear();
            }    
            comboBox1.Items.AddRange(BLL_QLBill.Instance.GetYear().Distinct().ToArray());
        }
        private void btn_ThongKe_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Chọn năm muốn thống kê", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            chart1.Series.Clear();
            chart1.Series.Add("DoanhThu");
            chart1.Titles.Clear();
            chart1.Titles.Add("Doanh thu của quán năm " + comboBox1.Text);
            List<string> listMonth = new List<string>();
            listMonth.AddRange(BLL_QLBill.Instance.GetMonth(comboBox1.Text).Distinct().ToArray());
            int i = 0;
            foreach (string m in listMonth)
            {
                int sum = BLL_QLBill.Instance.TotalMoney(m, comboBox1.Text);
                chart1.Series["DoanhThu"].Points.Add(sum);
                chart1.Series["DoanhThu"].Points[i].Label = sum.ToString();
                chart1.Series["DoanhThu"].Points[i].AxisLabel = "Tháng " + m;
                i = i + 1;
            }
        }
    }
}
