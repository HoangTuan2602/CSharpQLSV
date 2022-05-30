using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLySinhVien.DTO;

namespace QuanLySinhVien.DAL
{
    internal class DAL_DiemThi : DBConnection
    {
        public DataTable loadDiem()
        {
            return getData("SELECT ROW_NUMBER() OVER(ORDER BY maSV, maMH) as STT, GianDiemien.maDiem AS [Mã Diem], GianDiemien.tenDiem AS [Tên Diem], GianDiemien.chuyenNganh AS [Chuyên ngành], Khoa.tenKhoa AS Khoa FROM GianDiemien INNER JOIN Khoa ON GianDiemien.maKhoa = Khoa.maKhoa");
        }
        public bool themDiem(DTO_DiemThi diem)
        {
            try
            {
                conn.Open();
                string sql = $"INSERT INTO DiemThi (maSV, maMH, lanThi, diemThi) VALUES('{diem.maSV}', N'{diem.maMH}', {diem.lanThi}, {diem.diemThi});";
                if (excute(sql) > 0)
                    return true;
            }
            catch (Exception ex) { }
            finally
            {
                conn.Close();
            }
            return false;
        }

        public bool suaDiem(DTO_DiemThi diem)
        {
            try
            {
                conn.Open();
                string sql = $"UPDATE DiemThi SET lanThi = {diem.lanThi}, diemThi = {diem.diemThi} WHERE(maSV = '{diem.maSV}') AND(maMH = '{diem.maMH}');";
                if (excute(sql) > 0)
                    return true;
            }
            catch (Exception ex) { }
            finally
            {
                conn.Close();
            }
            return false;
        }

        public bool xoaDiem(string maSV, string maMH)
        {
            try
            {
                conn.Open();
                string sql = $"DELETE FROM DiemThi WHERE(maSV = '{maSV}') AND(maMH = '{maMH}');";
                if (excute(sql) > 0)
                    return true;
            }
            catch (Exception ex) { }
            finally
            {
                conn.Close();
            }
            return false;
        }
    }
}
