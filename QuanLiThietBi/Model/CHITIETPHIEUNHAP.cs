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
    
    public partial class CHITIETPHIEUNHAP
    {
        public int ID { get; set; }
        public int ID_ThietBi { get; set; }
        public int ID_PHIEUNHAN { get; set; }
        public Nullable<int> soluong { get; set; }
    
        public virtual PHIEUNHAP PHIEUNHAP { get; set; }
        public virtual THIETBI THIETBI { get; set; }
    }
}
