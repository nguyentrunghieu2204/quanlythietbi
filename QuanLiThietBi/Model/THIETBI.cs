//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class THIETBI
    {
        public THIETBI()
        {
            this.CHITIETPHIEUGIAOs = new HashSet<CHITIETPHIEUGIAO>();
            this.CHITIETPHIEUNHAPs = new HashSet<CHITIETPHIEUNHAP>();
        }
    
        public int ID { get; set; }
        public string TEN { get; set; }
        public Nullable<int> DonGia { get; set; }
        public string ThongSo { get; set; }
        public Nullable<System.DateTime> NgaySanXuat { get; set; }
        public Nullable<System.DateTime> NgaySD { get; set; }
        public Nullable<System.DateTime> NgayCapNhat { get; set; }
        public Nullable<int> SoLuong { get; set; }
        public string DonViTinh { get; set; }
        public int ID_Loai { get; set; }
        public int ID_TinhTrang { get; set; }
    
        public virtual ICollection<CHITIETPHIEUGIAO> CHITIETPHIEUGIAOs { get; set; }
        public virtual ICollection<CHITIETPHIEUNHAP> CHITIETPHIEUNHAPs { get; set; }
        public virtual LOAITHIETBI LOAITHIETBI { get; set; }
        public virtual TINHTRANG TINHTRANG { get; set; }
    }
}
