﻿using BLL;
using System.Windows.Forms;

namespace GUI.MyUserControls
{
    public partial class UC_Notification : UserControl
    {
        public string NgayTao
        {
            set => lblNgayTao.Text = value;
        }
        public string GioiTinhGV { get; set; }
        public string TenGV { get; set; }
        public string MaLopHP { get; set; }
        public string TenMH { get; set; }
        public string TieuDeTB { get; set; }
        public string NoiDungTB { get; set; }
        public int HeightText
        {
            get => lblTieuDe.Height + UtilityClass.CalculateHeightOfControl(lblNoiDung) + 70;
        }
        public UC_Notification()
        {
            InitializeComponent();
        }

        private void UC_Notification_Load(object sender, System.EventArgs e)
        {
            lblTieuDe.Text = GioiTinhGV + " " + TenGV + " thông báo đến lớp: " + TenMH + " [" + MaLopHP + "]";
            lblGV.Text = GioiTinhGV + " nhắn:";
            lblNoiDung.Text = "\nTiêu đề: " + TieuDeTB + "\nNội dung: " + NoiDungTB;
            int RealityHeightText = UtilityClass.CalculateHeightOfControl(lblNoiDung);
            if (lblNoiDung.Height < RealityHeightText)
            {
                lblNoiDung.Height = RealityHeightText;
                this.Height = lblNoiDung.Bounds.Bottom + 5;
            }
        }
    }
}
