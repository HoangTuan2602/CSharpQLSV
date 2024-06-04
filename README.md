# Hệ Thống Quản Lý Sinh Viên

## Giới thiệu
Đây là một ứng dụng quản lý sinh viên được xây dựng bằng C# Winform. Chương trình cung cấp các chức năng quản lý đầy đủ về khoa, giảng viên, môn học, lớp, sinh viên và quản lý điểm thi của sinh viên. Ứng dụng được thiết kế với giao diện người dùng responsive, đáp ứng tốt trên các kích cỡ màn hình khác nhau.

## Tính năng chính
- Đăng nhập / đăng xuất
- Quản lý thông tin khoa, giảng viên, môn học, lớp và sinh viên (thêm, sửa, xóa)
- Quản lý điểm thi của sinh viên
- Liên kết môn học với từng khoa
- Giao diện người dùng responsive
- Xử lý những trải nghiệm cơ bản của người dùng (ẩn hiện cửa sổ dựa trên logic, một số button tắt hữu ích khi sử dụng)

## Những công cụ sử dụng trong dự án
- SQL Server 2019
- Visual Studio 2019

## Cài đặt
1. Tải xuống mã nguồn từ repository.
2. Mở project trong Visual Studio.
3. Khởi tạo cơ sở dữ liệu QLSV từ file db được export trong SQL Server. (có thể thay đổi dữ liệu được tạo sẵn trong file db này)
4. Cấu hình kết nối cơ sở dữ liệu trong file `DBConnection.cs` (trong thư mục DAL) bằng cách thay đổi username, password và tên database.
5. Xây dựng project.
6. Chạy ứng dụng trực tiếp từ Visual Studio.
