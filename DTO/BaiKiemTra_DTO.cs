﻿using System;
using System.ComponentModel;

namespace DTO
{
    public class BaiKiemTra_DTO
    {
        public int MaBaiKiemTra { get; set; }

        [Browsable(false)] //Test,Giữa kì, Cuối kì (để lấy cái này hiển thị lên ExamName của UC_Day
        public string MaLoaiKiemTra { get; set; }

        [DisplayName("Mã học phần")]
        public string MaHP { get; set; }

        [DisplayName("Tên môn học")]
        public string TenMH { get; set; }

        [DisplayName("Bài kiểm tra")]
        public string TieuDeBaiKiemTra { get; set; }

        [Browsable(false)]
        private int _SoCauHoi { get; set; }

        [Browsable(false)]
        public int SoCauHoi
        {
            get => _SoCauHoi;
            set
            {
                _SoCauHoi = value;
                SoLuongCauHoi_Show = value + " (câu)";
            }
        }

        [DisplayName("Số lượng câu hỏi")]
        public string SoLuongCauHoi_Show { get; set; }

        [Browsable(false)]
        private int _ThoiGianLamBai { get; set; }

        [Browsable(false)]
        public int ThoiGianLamBai
        {
            get => _ThoiGianLamBai;
            set
            {
                _ThoiGianLamBai = value;
                ThoiGianLamBai_Show = value + " (phút)";
            }
        }

        [DisplayName("Thời gian làm bài")]
        public string ThoiGianLamBai_Show { get; set; }

        [Browsable(false)]
        private DateTime _ThoiGianBatDau { get; set; }

        [DisplayName("Thời gian bắt đầu")]
        public DateTime ThoiGianBatDau
        {
            get => _ThoiGianBatDau;
            set
            {
                _ThoiGianBatDau = value;

                //Phải tách ra như vậy, chứ nếu AddMinutes > 60p thì nó chỉ add được 60p
                int totalMinutes = ThoiGianLamBai + 30;
                ThoiGianKetThuc = value.AddMinutes(totalMinutes % 60);
                ThoiGianKetThuc = ThoiGianKetThuc.AddHours(totalMinutes / 60);
            }
        }

        [DisplayName("Thời gian kết thúc")]
        public DateTime ThoiGianKetThuc { get; set; }

        //Không thể dùng Browsable(false) mà phải Visible = false cột này
        //Do ta vẫn muốn truy cập đến cột này nhưng chẳng qua không muốn hiển thị lên dtgv thôi
        public string MkBaiKiemTra { get; set; }

        [Browsable(false)]
        public bool ChoPhepQuayLai { get; set; }
    }
}
