--Cau 4: Stored Procedure - Tìm danh sách tù nhân theo giới tính 
CREATE PROC sp_gioitinh_select @GioiTinh nvarchar(5)
AS BEGIN 
	SELECT MaTuNhan, SoCCCD, HoTen, GioiTinh
	FROM TUNHAN
	WHERE GioiTinh = @GioiTinh 
END;

sp_gioitinh_select Nữ;
sp_gioitinh_select Nam;

--Cau 4: Stored Procedure - Tìm thông tin tù nhân ở tù sớm nhất 
CREATE PROC sp_tunhan_select 
AS BEGIN 
	DECLARE @max int;
	SELECT @max = max(datediff(year, NgayBatDauThiHanhAn, getdate()))
	FROM BANAN 
	WHERE NgayBatDauThiHanhAn IS NOT NULL;
	SELECT TN.MaTuNhan, SoCCCD, HoTen, NgaySinh, GioiTinh, BA.NgayBatDauThiHanhAn
	FROM TUNHAN TN
	JOIN BANAN BA ON BA.MaTuNhan = TN.MaTuNhan
	WHERE datediff(year, NgayBatDauThiHanhAn, getdate()) = @max 
END;

sp_tunhan_select;

--Cau 4: Function - Cho biết số lượng phòng giam theo mã khu vực 
CREATE FUNCTION fn_soluong_select (@MaKV varchar(10)) 
RETURNS int
AS BEGIN
    DECLARE @SoLuong int;
    SELECT @SoLuong = COUNT(MaPhong)  
	FROM PHONGGIAM 
	WHERE MaKV  = @MaKV;
    RETURN @SoLuong;
END;

SELECT N'Số phòng giam khu A là:' AS ThongBao, dbo.fn_soluong_select ('KVA') AS SoLuong;
SELECT N'Số phòng giam khu B là:' AS ThongBao, dbo.fn_soluong_select ('KVB') AS SoLuong;
SELECT N'Số phòng giam khu C là:' AS ThongBao, dbo.fn_soluong_select ('KVC') AS SoLuong;
SELECT N'Số phòng giam khu D là:' AS ThongBao, dbo.fn_soluong_select ('KVD') AS SoLuong;

--Cau 4: Function - Tìm những quản ngục có mức lương cao hơn mức lương cần tìm
CREATE FUNCTION fn_quannguc_select (@Luong decimal(10,2)) RETURNS 
@RETURNTABLE TABLE 
	(
		MaQuanNguc varchar(10),
		TenQuanNguc nvarchar(100),
		Luong decimal(10,2)
	)
AS BEGIN
    INSERT INTO @RETURNTABLE
    SELECT MaQuanNguc, TenQuanNguc, Luong
    FROM QUANNGUC
    WHERE Luong > @Luong 
    RETURN
END;

SELECT * FROM dbo.fn_quannguc_select (13000000) ORDER BY Luong ASC;



