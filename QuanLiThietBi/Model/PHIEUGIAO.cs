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
    
    public partial class PHIEUGIAO
    {
        public PHIEUGIAO()
        {
            this.CHITIETPHIEUGIAOs = new HashSet<CHITIETPHIEUGIAO>();
        }
    
        public int ID { get; set; }
        public Nullable<System.DateTime> NgayGiao { get; set; }
        public string TinhTrang { get; set; }
        public int ID_QuanTri { get; set; }
    
        public virtual ICollection<CHITIETPHIEUGIAO> CHITIETPHIEUGIAOs { get; set; }
        public virtual PHONGQUANTRI PHONGQUANTRI { get; set; }
    }
}