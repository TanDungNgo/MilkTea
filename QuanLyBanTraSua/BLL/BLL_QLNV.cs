using QuanLyBanTraSua.DAL;
using QuanLyBanTraSua.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanTraSua.BLL
{
    public class BLL_QLNV
    {
        private static BLL_QLNV _Instance;
        public static BLL_QLNV Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BLL_QLNV();
                return _Instance;
            }
            private set { }
        }
        private BLL_QLNV()
        {

        }
        public bool Login(string username, string password)
        {
            if (DAL_QLNV.Instance.Login(username, password) > 0)
                return true;
            else return false;
        }
        public Staff GetUserByUsername(string username)
        {
            return DAL_QLNV.Instance.GetUserByUsername(username);
        }
        public int Count()
        {
            int count = DAL_QLNV.Instance.CountAllStaff();
            return count;
        }
        public List<string> GetListCBB()
        {
            List<string> l = new List<string>();
            foreach (DataRow i in DAL_QLNV.Instance.GetAllPosition().Rows)
            {
                l.Add(i["PhanQuyen"].ToString());
            }
            return l;
        }
        public List<Staff> GetListStaff()
        {
            List<Staff> data = new List<Staff>();
            data = DAL_QLNV.Instance.GetAllStaff();
            return data;
        }
        //public List<Staff> GetListStaff(string phanquyen, string search)
        //{
        //    List<Staff> data = new List<Staff>();
        //    if (phanquyen == "All")
        //    {
        //        if (search == "")
        //            data = DAL_QLNV.Instance.GetAllStaff();
        //        else
        //            data = DAL_QLNV.Instance.GetStaffBySearch(phanquyen, search);
        //    }
        //    else
        //    {
        //        if (search == "")
        //            data = DAL_QLNV.Instance.GetStaffByPosition(phanquyen);
        //        else
        //            data = DAL_QLNV.Instance.GetStaffBySearch(phanquyen, search);
        //    }
        //    return data;
        //}
        public Staff GetNVByID(string MaNV)
        {
            Staff staff = null;
            foreach (Staff i in DAL_QLNV.Instance.GetAllStaff())
            {
                if (i.MaNV == MaNV)
                    staff = i;
            }
            return staff;
        }


        public void ExecuteDB(Staff s)
        {
            int check = DAL_QLNV.Instance.CheckMaNV(s.MaNV);
            if (check == 0)
            {
                // Add
                if (DAL_QLNV.Instance.AddStaff(s) > 0)
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Thêm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Edit
                if (DAL_QLNV.Instance.EditStaff(s) > 0)
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Cập nhật thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Delete(List<string> LMaNV)
        {
            int length = LMaNV.Count;
            int count = 0;
            foreach (string i in LMaNV)
            {
                if (DAL_QLNV.Instance.DeleteStaff(i) > 0)
                    count++;
                else
                {
                    MessageBox.Show("Xóa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
            }
            if (count == length)

                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void UpdateUser(Staff s)
        {
            if (DAL_QLNV.Instance.UpdateUser(s) > 0)
                MessageBox.Show("Thay đổi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Thay đổi thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public bool CheckPhone(string MaNV, string Phone)
        {
            int k = 0;
            List<Staff> list = DAL_QLNV.Instance.GetAllStaff();
            if (list.Count > 0)
            {
                for (int i = 0; i < list.Count; i++)
                {  
                    if (list[i].SoDT == Phone && list[i].MaNV != MaNV)
                    {
                        k++;
                        break;
                    }    
                }
                if (k == 0)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }
        public bool CheckMaNVSDT(string MaNV, string SDT)
        {
            if (DAL_QLNV.Instance.CheckMaNVSDT(MaNV, SDT) > 0)
                return true;
            else return false;
        }
        public void ResetPass(string MaNV)
        {
            if (DAL_QLNV.Instance.ResetPass(MaNV) > 0)
                MessageBox.Show("Thành công! Mật khẩu mới sẽ là 123456", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
