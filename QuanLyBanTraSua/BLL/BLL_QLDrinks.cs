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
    public class BLL_QLDrinks
    {
        private static BLL_QLDrinks _Instance;
        public static BLL_QLDrinks Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BLL_QLDrinks();
                return _Instance;
            }
            private set { }
        }
        //public List<Drink> GetListMenu()
        //{
        //    List<Drink> data = new List<Drink>();
        //    data = DAL_QLDrinks.Instance.GetAllDrink();
        //    return data;
        //}
        public DataTable GetListMenu()
        {
            return DAL_QLDrinks.Instance.GetListMenu();
        }
        public DataTable SortListMenu()
        {
            return DAL_QLDrinks.Instance.SortListMenu();
        }
        public void ExecuteDB(Drink d)
        {
            int check = DAL_QLDrinks.Instance.CheckMaDoUong(d.MaDoUong);
            if (check != 0)
            {
                if (DAL_QLDrinks.Instance.EditDrink(d) > 0)
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Cập nhật thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (DAL_QLDrinks.Instance.AddDrink(d) > 0)
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Thêm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Delete(List<int> LMaDoUong)
        {
            int length = LMaDoUong.Count;
            int count = 0;
            foreach (int i in LMaDoUong)
            {
                if (DAL_QLDrinks.Instance.DeleteDrink(i) > 0)
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
        public Drink GetDrinkByID(int MaDoUong)
        {
            Drink menu = null;
            foreach (Drink i in DAL_QLDrinks.Instance.GetAllDrink())
            {
                if (i.MaDoUong == MaDoUong)
                    menu = i;
            }
            return menu;
        }
    }
}
