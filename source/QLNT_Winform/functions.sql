USE QLNT;
GO

IF OBJECT_ID('dbo.fn_PHONGGIAM_ThongKe') IS NOT NULL
    DROP FUNCTION dbo.fn_PHONGGIAM_ThongKe;
GO

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
GO

IF OBJECT_ID('dbo.fn_TOIDANH_ThongKe') IS NOT NULL
    DROP FUNCTION dbo.fn_TOIDANH_ThongKe;
GO

CREATE FUNCTION fn_TOIDANH_ThongKe()
RETURNS @KetQua TABLE (MaToiDanh VARCHAR(10), TenToiDanh NVARCHAR(40), SoLuongTuNhan INT)
AS
BEGIN
	INSERT INTO @KetQua
	SELECT TD.MaToiDanh, TD.TenToiDanh, COUNT(DISTINCT BA.MaTuNhan) AS SoLuongTuNhan
	FROM TOIDANH TD
	JOIN BANAN_TOIDANH BT ON BT.MaToiDanh = TD.MaToiDanh
	JOIN BANAN BA ON BA.MaBanAn = BT.MaBanAn
	GROUP BY TD.MaToiDanh, TD.TenToiDanh
	RETURN
END;
GO

IF OBJECT_ID('dbo.sp_ThongKeViPhamTheoHinhThuc') IS NOT NULL
    DROP PROC dbo.sp_ThongKeViPhamTheoHinhThuc;
GO

CREATE PROC sp_ThongKeViPhamTheoHinhThuc
AS
BEGIN
    SELECT 
        HinhThucXuLy,
        COUNT(MaViPham) AS SoLuongViPham,
        COUNT(DISTINCT MaTuNhan) AS SoTuNhanViPham,
        COUNT(MaViPham) * 100.0 / (SELECT COUNT(*) FROM VIPHAMKYLUAT) AS TiLePhanTram
    FROM VIPHAMKYLUAT
    GROUP BY HinhThucXuLy
    ORDER BY SoLuongViPham DESC;
END;
GO
