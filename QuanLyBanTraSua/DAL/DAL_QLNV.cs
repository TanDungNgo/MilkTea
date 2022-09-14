using QuanLyBanTraSua.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanTraSua.DAL
{
    public class DAL_QLNV
    {
        private static DAL_QLNV _Instance;
        public static DAL_QLNV Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new DAL_QLNV();
                return _Instance;
            }
            private set { }
        }
        private DAL_QLNV()
        {

        }
        public int Login(string username, string password)
        {
            string query = "Select * from NHAN_VIEN where SoDT = @username and MatKhau = @pass";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { username, password });
            return result.Rows.Count;
        }
        public DataTable GetAllPosition()
        {
            string query = "Select PhanQuyen from NHAN_VIEN ";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public List<Staff> GetAllStaff()
        {
            List<Staff> data = new List<Staff>();
            string query = "Select * from NHAN_VIEN where KiemTra = 'True'";
            foreach (DataRow i in DataProvider.Instance.ExecuteQuery(query).Rows)
            {
                data.Add(GetStaff(i));
            }
            return data;
        }
        public int CountAllStaff()
        {
            List<Staff> data = new List<Staff>();
            string query = "Select * from NHAN_VIEN";
            foreach (DataRow i in DataProvider.Instance.ExecuteQuery(query).Rows)
            {
                data.Add(GetStaff(i));
            }
            return data.Count;
        }
        public Staff GetUserByUsername(string username)
        {
            string query = "Select * from  NHAN_VIEN where SoDT = '" + username + "'";
            DataRow i = DataProvider.Instance.ExecuteQuery(query).Rows[0];
            return new Staff
            {
                MaNV = i["MaNV"].ToString(),
                TenNV = i["TenNV"].ToString(),
                GioiTinh = ((bool)i["GioiTinh"] == true) ? "Nam" : "Nữ",
                SoDT = i["SoDT"].ToString(),
                ChucVu = i["PhanQuyen"].ToString(),
                MatKhau = i["MatKhau"].ToString(),
                Luong = int.Parse(i["Luong"].ToString())
            };
        }
        public Staff GetStaff(DataRow i)
        {
            return new Staff
            {
                MaNV = i["MaNV"].ToString(),
                TenNV = i["TenNV"].ToString(),
                GioiTinh = ((bool)i["GioiTinh"] == true) ? "Nam" : "Nữ",
                SoDT = i["SoDT"].ToString(),
                ChucVu = i["PhanQuyen"].ToString(),
                MatKhau = i["MatKhau"].ToString(),
                Luong = int.Parse(i["Luong"].ToString())
            };
        }
        public int CheckMaNV(string MaNV)
        {
            string query = "Select count(*) from NHAN_VIEN where MaNV = '" + MaNV + "'";
            return DataProvider.Instance.ExecuteScalar(query);
        }
        public int AddStaff(Staff s)
        {
            string query = "Insert into NHAN_VIEN values ('" + s.MaNV + "', N'" + s.TenNV + "','" + s.GioiTinh + "','" + s.SoDT + "', '" + s.ChucVu + "', '123456', '" + s.Luong + "', 'True')";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
        public int EditStaff(Staff s)
        {
            string query = "Update NHAN_VIEN set MaNV = '" + s.MaNV + "', TenNV =  N'" + s.TenNV + "', GioiTinh = '" + s.GioiTinh + "', SoDT ='" + s.SoDT + "', PhanQuyen = N'" + s.ChucVu + "', Luong = '" + s.Luong +
                "' Where MaNV = '" + s.MaNV + "'";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
        public int DeleteStaff(string MaNV)
        {
            string query = "Update NHAN_VIEN set KiemTra = 'False' where MaNV = '" + MaNV + "'";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }

        public int UpdateUser(Staff s)
        {
            string query = "Update NHAN_VIEN set MatKhau = '" + s.MatKhau + "' where MaNV = '" + s.MaNV + "'";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
        public int ResetPass(string MaNV)
        {
            string query = "Update NHAN_VIEN set MatKhau = '123456' where MaNV = '" + MaNV + "'";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
        public int CheckMaNVSDT(string MaNV, string sdt)
        {
            string query = "select * from NHAN_VIEN where MaNV = @manv and SoDT = @sodt";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { MaNV, sdt });
            return result.Rows.Count;
        }
    }
}
