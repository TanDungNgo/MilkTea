using QuanLyBanTraSua.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanTraSua.DAL
{
    public class DAL_QLDrinks
    {
        private static DAL_QLDrinks _Instance;
        public static DAL_QLDrinks Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new DAL_QLDrinks();
                return _Instance;
            }
            private set { }
        }
        public int CheckMaDoUong(int MaDoUong)
        {
            return DataProvider.Instance.ExecuteScalar("Select count(*) from MENU where MaDoUong = '" + MaDoUong + "'");
        }
        public DataTable GetListMenu()
        {
            string query = "Select * from MENU";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable SortListMenu()
        {
            string query = "Select * from MENU order by Gia";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public Drink GetDrink(DataRow i)
        {
            return new Drink
            {
                MaDoUong = int.Parse(i["MaDoUong"].ToString()),
                TenDoUong = i["TenDoUong"].ToString(),
                Anh = i["Anh"].ToString(),
                Gia = int.Parse(i["Gia"].ToString()),
                TinhTrang = i["TinhTrang"].ToString(),
            };
        }
        public List<Drink> GetAllDrink()
        {
            List<Drink> listdrinks = new List<Drink>();
            string query = "Select * from MENU";
            foreach (DataRow i in DataProvider.Instance.ExecuteQuery(query).Rows)
            {
                listdrinks.Add(GetDrink(i));
            }
            return listdrinks;
        }
        public int AddDrink(Drink d)
        {
            if (d.Anh == null)
            {
                d.Anh = "Resources\\douong.png";
            }
            string query = @"Insert into MENU values (N'" + d.TenDoUong + "','" + d.Anh + "','" + d.Gia + "',N'" + d.TinhTrang + "')";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
        public int EditDrink(Drink d)
        {
            string query = "Update MENU set TenDoUong = N'" + d.TenDoUong + "',Anh = N'" + d.Anh +
                                    "',Gia = '" + d.Gia + "',TinhTrang = N'" + d.TinhTrang + "' where MaDoUong = '" + d.MaDoUong + "'";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
        public int DeleteDrink(int MaDoUong)
        {
            string query = "Delete from MENU where MaDoUong = '" + MaDoUong + "'";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
