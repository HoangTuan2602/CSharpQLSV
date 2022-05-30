using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLySinhVien.DAL;
using QuanLySinhVien.DTO;

namespace QuanLySinhVien.BLL
{
    internal class BLL_SinhVien
    {
        DAL_SinhVien dalSV = new DAL_SinhVien();
        public DataTable loadSV()
        {
            return dalSV.loadSinhVien();
        }
        public bool themKhoa(DTO_SinhVien sv)
        {
            return dalSV.themSinhVien(sv);
        }
        public bool suaKhoa(DTO_SinhVien sv)
        {
            return dalSV.suaSinhVien(sv);
        }
        public bool xoaKhoa(string maSV)
        {
            return dalSV.xoaSinhVien(maSV);
        }
    }
}
