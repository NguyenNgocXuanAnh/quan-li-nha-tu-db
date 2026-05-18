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
  
--1. Gộp danh sách quản ngục và tù nhân thành một danh sách chung.
SELECT QN.TenQuanNguc AS Ten, QN.DiaChi, N'Quản ngục' AS Loai
FROM QUANNGUC QN

UNION

SELECT TN.HoTen, TN.DiaChi, N'Tù nhân' AS Loai
FROM TUNHAN TN
-- 2. Tìm những tù nhân vừa bị vi phạm kỷ luật, vừa có kết quả cải tạo tốt.
SELECT TN.MaTuNhan, TN.HoTen
FROM TUNHAN TN
JOIN VIPHAMKYLUAT VP ON TN.MaTuNhan = VP.MaTuNhan

INTERSECT

SELECT TN.MaTuNhan, TN.HoTen
FROM TUNHAN TN
JOIN CAITAO CT ON TN.MaTuNhan = CT.MaTuNhan
WHERE CT.DanhGia = N'Tốt'

--3. Cho biết các phòng giam chưa có tù nhân nào đang ở
SELECT PG.MaPhong, QN.TenQuanNguc, PG.SucChua
FROM PHONGGIAM PG
JOIN QUANNGUC QN ON PG.MaQuanNguc = QN.MaQuanNguc

EXCEPT

SELECT PG.MaPhong, QN.TenQuanNguc, PG.SucChua
FROM PHONGGIAM PG
JOIN QUANNGUC QN ON PG.MaQuanNguc = QN.MaQuanNguc
JOIN TUNHAN TN ON PG.MaPhong = TN.MaPhong;














--4.	Tạo 7 thủ tục, 8 hàm và 5 trigger. Lưu ý thủ tục và hàm có cho ví dụ minh họa. (25 đ) 2 2 2 1
