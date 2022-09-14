using QuanLyBanTraSua.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanTraSua.DAL
{
    public class DAL_QLBill
    {
        private static DAL_QLBill _Instance;
        public static DAL_QLBill Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new DAL_QLBill();
                return _Instance;
            }
            private set { }
        }
        public Bill GetBill(DataRow i)
        {
            return new Bill
            {
                MaDoUong = int.Parse(i["MaDoUong"].ToString()),
                TenDoUong = i["TenDoUong"].ToString(),
                SoLuong = int.Parse(i["SoLuong"].ToString()),
                Gia = int.Parse(i["Gia"].ToString()),
            };
        }
        public DataTable GetAllMaHD()
        {
            DateTime now = DateTime.Now;
            string query = "select MaHD from HOA_DON where MaHD like 'HD" + now.Day + "/" + now.Month + "/" + now.Year + "%'";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public List<Bill> GetBillByMaHD(string MaHD)
        {
            List<Bill> data = new List<Bill>();
            string query = "exec ShowBill @MaHD = '" + MaHD + "'";
            foreach (DataRow i in DataProvider.Instance.ExecuteQuery(query).Rows)
            {
                data.Add(GetBill(i));
            }
            return data;
        }
        public int AddBill(string MaHD, string MaNV, string sale, string total)
        {
            string query = "insert into HOA_DON values ('" + MaHD + "','" + MaNV + "','" + DateTime.Now.ToString() + "','" + sale + "','" + total + "','0')";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
        public void AddDrink(string MaHD, List<Drink> drink)
        {
            foreach (Drink i in drink)
            {
                string query = "insert into CHI_TIET_HOA_DON values ('" + MaHD + "', '" + i.MaDoUong + "', '" + i.SoLuong + "')";
                DataProvider.Instance.ExecuteQuery(query);
            }
        }
        public DataTable CountBillToday()
        {
            DateTime now = DateTime.Now;
            string query = "select count(*) from HOA_DON where MaHD like 'HD" + now.Day + "/" + now.Month + "/" + now.Year + "%'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable GetMaGiamGia(string MaHD)
        {
            string query = "select MaGiamGia from HOA_DON where MaHD = '" + MaHD + "'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable GetYear()
        {
            string query = "select YEAR(ThoiGianThanhToan) from HOA_DON";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable GetMonth(string year)
        {
            string query = "select MONTH(ThoiGianThanhToan) from HOA_DON where YEAR(ThoiGianThanhToan) = "+ year ;
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable GetMoney(string month, string year)
        {
            string query = "select TongTien from HOA_DON where Month(ThoiGianThanhToan) =" + month + "and Year(ThoiGianThanhToan) = " + year ;
            return DataProvider.Instance.ExecuteQuery(query);
        }    
    }
}
