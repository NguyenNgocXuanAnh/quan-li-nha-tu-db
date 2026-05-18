--3.d.	Truy vấn lớn nhất, nhỏ nhất: 4 câu (4 đ) (Vũ)
--3.f.	Truy vấn Hợp/Giao/Trừ: 3 câu (3đ) (Vũ)
--4.	Tạo 7 thủ tục, 8 hàm và 5 trigger. Lưu ý thủ tục và hàm có cho ví dụ minh họa. (25 đ) 2 2 2 1


---===============================================-
--3.d.	Truy vấn lớn nhất, nhỏ nhất: 4 câu (4 đ) (Vũ)
--1. Tìm thông tin Tù nhân lớn tuổi nhất trong nhà tù
SELECT TOP 1 *
FROM TUNHAN
ORDER BY NgaySinh ASC;

--2. Tìm công việc có số lượng tối đa nhỏ nhất
SELECT *
FROM CONGVIEC CV
WHERE CV.SoLuongToiDa <= ALL (
    SELECT SoLuongToiDa
    FROM CONGVIEC
);
--3. Tìm mã quản ngục có số lần duyệt thăm nuôi nhiều nhất trong năm 2025
SELECT TOP 1 MaQuanNgucDuyet, COUNT(*) AS SoLanDuyet
FROM THAMNUOI
WHERE YEAR(NgayTham) = 2025
GROUP BY MaQuanNgucDuyet
ORDER BY COUNT(*) DESC

--4. Tìm phòng giam có số lượng tù nhân đang thi hành án nhiều nhất (dùng MAX)
SELECT PG.MaPhong, QN.TenQuanNguc, COUNT(TN.MaTuNhan) AS SoTuNhan
FROM PHONGGIAM PG
JOIN QUANNGUC QN ON PG.MaQuanNguc = QN.MaQuanNguc
JOIN TUNHAN TN ON PG.MaPhong = TN.MaPhong
WHERE TN.TrangThai = N'Đang thi hành án'
GROUP BY PG.MaPhong, QN.TenQuanNguc
HAVING COUNT(TN.MaTuNhan) = (
    SELECT MAX(SoTuNhan)
    FROM (
        SELECT COUNT(MaTuNhan) AS SoTuNhan
        FROM TUNHAN
        WHERE TrangThai = N'Đang thi hành án'
        GROUP BY MaPhong
    ) AS Dem
)

-- 5. Tìm thân nhân đi thăm nuôi nhiều nhất
SELECT *
FROM (
    SELECT TN.MaThanNhan, TN.HoTenThanNhan, COUNT(TM.NgayTham) AS SoLanTham
    FROM THANNHAN TN
    JOIN THAMNUOI TM ON TN.MaThanNhan = TM.MaThanNhan
    GROUP BY TN.MaThanNhan, TN.HoTenThanNhan
) AS DemThanNhan
WHERE SoLanTham = (
    SELECT MAX(SoLanTham)
    FROM (
        SELECT COUNT(*) AS SoLanTham
        FROM THAMNUOI
        GROUP BY MaThanNhan
    ) AS Dem
);


--3.f.	Truy vấn Hợp/Giao/Trừ: 3 câu (3đ) (Vũ)
  
--1. Liệt kê các phòng giam có trạng thái 'Đang sửa chữa' và 'Trống'
SELECT MaPhong, TrangThai
FROM PHONGGIAM
WHERE TrangThai = N'Trống'

UNION

SELECT MaPhong, TrangThai
FROM PHONGGIAM
WHERE TrangThai = N'Đang sửa chữa'

-- 2. Tìm những tù nhân vừa bị vi phạm kỷ luật, vừa có kết quả cải tạo tốt.
SELECT TN.MaTuNhan, TN.HoTen
FROM TUNHAN TN
JOIN VIPHAMKYLUAT VP ON TN.MaTuNhan = VP.MaTuNhan

INTERSECT

SELECT TN.MaTuNhan, TN.HoTen
FROM TUNHAN TN
JOIN CAITAO CT ON TN.MaTuNhan = CT.MaTuNhan
WHERE CT.DanhGia = N'Tốt'

--3. Liệt kê các quản ngục thuộc khu vực A nhưng không trực tiếp quản lý phòng giam khu A
SELECT MaQuanNguc, TenQuanNguc
FROM QUANNGUC
WHERE MaKV = 'KVA'

EXCEPT

SELECT DISTINCT QN.MaQuanNguc, QN.TenQuanNguc
FROM QUANNGUC QN
JOIN PHONGGIAM PG ON QN.MaQuanNguc = PG.MaQuanNguc
WHERE PG.MaKV = 'KVA'


--Câu 4: 2 thủ tục, 2 hàm, 1 trigger
-- Thủ tục 1: Cập nhật trạng thái tù nhân khi đến ngày mãn hạn
CREATE PROC sp_CapNhatManHanTuDong
AS
BEGIN
    SET NOCOUNT ON;
    
    -- Cập nhật tù nhân đã mãn hạn
    UPDATE TUNHAN
    SET TrangThai = N'Đã mãn hạn',
        NgayXuatTrai = GETDATE(),
        MaPhong = NULL
    WHERE TrangThai = N'Đang thi hành án'
      AND MaTuNhan IN (
          SELECT MaTuNhan FROM BANAN
          WHERE NgayKetThucDuKien <= GETDATE()
      );
    
    -- Cập nhật lại số lượng hiện tại cho các phòng bị ảnh hưởng
    UPDATE PHONGGIAM
    SET SoLuongHienTai = (
        SELECT COUNT(*) FROM TUNHAN
        WHERE MaPhong = PHONGGIAM.MaPhong
          AND TrangThai = N'Đang thi hành án'
    );
   SELECT N'Đã cập nhật tù nhân mãn hạn thành công!' AS ThongBao;
END;
  

EXEC sp_CapNhatManHanTuDong;


-- Kiểm tra kết quả
SELECT MaTuNhan, HoTen, TrangThai, NgayXuatTrai
FROM TUNHAN
WHERE TrangThai = N'Đã mãn hạn';

--Thủ tục 2: Thống kê vi phạm theo hình thức xử lý
CREATE PROC sp_ThongKeViPhamTheoHinhThuc
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT 
        HinhThucXuLy,
        COUNT(MaViPham) AS SoLuongViPham,
        COUNT(DISTINCT MaTuNhan) AS SoTuNhanViPham,
        ROUND(COUNT(MaViPham) * 100.0 / (SELECT COUNT(*) FROM VIPHAMKYLUAT), 2) AS TiLePhanTram
    FROM VIPHAMKYLUAT
    GROUP BY HinhThucXuLy
    ORDER BY SoLuongViPham DESC;
END;

-- Chạy thủ tục thống kê vi phạm
EXEC sp_ThongKeViPhamTheoHinhThuc;

-- Hàm 1: Thống kê số lượng tù nhân theo mức độ nguy hiểm và trạng thái

CREATE FUNCTION fn_TUNHAN_ThongKe()
RETURNS TABLE
AS
RETURN
(
    SELECT 
        MucDoNguyHiem,
        TrangThai,
        COUNT(*) AS SoLuong
    FROM TUNHAN
    GROUP BY MucDoNguyHiem, TrangThai
);

SELECT *
FROM dbo.fn_TUNHAN_ThongKe()
ORDER BY MucDoNguyHiem, SoLuong DESC;

-- Hàm 2: Thống kê hiệu suất sử dụng phòng giam theo khu vực
CREATE FUNCTION fn_PHONGGIAM_ThongKe()
RETURNS TABLE
AS
RETURN
(
    SELECT 
        KV.MaKV,
        KV.TenKV,
        COUNT(PG.MaPhong) AS SoPhong,
        SUM(PG.SucChua) AS TongSucChua,
        SUM(PG.SoLuongHienTai) AS TongTuNhan,
        CAST(SUM(PG.SoLuongHienTai) * 100.0 / SUM(PG.SucChua) AS DECIMAL(5,2)) AS TiLeLapDay
    FROM KHUVUC KV JOIN PHONGGIAM PG ON KV.MaKV = PG.MaKV
    GROUP BY KV.MaKV, KV.TenKV
);

SELECT *
FROM dbo.fn_PHONGGIAM_ThongKe()
ORDER BY TiLeLapDay DESC;



-- Trigger: Kiểm tra email nhập vào phải đúng định dạng chuẩn
IF EXISTS (SELECT NAME FROM SYSOBJECTS WHERE NAME = 'trg_KiemTraEmailQuanNguc' AND TYPE = 'tr')
DROP TRIGGER trg_KiemTraEmailQuanNguc
GO

CREATE TRIGGER trg_KiemTraEmailQuanNguc
ON QUANNGUC
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;
    
    -- Kiểm tra email có đúng định dạng không
    IF EXISTS (
        SELECT 1 
        FROM inserted
        WHERE Email IS NOT NULL 
          AND (
              -- Phải có 1 dấu @ và không ở đầu
              CHARINDEX('@', Email) <= 1
              -- Phải có dấu . sau @
              OR CHARINDEX('.', Email, CHARINDEX('@', Email)) = 0
              -- Không được có khoảng trắng
              OR Email LIKE '% %'
              -- Không được có ký tự đặc biệt không hợp lệ
              OR Email LIKE '%[^a-zA-Z0-9@._-]%'
              -- Đuôi email phải kết thúc bằng .com, .vn, .gov.vn, ...
              OR NOT (Email LIKE '%.com' OR Email LIKE '%.vn' OR Email LIKE '%.gov.vn')
          )
    )
    BEGIN
        ROLLBACK TRANSACTION;
        RAISERROR(N'Email không đúng định dạng! Email phải có dạng: ten@domain.com (hoặc .vn, .gov.vn)', 16, 1);
    END
END;

--ví dụ: đúng định dạng
BEGIN TRAN
-- Đúng định dạng: ten@domain.com
INSERT INTO QUANNGUC (MaQuanNguc, TenQuanNguc, NgaySinh, GioiTinh, DiaChi, SoDienThoai, Email, MaKV, NgayNhanChuc, Luong, ChucVu, TrangThai)
VALUES ('QN21', N'Nguyễn Văn A', '1990-01-01', N'Nam', N'123 Đường A', '0987654321', 'nguyenvana@prison.com', 'KVA', GETDATE(), 10000000, N'Quản ngục', N'Đang làm');
COMMIT TRAN;


--ví dụ: sai định dạng
BEGIN TRAN
-- Sai: Thiếu dấu @
INSERT INTO QUANNGUC (MaQuanNguc, TenQuanNguc, NgaySinh, GioiTinh, DiaChi, SoDienThoai, Email, MaKV, NgayNhanChuc, Luong, ChucVu, TrangThai)
VALUES ('QN24', N'Nguyễn Văn D', '1990-04-04', N'Nam', N'123 Đường D', '0987654324', 'nguyenvandprison.com', 'KVA', GETDATE(), 10000000, N'Quản ngục', N'Đang làm');
-- Kết quả: RAISERROR 'Email không đúng định dạng!'
ROLLBACK;

-- Tạo 1 user và cấp quyền
-- Tạo user cho tù nhân
CREATE LOGIN tunhan_qlnt WITH PASSWORD = 'Tunhan@123';
USE QLNT;
CREATE USER user_tunhan FOR LOGIN tunhan_qlnt;

-- Tạo VIEW chỉ hiển thị thông tin tù nhân đang đăng nhập
CREATE VIEW vw_ThongTinTuNhan
AS
SELECT MaTuNhan, HoTen, NgaySinh, GioiTinh, DiaChi, MaPhong, TrangThai
FROM TUNHAN
WHERE MaTuNhan = USER_NAME(); -- Lấy mã tù nhân từ user đang đăng nhập


-- Cho phép xem lịch thăm nuôi của chính mình
GRANT SELECT ON LICHTHAMNUOI TO user_tunhan;
GRANT SELECT ON THANNHAN TO user_tunhan;