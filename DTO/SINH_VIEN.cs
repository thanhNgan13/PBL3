//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DTO
{
    using System;
    using System.Collections.Generic;
    
    public partial class SINH_VIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SINH_VIEN()
        {
            this.LAM_BAI_KIEM_TRA = new HashSet<LAM_BAI_KIEM_TRA>();
            this.PHU_HUYNH = new HashSet<PHU_HUYNH>();
            this.SINHVIEN_LOPHOCPHAN = new HashSet<SINHVIEN_LOPHOCPHAN>();
        }
    
        public string MaSV { get; set; }
        public string Ho { get; set; }
        public string Ten { get; set; }
        public byte[] AnhCaNhan { get; set; }
        public System.DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string EmailCaNhan { get; set; }
        public string Sdt { get; set; }
        public string MaCTDT { get; set; }
        public string MaLopSH { get; set; }
    
        public virtual CHUONG_TRINH_DAO_TAO CHUONG_TRINH_DAO_TAO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LAM_BAI_KIEM_TRA> LAM_BAI_KIEM_TRA { get; set; }
        public virtual LOP_SINH_HOAT LOP_SINH_HOAT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHU_HUYNH> PHU_HUYNH { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SINHVIEN_LOPHOCPHAN> SINHVIEN_LOPHOCPHAN { get; set; }
        public virtual THONG_TIN_DANG_NHAP THONG_TIN_DANG_NHAP { get; set; }
    }
}
