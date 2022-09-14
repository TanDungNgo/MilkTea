using QuanLyBanTraSua.DAL;
using QuanLyBanTraSua.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace QuanLyBanTraSua.BLL
{
    public class BLL_QLBill
    {
        private static BLL_QLBill _Instance;
        public static BLL_QLBill Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BLL_QLBill();
                return _Instance;
            }
            private set { }
        }

        public List<string> GetListMaHD()
        {
            List<string> data = new List<string>();
            foreach (DataRow i in DAL_QLBill.Instance.GetAllMaHD().Rows)
            {
                data.Add(i["MaHD"].ToString());
            }
            return data;
        }
        public string GetMaGiamGia(string MaHD)
        {
            string data = "None";
            foreach (DataRow i in DAL_QLBill.Instance.GetMaGiamGia(MaHD).Rows)
            {
                data = i["MaGiamGia"].ToString();
            }
            return data;
        }
        public void AddBill(string MaHD, string MaNV, string sale, string total, List<Drink> list)
        {
            if (DAL_QLBill.Instance.AddBill(MaHD, MaNV, sale, total) > 0)
            {
                DAL_QLBill.Instance.AddDrink(MaHD, list);
                MessageBox.Show("Thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public int Count()
        {
            int count = 0;
            foreach (DataRow i in DAL_QLBill.Instance.CountBillToday().Rows)
                count = int.Parse(i[0].ToString());
            return count;
        }
        public void PrintBill(string MaHD, string sale, string total, string totalpay, List<Drink> list)
        {
            try
            {
                string header = "\t\t\t\tHÓA ĐƠN BÁN HÀNG";
                string noidung = "";
                string name = MaHD.Replace('/', '-');
                string filepath = @"D:\Subjects\QuanLyBanTraSua\QuanLyBanTraSua\File\HOADON_" + name + ".txt";
                noidung += "\n\tMã hóa đơn: " + MaHD;
                noidung += "\n\tNgày thu: " + DateTime.Now.ToString();
                noidung += "\n\n\tTên đồ uống\t\t\tSố lượng\tĐơn giá\t\tThành tiền\n";
                noidung += "\t________________________________________________________________";
                foreach (Drink drink in list)
                {
                    int thanhtien = int.Parse(drink.SoLuong.ToString()) * int.Parse(drink.Gia.ToString());
                    noidung += "\n\t" + drink.TenDoUong + "\t\t\t" + drink.SoLuong + "\t" + drink.Gia + "\t\t\t" + thanhtien.ToString() + "\n";
                }
                noidung += "\n\n\tTổng cộng: " + total + " đ";
                noidung += "\n\tGiảm giá: " + sale;
                noidung += "\n\tTổng thanh toán: " + totalpay + " đ"; ;
                noidung += "\n\n\t\t\t XIN CẢM ƠN - HẸN GẶP LẠI";
                FileStream fs = new FileStream(filepath, FileMode.Create);
                StreamWriter sWriter = new StreamWriter(fs, Encoding.UTF8);
                sWriter.WriteLine(header);
                sWriter.WriteLine(noidung);
                sWriter.Flush();
                fs.Close();
                MessageBox.Show("In thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("In thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public List<string> GetYear()
        {
            List<string> l = new List<string>();
            foreach (DataRow i in DAL_QLBill.Instance.GetYear().Rows)
            {
                l.Add(i[0].ToString());
            }
            return l;
        }
        public List<string> GetMonth(string year)
        {
            List<string> l = new List<string>();
            foreach (DataRow i in DAL_QLBill.Instance.GetMonth(year).Rows)
            {
                l.Add(i[0].ToString());
            }
            return l;
        }
        public int TotalMoney (string month, string year)
        {
            int sum = 0;
            foreach (DataRow i in DAL_QLBill.Instance.GetMoney(month, year).Rows)
            {
               sum += int.Parse(i[0].ToString());
            }
            return sum;
        }
    }
}
