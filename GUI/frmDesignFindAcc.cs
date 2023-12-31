﻿using BLL;
using DTO;
using GUI.MyCustomControl;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmDesignFindAcc : Form
    {
        private string mess { get; set; }
        private THONG_TIN_DANG_NHAP_DTO acc { get; set; }
        public frmDesignFindAcc()
        {
            InitializeComponent();
            btnSend.Enabled = false; // Không cho phép nhấn nút
            this.ActiveControl = label1;
            UtilityClass.EnableDragForm(this);

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            UtilityClass.OpenNewForm(this, new frmDesignLogin());
        }

        private void txtEmail__TextChanged(object sender, EventArgs e)
        {
            lbMessagebox.Visible = false;
            string input = txtEmail.Texts.ToString();
            if (input.Contains("@emailling.xyz"))
            {
                // chuỗi có chứa "@email.com"
                btnSend.Enabled = true; // Cho phép nhấn nút
            }
            else
            {
                btnSend.Enabled = false;
            }
        }


        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txtEmail.Texts.ToString() == "")
            {
                lbMessagebox.Text = "Vui lòng không bỏ trống!!!";
                lbMessagebox.Visible = true;
            }
            else
            {
                acc = ForgetPass_BLL.Instance.ResetPasswordByEmail(txtEmail.Texts.ToString());
                if (acc == null)
                {
                    lbMessagebox.Text = "Không tìm thấy tài khoản!!!";
                    lbMessagebox.Visible = true;
                }
                else
                {
                    lbMessagebox.Visible = false;
                    CustomMessageBox.Show("Đã tìm thấy tài khoản!\nĐang trong quá trình gửi mail. " +
                                          "Vui lòng đợi trong giây lát.", "Thông báo");
                    pnlProgressBar.Visible = true;

                    //Sau khi gọi RunWorkerAsync thì background worker sẽ gọi đến event DoWork
                    backgroundWorker1.RunWorkerAsync(acc.MaXacThucDeLayLaiMK);
                }
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            string digitcode = (string)e.Argument;

            // Gọi phương thức gửi email
            mess = UtilityClass.sendEmail(txtEmail.Texts.ToString(), digitcode);

            // Thông báo tiến độ hoàn thành
            backgroundWorker1.ReportProgress(100);
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            lblProgress.Text = $"{e.ProgressPercentage}%";
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pnlProgressBar.Visible = false;
            if (e.Error != null)
            {
                MessageBox.Show("Error: " + e.Error.Message);
            }
            else if (mess == null)
            {
                CustomMessageBox.Show("Gửi mail thành công", "Thông báo");
                UtilityClass.OpenNewForm(this, new frmDesignEnterDigitCode(acc, txtEmail.Texts.ToString()));
            }
            else
            {
                MessageBox.Show("Gửi mail thất bại" + mess, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
