using QuanLySinhVien.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.DAL
{
    internal class DAL_SinhVien : DBConnection
    {
        public DataTable loadSinhVien()
        {
            return getData("SELECT ROW_NUMBER() OVER(ORDER BY maSV) as STT, SinhVien.maSV AS [Mã SV], SinhVien.tenSV AS [Tên SV], SinhVien.gioiTinh AS [Giới tính], SinhVien.ngaySinh AS [Ngày sinh], SinhVien.noiSinh AS [Nơi sinh], Lop.tenLop AS Lớp, Khoa.tenKhoa AS Khoa " +
                "FROM Lop INNER JOIN SinhVien ON Lop.maLop = SinhVien.maLop INNER JOINKhoa ON Lop.maKhoa = Khoa.maKhoa;");
        }
        public bool themSinhVien(DTO_SinhVien sinhVien)
        {
            try
            {
                conn.Open();
                string sql = $"INSERT INTO SinhVien (maSV, tenSV, gioiTinh, ngaySinh, noiSinh, maLop) " +
                    $"VALUES('{sinhVien.maSV}', N'{sinhVien.tenSV}', N'{sinhVien.gioiTinh}', N'{sinhVien.ngaySinh}', N'{sinhVien.noiSinh}', N'{sinhVien.maLop}');";
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
        public bool suaSinhVien(DTO_SinhVien sinhVien)
        {
            try
            {
                conn.Open();
                string sql = $"UPDATE SinhVien SET tenSV = N'{sinhVien.tenSV}', gioiTinh = N'{sinhVien.gioiTinh}', ngaySinh = N'{sinhVien.ngaySinh}', noiSinh = N'{sinhVien.noiSinh}', maLop = N'{sinhVien.maLop}' WHERE(maSV = N'{sinhVien.maSV}');";
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
        public bool xoaSinhVien(string maSV)
        {
            try
            {
                conn.Open();
                string sql = $"DELETE FROM SinhVien WHERE(maSV = '{maSV}');";
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
