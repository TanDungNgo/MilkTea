using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanTraSua.DTO
{
    public class Staff
    {
        private string _MaNV;
        private string _TenNV;
        private string _GioiTinh;
        private string _SoDT;
        private string _ChucVu;
        private string _MatKhau;
        private int _Luong;

        public string MaNV { get => _MaNV; set => _MaNV = value; }
        public string TenNV { get => _TenNV; set => _TenNV = value; }
        public string GioiTinh { get => _GioiTinh; set => _GioiTinh = value; }
        public string SoDT { get => _SoDT; set => _SoDT = value; }
        public string ChucVu { get => _ChucVu; set => _ChucVu = value; }
        public string MatKhau { get => _MatKhau; set => _MatKhau = value; }
        public int Luong { get => _Luong; set => _Luong = value; }
    }
}
