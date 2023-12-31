﻿using DAL;
using DTO;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BLL
{
    public class LopSinhHoat_BLL
    {
        private static LopSinhHoat_BLL _Instance;
        public static LopSinhHoat_BLL Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new LopSinhHoat_BLL();
                return _Instance;
            }
        }
        private LopSinhHoat_BLL() { }

        public string GetMaKhoaOfLSH(string MaLopSH)
        {
            return LopSinhHoat_DAL.Instance.GetMaKhoaOfLSH(MaLopSH);
        }

        public LopSinhHoat_AdminEdit GetInforOfHomeroomClass(string MaLopSH)
        {
            return LopSinhHoat_DAL.Instance.GetInforOfHomeroomClass(MaLopSH);
        }

        public int GetNumberOfStudent(string MaLopSH)
        {
            //Hiện tại chưa dùng hàm này
            return LopSinhHoat_DAL.Instance.GetNumberOfStudent(MaLopSH);
        }

        public bool UpdateMaxStudentInClass(string MaLopSH, int num)
        {
            return LopSinhHoat_DAL.Instance.UpdateMaxStudentInClass(MaLopSH, num);
        }

        public bool InsertStudentIntoClass(string MaLopSH, string MSSV)
        {
            return LopSinhHoat_DAL.Instance.InsertStudentIntoClass(MaLopSH, MSSV);
        }

        public int DeleteStudent(List<string> li)
        {
            return LopSinhHoat_DAL.Instance.DeleteStudent(li);
        }
        public List<InformationClass_DTO> GetInformationClasses()
        {
            return LopSinhHoat_DAL.Instance.GetInformationClasses();
        }
        public int GetLastNumberInMaLopSH(string maLop)
        {
            return LopSinhHoat_DAL.Instance.GetLastNumberInMaLopSH(maLop);
        }

        public bool AddNewHomeroomClass(string idClass, string idTeacher, int numberMax)
        {
            LOP_SINH_HOAT newLsh = new LOP_SINH_HOAT()
            {
                MaLopSH = idClass,
                MaGVCN = idTeacher,
                SoLuongToiDa = numberMax
            };
            return LopSinhHoat_DAL.Instance.AddNewHomeroomClass(newLsh);
        }
        public int CountClassroom()
        {
            return LopSinhHoat_DAL.Instance.CountClassroom();
        }
        public bool DeleteHomeroomClass(string idHomeroomClass)
        {
            return LopSinhHoat_DAL.Instance.DeleteHomeroomClass(idHomeroomClass);
        }

        public List<KeyValuePair<string, string>> listOfStudentsWithoutClass(string maCTDT, string maKhoa)
        {
            return LopSinhHoat_DAL.Instance.listOfStudentsWithoutClass(maCTDT, maKhoa);
        }
    }
}
