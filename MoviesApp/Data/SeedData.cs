using MoviesApp.Data;
using MoviesApp.Models;

namespace MoviesApp.Data
{
    public static class SeedData
    {
        public static async Task InitializeAsync(WebMoviesDbContext context)
        {
            // Kiểm tra nếu đã có dữ liệu thì không seed nữa
            if (context.QuocGias.Any())
            {
                return;
            }

            // Seed QuocGia
            var quocGias = new List<QuocGia>
            {
                new QuocGia { MaQG = "VN", TenQG = "Việt Nam", MoTa = "Phim Việt Nam" },
                new QuocGia { MaQG = "US", TenQG = "Hoa Kỳ", MoTa = "Phim Hollywood" },
                new QuocGia { MaQG = "KR", TenQG = "Hàn Quốc", MoTa = "Phim Hàn Quốc" },
                new QuocGia { MaQG = "JP", TenQG = "Nhật Bản", MoTa = "Phim Nhật Bản" },
                new QuocGia { MaQG = "CN", TenQG = "Trung Quốc", MoTa = "Phim Trung Quốc" }
            };
            context.QuocGias.AddRange(quocGias);

            // Seed TheLoaiPhim
            var theLoaiPhims = new List<TheLoaiPhim>
            {
                new TheLoaiPhim { MaTL = "HANHD", TenTL = "Hành động", MoTa = "Phim hành động, phiêu lưu" },
                new TheLoaiPhim { MaTL = "LANGM", TenTL = "Lãng mạn", MoTa = "Phim tình cảm, lãng mạn" },
                new TheLoaiPhim { MaTL = "KINHD", TenTL = "Kinh dị", MoTa = "Phim kinh dị, ma quái" },
                new TheLoaiPhim { MaTL = "HAIHU", TenTL = "Hài hước", MoTa = "Phim hài, giải trí" },
                new TheLoaiPhim { MaTL = "KHVT", TenTL = "Khoa học viễn tưởng", MoTa = "Phim sci-fi" },
                new TheLoaiPhim { MaTL = "ANIME", TenTL = "Anime", MoTa = "Phim hoạt hình Nhật Bản" }
            };
            context.TheLoaiPhims.AddRange(theLoaiPhims);

            // Seed DanhMuc
            var danhMucs = new List<DanhMuc>
            {
                new DanhMuc { MaDM = "PHIMLE", TenDM = "Phim lẻ", MoTa = "Phim một tập" },
                new DanhMuc { MaDM = "PHIMBO", TenDM = "Phim bộ", MoTa = "Phim nhiều tập" },
                new DanhMuc { MaDM = "WEBSERI", TenDM = "Web Series", MoTa = "Phim web series" }
            };
            context.DanhMucs.AddRange(danhMucs);

            // Seed LoaiNguoiDung
            var loaiNguoiDungs = new List<LoaiNguoiDung>
            {
                new LoaiNguoiDung { MaLoaiND = "FREE", TenLoaiND = "Miễn phí", VaiTro = "Người dùng cơ bản", Gia = 0, SoNgayHieuLuc = 0 },
                new LoaiNguoiDung { MaLoaiND = "VIP", TenLoaiND = "VIP", VaiTro = "Người dùng VIP", Gia = 99000, SoNgayHieuLuc = 30 },
                new LoaiNguoiDung { MaLoaiND = "PREMIUM", TenLoaiND = "Premium", VaiTro = "Người dùng Premium", Gia = 199000, SoNgayHieuLuc = 30 }
            };
            context.LoaiNguoiDungs.AddRange(loaiNguoiDungs);

            await context.SaveChangesAsync();            // Seed Phim với ThongKePhim
            var phims = new List<Phim>
            {
                new Phim 
                { 
                    MaPhim = "PHIM001", 
                    MaQG = "KR", 
                    MaTL = "HANHD", 
                    MaDM = "PHIMBO",
                    TenPhim = "Squid Game", 
                    MoTaPhim = "Một loạt phim Hàn Quốc về những người chơi trò chơi sinh tử để giành giải thưởng khổng lồ.",
                    AnhPhim = "https://images.unsplash.com/photo-1489599162337-c7e53176c03e?w=300&h=450&fit=crop",
                    SoTap = 9,
                    TinhTrang = "Hoàn thành",
                    NamPhatHanh = 2021,
                    ThoiLuongPhim = 60,
                    DaoDien = "Hwang Dong-hyuk",
                    DienVien = "Lee Jung-jae, Park Hae-soo, Oh Young-soo, Wi Ha-joon, Jung Ho-yeon",
                    BienKich = "Hwang Dong-hyuk",
                    DiemImdb = 8.0m,
                    DiemMetascore = 66,
                    LuotVoteImdb = 500000,
                    NgonNgu = "Korean",
                    QuocGiaSanXuat = "South Korea",
                    XepHang = "TV-MA"
                },
                new Phim 
                { 
                    MaPhim = "PHIM002", 
                    MaQG = "US", 
                    MaTL = "KHVT", 
                    MaDM = "PHIMLE",
                    TenPhim = "Avengers: Endgame", 
                    MoTaPhim = "Các siêu anh hùng tập hợp để đánh bại Thanos và cứu vũ trụ.",
                    AnhPhim = "https://images.unsplash.com/photo-1571019613454-1cb2f99b2d8b?w=300&h=450&fit=crop",
                    SoTap = 1,
                    TinhTrang = "Hoàn thành",
                    NamPhatHanh = 2019,
                    ThoiLuongPhim = 181,
                    DaoDien = "Anthony Russo, Joe Russo",
                    DienVien = "Robert Downey Jr., Chris Evans, Mark Ruffalo, Chris Hemsworth, Scarlett Johansson, Jeremy Renner",
                    BienKich = "Christopher Markus, Stephen McFeely",
                    DiemImdb = 8.4m,
                    DiemMetascore = 78,
                    LuotVoteImdb = 1200000,
                    NgonNgu = "English",
                    QuocGiaSanXuat = "United States",
                    XepHang = "PG-13",
                    GiaiThuong = "Saturn Award for Best Comic-to-Film Motion Picture"
                },
                new Phim 
                { 
                    MaPhim = "PHIM003", 
                    MaQG = "JP", 
                    MaTL = "ANIME", 
                    MaDM = "PHIMBO",
                    TenPhim = "Attack on Titan", 
                    MoTaPhim = "Câu chuyện về loài người chiến đấu chống lại những người khổng lồ ăn thịt người.",
                    AnhPhim = "https://images.unsplash.com/photo-1578662996461-4c734ba2f1a1?w=300&h=450&fit=crop",
                    SoTap = 75,
                    TinhTrang = "Hoàn thành",
                    NamPhatHanh = 2013,
                    ThoiLuongPhim = 24,
                    DaoDien = "Tetsuro Araki",
                    DienVien = "Marina Inoue, Yuki Kaji, Yui Ishikawa, Hiroshi Kamiya",
                    BienKich = "Yasuko Kobayashi",
                    DiemImdb = 9.0m,
                    DiemMetascore = 85,
                    LuotVoteImdb = 400000,
                    NgonNgu = "Japanese",
                    QuocGiaSanXuat = "Japan",
                    XepHang = "TV-14"
                }
            };            context.Phims.AddRange(phims);
            await context.SaveChangesAsync();

            // Seed TapPhim với video test URLs
            var tapPhims = new List<TapPhim>
            {
                // Phim 1 - Avengers Endgame (Movie) - Trailer
                new TapPhim 
                { 
                    MaTap = "T001", 
                    MaPhim = "PHIM001", 
                    SoTapThuTu = 0, 
                    TenTap = "Trailer", 
                    ChiTiet = "Trailer chính thức của Avengers: Endgame",
                    VideoUrl = "https://www.youtube.com/watch?v=TcMBFSGVi1c", // Avengers Endgame Trailer
                    ThoiLuongTap = 3,
                    NgayPhatHanh = new DateTime(2019, 3, 14)
                },
                // Phim 1 - Full Movie (Test with sample video)
                new TapPhim 
                { 
                    MaTap = "T002", 
                    MaPhim = "PHIM001", 
                    SoTapThuTu = 1, 
                    TenTap = "Phim đầy đủ", 
                    ChiTiet = "Phim Avengers: Endgame full length",
                    VideoUrl = "https://sample-videos.com/zip/10/mp4/SampleVideo_720x480_5mb.mp4", // Sample video for testing
                    ThoiLuongTap = 181,
                    NgayPhatHanh = new DateTime(2019, 4, 26)
                },

                // Phim 2 - Spider-Man (Movie) - Trailer
                new TapPhim 
                { 
                    MaTap = "T003", 
                    MaPhim = "PHIM002", 
                    SoTapThuTu = 0, 
                    TenTap = "Trailer", 
                    ChiTiet = "Trailer chính thức của Spider-Man: No Way Home",
                    VideoUrl = "https://www.youtube.com/watch?v=JfVOs4VSpmA", // Spider-Man Trailer
                    ThoiLuongTap = 3,
                    NgayPhatHanh = new DateTime(2021, 8, 24)
                },
                // Phim 2 - Full Movie
                new TapPhim 
                { 
                    MaTap = "T004", 
                    MaPhim = "PHIM002", 
                    SoTapThuTu = 1, 
                    TenTap = "Phim đầy đủ", 
                    ChiTiet = "Phim Spider-Man: No Way Home full length",
                    VideoUrl = "https://www.learningcontainer.com/wp-content/uploads/2020/05/sample-mp4-file.mp4", // Another sample video
                    ThoiLuongTap = 148,
                    NgayPhatHanh = new DateTime(2021, 12, 17)
                },

                // Phim 3 - Attack on Titan (Series) - Episodes
                new TapPhim 
                { 
                    MaTap = "T005", 
                    MaPhim = "PHIM003", 
                    SoTapThuTu = 1, 
                    TenTap = "To You, in 2000 Years", 
                    ChiTiet = "Tập đầu tiên của Attack on Titan - Con người đối mặt với Titan",
                    VideoUrl = "https://www.youtube.com/watch?v=MGRm4IzK1SQ", // Attack on Titan Episode 1 clip
                    ThoiLuongTap = 24,
                    NgayPhatHanh = new DateTime(2013, 4, 7)
                },
                new TapPhim 
                { 
                    MaTap = "T006", 
                    MaPhim = "PHIM003", 
                    SoTapThuTu = 2, 
                    TenTap = "That Day", 
                    ChiTiet = "Tập 2 - Hồi ức về ngày Titan phá vỡ tường Maria",
                    VideoUrl = "https://file-examples.com/storage/fe68c0b3d4c80b9fc1906ac/2017/10/file_example_MP4_480_1_5MG.mp4", // Sample video
                    ThoiLuongTap = 24,
                    NgayPhatHanh = new DateTime(2013, 4, 14)
                },
                new TapPhim 
                { 
                    MaTap = "T007", 
                    MaPhim = "PHIM003", 
                    SoTapThuTu = 3, 
                    TenTap = "A Dim Light Amid Despair", 
                    ChiTiet = "Tập 3 - Ánh sáng mờ nhạt giữa tuyệt vọng",
                    VideoUrl = "https://www.youtube.com/watch?v=w3UR7nsTLw4", // Another AOT clip
                    ThoiLuongTap = 24,
                    NgayPhatHanh = new DateTime(2013, 4, 21)
                }
            };
            context.TapPhims.AddRange(tapPhims);
            await context.SaveChangesAsync();

            // Seed ThongKePhim
            var thongKePhims = new List<ThongKePhim>
            {
                new ThongKePhim { MaPhim = "PHIM001", TongLuotXem = 1500000, DiemTrungBinh = 9.2m, SoLuotDanhGia = 25000 },
                new ThongKePhim { MaPhim = "PHIM002", TongLuotXem = 2800000, DiemTrungBinh = 8.8m, SoLuotDanhGia = 45000 },
                new ThongKePhim { MaPhim = "PHIM003", TongLuotXem = 980000, DiemTrungBinh = 9.5m, SoLuotDanhGia = 18000 }
            };
            context.ThongKePhims.AddRange(thongKePhims);

            await context.SaveChangesAsync();
        }
    }
}
